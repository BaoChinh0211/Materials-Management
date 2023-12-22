using DevExpress.XtraReports.UI;
using System;
using System.IO;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FrptInDanhSachVatTu : DevExpress.XtraEditors.XtraForm
    {
        public FrptInDanhSachVatTu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void DanhSachVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.dS.Vattu);

        }

        private void btnXemPreview_Click(object sender, EventArgs e)
        {
            BaoCaoDanhSachVatTu report = new BaoCaoDanhSachVatTu();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BaoCaoDanhSachVatTu report = new BaoCaoDanhSachVatTu();
            try
            {
                if (File.Exists(@"D:\ReportCSDLPT\Danh sách vật tư của công ty.pdf"))
                {

                    if (MessageBox.Show("File Danh sách vật tư của công ty.pdf tại thư mục ReportCSDLPT đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        File.Delete(@"D:\ReportCSDLPT\Danh sách vật tư của công ty.pdf");
                        report.ExportToPdf(@"D:\ReportCSDLPT\Danh sách vật tư của công ty.pdf");
                        MessageBox.Show("File Danh sách vật tư của công ty.pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ đĩa D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportCSDLPT\Danh sách vật tư của công ty.pdf");
                    MessageBox.Show("File Danh sách vật tư của công ty.pdf đã được ghi thành công tại ổ D",
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