using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormChonChiNhanhChuyenNhanVien : DevExpress.XtraEditors.XtraForm
    {
        FormNhanVien formNhanVien = Application.OpenForms.OfType<FormNhanVien>().FirstOrDefault();
        public FormChonChiNhanhChuyenNhanVien()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormChonChiNhanhChuyenNhanVien_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            tbaViewNhanVien.Connection.ConnectionString = Program.connectString;
            tbaViewNhanVien.Fill(DS.view_danhSachNhanVienChuaBiChuyen);

            cbbMaChiNhanh.DataSource = Program.bindingSource_listBranch.DataSource;
            cbbMaChiNhanh.DisplayMember = "TENCN";
            cbbMaChiNhanh.ValueMember = "TENSERVER";
            cbbMaChiNhanh.SelectedIndex = Program.mBranch;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cbbMaChiNhanh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh để điều chuyển nhân viên này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else if (cbbMaChiNhanh.SelectedIndex == Program.mBranch)
            {
                MessageBox.Show("Nhân viên bạn muốn chuyển đang làm việc trên chi nhánh bạn chọn, vui lòng chọn chi nhánh khác để điều chuyển nhân viên này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn điều chuyển nhân viên này sang chi nhánh mới?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string chiNhanhMoi = cbbMaChiNhanh.SelectedValue.ToString();
                    string chiNhanhHienTai = "";
                    string ChiNhanhMoi = "";
                    string maNhanVien = ((DataRowView)bdsViewNhanVien[bdsViewNhanVien.Position])["MANV"].ToString();
                    if (cbbMaChiNhanh.SelectedValue.ToString().Contains("1"))
                    {
                        chiNhanhHienTai = "CN2";
                        ChiNhanhMoi = "CN1";
                    }
                    else if (cbbMaChiNhanh.SelectedValue.ToString().Contains("2"))
                    {
                        chiNhanhHienTai = "CN1";
                        ChiNhanhMoi = "CN2";
                    }
                    try
                    {
                        Program.serverNameLeft = cbbMaChiNhanh.SelectedValue.ToString();
                        string cauTruyVan = "EXEC sp_ChuyenChiNhanh " + maNhanVien + ",'" + ChiNhanhMoi + "'";
                        Program.ExecSqlNonQuery(cauTruyVan);
                        Console.WriteLine(cauTruyVan);
                        MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK);
                        string cauTruyVanHoanTac = "EXEC sp_hoanTacChuyenChiNhanh " + maNhanVien;
                        Console.WriteLine(cauTruyVanHoanTac);
                        /*String cauTruyVanHoanTac = "EXEC sp_ChuyenChiNhanh " + maNhanVien + ",'" + chiNhanhHienTai + "'";
                        undoList.Push(cauTruyVanHoanTac);*/
                        /*Program.serverNameLeft = chiNhanhMoi;*/
                        formNhanVien.undoList.Push(cauTruyVanHoanTac);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    formNhanVien.tbaNhanVien.Update(formNhanVien.DS.NhanVien);
                    formNhanVien.tbaNhanVien.Fill(formNhanVien.DS.NhanVien);
                    formNhanVien.gcNhanVien.Refresh();
                    formNhanVien.btnUndo.Enabled = true;
                    Close();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}