using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.Reports
{
    public partial class BaoCaoDanhSachDonDatHangChuaCoPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoDanhSachDonDatHangChuaCoPhieuNhap()
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connectString;
            sqlDataSource1.Fill();
        }

    }
}
