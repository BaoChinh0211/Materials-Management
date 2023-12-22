using DevExpress.XtraBars;
using QLVT.Reports;
using System;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private Form IsExists(Type type)
        {
            foreach (Form form in MdiChildren)
            {
                if (form.GetType() == type)
                    return form;
            }
            return null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormDangNhap loginForm = new FormDangNhap();
            loginForm.MdiParent = this;
            loginForm.Show();
        }


        public void ShowMenu()
        {
            lbMaNV.Text = "Mã nhân viên: " + Program.userName;
            lbTenNV.Text = "Tên nhân viên: " + Program.mFullName;
            lbVaiTro.Text = "Vai trò: " + Program.mRole;

            // Cấp quyền
            PageDanhMuc.Visible = pageNghiepVu.Visible = pageBaoCao.Visible = true;
            btnTaoTaiKhoan.Enabled = btnDangXuat.Enabled = true;
            btnDangNhap.Enabled = false;
            if (Program.mRole == "USER")
            {
                btnTaoTaiKhoan.Enabled = false;
            }
        }

        private void BtnEmployeeClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FormNhanVien));
            if (form != null)
                form.Activate();
            else
            {
                FormNhanVien employeeForm = new FormNhanVien();
                employeeForm.MdiParent = this;
                employeeForm.Show();
            }
        }

        private void BtnProductClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FormVatTu));
            if (form != null)
                form.Activate();
            else
            {
                FormVatTu productForm = new FormVatTu();
                productForm.MdiParent = this;
                productForm.Show();
            }
        }

        private void BtnWarehouseClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FormKho));
            if (form != null)
                form.Activate();
            else
            {
                FormKho warehouseForm = new FormKho();
                warehouseForm.MdiParent = this;
                warehouseForm.Show();
            }
        }

        private void BtnLoginClick(object sender, ItemClickEventArgs e)
        {
            Form form1 = IsExists(typeof(FormDangNhap));
            if (form1 != null)
                form1.Activate();
            else
            {
                FormDangNhap loginForm = new FormDangNhap();
                loginForm.MdiParent = this;
                loginForm.Show();
            }
        }

        private void BtnLogoutClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (Form form in MdiChildren)
                    form.Dispose();
                btnDangNhap.Enabled = true;
                btnDangXuat.Enabled = false;
                btnTaoTaiKhoan.Enabled = false;
                PageDanhMuc.Visible = pageNghiepVu.Visible = pageBaoCao.Visible = false;

                Program.mainForm.lbMaNV.Visible = Program.mainForm.lbTenNV.Visible = Program.mainForm.lbVaiTro.Visible = false;
            }
        }

        private void BtnTaoTaiKhoanClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(CreateLoginForm));
            if (form != null)
                form.Activate();
            else
            {
                CreateLoginForm createLoginForm = new CreateLoginForm();
                createLoginForm.MdiParent = this;
                createLoginForm.Show();
            }
        }

        private void BtnThoatClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
                Program.mainForm.Close();
            }
        }

        private void PageDDH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FormDonDatHang));
            if (form != null)
                form.Activate();
            else
            {
                FormDonDatHang donDatHang = new FormDonDatHang();
                donDatHang.MdiParent = this;
                donDatHang.Show();
            }
        }

        private void PagePhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FormPhieuNhap));
            if (form != null)
                form.Activate();
            else
            {
                FormPhieuNhap phieuNhap = new FormPhieuNhap();
                phieuNhap.MdiParent = this;
                phieuNhap.Show();
            }
        }

        private void PagePhieuXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FormPhieuXuat));
            if (form != null)
                form.Activate();
            else
            {
                FormPhieuXuat phieuXuat = new FormPhieuXuat();
                phieuXuat.MdiParent = this;
                phieuXuat.Show();
            }
        }

        private void BarButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FrptBaoCaoBangKeChiTietSoLuong_TriGia));
            if (form != null)
                form.Activate();
            else
            {
                FrptBaoCaoBangKeChiTietSoLuong_TriGia baoCao3 = new FrptBaoCaoBangKeChiTietSoLuong_TriGia();
                baoCao3.MdiParent = this;
                baoCao3.Show();
            }
        }

        private void baoCao4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FrptBaoCaoDanhSachDonDatHangChuaCoPhieuNhap));
            if (form != null)
                form.Activate();
            else
            {
                FrptBaoCaoDanhSachDonDatHangChuaCoPhieuNhap baoCao4 = new FrptBaoCaoDanhSachDonDatHangChuaCoPhieuNhap();
                baoCao4.MdiParent = this;
                baoCao4.Show();
            }
        }

        private void btnBaoCao5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FrptHoatDongCuaNhanVien));
            if (form != null)
                form.Activate();
            else
            {
                FrptHoatDongCuaNhanVien baoCao5 = new FrptHoatDongCuaNhanVien();
                baoCao5.MdiParent = this;
                baoCao5.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FrptInDanhSachNV));
            if (form != null)
                form.Activate();
            else
            {
                FrptInDanhSachNV baoCao = new FrptInDanhSachNV();
                baoCao.MdiParent = this;
                baoCao.Show();
            }
        }

        private void btnDanhSachVT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FrptInDanhSachVatTu));
            if (form != null)
                form.Activate();
            else
            {
                FrptInDanhSachVatTu baoCao = new FrptInDanhSachVatTu();
                baoCao.MdiParent = this;
                baoCao.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = IsExists(typeof(FrptBaoCaoHoatDongNhapXuat));
            if (form != null)
                form.Activate();
            else
            {
                FrptBaoCaoHoatDongNhapXuat baoCao = new FrptBaoCaoHoatDongNhapXuat();
                baoCao.MdiParent = this;
                baoCao.Show();
            }
        }
    }
}