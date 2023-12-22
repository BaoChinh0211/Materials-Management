using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDanhSachVatTuChuaCoCTPX : DevExpress.XtraEditors.XtraForm
    {
        FormPhieuXuat formPhieuXuat = Application.OpenForms.OfType<FormPhieuXuat>().FirstOrDefault();
        public FormDanhSachVatTuChuaCoCTPX()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FormDanhSachVatTuChuaCoCTPX_Load(object sender, EventArgs e)
        {
            if (Program.sqlConnection != null && Program.sqlConnection.State == System.Data.ConnectionState.Open)
            {
                Program.sqlConnection.Close();
            }
            try
            {
                Program.sqlConnection.Open();
                SqlCommand command = new SqlCommand("sp_danhSachVatTuChuaCoCTPX", Program.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MAPX", txtMaPX.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(DS.sp_danhSachVatTuChuaCoCTPX);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void btnChon_Click_1(object sender, EventArgs e)
        {
            if (formPhieuXuat == null)
            {
                MessageBox.Show("Không có form phiếu xuất nào đang mở", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
                return;
            }
            else
            {
                string tenVT = ((DataRowView)bdsVattu[bdsVattu.Position])["TENVT"].ToString();
                string maVT = ((DataRowView)bdsVattu[bdsVattu.Position])["MAVT"].ToString(); ;
                formPhieuXuat.txtMaVatTu.Text = maVT;
                formPhieuXuat.txtTenVattu.Text = tenVT;
                formPhieuXuat.btnHuyVattu.Enabled = true;
                Close();
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}