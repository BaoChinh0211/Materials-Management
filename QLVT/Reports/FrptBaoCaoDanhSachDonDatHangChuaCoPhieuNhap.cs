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
    public partial class FrptBaoCaoDanhSachDonDatHangChuaCoPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public FrptBaoCaoDanhSachDonDatHangChuaCoPhieuNhap()
        {
            InitializeComponent();
        }
        private void FrptBaoCaoDanhSachDonDatHangChuaCoPhieuNhap_Load(object sender, EventArgs e)
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
        private void cbbMaCN_SelectedIndexChanged(object sender, EventArgs e)
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
            BaoCaoDanhSachDonDatHangChuaCoPhieuNhap report = new BaoCaoDanhSachDonDatHangChuaCoPhieuNhap();
            report.lbTieuDe.Text = "Danh Sách Đơn Đặt Hàng Chưa Có Phiếu Nhập Thuộc " + cbbMaCN.Text;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            BaoCaoDanhSachDonDatHangChuaCoPhieuNhap report = new BaoCaoDanhSachDonDatHangChuaCoPhieuNhap();
            report.lbTieuDe.Text = "Danh Sách Đơn Đặt Hàng Chưa Có Phiếu Nhập Thuộc " + cbbMaCN.Text;
            try
            {
                if (File.Exists(@"D:\ReportCSDLPT\Danh Sách Đơn Đặt Hàng Chưa Có Phiếu Nhập Thuộc " + cbbMaCN.Text + ".pdf"))
                {

                    if (MessageBox.Show("File Danh Sách Đơn Đặt Hàng Chưa Có Phiếu Nhập Thuộc " + cbbMaCN.Text + ".pdf tại thư mục ReportCSDLPT đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        File.Delete(@"D:\ReportCSDLPT\Danh Sách Đơn Đặt Hàng Chưa Có Phiếu Nhập Thuộc " + cbbMaCN.Text + ".pdf");
                        report.ExportToPdf(@"D:\ReportCSDLPT\Danh Sách Đơn Đặt Hàng Chưa Có Phiếu Nhập Thuộc " + cbbMaCN.Text + ".pdf");
                        MessageBox.Show("File Danh Sách Đơn Đặt Hàng Chưa Có Phiếu Nhập Thuộc " + cbbMaCN.Text + ".pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportCSDLPT\Danh Sách Đơn Đặt Hàng Chưa Có Phiếu Nhập Thuộc " + cbbMaCN.Text + ".pdf");
                    MessageBox.Show("File Danh Sách Đơn Đặt Hàng Chưa Có Phiếu Nhập Thuộc " + cbbMaCN.Text + ".pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lưu file không thành công, vui lòng thử lại",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

    }
}