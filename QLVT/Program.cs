using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection sqlConnection = new SqlConnection();
        public static string connectString = "";
        public static string connectString_Publisher = "Data Source= MSI; Initial Catalog= QLVT; Integrated Security = True";

        public static SqlDataReader sqlDataReader;
        public static string serverName = "";
        public static string serverNameLeft = "";
        public static string userName = "";
        public static string mLogin = "";
        public static string password = "";

        public static string database = "QLVT";
        public static string remoteLogin = "htkn";
        public static string remotePassword = "123";
        public static string currentLogin = "";
        public static string currentPassword = "";
        public static string mRole = "";
        public static string mFullName = "";
        public static int mBranch = 0;

        public static FormChinh mainForm;
        public static FormDangNhap loginForm;
        public static BindingSource bindingSource_listBranch = new BindingSource();
        public static int Connecting()
        {
            if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            try
            {
                connectString = "Data Source= " + serverName.ToString() + "; Initial Catalog= " + database + "; User ID= " + mLogin + "; password= " + password;
                sqlConnection.ConnectionString = connectString;
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối Cơ sở dữ liệu" + ex.Message);
                return 0;
            }
        }

        /* ExecSqlDataTable thực hiện câu lệnh mà dữ liệu trả về chỉ để xem và không được thao tác,
           ví dụ SELECT * FROM view_DSPM */
        public static SqlDataReader ExecSqlDataReader(String stringCommand)
        {
            SqlDataReader sqlDataReader;
            SqlCommand sqlCommand = new SqlCommand(stringCommand, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text; ;
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                return sqlDataReader;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /* ExecSqlDataTable thực hiện câu lệnh mà dữ liệu trả về có thể thao tác tùy ý,
           ví dụ SELECT * FROM NHANVIEN */
        public static DataTable ExecSQLDataTable(string cmd)
        {
            DataTable dataTable = new DataTable();
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        // Thực thi câu lệnh SQL để chạy stored produce mà không trả về giá trị
        public static void ExecSqlNonQuery(string strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, sqlConnection);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
                return;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show(ex.Message);
                sqlConnection.Close();
                return;
            }
        }

        public static int ExecuteScalar(string cmd)
        {
            SqlCommand Sqlcmd = new SqlCommand(cmd, sqlConnection);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                object result = Sqlcmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ketqua))
                {
                    sqlConnection.Close();
                    return ketqua;
                }
                else
                {
                    sqlConnection.Close();
                    return 0;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Lỗi dữ liệu");
                else MessageBox.Show(ex.Message);
                sqlConnection.Close();
                return ex.State;
            }
        }

        public static void CapNhatSoLuongVatTu(string cheDo, string maVatTu, int soLuong)
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            try
            {
                sqlConnection.Open();
                string cauTruyVan = "EXEC [dbo].[sp_CapNhatSoLuongVatTu] '" + cheDo + "', '" + maVatTu + "', " + soLuong;
                Console.WriteLine(cauTruyVan);
                ExecSqlNonQuery(cauTruyVan);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi Cập nhật số lượng Vật tư! \n Lỗi:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new FormChinh();
            loginForm = new FormDangNhap();

            Application.Run(mainForm);
        }
    }
}
