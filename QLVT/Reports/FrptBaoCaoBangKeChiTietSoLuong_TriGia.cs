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
    public partial class FrptBaoCaoBangKeChiTietSoLuong_TriGia : DevExpress.XtraEditors.XtraForm
    {
        public FrptBaoCaoBangKeChiTietSoLuong_TriGia()
        {
            InitializeComponent();
        }

        private void FormBaoCaoBangKeChiTietSoLuong_TriGia_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
        }

        private void BtnXemPreview_Click(object sender, EventArgs e)
        {
            if (kiemTra() == false)
            {
                return;
            }
            else
            {
                BaoCaoBangKeChiTietSoLuong_TriGia baoCao = new BaoCaoBangKeChiTietSoLuong_TriGia(Program.mRole, cbbType.Text.Substring(0, 1), dtpDateFrom.DateTime, dtpDateTo.DateTime);
                baoCao.lbType.Text = cbbType.Text;
                ReportPrintTool print = new ReportPrintTool(baoCao);
                print.ShowPreviewDialog();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (kiemTra() == false)
            {
                return;
            }
            else
            {
                BaoCaoBangKeChiTietSoLuong_TriGia baoCao = new BaoCaoBangKeChiTietSoLuong_TriGia(Program.mRole, cbbType.Text.Substring(0, 1), dtpDateFrom.DateTime, dtpDateTo.DateTime);
                baoCao.lbType.Text = cbbType.Text;
                try
                {
                    if (File.Exists(@"D:\ReportCSDLPT\Bảng kê chi tiết số lượng – trị giá hàng " + cbbType.Text + ".pdf"))
                    {

                        if (MessageBox.Show("Bảng kê chi tiết số lượng – trị giá hàng " + cbbType.Text + ".pdf tại thư mục ReportCSDLPT đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            File.Delete(@"D:\ReportCSDLPT\Bảng kê chi tiết số lượng – trị giá hàng " + cbbType.Text + ".pdf");
                            baoCao.ExportToPdf(@"D:\ReportCSDLPT\Bảng kê chi tiết số lượng – trị giá hàng " + cbbType.Text + ".pdf");
                            MessageBox.Show("File Bảng kê chi tiết số lượng – trị giá hàng " + cbbType.Text + ".pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
                            "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {
                        baoCao.ExportToPdf(@"D:\ReportCSDLPT\Bảng kê chi tiết số lượng – trị giá hàng " + cbbType.Text + ".pdf");
                        MessageBox.Show("File Bảng kê chi tiết số lượng – trị giá hàng " + cbbType.Text + ".pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
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

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool kiemTra()
        {
            if (cbbType.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn loại phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbType.Focus();
                return false;
            } 
            else if (dtpDateFrom.Text.Equals(""))
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