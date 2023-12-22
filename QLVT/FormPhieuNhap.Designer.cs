namespace QLVT
{
    partial class FormPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label tENVTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuNhap));
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
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.tbaPhieuNhap = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.tbaCTPN = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.tbaTenNV = new QLVT.DSTableAdapters.HoTenTableAdapter();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsTenNV = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTenVT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsTenVT = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPhieuNhap = new System.Windows.Forms.GroupBox();
            this.cbbTenKho = new System.Windows.Forms.ComboBox();
            this.bdsTenKho = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.btnHuyDDH = new System.Windows.Forms.Button();
            this.btnDDH = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.dtpNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.gbCTPN = new System.Windows.Forms.GroupBox();
            this.btnHuyCTDDH = new System.Windows.Forms.Button();
            this.btnCTDDH = new System.Windows.Forms.Button();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.seSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtCT_MaPN = new System.Windows.Forms.TextBox();
            this.gcNhapLieu = new DevExpress.XtraEditors.GroupControl();
            this.bdsVattuChuaCoPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.tbaVattuChuaCoPhieuNhap = new QLVT.DSTableAdapters.sp_VTNotInCTPNTableAdapter();
            this.tbaTenVT = new QLVT.DSTableAdapters.TenVatTuTableAdapter();
            this.tbaTenKho = new QLVT.DSTableAdapters.TenKhoTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenVT)).BeginInit();
            this.gbPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).BeginInit();
            this.gbCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapLieu)).BeginInit();
            this.gcNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattuChuaCoPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPNLabel.Location = new System.Drawing.Point(82, 17);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(98, 17);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "Mã phiếu nhập:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(137, 63);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(43, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(95, 111);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(85, 17);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHOLabel.Location = new System.Drawing.Point(340, 30);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(59, 17);
            tENKHOLabel.TabIndex = 8;
            tENKHOLabel.Text = "Tên kho:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(328, 63);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(71, 17);
            hOTENLabel.TabIndex = 12;
            hOTENLabel.Text = "Nhân viên:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPNLabel1.Location = new System.Drawing.Point(36, 40);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(98, 17);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "Mã phiếu nhập:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGLabel.Location = new System.Drawing.Point(68, 144);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 17);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dONGIALabel.Location = new System.Drawing.Point(411, 144);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(58, 17);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENVTLabel.Location = new System.Drawing.Point(62, 94);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(72, 17);
            tENVTLabel.TabIndex = 17;
            tENVTLabel.Text = "Tên vật tư:";
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
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
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
            this.btnCheDo.Caption = "Chi tiết Phiếu nhập";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 678);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1388, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 646);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1388, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 646);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbMaCN);
            this.panel1.Controls.Add(this.lbCN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 66);
            this.panel1.TabIndex = 6;
            // 
            // cbbMaCN
            // 
            this.cbbMaCN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaCN.FormattingEnabled = true;
            this.cbbMaCN.Location = new System.Drawing.Point(613, 19);
            this.cbbMaCN.Name = "cbbMaCN";
            this.cbbMaCN.Size = new System.Drawing.Size(244, 27);
            this.cbbMaCN.TabIndex = 1;
            this.cbbMaCN.SelectedIndexChanged += new System.EventHandler(this.CbbMaCN_SelectedIndexChanged);
            // 
            // lbCN
            // 
            this.lbCN.AutoSize = true;
            this.lbCN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCN.Location = new System.Drawing.Point(531, 23);
            this.lbCN.Name = "lbCN";
            this.lbCN.Size = new System.Drawing.Size(76, 19);
            this.lbCN.TabIndex = 0;
            this.lbCN.Text = "Chi nhánh";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PhieuNhap";
            this.bdsPhieuNhap.DataSource = this.DS;
            // 
            // tbaPhieuNhap
            // 
            this.tbaPhieuNhap.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.tbaCTPN;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.tbaPhieuNhap;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.TenVatTuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // tbaCTPN
            // 
            this.tbaCTPN.ClearBeforeFill = true;
            // 
            // tbaTenNV
            // 
            this.tbaTenNV.ClearBeforeFill = true;
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.DataSource = this.bdsPhieuNhap;
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuNhap.Location = new System.Drawing.Point(0, 98);
            this.gcPhieuNhap.MainView = this.gridView1;
            this.gcPhieuNhap.MenuManager = this.barManager1;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(1388, 220);
            this.gcPhieuNhap.TabIndex = 13;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMAKHO,
            this.colMANV});
            this.gridView1.GridControl = this.gcPhieuNhap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView1_FocusedRowChanged_1);
            // 
            // colMAPN
            // 
            this.colMAPN.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAPN.AppearanceCell.Options.UseFont = true;
            this.colMAPN.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colMAPN.AppearanceHeader.Options.UseBackColor = true;
            this.colMAPN.Caption = "Mã phiếu nhập";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 140;
            // 
            // colNGAY
            // 
            this.colNGAY.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAY.AppearanceCell.Options.UseFont = true;
            this.colNGAY.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colNGAY.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAY.Caption = "Ngày nhập";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 123;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMasoDDH.AppearanceCell.Options.UseFont = true;
            this.colMasoDDH.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colMasoDDH.AppearanceHeader.Options.UseBackColor = true;
            this.colMasoDDH.Caption = "Mã số DDH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 133;
            // 
            // colMAKHO
            // 
            this.colMAKHO.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHO.AppearanceCell.Options.UseFont = true;
            this.colMAKHO.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.colMAKHO.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 3;
            this.colMAKHO.Width = 126;
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
            this.colMANV.VisibleIndex = 4;
            this.colMANV.Width = 127;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPhieuNhap;
            // 
            // bdsTenNV
            // 
            this.bdsTenNV.DataMember = "HoTen";
            this.bdsTenNV.DataSource = this.DS;
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AllowUserToAddRows = false;
            this.dgvCTPN.AllowUserToDeleteRows = false;
            this.dgvCTPN.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPN,
            this.cbbTenVT,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvCTPN.DataSource = this.bdsCTPN;
            this.dgvCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPN.Location = new System.Drawing.Point(793, 318);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.ReadOnly = true;
            this.dgvCTPN.Size = new System.Drawing.Size(595, 360);
            this.dgvCTPN.TabIndex = 14;
            this.dgvCTPN.SelectionChanged += new System.EventHandler(this.DgvCTPN_SelectionChanged);
            // 
            // MAPN
            // 
            this.MAPN.DataPropertyName = "MAPN";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAPN.DefaultCellStyle = dataGridViewCellStyle2;
            this.MAPN.HeaderText = "Mã phiếu nhập";
            this.MAPN.Name = "MAPN";
            this.MAPN.ReadOnly = true;
            this.MAPN.Width = 125;
            // 
            // cbbTenVT
            // 
            this.cbbTenVT.DataPropertyName = "MAVT";
            this.cbbTenVT.DataSource = this.bdsTenVT;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenVT.DefaultCellStyle = dataGridViewCellStyle3;
            this.cbbTenVT.DisplayMember = "TENVT";
            this.cbbTenVT.HeaderText = "Vật tư";
            this.cbbTenVT.Name = "cbbTenVT";
            this.cbbTenVT.ReadOnly = true;
            this.cbbTenVT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbbTenVT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbbTenVT.ValueMember = "MAVT";
            this.cbbTenVT.Width = 200;
            // 
            // bdsTenVT
            // 
            this.bdsTenVT.DataMember = "TenVatTu";
            this.bdsTenVT.DataSource = this.DS;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // gbPhieuNhap
            // 
            this.gbPhieuNhap.Controls.Add(this.cbbTenKho);
            this.gbPhieuNhap.Controls.Add(this.txtMaKho);
            this.gbPhieuNhap.Controls.Add(this.cbbTenNV);
            this.gbPhieuNhap.Controls.Add(this.btnHuyDDH);
            this.gbPhieuNhap.Controls.Add(this.btnDDH);
            this.gbPhieuNhap.Controls.Add(hOTENLabel);
            this.gbPhieuNhap.Controls.Add(this.txtMaNV);
            this.gbPhieuNhap.Controls.Add(tENKHOLabel);
            this.gbPhieuNhap.Controls.Add(masoDDHLabel);
            this.gbPhieuNhap.Controls.Add(this.txtMaDDH);
            this.gbPhieuNhap.Controls.Add(nGAYLabel);
            this.gbPhieuNhap.Controls.Add(this.dtpNgay);
            this.gbPhieuNhap.Controls.Add(mAPNLabel);
            this.gbPhieuNhap.Controls.Add(this.txtMaPN);
            this.gbPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPhieuNhap.Location = new System.Drawing.Point(2, 23);
            this.gbPhieuNhap.Name = "gbPhieuNhap";
            this.gbPhieuNhap.Size = new System.Drawing.Size(789, 159);
            this.gbPhieuNhap.TabIndex = 0;
            this.gbPhieuNhap.TabStop = false;
            this.gbPhieuNhap.Text = "Phiếu nhập";
            // 
            // cbbTenKho
            // 
            this.cbbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPhieuNhap, "MAKHO", true));
            this.cbbTenKho.DataSource = this.bdsTenKho;
            this.cbbTenKho.DisplayMember = "TENKHO";
            this.cbbTenKho.Enabled = false;
            this.cbbTenKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenKho.FormattingEnabled = true;
            this.cbbTenKho.Location = new System.Drawing.Point(405, 26);
            this.cbbTenKho.Name = "cbbTenKho";
            this.cbbTenKho.Size = new System.Drawing.Size(209, 25);
            this.cbbTenKho.TabIndex = 19;
            this.cbbTenKho.ValueMember = "MAKHO";
            this.cbbTenKho.SelectedIndexChanged += new System.EventHandler(this.CbbTenKho_SelectedIndexChanged_1);
            // 
            // bdsTenKho
            // 
            this.bdsTenKho.DataMember = "TenKho";
            this.bdsTenKho.DataSource = this.DS;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKho.Location = new System.Drawing.Point(634, 26);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(100, 25);
            this.txtMaKho.TabIndex = 18;
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPhieuNhap, "MANV", true));
            this.cbbTenNV.DataSource = this.bdsTenNV;
            this.cbbTenNV.DisplayMember = "HOTEN";
            this.cbbTenNV.Enabled = false;
            this.cbbTenNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(405, 59);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(209, 25);
            this.cbbTenNV.TabIndex = 17;
            this.cbbTenNV.ValueMember = "MANV";
            this.cbbTenNV.SelectedIndexChanged += new System.EventHandler(this.CbbTenNV_SelectedIndexChanged);
            // 
            // btnHuyDDH
            // 
            this.btnHuyDDH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDDH.Location = new System.Drawing.Point(521, 99);
            this.btnHuyDDH.Name = "btnHuyDDH";
            this.btnHuyDDH.Size = new System.Drawing.Size(150, 40);
            this.btnHuyDDH.TabIndex = 15;
            this.btnHuyDDH.Text = "Hủy";
            this.btnHuyDDH.UseVisualStyleBackColor = true;
            this.btnHuyDDH.Click += new System.EventHandler(this.BtnHuyDDH_Click_1);
            // 
            // btnDDH
            // 
            this.btnDDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDDH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDH.Location = new System.Drawing.Point(351, 99);
            this.btnDDH.Name = "btnDDH";
            this.btnDDH.Size = new System.Drawing.Size(150, 40);
            this.btnDDH.TabIndex = 14;
            this.btnDDH.Text = "Chọn Đơn đặt hàng";
            this.btnDDH.UseVisualStyleBackColor = false;
            this.btnDDH.Click += new System.EventHandler(this.BtnDDH_Click_1);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(634, 59);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 25);
            this.txtMaNV.TabIndex = 11;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MasoDDH", true));
            this.txtMaDDH.Enabled = false;
            this.txtMaDDH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDDH.Location = new System.Drawing.Point(186, 107);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(100, 25);
            this.txtMaDDH.TabIndex = 5;
            // 
            // dtpNgay
            // 
            this.dtpNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuNhap, "NGAY", true));
            this.dtpNgay.EditValue = null;
            this.dtpNgay.Location = new System.Drawing.Point(186, 59);
            this.dtpNgay.MenuManager = this.barManager1;
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Properties.Appearance.Options.UseFont = true;
            this.dtpNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Size = new System.Drawing.Size(100, 24);
            this.dtpNgay.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAPN", true));
            this.txtMaPN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(186, 13);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(100, 25);
            this.txtMaPN.TabIndex = 1;
            // 
            // gbCTPN
            // 
            this.gbCTPN.Controls.Add(this.btnHuyCTDDH);
            this.gbCTPN.Controls.Add(this.btnCTDDH);
            this.gbCTPN.Controls.Add(tENVTLabel);
            this.gbCTPN.Controls.Add(this.txtTenVT);
            this.gbCTPN.Controls.Add(dONGIALabel);
            this.gbCTPN.Controls.Add(this.txtDonGia);
            this.gbCTPN.Controls.Add(sOLUONGLabel);
            this.gbCTPN.Controls.Add(this.seSoLuong);
            this.gbCTPN.Controls.Add(this.txtMaVT);
            this.gbCTPN.Controls.Add(mAPNLabel1);
            this.gbCTPN.Controls.Add(this.txtCT_MaPN);
            this.gbCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTPN.Location = new System.Drawing.Point(2, 182);
            this.gbCTPN.Name = "gbCTPN";
            this.gbCTPN.Size = new System.Drawing.Size(789, 176);
            this.gbCTPN.TabIndex = 1;
            this.gbCTPN.TabStop = false;
            this.gbCTPN.Text = "Chi tiết phiếu nhập";
            // 
            // btnHuyCTDDH
            // 
            this.btnHuyCTDDH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCTDDH.Location = new System.Drawing.Point(501, 27);
            this.btnHuyCTDDH.Name = "btnHuyCTDDH";
            this.btnHuyCTDDH.Size = new System.Drawing.Size(150, 40);
            this.btnHuyCTDDH.TabIndex = 19;
            this.btnHuyCTDDH.Text = "Hủy";
            this.btnHuyCTDDH.UseVisualStyleBackColor = true;
            this.btnHuyCTDDH.Click += new System.EventHandler(this.BtnHuyCTDDH_Click);
            // 
            // btnCTDDH
            // 
            this.btnCTDDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCTDDH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTDDH.Location = new System.Drawing.Point(305, 27);
            this.btnCTDDH.Name = "btnCTDDH";
            this.btnCTDDH.Size = new System.Drawing.Size(180, 40);
            this.btnCTDDH.TabIndex = 18;
            this.btnCTDDH.Text = "Chọn CT Đơn đặt hàng";
            this.btnCTDDH.UseVisualStyleBackColor = false;
            this.btnCTDDH.Click += new System.EventHandler(this.BtnCTDDH_Click);
            // 
            // txtTenVT
            // 
            this.txtTenVT.Enabled = false;
            this.txtTenVT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVT.Location = new System.Drawing.Point(140, 90);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(325, 25);
            this.txtTenVT.TabIndex = 18;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "DONGIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(475, 140);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.DisplayFormat.FormatString = "n0";
            this.txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Properties.EditFormat.FormatString = "n0";
            this.txtDonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Size = new System.Drawing.Size(100, 24);
            this.txtDonGia.TabIndex = 7;
            // 
            // seSoLuong
            // 
            this.seSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "SOLUONG", true));
            this.seSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSoLuong.Location = new System.Drawing.Point(137, 140);
            this.seSoLuong.MenuManager = this.barManager1;
            this.seSoLuong.Name = "seSoLuong";
            this.seSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seSoLuong.Properties.Appearance.Options.UseFont = true;
            this.seSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoLuong.Size = new System.Drawing.Size(149, 24);
            this.seSoLuong.TabIndex = 5;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAVT", true));
            this.txtMaVT.Enabled = false;
            this.txtMaVT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Location = new System.Drawing.Point(475, 90);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(100, 25);
            this.txtMaVT.TabIndex = 3;
            // 
            // txtCT_MaPN
            // 
            this.txtCT_MaPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAPN", true));
            this.txtCT_MaPN.Enabled = false;
            this.txtCT_MaPN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCT_MaPN.Location = new System.Drawing.Point(140, 36);
            this.txtCT_MaPN.Name = "txtCT_MaPN";
            this.txtCT_MaPN.Size = new System.Drawing.Size(146, 25);
            this.txtCT_MaPN.TabIndex = 1;
            // 
            // gcNhapLieu
            // 
            this.gcNhapLieu.Controls.Add(this.gbCTPN);
            this.gcNhapLieu.Controls.Add(this.gbPhieuNhap);
            this.gcNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcNhapLieu.Location = new System.Drawing.Point(0, 318);
            this.gcNhapLieu.Name = "gcNhapLieu";
            this.gcNhapLieu.Size = new System.Drawing.Size(793, 360);
            this.gcNhapLieu.TabIndex = 14;
            this.gcNhapLieu.Text = "Nhập liệu";
            // 
            // bdsVattuChuaCoPhieuNhap
            // 
            this.bdsVattuChuaCoPhieuNhap.DataMember = "sp_VTNotInCTPN";
            this.bdsVattuChuaCoPhieuNhap.DataSource = this.DS;
            // 
            // tbaVattuChuaCoPhieuNhap
            // 
            this.tbaVattuChuaCoPhieuNhap.ClearBeforeFill = true;
            // 
            // tbaTenVT
            // 
            this.tbaTenVT.ClearBeforeFill = true;
            // 
            // tbaTenKho
            // 
            this.tbaTenKho.ClearBeforeFill = true;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 698);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.gcNhapLieu);
            this.Controls.Add(this.gcPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormPhieuNhap";
            this.Text = "FormPhieuNhap";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenVT)).EndInit();
            this.gbPhieuNhap.ResumeLayout(false);
            this.gbPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTenKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).EndInit();
            this.gbCTPN.ResumeLayout(false);
            this.gbCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapLieu)).EndInit();
            this.gcNhapLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsVattuChuaCoPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbMaCN;
        private System.Windows.Forms.Label lbCN;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DS DS;
        private DSTableAdapters.PhieuNhapTableAdapter tbaPhieuNhap;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.CTPNTableAdapter tbaCTPN;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.HoTenTableAdapter tbaTenNV;
        private System.Windows.Forms.BindingSource bdsTenNV;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private DevExpress.XtraEditors.GroupControl gcNhapLieu;
        private System.Windows.Forms.GroupBox gbCTPN;
        public System.Windows.Forms.TextBox txtTenVT;
        public DevExpress.XtraEditors.TextEdit txtDonGia;
        public DevExpress.XtraEditors.SpinEdit seSoLuong;
        public System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.TextBox txtCT_MaPN;
        private System.Windows.Forms.GroupBox gbPhieuNhap;
        public System.Windows.Forms.Button btnHuyDDH;
        private System.Windows.Forms.Button btnDDH;
        private System.Windows.Forms.TextBox txtMaNV;
        public System.Windows.Forms.TextBox txtMaDDH;
        private DevExpress.XtraEditors.DateEdit dtpNgay;
        private System.Windows.Forms.TextBox txtMaPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.BindingSource bdsVattuChuaCoPhieuNhap;
        private DSTableAdapters.sp_VTNotInCTPNTableAdapter tbaVattuChuaCoPhieuNhap;
        public System.Windows.Forms.Button btnHuyCTDDH;
        private System.Windows.Forms.Button btnCTDDH;
        private System.Windows.Forms.BindingSource bdsTenVT;
        private DSTableAdapters.TenVatTuTableAdapter tbaTenVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbTenVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.BindingSource bdsTenKho;
        private DSTableAdapters.TenKhoTableAdapter tbaTenKho;
        public System.Windows.Forms.ComboBox cbbTenKho;
    }
}