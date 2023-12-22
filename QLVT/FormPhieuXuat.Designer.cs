namespace QLVT
{
    partial class FormPhieuXuat
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
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label masoDDHLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label nhaCCLabel1;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuXuat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbMaCN = new System.Windows.Forms.ComboBox();
            this.lbCN = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bdsPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.tbaPhieuXuat = new QLVT.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.tbaCTPX = new QLVT.DSTableAdapters.CTPXTableAdapter();
            this.gcPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNhapLieu = new DevExpress.XtraEditors.GroupControl();
            this.gbCTPX = new System.Windows.Forms.GroupBox();
            this.txtTenVattu = new System.Windows.Forms.TextBox();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.seSoLuongXuat = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVatTu = new System.Windows.Forms.TextBox();
            this.txtCT_MaPhieuXuat = new System.Windows.Forms.TextBox();
            this.btnHuyVattu = new System.Windows.Forms.Button();
            this.btnVattu = new System.Windows.Forms.Button();
            this.gbPhieuXuat = new System.Windows.Forms.GroupBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.dtpNgayXuat = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.cbbTenKho = new System.Windows.Forms.ComboBox();
            this.bdsTenKho = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.bdsTenNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCTPX = new System.Windows.Forms.DataGridView();
            this.dgvMaPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVattu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsTenVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbaTenNhanVien = new QLVT.DSTableAdapters.HoTenTableAdapter();
            this.tbaTenKho = new QLVT.DSTableAdapters.TenKhoTableAdapter();
            this.tbaTenVattu = new QLVT.DSTableAdapters.TenVatTuTableAdapter();
            dONGIALabel = new System.Windows.Forms.Label();
            masoDDHLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            nhaCCLabel1 = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapLieu)).BeginInit();
            this.gcNhapLieu.SuspendLayout();
            this.gbCTPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuongXuat.Properties)).BeginInit();
            this.gbPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayXuat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dONGIALabel.Location = new System.Drawing.Point(315, 111);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(58, 17);
            dONGIALabel.TabIndex = 23;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // masoDDHLabel1
            // 
            masoDDHLabel1.AutoSize = true;
            masoDDHLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel1.Location = new System.Drawing.Point(42, 32);
            masoDDHLabel1.Name = "masoDDHLabel1";
            masoDDHLabel1.Size = new System.Drawing.Size(97, 17);
            masoDDHLabel1.TabIndex = 17;
            masoDDHLabel1.Text = "Mã Phiếu xuất:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAVTLabel.Location = new System.Drawing.Point(91, 74);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(49, 17);
            mAVTLabel.TabIndex = 21;
            mAVTLabel.Text = "Vật tư:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGLabel.Location = new System.Drawing.Point(69, 112);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 17);
            sOLUONGLabel.TabIndex = 19;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(68, 98);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(71, 17);
            hOTENLabel.TabIndex = 42;
            hOTENLabel.Text = "Nhân viên:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHOLabel.Location = new System.Drawing.Point(105, 140);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(36, 17);
            tENKHOLabel.TabIndex = 40;
            tENKHOLabel.Text = "Kho:";
            // 
            // nhaCCLabel1
            // 
            nhaCCLabel1.AutoSize = true;
            nhaCCLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nhaCCLabel1.Location = new System.Drawing.Point(291, 60);
            nhaCCLabel1.Name = "nhaCCLabel1";
            nhaCCLabel1.Size = new System.Drawing.Size(82, 17);
            nhaCCLabel1.TabIndex = 40;
            nhaCCLabel1.Text = "Khách hàng:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(69, 60);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(72, 17);
            nGAYLabel.TabIndex = 31;
            nGAYLabel.Text = "Ngày xuất:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(46, 23);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(95, 17);
            masoDDHLabel.TabIndex = 29;
            masoDDHLabel.Text = "Mã phiếu xuất:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnUndo,
            this.btnRefresh,
            this.btnGhi,
            this.btnCheDo,
            this.btnThoat,
            this.btnSua});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCheDo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 9;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSua_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Hủy thao tác";
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnUndo.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnUndo.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUndo.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUndo_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 5;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGhi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Làm mới";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRefresh_ItemClick);
            // 
            // btnCheDo
            // 
            this.btnCheDo.Caption = "Chi tiết Phiếu xuất";
            this.btnCheDo.Id = 7;
            this.btnCheDo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheDo.ImageOptions.Image")));
            this.btnCheDo.Name = "btnCheDo";
            this.btnCheDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCheDo_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 8;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1388, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 700);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1388, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 668);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1388, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 668);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbMaCN);
            this.panel1.Controls.Add(this.lbCN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 66);
            this.panel1.TabIndex = 7;
            // 
            // cbbMaCN
            // 
            this.cbbMaCN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaCN.FormattingEnabled = true;
            this.cbbMaCN.Location = new System.Drawing.Point(605, 20);
            this.cbbMaCN.Name = "cbbMaCN";
            this.cbbMaCN.Size = new System.Drawing.Size(244, 27);
            this.cbbMaCN.TabIndex = 1;
            this.cbbMaCN.SelectedIndexChanged += new System.EventHandler(this.CbbMaCN_SelectedIndexChanged);
            // 
            // lbCN
            // 
            this.lbCN.AutoSize = true;
            this.lbCN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCN.Location = new System.Drawing.Point(523, 24);
            this.lbCN.Name = "lbCN";
            this.lbCN.Size = new System.Drawing.Size(81, 19);
            this.lbCN.TabIndex = 0;
            this.lbCN.Text = "Chi nhánh:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhieuXuat
            // 
            this.bdsPhieuXuat.DataMember = "PhieuXuat";
            this.bdsPhieuXuat.DataSource = this.DS;
            // 
            // tbaPhieuXuat
            // 
            this.tbaPhieuXuat.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.tbaCTPX;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.tbaPhieuXuat;
            this.tableAdapterManager.TenVatTuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // tbaCTPX
            // 
            this.tbaCTPX.ClearBeforeFill = true;
            // 
            // gcPhieuXuat
            // 
            this.gcPhieuXuat.DataSource = this.bdsPhieuXuat;
            this.gcPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuXuat.Location = new System.Drawing.Point(0, 98);
            this.gcPhieuXuat.MainView = this.gridView1;
            this.gcPhieuXuat.MenuManager = this.barManager1;
            this.gcPhieuXuat.Name = "gcPhieuXuat";
            this.gcPhieuXuat.Size = new System.Drawing.Size(1388, 222);
            this.gcPhieuXuat.TabIndex = 12;
            this.gcPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPhieuXuat;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView1_FocusedRowChanged);
            // 
            // colMAPX
            // 
            this.colMAPX.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAPX.AppearanceCell.Options.UseFont = true;
            this.colMAPX.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colMAPX.AppearanceHeader.Options.UseBackColor = true;
            this.colMAPX.Caption = "Mã phiếu xuất";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 139;
            // 
            // colNGAY
            // 
            this.colNGAY.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAY.AppearanceCell.Options.UseFont = true;
            this.colNGAY.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colNGAY.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAY.Caption = "Ngày xuất";
            this.colNGAY.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 134;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOTENKH.AppearanceCell.Options.UseFont = true;
            this.colHOTENKH.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colHOTENKH.AppearanceHeader.Options.UseBackColor = true;
            this.colHOTENKH.Caption = "Khách hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 223;
            // 
            // colMANV
            // 
            this.colMANV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMANV.AppearanceCell.Options.UseFont = true;
            this.colMANV.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colMANV.AppearanceHeader.Options.UseBackColor = true;
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 137;
            // 
            // colMAKHO
            // 
            this.colMAKHO.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHO.AppearanceCell.Options.UseFont = true;
            this.colMAKHO.AppearanceCell.Options.UseTextOptions = true;
            this.colMAKHO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMAKHO.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colMAKHO.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 120;
            // 
            // gcNhapLieu
            // 
            this.gcNhapLieu.Controls.Add(this.gbCTPX);
            this.gcNhapLieu.Controls.Add(this.gbPhieuXuat);
            this.gcNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcNhapLieu.Location = new System.Drawing.Point(0, 320);
            this.gcNhapLieu.Name = "gcNhapLieu";
            this.gcNhapLieu.Size = new System.Drawing.Size(599, 380);
            this.gcNhapLieu.TabIndex = 31;
            this.gcNhapLieu.Text = "Thông tin";
            // 
            // gbCTPX
            // 
            this.gbCTPX.Controls.Add(this.txtTenVattu);
            this.gbCTPX.Controls.Add(this.txtDonGia);
            this.gbCTPX.Controls.Add(this.seSoLuongXuat);
            this.gbCTPX.Controls.Add(this.txtMaVatTu);
            this.gbCTPX.Controls.Add(this.txtCT_MaPhieuXuat);
            this.gbCTPX.Controls.Add(this.btnHuyVattu);
            this.gbCTPX.Controls.Add(this.btnVattu);
            this.gbCTPX.Controls.Add(dONGIALabel);
            this.gbCTPX.Controls.Add(masoDDHLabel1);
            this.gbCTPX.Controls.Add(mAVTLabel);
            this.gbCTPX.Controls.Add(sOLUONGLabel);
            this.gbCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTPX.Location = new System.Drawing.Point(2, 213);
            this.gbCTPX.Name = "gbCTPX";
            this.gbCTPX.Size = new System.Drawing.Size(595, 165);
            this.gbCTPX.TabIndex = 22;
            this.gbCTPX.TabStop = false;
            this.gbCTPX.Text = "Chi tiết phiếu xuất";
            // 
            // txtTenVattu
            // 
            this.txtTenVattu.Enabled = false;
            this.txtTenVattu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVattu.Location = new System.Drawing.Point(145, 70);
            this.txtTenVattu.Name = "txtTenVattu";
            this.txtTenVattu.Size = new System.Drawing.Size(274, 25);
            this.txtTenVattu.TabIndex = 38;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "DONGIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(379, 108);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.DisplayFormat.FormatString = "n0";
            this.txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Properties.EditFormat.FormatString = "n0";
            this.txtDonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Size = new System.Drawing.Size(160, 24);
            this.txtDonGia.TabIndex = 37;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_PX";
            this.bdsCTPX.DataSource = this.bdsPhieuXuat;
            // 
            // seSoLuongXuat
            // 
            this.seSoLuongXuat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "SOLUONG", true));
            this.seSoLuongXuat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSoLuongXuat.Location = new System.Drawing.Point(145, 108);
            this.seSoLuongXuat.MenuManager = this.barManager1;
            this.seSoLuongXuat.Name = "seSoLuongXuat";
            this.seSoLuongXuat.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seSoLuongXuat.Properties.Appearance.Options.UseFont = true;
            this.seSoLuongXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoLuongXuat.Size = new System.Drawing.Size(126, 24);
            this.seSoLuongXuat.TabIndex = 36;
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "MAVT", true));
            this.txtMaVatTu.Enabled = false;
            this.txtMaVatTu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVatTu.Location = new System.Drawing.Point(439, 70);
            this.txtMaVatTu.Name = "txtMaVatTu";
            this.txtMaVatTu.Size = new System.Drawing.Size(100, 25);
            this.txtMaVatTu.TabIndex = 35;
            // 
            // txtCT_MaPhieuXuat
            // 
            this.txtCT_MaPhieuXuat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "MAPX", true));
            this.txtCT_MaPhieuXuat.Enabled = false;
            this.txtCT_MaPhieuXuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCT_MaPhieuXuat.Location = new System.Drawing.Point(147, 28);
            this.txtCT_MaPhieuXuat.Name = "txtCT_MaPhieuXuat";
            this.txtCT_MaPhieuXuat.Size = new System.Drawing.Size(100, 25);
            this.txtCT_MaPhieuXuat.TabIndex = 34;
            // 
            // btnHuyVattu
            // 
            this.btnHuyVattu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyVattu.Location = new System.Drawing.Point(439, 20);
            this.btnHuyVattu.Name = "btnHuyVattu";
            this.btnHuyVattu.Size = new System.Drawing.Size(105, 40);
            this.btnHuyVattu.TabIndex = 33;
            this.btnHuyVattu.Text = "Hủy";
            this.btnHuyVattu.UseVisualStyleBackColor = true;
            this.btnHuyVattu.Click += new System.EventHandler(this.btnHuyVattu_Click);
            // 
            // btnVattu
            // 
            this.btnVattu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVattu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVattu.Location = new System.Drawing.Point(269, 20);
            this.btnVattu.Name = "btnVattu";
            this.btnVattu.Size = new System.Drawing.Size(150, 40);
            this.btnVattu.TabIndex = 32;
            this.btnVattu.Text = "Chọn Vật tư";
            this.btnVattu.UseVisualStyleBackColor = false;
            this.btnVattu.Click += new System.EventHandler(this.btnVattu_Click);
            // 
            // gbPhieuXuat
            // 
            this.gbPhieuXuat.Controls.Add(this.txtMaKho);
            this.gbPhieuXuat.Controls.Add(this.txtMaNhanVien);
            this.gbPhieuXuat.Controls.Add(this.txtKhachHang);
            this.gbPhieuXuat.Controls.Add(this.dtpNgayXuat);
            this.gbPhieuXuat.Controls.Add(this.txtMaPhieuXuat);
            this.gbPhieuXuat.Controls.Add(this.cbbTenKho);
            this.gbPhieuXuat.Controls.Add(this.cbbTenNV);
            this.gbPhieuXuat.Controls.Add(hOTENLabel);
            this.gbPhieuXuat.Controls.Add(tENKHOLabel);
            this.gbPhieuXuat.Controls.Add(nhaCCLabel1);
            this.gbPhieuXuat.Controls.Add(nGAYLabel);
            this.gbPhieuXuat.Controls.Add(masoDDHLabel);
            this.gbPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPhieuXuat.Location = new System.Drawing.Point(2, 23);
            this.gbPhieuXuat.Name = "gbPhieuXuat";
            this.gbPhieuXuat.Size = new System.Drawing.Size(595, 190);
            this.gbPhieuXuat.TabIndex = 23;
            this.gbPhieuXuat.TabStop = false;
            this.gbPhieuXuat.Text = "Phiếu xuất";
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKho.Location = new System.Drawing.Point(444, 136);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(100, 25);
            this.txtMaKho.TabIndex = 58;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "MANV", true));
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(444, 94);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(100, 25);
            this.txtMaNhanVien.TabIndex = 57;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "HOTENKH", true));
            this.txtKhachHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachHang.Location = new System.Drawing.Point(379, 56);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(160, 25);
            this.txtKhachHang.TabIndex = 56;
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuXuat, "NGAY", true));
            this.dtpNgayXuat.EditValue = null;
            this.dtpNgayXuat.Location = new System.Drawing.Point(147, 56);
            this.dtpNgayXuat.MenuManager = this.barManager1;
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuat.Properties.Appearance.Options.UseFont = true;
            this.dtpNgayXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayXuat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayXuat.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtpNgayXuat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgayXuat.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.dtpNgayXuat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNgayXuat.Size = new System.Drawing.Size(124, 24);
            this.dtpNgayXuat.TabIndex = 55;
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "MAPX", true));
            this.txtMaPhieuXuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(145, 19);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(126, 25);
            this.txtMaPhieuXuat.TabIndex = 54;
            // 
            // cbbTenKho
            // 
            this.cbbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPhieuXuat, "MAKHO", true));
            this.cbbTenKho.DataSource = this.bdsTenKho;
            this.cbbTenKho.DisplayMember = "TENKHO";
            this.cbbTenKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenKho.FormattingEnabled = true;
            this.cbbTenKho.Location = new System.Drawing.Point(147, 136);
            this.cbbTenKho.Name = "cbbTenKho";
            this.cbbTenKho.Size = new System.Drawing.Size(275, 25);
            this.cbbTenKho.TabIndex = 53;
            this.cbbTenKho.ValueMember = "MAKHO";
            this.cbbTenKho.SelectedIndexChanged += new System.EventHandler(this.CbbTenKho_SelectedIndexChanged);
            // 
            // bdsTenKho
            // 
            this.bdsTenKho.DataMember = "TenKho";
            this.bdsTenKho.DataSource = this.DS;
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPhieuXuat, "MANV", true));
            this.cbbTenNV.DataSource = this.bdsTenNhanVien;
            this.cbbTenNV.DisplayMember = "HOTEN";
            this.cbbTenNV.Enabled = false;
            this.cbbTenNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(146, 94);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(276, 25);
            this.cbbTenNV.TabIndex = 52;
            this.cbbTenNV.ValueMember = "MANV";
            this.cbbTenNV.SelectedIndexChanged += new System.EventHandler(this.CbbTenNV_SelectedIndexChanged);
            // 
            // bdsTenNhanVien
            // 
            this.bdsTenNhanVien.DataMember = "HoTen";
            this.bdsTenNhanVien.DataSource = this.DS;
            // 
            // dgvCTPX
            // 
            this.dgvCTPX.AllowUserToAddRows = false;
            this.dgvCTPX.AllowUserToDeleteRows = false;
            this.dgvCTPX.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaPhieuXuat,
            this.dgvVattu,
            this.dgvSoLuong,
            this.dgvDonGia});
            this.dgvCTPX.DataSource = this.bdsCTPX;
            this.dgvCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPX.Location = new System.Drawing.Point(599, 320);
            this.dgvCTPX.Name = "dgvCTPX";
            this.dgvCTPX.Size = new System.Drawing.Size(789, 380);
            this.dgvCTPX.TabIndex = 31;
            this.dgvCTPX.SelectionChanged += new System.EventHandler(this.DgvCTPX_SelectionChanged);
            // 
            // dgvMaPhieuXuat
            // 
            this.dgvMaPhieuXuat.DataPropertyName = "MAPX";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMaPhieuXuat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaPhieuXuat.HeaderText = "Mã Phiếu xuất";
            this.dgvMaPhieuXuat.Name = "dgvMaPhieuXuat";
            this.dgvMaPhieuXuat.ReadOnly = true;
            // 
            // dgvVattu
            // 
            this.dgvVattu.DataPropertyName = "MAVT";
            this.dgvVattu.DataSource = this.bdsTenVatTu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVattu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVattu.DisplayMember = "TENVT";
            this.dgvVattu.HeaderText = "Vật tư";
            this.dgvVattu.Name = "dgvVattu";
            this.dgvVattu.ReadOnly = true;
            this.dgvVattu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVattu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvVattu.ValueMember = "MAVT";
            this.dgvVattu.Width = 200;
            // 
            // bdsTenVatTu
            // 
            this.bdsTenVatTu.DataMember = "TenVatTu";
            this.bdsTenVatTu.DataSource = this.DS;
            // 
            // dgvSoLuong
            // 
            this.dgvSoLuong.DataPropertyName = "SOLUONG";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvSoLuong.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSoLuong.HeaderText = "Số lượng";
            this.dgvSoLuong.Name = "dgvSoLuong";
            // 
            // dgvDonGia
            // 
            this.dgvDonGia.DataPropertyName = "DONGIA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.dgvDonGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDonGia.HeaderText = "Đơn giá";
            this.dgvDonGia.Name = "dgvDonGia";
            this.dgvDonGia.ReadOnly = true;
            // 
            // tbaTenNhanVien
            // 
            this.tbaTenNhanVien.ClearBeforeFill = true;
            // 
            // tbaTenKho
            // 
            this.tbaTenKho.ClearBeforeFill = true;
            // 
            // tbaTenVattu
            // 
            this.tbaTenVattu.ClearBeforeFill = true;
            // 
            // FormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 720);
            this.Controls.Add(this.dgvCTPX);
            this.Controls.Add(this.gcNhapLieu);
            this.Controls.Add(this.gcPhieuXuat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormPhieuXuat";
            this.Text = "FormPhieuXuat";
            this.Load += new System.EventHandler(this.FormPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapLieu)).EndInit();
            this.gcNhapLieu.ResumeLayout(false);
            this.gbCTPX.ResumeLayout(false);
            this.gbCTPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuongXuat.Properties)).EndInit();
            this.gbPhieuXuat.ResumeLayout(false);
            this.gbPhieuXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayXuat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenVatTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnCheDo;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbMaCN;
        private System.Windows.Forms.Label lbCN;
        private System.Windows.Forms.BindingSource bdsPhieuXuat;
        private DS DS;
        private DSTableAdapters.PhieuXuatTableAdapter tbaPhieuXuat;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.GroupControl gcNhapLieu;
        private System.Windows.Forms.GroupBox gbCTPX;
        public System.Windows.Forms.Button btnHuyVattu;
        private System.Windows.Forms.Button btnVattu;
        private System.Windows.Forms.GroupBox gbPhieuXuat;
        private System.Windows.Forms.ComboBox cbbTenKho;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private DSTableAdapters.CTPXTableAdapter tbaCTPX;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private System.Windows.Forms.DataGridView dgvCTPX;
        private System.Windows.Forms.BindingSource bdsTenNhanVien;
        private DSTableAdapters.HoTenTableAdapter tbaTenNhanVien;
        private System.Windows.Forms.BindingSource bdsTenKho;
        private DSTableAdapters.TenKhoTableAdapter tbaTenKho;
        private System.Windows.Forms.BindingSource bdsTenVatTu;
        private DSTableAdapters.TenVatTuTableAdapter tbaTenVattu;
        private System.Windows.Forms.TextBox txtCT_MaPhieuXuat;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtKhachHang;
        private DevExpress.XtraEditors.DateEdit dtpNgayXuat;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.SpinEdit seSoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaPhieuXuat;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvVattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDonGia;
        public System.Windows.Forms.TextBox txtTenVattu;
        public System.Windows.Forms.TextBox txtMaVatTu;
    }
}