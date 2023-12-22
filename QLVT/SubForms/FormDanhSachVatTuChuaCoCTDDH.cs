using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDanhSachVatTuChuaCoCTDDH : DevExpress.XtraEditors.XtraForm
    {
        FormDonDatHang formDonDatHang = Application.OpenForms.OfType<FormDonDatHang>().FirstOrDefault();
        public FormDanhSachVatTuChuaCoCTDDH()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FormDanhSachVatTuChuaCoCTDDH_Load(object sender, EventArgs e)
        {
            if (Program.sqlConnection != null && Program.sqlConnection.State == System.Data.ConnectionState.Open)
            {
                Program.sqlConnection.Close();
            }
            try
            {
                Program.sqlConnection.Open();
                SqlCommand command = new SqlCommand("sp_danhSachVatTuChuaCoCTDDH", Program.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MADDH", txtMaDDH.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(DS.sp_danhSachVatTuChuaCoCTDDH);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMaDDH.Enabled = false;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (formDonDatHang == null)
            {
                MessageBox.Show("Không có form phiếu nhập nào đang mở", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
                return;
            }
            else
            {
                string tenVT = ((DataRowView)bdsVattu[bdsVattu.Position])["TENVT"].ToString();
                string maVT = ((DataRowView)bdsVattu[bdsVattu.Position])["MAVT"].ToString(); ;
                formDonDatHang.txtMaVT.Text = maVT;
                formDonDatHang.txtVatTu.Text = tenVT;
                formDonDatHang.btnHuyVattu.Enabled = true;
                Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}