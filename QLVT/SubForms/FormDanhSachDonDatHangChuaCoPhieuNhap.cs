using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.SubForms
{
    public partial class FormDanhSachDonDatHangChuaCoPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        FormPhieuNhap formPhieuNhap = Application.OpenForms.OfType<FormPhieuNhap>().FirstOrDefault();
        public FormDanhSachDonDatHangChuaCoPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormDanhSachDonDatHangChuaCoPhieuNhap_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            tbaDDH.Connection.ConnectionString = Program.connectString;
            tbaDDH.Fill(DS.view_DdhNotInPN);
            StartPosition = FormStartPosition.CenterScreen;
            if (bdsDDH.Count == 0)
            {
                btnChon.Enabled = false;
            }
            else
            {
                btnChon.Enabled = true;
            }
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            if (formPhieuNhap == null)
            {
                MessageBox.Show("Không có form phiếu nhập nào đang mở", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
                return;
            }
            else
            {
                string maSoDDH = ((DataRowView)bdsDDH[bdsDDH.Position])["MasoDDH"].ToString();
                string kho = ((DataRowView)bdsDDH[bdsDDH.Position])["TENKHO"].ToString();
                formPhieuNhap.cbbTenKho.Text = kho;
                formPhieuNhap.txtMaDDH.Text = maSoDDH;
                formPhieuNhap.btnHuyDDH.Enabled = true;
                Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}