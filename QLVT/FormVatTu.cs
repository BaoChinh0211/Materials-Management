using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormVatTu : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        Stack undoList = new Stack();
        string flag = "";
        public FormVatTu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // Tắt kiểm tra khóa ngoại
            DS.EnforceConstraints = false;
            tbaVatTu.Connection.ConnectionString = Program.connectString;
            tbaVatTu.Fill(DS.Vattu);

            tbaCT_DHH.Connection.ConnectionString = Program.connectString;
            tbaCT_DHH.Fill(DS.CTDDH);

            tbaCT_PN.Connection.ConnectionString = Program.connectString;
            tbaCT_PN.Fill(DS.CTPN);

            tbaCT_PX.Connection.ConnectionString = Program.connectString;
            tbaCT_PX.Fill(DS.CTPX);

            if (Program.mRole == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                btnInDSVT.Enabled = true;
            }
            // Nếu số lượng vật tư là 0 thì nút xóa sẽ ẩn đi
            if (bdsVatTu.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            gcNhapLieu.Enabled = false;
            gcVatTu.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Khởi tạo các biến cờ và vị trí con trỏ trước khi thêm
            flag = "them";
            viTri = bdsVatTu.Position;
            // Bật tắt
            gcVatTu.Enabled = false;
            gcNhapLieu.Enabled = btnGhi.Enabled = btnUndo.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnInDSVT.Enabled = false;
            // Phương thức thêm một vật tư
            bdsVatTu.AddNew();
            txtMaVT.Enabled = true;
            txtSLT.EditValue = 0;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCT_DHH.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đang tồn tại trong đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (bdsCT_PN.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đang tồn tại trong phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (bdsCT_PX.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đang tồn tại trong phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (Convert.ToInt32(txtSLT.EditValue) > 0)
            {
                MessageBox.Show("Không thể xóa vật tư còn số lượng tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cauTruyVankiemTra = "DECLARE @result int " + "EXEC @result = [dbo].[sp_kiemTraVatTuTonTaiKhiXoa] '" + txtMaVT.Text.Trim() + "' " + "SELECT 'Value' = @result";
            try
            {
                Program.sqlDataReader = Program.ExecSqlDataReader(cauTruyVankiemTra);
                /* không có kết quả trả về thì kết thúc*/
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
                MessageBox.Show("Không thể xóa vật tư này vì đang tồn tại trên các phiếu thuộc chi nhánh khác", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                string cauQueryHoanTac = string.Format("INSERT INTO dbo.Vattu(MAVT, TENVT, DVT, SOLUONGTON) " +
             "VALUES(N'{0}', N'{1}', N'{2}', {3})",
                txtMaVT.Text, txtTenVT.Text, txtDVT.Text, Convert.ToInt32(txtSLT.EditValue));

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư này không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    viTri = bdsVatTu.Position;
                    try
                    {
                        bdsVatTu.RemoveCurrent();
                        tbaVatTu.Connection.ConnectionString = Program.connectString;
                        tbaVatTu.Update(DS.Vattu);
                        tbaVatTu.Fill(DS.Vattu);

                        MessageBox.Show("Xóa vật tư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnUndo.Enabled = true;
                        //Lưu câu truy vấn hoàn tác vào stack;
                        undoList.Push(cauQueryHoanTac);
                        if (bdsVatTu.Count == 0)
                            btnXoa.Enabled = btnSua.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa vật tư: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbaVatTu.Fill(DS.Vattu);
                        bdsVatTu.Position = viTri;
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = "sua";
            gcNhapLieu.Enabled = true;
            gcVatTu.Enabled = txtMaVT.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;

            string maVT = txtMaVT.Text.Trim();
            string tenVT = txtTenVT.Text.Trim();
            int SLT = Convert.ToInt32(txtSLT.EditValue);
            string DVT = txtDVT.Text.Trim();

            string cauTruyvanHoanTac = "UPDATE DBO.Vattu " +
                        "SET " +
                        "MAVT = N'" + maVT + "'," +
                        "TENVT = N'" + tenVT + "'," +
                        "DVT = N'" + DVT + "'," +
                        "SOLUONGTON = " + SLT +
                        "WHERE MAVT = '" + maVT + "'";
            undoList.Push(cauTruyvanHoanTac);
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
                    string cauTruyVanKiemTra = "DECLARE @RESULT int " + "EXEC @RESULT = [dbo].[sp_kiemTraMaVatTuThemMoi] '" + txtMaVT.Text.Trim() + "' " + "SELECT 'Value' = @RESULT";
                    try
                    {
                        Program.sqlDataReader = Program.ExecSqlDataReader(cauTruyVanKiemTra);
                        /* không có kết quả trả về thì kết thúc*/
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
                        MessageBox.Show("Mã vật tư đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn muốn thêm vật tư mới vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnUndo.Enabled = btnThoat.Enabled = true;
                                gcVatTu.Enabled = true;
                                gcNhapLieu.Enabled = btnGhi.Enabled = false;
                                // Lưu câu lệnh hoàn tác cho nút Undo
                                string queryUndo = "" + "DELETE DBO.Vattu " + "WHERE MAVT = '" + txtMaVT.Text.Trim() + "'";
                                undoList.Push(queryUndo);
                                // Thêm dữ liệu
                                bdsVatTu.EndEdit();
                                tbaVatTu.Update(DS.Vattu);
                                // Làm mới
                                tbaVatTu.Fill(DS.Vattu);
                                gcVatTu.Refresh();
                                /*cập nhật lại trạng thái cờ*/
                                flag = "";
                                MessageBox.Show("Thêm vật tư mới thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {
                                bdsVatTu.RemoveCurrent();
                                MessageBox.Show("Thêm vật tư mới thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            gcVatTu.Enabled = true;
                            gcNhapLieu.Enabled = btnGhi.Enabled = false;
                            // Thêm dữ liệu
                            bdsVatTu.EndEdit();
                            tbaVatTu.Update(DS.Vattu);
                            // Làm mới
                            tbaVatTu.Fill(DS.Vattu);
                            gcVatTu.Refresh();
                            /*cập nhật lại trạng thái cờ*/
                            flag = "";
                            MessageBox.Show("Cập nhật thông tin vật tư thành công", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                        catch (Exception ex)
                        {
                            bdsVatTu.RemoveCurrent();
                            MessageBox.Show("Cập nhật thông tin vật tư thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show("Bạn muốn hủy thêm mới vật tư?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    flag = "";
                    bdsVatTu.CancelEdit();
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                    gcVatTu.Enabled = true;
                    btnGhi.Enabled = gcNhapLieu.Enabled = false;
                    /* trở về lúc đầu con trỏ đang đứng*/
                    bdsVatTu.Position = viTri;
                }
                else
                {
                    return;
                }
            }
            if (flag.Equals("sua") && btnSua.Enabled == false)
            {
                if (MessageBox.Show("Bạn muốn hủy cập nhật vật tư?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bdsVatTu.CancelEdit();
                    flag = "";
                    btnGhi.Enabled = gcNhapLieu.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                    gcVatTu.Enabled = true;
                    undoList.Pop();
                }
                else
                {
                    return;
                }
            }
            if (undoList.Count > 0)
            {
                String cauTruyVanHoanTac = undoList.Pop().ToString();
                if (Program.Connecting() == 0)
                {
                    MessageBox.Show("Lỗi kết nối", "Hoàn tác thất bại", MessageBoxButtons.OK);
                    return;
                }
                Program.ExecSqlNonQuery(cauTruyVanHoanTac);
                tbaVatTu.Fill(DS.Vattu);
                gcVatTu.Refresh();
            }
            if (undoList.Count == 0)
            {
                //MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                return;
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // Đổ dữ liệu mới vào lại DataSet
                tbaVatTu.Fill(DS.Vattu);
                gcVatTu.Refresh();
                gcVatTu.Enabled = true;
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
                    bdsVatTu.CancelEdit();
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
            if (txtMaVT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaVT.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtMaVT.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mã vật tư chỉ chấp nhận giá trị là số, chữ cái và không có giá trị trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaVT.Focus();
                return false;
            }
            else if (txtMaVT.Text.Length != 4)
            {
                MessageBox.Show("Mã vật tư bao gồm 4 kí tự bao gồm số và chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaVT.Focus();
                return false;
            }
            else if (txtTenVT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenVT.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtTenVT.Text, @"^[A-Za-z0-9,/\.À-Ỹà-ỹ]+$") == false)
            {
                MessageBox.Show("Tên vật tư chỉ bao gồm chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenVT.Focus();
                return false;
            }
            else if (txtTenVT.Text.Length > 30)
            {
                MessageBox.Show("Tên của vật tư không được quá 30 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenVT.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtSLT.EditValue) < 0)
            {
                MessageBox.Show("Số lượng tồn phải từ 0 trở lên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSLT.Focus();
                return false;
            }
            else if (txtSLT.EditValue.Equals(""))
            {
                MessageBox.Show("Số lượng tồn không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSLT.Focus();
                return false;
            }
            else if (txtDVT.Text.Equals(""))
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVT.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtTenVT.Text, @"^[A-Za-z,/\.À-Ỹà-ỹ]+$") == false)
            {
                MessageBox.Show("Đơn vị tính chỉ bao gồm chữ và không có số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVT.Focus();
                return false;
            }
            else if (txtDVT.Text.Length > 15)
            {
                MessageBox.Show("Đơn vị tính không được quá 15 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVT.Focus();
                return false;
            }
            return true;
        }
    }
}