using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDanhSachCTDDHChuaCoCTPN : DevExpress.XtraEditors.XtraForm
    {
        public static int soLuongCTDDH;
        public static float donGiaCTDDH;
        FormPhieuNhap formPhieuNhap = Application.OpenForms.OfType<FormPhieuNhap>().FirstOrDefault();
        public FormDanhSachCTDDHChuaCoCTPN()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FromDanhSachCTDDHChuaCoCTPN_Load(object sender, EventArgs e)
        {
            if (Program.sqlConnection != null && Program.sqlConnection.State == System.Data.ConnectionState.Open)
            {
                Program.sqlConnection.Close();
            }
            try
            {
                Program.sqlConnection.Open();
                SqlCommand command = new SqlCommand("sp_VTNotInCTPN", Program.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MasoDDH", txtMaDDH.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(DS.sp_VTNotInCTPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (formPhieuNhap == null)
            {
                MessageBox.Show("Không có form phiếu nhập nào đang mở", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
                return;
            }
            else
            {

                string maSoDDH = ((DataRowView)bdsVattu[bdsVattu.Position])["MasoDDH"].ToString();
                string tenVT = ((DataRowView)bdsVattu[bdsVattu.Position])["TENVT"].ToString();
                string maVT = ((DataRowView)bdsVattu[bdsVattu.Position])["MAVT"].ToString();
                int soLuong = (int)((DataRowView)bdsVattu[bdsVattu.Position])["SOLUONG"];
                float donGia = float.Parse(((DataRowView)bdsVattu[bdsVattu.Position])["DONGIA"].ToString());
                formPhieuNhap.txtMaDDH.Text = maSoDDH;
                formPhieuNhap.txtMaVT.Text = maVT;
                formPhieuNhap.txtTenVT.Text = tenVT;
                formPhieuNhap.seSoLuong.Value = soLuongCTDDH = soLuong;
                formPhieuNhap.txtDonGia.EditValue = donGiaCTDDH = donGia;
                formPhieuNhap.btnHuyDDH.Enabled = formPhieuNhap.seSoLuong.Enabled = formPhieuNhap.txtDonGia.Enabled = true;
                formPhieuNhap.btnHuyCTDDH.Enabled = true;
                Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}