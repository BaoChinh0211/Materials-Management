using DevExpress.XtraReports.UI;
using QLVT.Reports;
using System;
using System.IO;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FrptInDanhSachNV : DevExpress.XtraEditors.XtraForm
    {
        public FrptInDanhSachNV()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void ListEmployeeForm_Load(object sender, EventArgs e)
        {

            tbaNV.Connection.ConnectionString = Program.connectString;
            tbaNV.Fill(DS.NhanVien);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                /*Đổ dữ liệu từ dataset vào girdControl*/
                tbaNV.Connection.ConnectionString = Program.connectString;
                tbaNV.Fill(DS.NhanVien);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BaoCaoDanhSachNhanVien report = new BaoCaoDanhSachNhanVien();
            report.lbCN.Text = cbbMaCN.Text;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BaoCaoDanhSachNhanVien report = new BaoCaoDanhSachNhanVien();
            report.lbCN.Text = cbbMaCN.Text;
            try
            {
                if (File.Exists(@"D:\ReportCSDLPT\Danh sách nhân viên thuộc " + cbbMaCN.Text + ".pdf"))
                {

                    if (MessageBox.Show("File Danh sách nhân viên thuộc " + cbbMaCN.Text + ".pdf tại thư mục ReportCSDLPT đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        File.Delete(@"D:\ReportCSDLPT\Danh sách nhân viên thuộc " + cbbMaCN.Text + ".pdf");
                        report.ExportToPdf(@"D:\ReportCSDLPT\Danh sách nhân viên thuộc " + cbbMaCN.Text + ".pdf");
                        MessageBox.Show("File Danh sách nhân viên thuộc " + cbbMaCN.Text + ".pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportCSDLPT\Danh sách nhân viên thuộc " + cbbMaCN.Text + ".pdf");
                    MessageBox.Show("File Danh sách nhân viên thuộc " + cbbMaCN.Text + ".pdf đã được ghi thành công tại thư mục ReportCSDLPT trong ổ D",
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