using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Filtering.ExcelFilterOptions;

namespace QLVT.Reports
{
    public partial class FrptHoatDongCuaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NumberToTextVN number = new NumberToTextVN();   
        public FrptHoatDongCuaNhanVien()
        {
            InitializeComponent();
        }

        private void FrptHoatDongCuaNhanVien_Load(object sender, EventArgs e)
        {
            tbaHoTen.Connection.ConnectionString = Program.connectString;
            tbaHoTen.Fill(DS.HoTen);

            cbbMaCN.DataSource = Program.bindingSource_listBranch.DataSource;
            cbbMaCN.DisplayMember = "TENCN";
            cbbMaCN.ValueMember = "TENSERVER";
            cbbMaCN.SelectedIndex = Program.mBranch;
            // Phân quyền
            if (Program.mRole == "CONGTY")
            {
                cbbMaCN.Enabled = true;
            }
            else
            {
                cbbMaCN.Enabled = false;
            }
        }

        private void CbbMaCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cbbMaCN.SelectedValue.ToString();

            /*Nếu chọn chi nhánh khác với chi nhánh hiện tại*/
            if (cbbMaCN.SelectedIndex != Program.mBranch)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            /*Nếu chi nhánh được chọn là chi nhánh được chọn lúc đăng nhập*/
            else
            {
                Program.mLogin = Program.currentLogin;
                Program.password = Program.currentPassword;
            }

            if (Program.Connecting() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                tbaHoTen.Connection.ConnectionString = Program.connectString;
                tbaHoTen.Fill(DS.HoTen);
            }
        }

        private void BtnXemPreview_Click(object sender, EventArgs e)
        {
            if (!kiemTra())
            {
                return;
            }
            else
            {
                BaoCaoHoatDongCuaNhanVien report = new BaoCaoHoatDongCuaNhanVien((int)cbbNV.SelectedValue, dtpDateFrom.DateTime, dtpDateTo.DateTime);
                report.lbHoTenNhanVien.Text = "Họ tên nhân viên: " + cbbNV.Text;
                report.lbTime.Text = "Từ ngày " + dtpDateFrom.Text + " đến ngày " + dtpDateTo.Text;
                report.lbNgayLap.Text = "Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy");

                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
                /*Console.WriteLine(number.NumberToText(10000));*/
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (!kiemTra())
            {
                return;
            }
            else
            {
                BaoCaoHoatDongCuaNhanVien report = new BaoCaoHoatDongCuaNhanVien((int)cbbNV.SelectedValue, dtpDateFrom.DateTime, dtpDateTo.DateTime);
                report.lbHoTenNhanVien.Text = "Họ tên nhân viên: " + cbbNV.Text;
                report.lbTime.Text = "Từ ngày " + dtpDateFrom.Text + " đến ngày " + dtpDateTo.Text;
                report.lbNgayLap.Text = "Ngày lập: " + DateTime.Now.ToString();
                try
                {
                    if (File.Exists(@"D:\ReportCSDLPT\Báo cáo hoạt động của nhân viên " + cbbNV.Text + ".pdf"))
                    {

                        if (MessageBox.Show("Báo cáo hoạt động của nhân viên " + cbbNV.Text + ".pdf tại thư mục ReportCSDLPT đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            File.Delete(@"D:\ReportCSDLPT\Báo cáo hoạt động của nhân viên " + cbbNV.Text + ".pdf");
                            report.ExportToPdf(@"D:\ReportCSDLPT\Báo cáo hoạt động của nhân viên " + cbbNV.Text + ".pdf");
                            MessageBox.Show("File Báo cáo hoạt động của nhân viên " + cbbNV.Text + ".pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
                            "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {
                        report.ExportToPdf(@"D:\ReportCSDLPT\Báo cáo hoạt động của nhân viên " + cbbNV.Text + ".pdf");
                        MessageBox.Show("File Báo cáo hoạt động của nhân viên " + cbbNV.Text + ".pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Lưu file không thành công, vui lòng thử lại\n Lỗi:" + ex.Message,
                        "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool kiemTra()
        {
            if (dtpDateFrom.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateFrom.Focus();
                return false;
            }
            else if (dtpDateTo.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDateTo.Focus();
                return false;
            }
            return true;
        }
    }
}