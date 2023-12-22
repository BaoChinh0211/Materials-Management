using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
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

namespace QLVT.Reports
{
    public partial class FrptBaoCaoHoatDongNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        public FrptBaoCaoHoatDongNhapXuat()
        {
            InitializeComponent();
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
            }
        }

        private void BtnXemPreview_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return;
            }
            else
            {
                BaoCaoTongHopHoatDongNhapXuat report = new BaoCaoTongHopHoatDongNhapXuat(dtpDateFrom.DateTime, dtpDateTo.DateTime);
                report.lbTime.Text = "Từ ngày " + dtpDateFrom.Text + " đến ngày " + dtpDateTo.Text;
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return;
            }
            else
            {
                BaoCaoTongHopHoatDongNhapXuat report = new BaoCaoTongHopHoatDongNhapXuat(dtpDateFrom.DateTime, dtpDateTo.DateTime);
                report.lbTime.Text = "Từ ngày " + dtpDateFrom.Text + " đến ngày " + dtpDateTo.Text;
                try
                {
                    if (File.Exists(@"D:\ReportCSDLPT\Tổng hợp hoạt động nhập xuất.pdf"))
                    {

                        if (MessageBox.Show("Báo cáo Tổng hợp hoạt động nhập xuất.pdf tại thư mục ReportCSDLPT đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            File.Delete(@"D:\ReportCSDLPT\Báo cáo Tổng hợp hoạt động nhập xuất.pdf");
                            report.ExportToPdf(@"D:\ReportCSDLPT\Báo cáo Tổng hợp hoạt động nhập xuất.pdf");
                            MessageBox.Show("File Báo cáo Tổng hợp hoạt động nhập xuất.pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
                            "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {
                        report.ExportToPdf(@"D:\ReportCSDLPT\Báo cáo Tổng hợp hoạt động nhập xuất.pdf");
                        MessageBox.Show("File Báo cáo Tổng hợp hoạt động nhập xuất.pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
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

        private void FrptBaoCaoHoatDongNhapXuat_Load(object sender, EventArgs e)
        {
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
        private bool KiemTra()
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