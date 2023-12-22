using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QLVT.Reports
{
    public partial class BaoCaoHoatDongCuaNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoHoatDongCuaNhanVien()
        {
            
        }
        public BaoCaoHoatDongCuaNhanVien(int maNV, DateTime dateFrom, DateTime dateEnd)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connectString;
            sqlDataSource1.Queries[0].Parameters[0].Value = maNV;
            sqlDataSource1.Queries[0].Parameters[1].Value = dateFrom;
            sqlDataSource1.Queries[0].Parameters[2].Value = dateEnd;
            sqlDataSource1.Fill();
        }

    }
}
