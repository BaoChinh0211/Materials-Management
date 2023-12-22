using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.Reports
{
    public partial class BaoCaoTongHopHoatDongNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoTongHopHoatDongNhapXuat()
        {
            
        }
        public BaoCaoTongHopHoatDongNhapXuat(DateTime dateFrom, DateTime dateEnd)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connectString;
            sqlDataSource1.Queries[0].Parameters[0].Value = dateFrom;
            sqlDataSource1.Queries[0].Parameters[1].Value = dateEnd;
            sqlDataSource1.Fill();
        }

    }
}
