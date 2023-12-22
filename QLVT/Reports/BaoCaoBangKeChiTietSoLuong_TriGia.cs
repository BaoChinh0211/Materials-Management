using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.Reports
{
    public partial class BaoCaoBangKeChiTietSoLuong_TriGia : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoBangKeChiTietSoLuong_TriGia()
        {

        }
        public BaoCaoBangKeChiTietSoLuong_TriGia(string role, string loai, DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connectString;
            sqlDataSource1.Queries[0].Parameters[0].Value = role;
            sqlDataSource1.Queries[0].Parameters[1].Value = loai;
            sqlDataSource1.Queries[0].Parameters[2].Value = dateFrom;
            sqlDataSource1.Queries[0].Parameters[3].Value = dateTo;
            sqlDataSource1.Fill();

        }

    }
}
