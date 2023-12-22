using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT
{
    public partial class CreateLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public CreateLoginForm()
        {
            InitializeComponent();
            showListUser();
        }

        private void CreateLoginForm_Load(object sender, EventArgs e)
        {
            if (Program.mRole == "CONGTY")
            {
                radCONGTY.Checked = true;
                radCHINHANH.Enabled = radUSER.Enabled = false;
            }
            else if (Program.mRole == "CHINHANH")
            {
                radCONGTY.Enabled = false;
                radCHINHANH.Enabled = radUSER.Enabled = true;
                radCHINHANH.Checked = true;
            }
        }
        private void showListUser()
        {
            String strCmd = "SELECT MANV,  CONCAT(HO, ' ', TEN)  AS HOTEN FROM dbo.NhanVien";
            DataTable dataTable = Program.ExecSQLDataTable(strCmd);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            cbbUsername.DataSource = bindingSource;
            cbbUsername.DisplayMember = "HOTEN";
            cbbUsername.ValueMember = "MANV";
        }
        private Boolean checkInputValidate()
        {
            if (txtLogin.Text.Trim().Equals(""))
            {
                MessageBox.Show("Login name không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private string role()
        {
            string role;
            if (radCONGTY.Checked)
                role = radCONGTY.Text;
            else if (radCHINHANH.Checked)
                role = radCHINHANH.Text;
            else role = radUSER.Text;
            return role;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (checkInputValidate() == false)
            {
                return;
            }
            else
            {
                try
                {
                    String mRole = role();
                    String lenhTaoLogin = "DECLARE @result int " + "EXEC @result = [dbo].[sp_CreateLogin] '" + txtLogin.Text.Trim() +
                        "', '" + txtPassword.Text.Trim() +
                        "', '" + cbbUsername.SelectedValue.ToString().Trim() +
                        "', '" + mRole +
                        "' " +
                        "SELECT 'Value' = @result";
                    Program.sqlDataReader = Program.ExecSqlDataReader(lenhTaoLogin);
                    Program.sqlDataReader.Read();
                    int result = int.Parse(Program.sqlDataReader.GetValue(0).ToString());
                    Program.sqlDataReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Login name đã bị trùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (result == 2)
                    {
                        MessageBox.Show("Nhân viên này đã có Username", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("Tạo login thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tạo login:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }
    }
}