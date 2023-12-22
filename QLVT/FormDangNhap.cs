using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection_publisher = new SqlConnection();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            tbUsername.Text = "TranThanh";// Luong Trang - CONGTY
            tbPassword.Text = "123456";
            if (connectToMainServer() == 0)
                return;
            getListBranch("SELECT * FROM V_DS_PHANMANH");
            cbSelectBranch.SelectedIndex = 1;
            cbSelectBranch.SelectedIndex = 0;
            Program.mainForm.lbMaNV.Visible = Program.mainForm.lbTenNV.Visible = Program.mainForm.lbVaiTro.Visible = false;
        }

        private int connectToMainServer()
        {
            if (connection_publisher != null && connection_publisher.State == ConnectionState.Open)
                connection_publisher.Close();
            try
            {
                connection_publisher.ConnectionString = Program.connectString_Publisher;
                connection_publisher.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return 0;
            }
        }

        private void getListBranch(string cmd)
        {
            DataTable dataTable = new DataTable();
            if (connection_publisher.State == ConnectionState.Closed)
                connection_publisher.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, connection_publisher);
            sqlDataAdapter.Fill(dataTable);
            connection_publisher.Close();
                
            Program.bindingSource_listBranch.DataSource = dataTable;
            cbSelectBranch.DataSource = Program.bindingSource_listBranch;
            cbSelectBranch.DisplayMember = "TENCN";
            cbSelectBranch.ValueMember = "TENSERVER";
        }

        private void cbSelectBranchSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cbSelectBranch.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnLoginClick(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống, vui lòng nhập!", "", MessageBoxButtons.OK);
                return;
            }
            else if (tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống, vui lòng nhập!", "", MessageBoxButtons.OK);
                return;
            }

            Program.mLogin = tbUsername.Text.Trim();
            Program.password = tbPassword.Text.Trim();

            if (Program.Connecting() == 0)
                return;
            Program.currentLogin = Program.mLogin;
            Program.currentPassword = Program.password;
            Program.mBranch = cbSelectBranch.SelectedIndex;

            string stringCommand = "EXEC SP_DANGNHAP '" + Program.mLogin + "'";
            Program.sqlDataReader = Program.ExecSqlDataReader(stringCommand);
            if (Program.sqlDataReader == null)
                return;
            Program.sqlDataReader.Read();

            Program.userName = Program.sqlDataReader.GetString(0);
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập vào database");
                return;
            }
            else
            {
                Program.mFullName = Program.sqlDataReader.GetString(1);
                Program.mRole = Program.sqlDataReader.GetString(2);

                Program.sqlDataReader.Close();
                Program.sqlConnection.Close();
                Program.mainForm.lbMaNV.Visible = Program.mainForm.lbTenNV.Visible = Program.mainForm.lbVaiTro.Visible = true;
                Program.mainForm.lbMaNV.Text = "Mã nhân viên: " + Program.userName;
                Program.mainForm.lbTenNV.Text = "Tên nhân viên: " + Program.mFullName;
                Program.mainForm.lbVaiTro.Text = "Vai trò: " + Program.mRole;
                Program.mainForm.ShowMenu();
                Close();
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExitClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
                Program.mainForm.Close();
            }
            else
                return;
        }
    }
}