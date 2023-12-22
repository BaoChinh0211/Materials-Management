namespace QLVT
{
    partial class FormDonDatHang
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
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nhaCCLabel1;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label masoDDHLabel1;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonDatHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QLVT.DS();
            this.tbaVatTu = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbMaCN = new System.Windows.Forms.ComboBox();
            this.lbCN = new System.Windows.Forms.Label();
            this.tbaCTDDH = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.tbaKho = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.tbaDatHang = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.gcDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvCTDDH = new System.Windows.Forms.DataGridView();
            this.MaSoDDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTenVT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsTenVT = new System.Windows.Forms.BindingSource(this.components);
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.gcNhapLieu = new DevExpress.XtraEditors.GroupControl();
            this.gbCTDDH = new System.Windows.Forms.GroupBox();
            this.txtVatTu = new System.Windows.Forms.TextBox();
            this.btnHuyVattu = new System.Windows.Forms.Button();
            this.btnVattu = new System.Windows.Forms.Button();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.seSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtCT_MaDDH = new System.Windows.Forms.TextBox();
            this.gbDDH = new System.Windows.Forms.GroupBox();
            this.cbbTenKho = new System.Windows.Forms.ComboBox();
            this.bdsTenKho = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.bdsHoTen = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.dtpNgayDat = new DevExpress.XtraEditors.DateEdit();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.tbaHoTen = new QLVT.DSTableAdapters.HoTenTableAdapter();
            this.tbaTenVT = new QLVT.DSTableAdapters.TenVatTuTableAdapter();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.tbaPhieuNhap = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.tbaTenKho = new QLVT.DSTableAdapters.TenKhoTableAdapter();
            hOTENLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            nhaCCLabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            masoDDHLabel1 = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapLieu)).BeginInit();
            this.gcNhapLieu.SuspendLayout();
            this.gbCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).BeginInit();
            this.gbDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(63, 103);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(71, 17);
            hOTENLabel.TabIndex = 42;
            hOTENLabel.Text = "Nhân viên:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHOLabel.Location = new System.Drawing.Point(100, 145);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(36, 17);
            tENKHOLabel.TabIndex = 40;
            tENKHOLabel.Text = "Kho:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(92, 65);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(43, 17);
            nGAYLabel.TabIndex = 31;
            nGAYLabel.Text = "Ngày:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(50, 24);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(85, 17);
            masoDDHLabel.TabIndex = 29;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // nhaCCLabel1
            // 
            nhaCCLabel1.AutoSize = true;
            nhaCCLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nhaCCLabel1.Location = new System.Drawing.Point(275, 65);
            nhaCCLabel1.Name = "nhaCCLabel1";
            nhaCCLabel1.Size = new System.Drawing.Size(93, 17);
            nhaCCLabel1.TabIndex = 40;
            nhaCCLabel1.Text = "Nhà cung cấp:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGLabel.Location = new System.Drawing.Point(62, 128);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 17);
            sOLUONGLabel.TabIndex = 19;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAVTLabel.Location = new System.Drawing.Point(84, 93);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(49, 17);
            mAVTLabel.TabIndex = 21;
            mAVTLabel.Text = "Vật tư:";
            // 
            // masoDDHLabel1
            // 
            masoDDHLabel1.AutoSize = true;
            masoDDHLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel1.Location = new System.Drawing.Point(48, 55);
            masoDDHLabel1.Name = "masoDDHLabel1";
            masoDDHLabel1.Size = new System.Drawing.Size(85, 17);
            masoDDHLabel1.TabIndex = 17;
            masoDDHLabel1.Text = "Mã số DDH:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dONGIALabel.Location = new System.Drawing.Point(334, 124);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(58, 17);
            dONGIALabel.TabIndex = 23;
            dONGIALabel.Text = "Đơn giá:";
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
            this.btnSua,
            this.btnUndo,
            this.btnRefresh,
            this.btnGhi,
            this.btnCheDo,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnSua.Caption = "Hiệu chỉnh";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 5;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGhi_ItemClick);
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
            this.btnCheDo.Caption = "Chi tiết DDH";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1259, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 687);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1259, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1259, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 655);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbaVatTu
            // 
            this.tbaVatTu.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbMaCN);
            this.panel1.Controls.Add(this.lbCN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 66);
            this.panel1.TabIndex = 5;
            // 
            // cbbMaCN
            // 
            this.cbbMaCN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaCN.FormattingEnabled = true;
            this.cbbMaCN.Location = new System.Drawing.Point(532, 22);
            this.cbbMaCN.Name = "cbbMaCN";
            this.cbbMaCN.Size = new System.Drawing.Size(244, 27);
            this.cbbMaCN.TabIndex = 1;
            this.cbbMaCN.SelectedIndexChanged += new System.EventHandler(this.CbbMaCN_SelectedIndexChanged);
            // 
            // lbCN
            // 
            this.lbCN.AutoSize = true;
            this.lbCN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCN.Location = new System.Drawing.Point(450, 26);
            this.lbCN.Name = "lbCN";
            this.lbCN.Size = new System.Drawing.Size(76, 19);
            this.lbCN.TabIndex = 0;
            this.lbCN.Text = "Chi nhánh";
            // 
            // tbaCTDDH
            // 
            this.tbaCTDDH.ClearBeforeFill = true;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.DS;
            // 
            // tbaKho
            // 
            this.tbaKho.ClearBeforeFill = true;
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DatHang";
            this.bdsDatHang.DataSource = this.DS;
            // 
            // tbaDatHang
            // 
            this.tbaDatHang.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.tbaDatHang;
            this.tableAdapterManager.KhoTableAdapter = this.tbaKho;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.TenVatTuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.tbaVatTu;
            // 
            // gcDatHang
            // 
            this.gcDatHang.DataSource = this.bdsDatHang;
            this.gcDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDatHang.Location = new System.Drawing.Point(0, 98);
            this.gcDatHang.MainView = this.gridView1;
            this.gcDatHang.MenuManager = this.barManager1;
            this.gcDatHang.Name = "gcDatHang";
            this.gcDatHang.Size = new System.Drawing.Size(1259, 192);
            this.gcDatHang.TabIndex = 29;
            this.gcDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMAKHO,
            this.colMANV});
            this.gridView1.GridControl = this.gcDatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView1_FocusedRowChanged);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMasoDDH.AppearanceCell.Options.UseFont = true;
            this.colMasoDDH.AppearanceCell.Options.UseTextOptions = true;
            this.colMasoDDH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMasoDDH.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colMasoDDH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMasoDDH.AppearanceHeader.Options.UseBackColor = true;
            this.colMasoDDH.AppearanceHeader.Options.UseFont = true;
            this.colMasoDDH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMasoDDH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMasoDDH.Caption = "Mã số DDH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 170;
            // 
            // colNGAY
            // 
            this.colNGAY.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAY.AppearanceCell.Options.UseFont = true;
            this.colNGAY.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAY.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colNGAY.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAY.Caption = "Ngày đặt";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 254;
            // 
            // colNhaCC
            // 
            this.colNhaCC.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNhaCC.AppearanceCell.Options.UseFont = true;
            this.colNhaCC.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colNhaCC.AppearanceHeader.Options.UseBackColor = true;
            this.colNhaCC.Caption = "Nhà cung cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 376;
            // 
            // colMAKHO
            // 
            this.colMAKHO.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHO.AppearanceCell.Options.UseFont = true;
            this.colMAKHO.AppearanceCell.Options.UseTextOptions = true;
            this.colMAKHO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHO.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colMAKHO.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 3;
            this.colMAKHO.Width = 183;
            // 
            // colMANV
            // 
            this.colMANV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMANV.AppearanceCell.Options.UseFont = true;
            this.colMANV.AppearanceCell.Options.UseTextOptions = true;
            this.colMANV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMANV.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colMANV.AppearanceHeader.Options.UseBackColor = true;
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 4;
            this.colMANV.Width = 251;
            // 
            // dgvCTDDH
            // 
            this.dgvCTDDH.AllowUserToAddRows = false;
            this.dgvCTDDH.AllowUserToDeleteRows = false;
            this.dgvCTDDH.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTDDH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSoDDH,
            this.cbbTenVT,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn});
            this.dgvCTDDH.DataSource = this.bdsCTDDH;
            this.dgvCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTDDH.Location = new System.Drawing.Point(592, 290);
            this.dgvCTDDH.Name = "dgvCTDDH";
            this.dgvCTDDH.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTDDH.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCTDDH.Size = new System.Drawing.Size(667, 397);
            this.dgvCTDDH.TabIndex = 31;
            this.dgvCTDDH.SelectionChanged += new System.EventHandler(this.DgvCTDDH_SelectionChanged);
            // 
            // MaSoDDH
            // 
            this.MaSoDDH.DataPropertyName = "MasoDDH";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSoDDH.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaSoDDH.HeaderText = "Mã số DDH";
            this.MaSoDDH.Name = "MaSoDDH";
            this.MaSoDDH.ReadOnly = true;
            // 
            // cbbTenVT
            // 
            this.cbbTenVT.DataPropertyName = "MAVT";
            this.cbbTenVT.DataSource = this.bdsTenVT;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenVT.DefaultCellStyle = dataGridViewCellStyle3;
            this.cbbTenVT.DisplayMember = "TENVT";
            this.cbbTenVT.HeaderText = "Vật tư";
            this.cbbTenVT.Name = "cbbTenVT";
            this.cbbTenVT.ReadOnly = true;
            this.cbbTenVT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbbTenVT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbbTenVT.ValueMember = "MAVT";
            this.cbbTenVT.Width = 250;
            // 
            // bdsTenVT
            // 
            this.bdsTenVT.DataMember = "TenVatTu";
            this.bdsTenVT.DataSource = this.DS;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOLUONGDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOLUONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.dONGIADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            this.dONGIADataGridViewTextBoxColumn.ReadOnly = true;
            this.dONGIADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dONGIADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dONGIADataGridViewTextBoxColumn.Width = 150;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDatHang;
            // 
            // gcNhapLieu
            // 
            this.gcNhapLieu.Controls.Add(this.gbCTDDH);
            this.gcNhapLieu.Controls.Add(this.gbDDH);
            this.gcNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcNhapLieu.Location = new System.Drawing.Point(0, 290);
            this.gcNhapLieu.Name = "gcNhapLieu";
            this.gcNhapLieu.Size = new System.Drawing.Size(592, 397);
            this.gcNhapLieu.TabIndex = 30;
            this.gcNhapLieu.Text = "Thông tin";
            // 
            // gbCTDDH
            // 
            this.gbCTDDH.Controls.Add(this.txtVatTu);
            this.gbCTDDH.Controls.Add(this.btnHuyVattu);
            this.gbCTDDH.Controls.Add(this.btnVattu);
            this.gbCTDDH.Controls.Add(this.txtMaVT);
            this.gbCTDDH.Controls.Add(this.txtDonGia);
            this.gbCTDDH.Controls.Add(this.seSoLuong);
            this.gbCTDDH.Controls.Add(this.txtCT_MaDDH);
            this.gbCTDDH.Controls.Add(dONGIALabel);
            this.gbCTDDH.Controls.Add(masoDDHLabel1);
            this.gbCTDDH.Controls.Add(mAVTLabel);
            this.gbCTDDH.Controls.Add(sOLUONGLabel);
            this.gbCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTDDH.Location = new System.Drawing.Point(2, 219);
            this.gbCTDDH.Name = "gbCTDDH";
            this.gbCTDDH.Size = new System.Drawing.Size(588, 176);
            this.gbCTDDH.TabIndex = 22;
            this.gbCTDDH.TabStop = false;
            this.gbCTDDH.Text = "Chi tiết Đơn đặt hàng";
            // 
            // txtVatTu
            // 
            this.txtVatTu.Enabled = false;
            this.txtVatTu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatTu.Location = new System.Drawing.Point(138, 89);
            this.txtVatTu.Name = "txtVatTu";
            this.txtVatTu.Size = new System.Drawing.Size(254, 25);
            this.txtVatTu.TabIndex = 34;
            // 
            // btnHuyVattu
            // 
            this.btnHuyVattu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyVattu.Location = new System.Drawing.Point(432, 42);
            this.btnHuyVattu.Name = "btnHuyVattu";
            this.btnHuyVattu.Size = new System.Drawing.Size(105, 40);
            this.btnHuyVattu.TabIndex = 33;
            this.btnHuyVattu.Text = "Hủy";
            this.btnHuyVattu.UseVisualStyleBackColor = true;
            this.btnHuyVattu.Click += new System.EventHandler(this.BtnHuyVattu_Click);
            // 
            // btnVattu
            // 
            this.btnVattu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVattu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVattu.Location = new System.Drawing.Point(262, 42);
            this.btnVattu.Name = "btnVattu";
            this.btnVattu.Size = new System.Drawing.Size(150, 40);
            this.btnVattu.TabIndex = 32;
            this.btnVattu.Text = "Chọn Vật tư";
            this.btnVattu.UseVisualStyleBackColor = false;
            this.btnVattu.Click += new System.EventHandler(this.BtnVattu_Click);
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTDDH, "MAVT", true));
            this.txtMaVT.Enabled = false;
            this.txtMaVT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Location = new System.Drawing.Point(437, 89);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(100, 25);
            this.txtMaVT.TabIndex = 30;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "DONGIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(398, 121);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.DisplayFormat.FormatString = "n0";
            this.txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Properties.EditFormat.FormatString = "n0";
            this.txtDonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Size = new System.Drawing.Size(166, 24);
            this.txtDonGia.TabIndex = 28;
            // 
            // seSoLuong
            // 
            this.seSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "SOLUONG", true));
            this.seSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSoLuong.Location = new System.Drawing.Point(138, 124);
            this.seSoLuong.MenuManager = this.barManager1;
            this.seSoLuong.Name = "seSoLuong";
            this.seSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seSoLuong.Properties.Appearance.Options.UseFont = true;
            this.seSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoLuong.Size = new System.Drawing.Size(113, 24);
            this.seSoLuong.TabIndex = 27;
            // 
            // txtCT_MaDDH
            // 
            this.txtCT_MaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTDDH, "MasoDDH", true));
            this.txtCT_MaDDH.Enabled = false;
            this.txtCT_MaDDH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCT_MaDDH.Location = new System.Drawing.Point(138, 51);
            this.txtCT_MaDDH.Name = "txtCT_MaDDH";
            this.txtCT_MaDDH.Size = new System.Drawing.Size(113, 25);
            this.txtCT_MaDDH.TabIndex = 24;
            // 
            // gbDDH
            // 
            this.gbDDH.Controls.Add(this.cbbTenKho);
            this.gbDDH.Controls.Add(this.cbbTenNV);
            this.gbDDH.Controls.Add(this.txtMaKho);
            this.gbDDH.Controls.Add(this.txtMaNV);
            this.gbDDH.Controls.Add(this.txtNhaCC);
            this.gbDDH.Controls.Add(this.dtpNgayDat);
            this.gbDDH.Controls.Add(this.txtMaDDH);
            this.gbDDH.Controls.Add(hOTENLabel);
            this.gbDDH.Controls.Add(tENKHOLabel);
            this.gbDDH.Controls.Add(nhaCCLabel1);
            this.gbDDH.Controls.Add(nGAYLabel);
            this.gbDDH.Controls.Add(masoDDHLabel);
            this.gbDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDDH.Location = new System.Drawing.Point(2, 23);
            this.gbDDH.Name = "gbDDH";
            this.gbDDH.Size = new System.Drawing.Size(588, 196);
            this.gbDDH.TabIndex = 23;
            this.gbDDH.TabStop = false;
            this.gbDDH.Text = "Đơn đặt hàng";
            // 
            // cbbTenKho
            // 
            this.cbbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDatHang, "MAKHO", true));
            this.cbbTenKho.DataSource = this.bdsTenKho;
            this.cbbTenKho.DisplayMember = "TENKHO";
            this.cbbTenKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenKho.FormattingEnabled = true;
            this.cbbTenKho.Location = new System.Drawing.Point(142, 142);
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
            this.cbbTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDatHang, "MANV", true));
            this.cbbTenNV.DataSource = this.bdsHoTen;
            this.cbbTenNV.DisplayMember = "HOTEN";
            this.cbbTenNV.Enabled = false;
            this.cbbTenNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(141, 99);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(276, 25);
            this.cbbTenNV.TabIndex = 52;
            this.cbbTenNV.ValueMember = "MANV";
            this.cbbTenNV.SelectedIndexChanged += new System.EventHandler(this.CbbTenNV_SelectedIndexChanged);
            // 
            // bdsHoTen
            // 
            this.bdsHoTen.DataMember = "HoTen";
            this.bdsHoTen.DataSource = this.DS;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDatHang, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKho.Location = new System.Drawing.Point(439, 141);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(127, 25);
            this.txtMaKho.TabIndex = 51;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDatHang, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(439, 99);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(127, 25);
            this.txtMaNV.TabIndex = 48;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDatHang, "NhaCC", true));
            this.txtNhaCC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCC.Location = new System.Drawing.Point(374, 61);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(192, 25);
            this.txtNhaCC.TabIndex = 45;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NGAY", true));
            this.dtpNgayDat.EditValue = null;
            this.dtpNgayDat.Location = new System.Drawing.Point(141, 62);
            this.dtpNgayDat.MenuManager = this.barManager1;
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDat.Properties.Appearance.Options.UseFont = true;
            this.dtpNgayDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayDat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayDat.Size = new System.Drawing.Size(112, 24);
            this.dtpNgayDat.TabIndex = 44;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDatHang, "MasoDDH", true));
            this.txtMaDDH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDDH.Location = new System.Drawing.Point(141, 24);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(112, 25);
            this.txtMaDDH.TabIndex = 43;
            // 
            // tbaHoTen
            // 
            this.tbaHoTen.ClearBeforeFill = true;
            // 
            // tbaTenVT
            // 
            this.tbaTenVT.ClearBeforeFill = true;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "FK_PhieuNhap_DatHang";
            this.bdsPhieuNhap.DataSource = this.bdsDatHang;
            // 
            // tbaPhieuNhap
            // 
            this.tbaPhieuNhap.ClearBeforeFill = true;
            // 
            // tbaTenKho
            // 
            this.tbaTenKho.ClearBeforeFill = true;
            // 
            // FormDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 707);
            this.Controls.Add(this.dgvCTDDH);
            this.Controls.Add(this.gcNhapLieu);
            this.Controls.Add(this.gcDatHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDonDatHang";
            this.Text = "FormDonDatHang";
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapLieu)).EndInit();
            this.gcNhapLieu.ResumeLayout(false);
            this.gbCTDDH.ResumeLayout(false);
            this.gbCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).EndInit();
            this.gbDDH.ResumeLayout(false);
            this.gbDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnCheDo;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DS DS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbMaCN;
        private System.Windows.Forms.Label lbCN;
        private DSTableAdapters.CTDDHTableAdapter tbaCTDDH;
        private DSTableAdapters.VattuTableAdapter tbaVatTu;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KhoTableAdapter tbaKho;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DSTableAdapters.DatHangTableAdapter tbaDatHang;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvCTDDH;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DevExpress.XtraEditors.GroupControl gcNhapLieu;
        private System.Windows.Forms.GroupBox gbDDH;
        private DevExpress.XtraGrid.GridControl gcDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.BindingSource bdsHoTen;
        private DSTableAdapters.HoTenTableAdapter tbaHoTen;
        private DSTableAdapters.TenVatTuTableAdapter tbaTenVT;
        private System.Windows.Forms.GroupBox gbCTDDH;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.SpinEdit seSoLuong;
        private System.Windows.Forms.TextBox txtCT_MaDDH;
        private System.Windows.Forms.BindingSource bdsTenVT;
        public System.Windows.Forms.Button btnHuyVattu;
        public System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.Button btnVattu;
        public System.Windows.Forms.TextBox txtVatTu;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DSTableAdapters.PhieuNhapTableAdapter tbaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoDDH;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbTenVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dONGIADataGridViewTextBoxColumn;
        private DSTableAdapters.TenKhoTableAdapter tbaTenKho;
        private System.Windows.Forms.BindingSource bdsTenKho;
        private System.Windows.Forms.ComboBox cbbTenKho;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtNhaCC;
        private DevExpress.XtraEditors.DateEdit dtpNgayDat;
        private System.Windows.Forms.TextBox txtMaDDH;
    }
}