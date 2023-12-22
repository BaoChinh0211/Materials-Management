using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        string maCN = "";
        Stack undoList = new Stack();
        string flag = "";
        public FormKho()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            tbaKho.Connection.ConnectionString = Program.connectString;
            tbaKho.Fill(DS.Kho);

            tbaDH.Connection.ConnectionString = Program.connectString;
            tbaDH.Fill(DS.DatHang);

            tbaPN.Connection.ConnectionString = Program.connectString;
            tbaPN.Fill(DS.PhieuNhap);

            tbaPX.Connection.ConnectionString = Program.connectString;
            tbaPX.Fill(DS.PhieuXuat);

            if (bdsKho.Count > 0)
                maCN = ((DataRowView)bdsKho[0])["MACN"].ToString();

            cbbMaCN.DataSource = Program.bindingSource_listBranch;
            cbbMaCN.DisplayMember = "TENCN";
            cbbMaCN.ValueMember = "TENSERVER";
            cbbMaCN.SelectedIndex = Program.mBranch;
            gcNhapLieu.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;


            // Phân quyền
            if (Program.mRole == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = false;
                btnThoat.Enabled = cbbMaCN.Enabled = true;
            }
            else
            {
                cbbMaCN.Enabled = false;
            }

            // Nếu số lượng kho là 0 thì nút xóa sẽ ẩn đi
            if (bdsKho.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void cbbMaCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cbbMaCN.SelectedValue.ToString();

            /*Nếu chọn chi nhánh khác với chi nhánh hiện tại*/
            if (cbbMaCN.SelectedIndex != Program.mBranch)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            /*Nếu chi nhánh được chọn là chi nhánh được chọn lúc đăng nhập*/
            else
            {
                Program.mLogin = Program.currentLogin;
                Program.password = Program.currentPassword;
            }

            if (Program.Connecting() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                /*Đổ dữ liệu từ dataset vào girdControl*/
                tbaKho.Connection.ConnectionString = Program.connectString;
                tbaKho.Fill(DS.Kho);

                tbaDH.Connection.ConnectionString = Program.connectString;
                tbaDH.Fill(DS.DatHang);

                tbaPN.Connection.ConnectionString = Program.connectString;
                tbaPN.Fill(DS.PhieuNhap);

                tbaPX.Connection.ConnectionString = Program.connectString;
                tbaPX.Fill(DS.PhieuXuat);
                return;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Khởi tạo các biến cờ và vị trí con trỏ trước khi thêm
            flag = "them";
            viTri = bdsKho.Position;
            // Bật tắt
            gcKho.Enabled = false;
            txtMaKho.Enabled = gcNhapLieu.Enabled = true;
            txtMaCN.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            // Thêm dữ liệu
            bdsKho.AddNew();
            txtMaCN.Text = maCN;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy số lượng của kho đang xóa trong PhieuNhap
            string maKho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
            string queryCountPhieuNhap = string.Format("SELECT COUNT(*) FROM dbo.PhieuNhap WHERE MAKHO = '{0}'", maKho);
            int countPhieuNhap = Program.ExecuteScalar(queryCountPhieuNhap);
            // Không xóa kho đã có giá trị được lập trong ĐĐH, PX, PN
            if (bdsDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho này vì đang tồn tại đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (countPhieuNhap > 0)
            {
                MessageBox.Show("Không thể xóa kho này vì đang tồn tại phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (bdsPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho này vì đang tồn tại phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            /* Nếu OK thì tiến hành xóa kho */

            // Tạo câu lệnh truy vấn chèn dữ liệu kho bị xóa để phục vụ cho nút Hoàn tác


            string cauQueryHoanTac = string.Format("INSERT INTO dbo.Kho(MAKHO, TENKHO, DIACHI, MACN) " +
             "VALUES(N'{0}', N'{1}', N'{2}', N'{3}')",
                txtMaKho.Text, txtTenKho.Text, txtDiaChi.Text, txtMaCN.Text);
            viTri = bdsKho.Position;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa kho này không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsKho.RemoveCurrent();
                    tbaKho.Connection.ConnectionString = Program.connectString;
                    tbaKho.Update(DS.Kho);
                    tbaKho.Fill(DS.Kho);

                    MessageBox.Show("Xóa kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnUndo.Enabled = true;
                    //Lưu câu truy vấn hoàn tác vào stack;
                    undoList.Push(cauQueryHoanTac);

                    if (bdsKho.Count == 0)
                        btnXoa.Enabled = btnSua.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbaKho.Fill(DS.Kho);
                    bdsKho.Position = viTri;
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Bật tắt các công cụ
            flag = "sua";
            viTri = bdsKho.Position;
            gcNhapLieu.Enabled = true;
            gcKho.Enabled = txtMaCN.Enabled = txtMaKho.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = btnThoat.Enabled = true;
            // Lấy dữ liệu trước khi cập nhật để lưu vào câu truy vấn hoàn tác
            string maKho = txtMaKho.Text.Trim();
            string tenKho = txtTenKho.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            string cauTruyVanHoanTac = "UPDATE DBO.Kho " +
                        "SET " +
                        "TENKHO = N'" + tenKho + "'," +
                        "DIACHI = N'" + diaChi + "' " +
                        "WHERE MAKHO = '" + maKho + "'";
            undoList.Push(cauTruyVanHoanTac);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool checkResult = checkInputValidate();
            if (checkResult == false)
            {
                return;
            }
            else
            {
                if (flag.Equals("them"))
                {
                    string CauTruyVanKiemTraMaKho = "DECLARE @RESULT int " + "EXEC @RESULT = [dbo].[sp_kiemTraMaKhoThemMoi] '" + txtMaKho.Text.Trim() + "' " + "SELECT 'Value' = @RESULT"; ;
                    try
                    {
                        Program.sqlDataReader = Program.ExecSqlDataReader(CauTruyVanKiemTraMaKho);
                        /*khong co ket qua tra ve thi ket thuc luon*/
                        if (Program.sqlDataReader == null)
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Program.sqlDataReader.Read();
                    int result = int.Parse(Program.sqlDataReader.GetValue(0).ToString());
                    Program.sqlDataReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Mã kho đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn muốn thêm kho mới vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnUndo.Enabled = true;
                                gcKho.Enabled = true;
                                gcNhapLieu.Enabled = btnGhi.Enabled = false;
                                // Lưu câu lệnh hoàn tác cho nút Undo
                                string queryUndo = "" + "DELETE DBO.Kho " + "WHERE MAKHO = '" + txtMaKho.Text.Trim() + "'";
                                undoList.Push(queryUndo);
                                // Thêm dữ liệu
                                bdsKho.EndEdit();
                                tbaKho.Update(DS.Kho);
                                // Làm mới
                                tbaKho.Fill(DS.Kho);
                                gcKho.Refresh();
                                /*cập nhật lại trạng thái cờ*/
                                flag = "";
                                MessageBox.Show("Thêm kho thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {
                                bdsKho.RemoveCurrent();
                                MessageBox.Show("Thêm kho thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (flag.Equals("sua"))
                {
                    if (MessageBox.Show("Bạn muốn cập nhật thông tin mới vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            // Bật tắt các nút
                            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnUndo.Enabled = btnThoat.Enabled = true;
                            gcKho.Enabled = true;
                            gcNhapLieu.Enabled = btnGhi.Enabled = false;
                            // Thêm dữ liệu
                            bdsKho.EndEdit();
                            tbaKho.Update(DS.Kho);
                            // Làm mới
                            tbaKho.Fill(DS.Kho);
                            gcKho.Refresh();
                            gcKho.Enabled = true;
                            bdsKho.Position = viTri;
                            /*cập nhật lại trạng thái cờ*/
                            flag = "";
                            MessageBox.Show("Cập nhật thông tin kho thành công", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                        catch (Exception ex)
                        {
                            bdsKho.EndEdit();
                            MessageBox.Show("Cập nhật thông tin kho thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }

                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag.Equals("them") && btnThem.Enabled == false)
            {
                if (MessageBox.Show("Bạn muốn hủy thêm mới kho?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                    gcKho.Enabled = true;
                    btnGhi.Enabled = gcNhapLieu.Enabled = false;
                    // Xóa dòng hiện tại
                    //bdsKho.RemoveCurrent();
                    bdsKho.CancelEdit();
                    /* trở về lúc đầu con trỏ đang đứng*/
                    bdsKho.Position = viTri;
                }
                else
                {
                    return;
                }
            }
            if (flag.Equals("sua") && btnSua.Enabled == false)
            {
                if (MessageBox.Show("Bạn muốn hủy cập nhật kho?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bdsKho.CancelEdit();
                    flag = "";
                    txtMaKho.Enabled = btnGhi.Enabled = gcNhapLieu.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                    gcKho.Enabled = true;
                    undoList.Pop();
                }
                else
                {
                    return;
                }
            }
            if (undoList.Count > 0)
            {
                string cauTruyVanHoanTac = undoList.Pop().ToString();
                if (Program.Connecting() == 0)
                {
                    MessageBox.Show("Lỗi kết nối", "Hoàn tác thất bại", MessageBoxButtons.OK);
                    return;
                }
                Program.ExecSqlNonQuery(cauTruyVanHoanTac);
                tbaKho.Fill(DS.Kho);
                gcKho.Refresh();
            }
            if (undoList.Count == 0)
            {
                // MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
            }
            return;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // Đổ dữ liệu mới vào lại DataSet
                tbaKho.Fill(DS.Kho);
                gcKho.Refresh();
                gcKho.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!flag.Equals(""))
            {
                if (MessageBox.Show("Bạn muốn thoát mà chưa lưu dữ liệu?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bdsKho.CancelEdit();
                    undoList.Clear();
                    Close();
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                Close();
            }
        }

        private bool checkInputValidate()
        {
            if (txtMaKho.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã kho không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKho.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtMaKho.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mã kho chỉ chấp nhận giá trị là số, chữ cái và không có giá trị trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKho.Focus();
                return false;
            }
            else if (txtMaKho.Text.Length != 4)
            {
                MessageBox.Show("Mã kho phải bao gồm 4 kí tự bao gồm số và chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKho.Focus();
                return false;
            }
            else if (txtTenKho.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên của kho không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKho.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtTenKho.Text, @"^[A-Za-zÀ-Ỹà-ỹ ]+$") == false)
            {
                MessageBox.Show("Tên của kho chỉ bao gồm chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKho.Focus();
                return false;
            }
            else if (txtTenKho.Text.Length > 30)
            {
                MessageBox.Show("Tên của kho không được quá 30 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKho.Focus();
                return false;
            }
            else if (txtDiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Địa chỉ kho không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtDiaChi.Text, @"^[A-Za-z0-9,/\.À-Ỹà-ỹ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và không chứa ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            else if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ kho không được quá 100 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
    }
}