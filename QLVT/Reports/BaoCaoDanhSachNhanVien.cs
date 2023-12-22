namespace QLVT.Reports
{
    public partial class BaoCaoDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoDanhSachNhanVien()
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connectString;
            sqlDataSource1.Fill();
        }

    }
}
