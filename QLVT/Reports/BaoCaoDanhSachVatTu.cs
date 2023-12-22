namespace QLVT
{
    public partial class BaoCaoDanhSachVatTu : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoDanhSachVatTu()
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connectString;
            sqlDataSource1.Fill();
        }

    }
}
