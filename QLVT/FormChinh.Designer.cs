namespace QLVT
{
    partial class FormChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSystem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnWarehouse = new DevExpress.XtraBars.BarButtonItem();
            this.pageDDH = new DevExpress.XtraBars.BarButtonItem();
            this.pagePhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.pagePhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.baoCao4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCao5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachVT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.pageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage_employee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.page1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTenNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbVaiTro = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageGroupSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroupSystem
            // 
            ribbonPageGroupSystem.ItemLinks.Add(this.btnDangNhap);
            ribbonPageGroupSystem.ItemLinks.Add(this.btnDangXuat);
            ribbonPageGroupSystem.ItemLinks.Add(this.btnTaoTaiKhoan);
            ribbonPageGroupSystem.ItemLinks.Add(this.btnThoat);
            ribbonPageGroupSystem.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            ribbonPageGroupSystem.Name = "ribbonPageGroupSystem";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 5;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLoginClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLogoutClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Enabled = false;
            this.btnTaoTaiKhoan.Id = 1;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTaoTaiKhoanClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThoatClick);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnTaoTaiKhoan,
            this.btnDangXuat,
            this.btnThoat,
            this.btnDangNhap,
            this.btnEmployee,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnProduct,
            this.btnWarehouse,
            this.pageDDH,
            this.pagePhieuNhap,
            this.pagePhieuXuat,
            this.barButtonItem1,
            this.baoCao4,
            this.btnBaoCao5,
            this.barButtonItem7,
            this.btnDanhSachVT,
            this.barButtonItem8});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 24;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageHeThong,
            this.PageDanhMuc,
            this.pageNghiepVu,
            this.pageBaoCao});
            this.ribbon.Size = new System.Drawing.Size(1191, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Caption = "NHÂN VIÊN";
            this.btnEmployee.Id = 6;
            this.btnEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.ImageOptions.Image")));
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEmployeeClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "VẬT TƯ";
            this.btnProduct.Id = 13;
            this.btnProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.ImageOptions.Image")));
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnProductClick);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Caption = "KHO";
            this.btnWarehouse.Id = 14;
            this.btnWarehouse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWarehouse.ImageOptions.Image")));
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnWarehouse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnWarehouseClick);
            // 
            // pageDDH
            // 
            this.pageDDH.Caption = "Đơn đặt hàng";
            this.pageDDH.Id = 15;
            this.pageDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pageDDH.ImageOptions.Image")));
            this.pageDDH.Name = "pageDDH";
            this.pageDDH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.pageDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PageDDH_ItemClick);
            // 
            // pagePhieuNhap
            // 
            this.pagePhieuNhap.Caption = "Phiếu nhập";
            this.pagePhieuNhap.Id = 16;
            this.pagePhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pagePhieuNhap.ImageOptions.Image")));
            this.pagePhieuNhap.Name = "pagePhieuNhap";
            this.pagePhieuNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.pagePhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PagePhieuNhap_ItemClick);
            // 
            // pagePhieuXuat
            // 
            this.pagePhieuXuat.Caption = "Phiếu xuất";
            this.pagePhieuXuat.Id = 17;
            this.pagePhieuXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pagePhieuXuat.ImageOptions.Image")));
            this.pagePhieuXuat.Name = "pagePhieuXuat";
            this.pagePhieuXuat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.pagePhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PagePhieuXuat_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Bảng kê Chi tiết Số lượng - Trị Giá";
            this.barButtonItem1.Id = 18;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1_ItemClick);
            // 
            // baoCao4
            // 
            this.baoCao4.Caption = "Danh sách Đơn đặt hàng chưa có phiếu nhập";
            this.baoCao4.Id = 19;
            this.baoCao4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("baoCao4.ImageOptions.Image")));
            this.baoCao4.Name = "baoCao4";
            this.baoCao4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.baoCao4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.baoCao4_ItemClick);
            // 
            // btnBaoCao5
            // 
            this.btnBaoCao5.Caption = "Hoạt động của nhân viên";
            this.btnBaoCao5.Id = 20;
            this.btnBaoCao5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao5.ImageOptions.Image")));
            this.btnBaoCao5.Name = "btnBaoCao5";
            this.btnBaoCao5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBaoCao5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCao5_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Danhh sách nhân viên";
            this.barButtonItem7.Id = 21;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // btnDanhSachVT
            // 
            this.btnDanhSachVT.Caption = "Danh sách vật tư";
            this.btnDanhSachVT.Id = 22;
            this.btnDanhSachVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachVT.ImageOptions.Image")));
            this.btnDanhSachVT.Name = "btnDanhSachVT";
            this.btnDanhSachVT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhSachVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachVT_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Tổng hợp nhập xuất";
            this.barButtonItem8.Id = 23;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // pageHeThong
            // 
            this.pageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            ribbonPageGroupSystem});
            this.pageHeThong.Name = "pageHeThong";
            this.pageHeThong.Text = "Hệ thống";
            // 
            // PageDanhMuc
            // 
            this.PageDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPage_employee,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.PageDanhMuc.Name = "PageDanhMuc";
            this.PageDanhMuc.Text = "Danh mục";
            this.PageDanhMuc.Visible = false;
            // 
            // ribbonPage_employee
            // 
            this.ribbonPage_employee.AllowTextClipping = false;
            this.ribbonPage_employee.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPage_employee.ItemLinks.Add(this.btnEmployee);
            this.ribbonPage_employee.Name = "ribbonPage_employee";
            this.ribbonPage_employee.Text = "Nhân viên";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Vật tư";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnWarehouse);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Kho";
            // 
            // pageNghiepVu
            // 
            this.pageNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.page1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.pageNghiepVu.Name = "pageNghiepVu";
            this.pageNghiepVu.Text = "Nghiệp vụ";
            this.pageNghiepVu.Visible = false;
            // 
            // page1
            // 
            this.page1.ItemLinks.Add(this.pageDDH);
            this.page1.Name = "page1";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.pagePhieuNhap);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.pagePhieuXuat);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // pageBaoCao
            // 
            this.pageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonPageGroup8,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup7,
            this.ribbonPageGroup10});
            this.pageBaoCao.Name = "pageBaoCao";
            this.pageBaoCao.Text = "Báo cáo";
            this.pageBaoCao.Visible = false;
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnDanhSachVT);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.baoCao4);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnBaoCao5);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 671);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1191, 24);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMaNV,
            this.lbTenNV,
            this.lbVaiTro});
            this.statusStrip1.Location = new System.Drawing.Point(0, 649);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1191, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbMaNV
            // 
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(79, 17);
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbTenNV
            // 
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(80, 17);
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // lbVaiTro
            // 
            this.lbVaiTro.Name = "lbVaiTro";
            this.lbVaiTro.Size = new System.Drawing.Size(40, 17);
            this.lbVaiTro.Text = "Vai trò";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 695);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormChinh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÝ VẬT TƯ - ĐẶT HÀNG";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lbMaNV;
        public System.Windows.Forms.ToolStripStatusLabel lbTenNV;
        public System.Windows.Forms.ToolStripStatusLabel lbVaiTro;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup page1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPage_employee;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        public DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnEmployee;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.BarButtonItem btnWarehouse;
        private DevExpress.XtraBars.BarButtonItem pageDDH;
        private DevExpress.XtraBars.BarButtonItem pagePhieuNhap;
        private DevExpress.XtraBars.BarButtonItem pagePhieuXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem baoCao4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnBaoCao5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachVT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
    }
}