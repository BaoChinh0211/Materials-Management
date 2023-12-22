using DevExpress.XtraBars.Docking2010.DragEngine;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        string maCN = "";
        public Stack undoList = new Stack();
        string flag = "";

        public FormNhanVien()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void EmpoyeeForm_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            tbaNhanVien.Connection.ConnectionString = Program.connectString;
            tbaNhanVien.Fill(DS.NhanVien);

            tbaDatHang.Connection.ConnectionString = Program.connectString;
            tbaDatHang.Fill(DS.DatHang);

            tbaPhieuNhap.Connection.ConnectionString = Program.connectString;
            tbaPhieuNhap.Fill(DS.PhieuNhap);

            tbaPhieuXuat.Connection.ConnectionString = Program.connectString;
            tbaPhieuXuat.Fill(DS.PhieuXuat);

            if (bdsNhanVien.Count > 0)
                maCN = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();

            cbbMaCN.DataSource = Program.bindingSource_listBranch;
            cbbMaCN.DisplayMember = "TENCN";
            cbbMaCN.ValueMember = "TENSERVER";
            cbbMaCN.SelectedIndex = Program.mBranch;
            gcNhapLieu.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;

            // Phân quyền
            if (Program.mRole == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnCNN.Enabled = false;
                cbbMaCN.Enabled = true;
            }
            else
            {
                cbbMaCN.Enabled = false;
            }

            // Nếu số lượng nhân viên là 0 thì nút xóa sẽ ẩn đi
            if (bdsNhanVien.Count == 0)
            {
                btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void CbbMaCN_SelectedIndexChanged(object sender, EventArgs e)
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
            else /*Nếu chi nhánh được chọn là chi nhánh được chọn lúc đăng nhập*/
            {
                Program.mLogin = Program.currentLogin;
                Program.password = Program.currentPassword;
            }

            if (Program.Connecting() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                /*Đổ dữ liệu từ dataset vào girdControl*/
                tbaNhanVien.Connection.ConnectionString = Program.connectString;
                tbaNhanVien.Fill(DS.NhanVien);

                tbaDatHang.Connection.ConnectionString = Program.connectString;
                tbaDatHang.Fill(DS.DatHang);

                tbaPhieuNhap.Connection.ConnectionString = Program.connectString;
                tbaPhieuNhap.Fill(DS.PhieuNhap);

                tbaPhieuXuat.Connection.ConnectionString = Program.connectString;
                tbaPhieuXuat.Fill(DS.PhieuXuat);
            }
        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Khởi tạo các biến cờ và vị trí con trỏ trước khi thêm
            flag = "them";
            viTri = bdsNhanVien.Position;
            // Bật tắt
            txtMaNV.Enabled = gcNhapLieu.Enabled = true;
            gcNhanVien.Enabled = false;
            txtMaCN.Enabled = cbTTX.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            // Thêm mới
            bdsNhanVien.AddNew();
            txtMaCN.Text = maCN;
            txtLuong.Text = "4000000";
            dtpNgaySinh.Text = "01-01-1970";
            cbTTX.Checked = false;
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy số lượng của MaNV đang xóa trong PhieuNhap
            string maNV = ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString();
            string queryCountPhieuNhap = string.Format("SELECT COUNT(*) FROM dbo.PhieuNhap WHERE MANV = '{0}'", maNV);
            int countPhieuNhap = Program.ExecuteScalar(queryCountPhieuNhap);


            // Không xóa nhân viên có tài khoản đang được đăng nhập
            if (maNV == Program.userName)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            // Không xóa nhân viên đã lập ĐĐH, PX, PN
            if (bdsDatHang.Count > 0)
            {

                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (countPhieuNhap > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (bdsPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            /* Nếu OK thì tiến hành xóa nhân viên */

            // Tạo câu lệnh truy vấn chèn dữ liệu nhân viên bị xóa để phục vụ cho nút Hoàn tác
            string cauQueryHoanTac = string.Format("INSERT INTO dbo.NhanVien(MANV, HO, TEN, SOCMND, DIACHI, NGAYSINH, LUONG, MACN) " +
             "VALUES({0}, N'{1}', N'{2}', N'{3}', N'{4}', CONVERT(DATETIME,'{5}', 103), {6}, N'{7}')",
                txtMaNV.Text, txtHo.Text, txtTen.Text, txtCMND.Text, txtDiaChi.Text, dtpNgaySinh.Text, txtLuong.EditValue, txtMaCN.Text.Trim());
            viTri = bdsNhanVien.Position;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsNhanVien.RemoveCurrent();
                    tbaNhanVien.Connection.ConnectionString = Program.connectString;
                    tbaNhanVien.Update(DS.NhanVien);
                    tbaNhanVien.Fill(DS.NhanVien);
                    btnUndo.Enabled = true;
                    //Lưu câu truy vấn hoàn tác vào stack;
                    undoList.Push(cauQueryHoanTac);
                    if (bdsNhanVien.Count == 0)
                        btnXoa.Enabled = btnSua.Enabled = false;
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbaNhanVien.Fill(DS.NhanVien);
                    bdsNhanVien.Position = viTri;
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag = "sua";
            viTri = bdsNhanVien.Position;
            gcNhapLieu.Enabled = true;
            gcNhanVien.Enabled = cbTTX.Enabled = txtMaCN.Enabled = txtMaNV.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCNN.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;


            string maNV = txtMaNV.Text.Trim();
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();
            string CMND = txtCMND.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            DateTime ngaySinh = (DateTime)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["NGAYSINH"];
            float LUONG = float.Parse(((DataRowView)bdsNhanVien[bdsNhanVien.Position])["LUONG"].ToString());
            string luong = LUONG.ToString();
            int trangThaiXoa = (cbTTX.Checked == true) ? 1 : 0;

            string queryUndo = "UPDATE DBO.NhanVien " +
                        "SET " +
                        "HO = N'" + ho + "'," +
                        "TEN = N'" + ten + "'," +
                        "SOCMND = N'" + CMND + "'," +
                        "DIACHI = N'" + diaChi + "'," +
                        "NGAYSINH = CAST('" + ngaySinh.ToString("yyyy-MM-dd") + "' AS DATETIME)," +
                        "LUONG = '" + luong + "'," +
                        "TrangThaiXoa = " + trangThaiXoa + " " +
                        "WHERE MANV = '" + maNV + "'";
            undoList.Push(queryUndo);
        }

        private void BtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra dữ liệu truyền vào
            bool checkResult = CheckInputValidate();
            if (checkResult == false)
            {
                return;
            }
            else
            {
                if (flag.Equals("them"))
                {
                    string CauTruyVanKiemTraMaNhanVien = "DECLARE @RESULT int " + "EXEC @RESULT = [dbo].[sp_kiemTraMaNhanVienThemMoi] '" + txtMaNV.Text.Trim() + "' " + "SELECT 'Value' = @RESULT";
                    try
                    {
                        Program.sqlDataReader = Program.ExecSqlDataReader(CauTruyVanKiemTraMaNhanVien);
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
                        MessageBox.Show("Mã nhân viên đã tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn muốn thêm nhân viên mới vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnUndo.Enabled = true;
                                gcNhanVien.Enabled = true;
                                gcNhapLieu.Enabled = btnGhi.Enabled = false;
                                // Lưu câu lệnh hoàn tác cho nút Undo
                                string cauTruyVanHoanTac = "" + "DELETE DBO.NhanVien " + "WHERE MANV = '" + txtMaNV.Text.Trim() + "'";
                                undoList.Push(cauTruyVanHoanTac);
                                // Thêm dữ liệu
                                bdsNhanVien.EndEdit();
                                tbaNhanVien.Update(DS.NhanVien);
                                // Làm mới
                                tbaNhanVien.Fill(DS.NhanVien);
                                gcNhanVien.Refresh();
                                /* cập nhật lại trạng thái cờ */
                                flag = "";
                                MessageBox.Show("Thêm nhân viên mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                bdsNhanVien.RemoveCurrent();
                                MessageBox.Show("Thêm nhân viên mới thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnUndo.Enabled = true;
                            btnGhi.Enabled = false;
                            gcNhanVien.Enabled = true;
                            gcNhapLieu.Enabled = false;
                            // Thêm dữ liệu
                            bdsNhanVien.EndEdit();
                            tbaNhanVien.Update(DS.NhanVien);
                            // Làm mới      
                            tbaNhanVien.Fill(DS.NhanVien);
                            gcNhanVien.Refresh();
                            bdsNhanVien.Position = viTri;
                            /*cập nhật lại trạng thái cờ*/
                            flag = "";
                            MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                        catch (Exception ex)
                        {
                            bdsNhanVien.EndEdit();
                            MessageBox.Show("Cập nhật thông tin nhân viên thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag.Equals("them") && btnThem.Enabled == false)
            {
                if (MessageBox.Show("Bạn muốn hủy thêm mới nhân viên?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = true;
                    gcNhanVien.Enabled = true;
                    btnGhi.Enabled = gcNhapLieu.Enabled = false;
                    bdsNhanVien.CancelEdit();
                    /* trở về lúc đầu con trỏ đang đứng*/
                    bdsNhanVien.Position = viTri;
                }
                else
                {
                    return;
                }
            }
            if (flag.Equals("sua") && btnSua.Enabled == false)
            {
                if (MessageBox.Show("Bạn muốn hủy cập nhật thông tin nhân viên?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bdsNhanVien.CancelEdit();
                    flag = "";
                    btnGhi.Enabled = gcNhapLieu.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = true;
                    gcNhanVien.Enabled = true;
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
                if (cauTruyVanHoanTac.Contains("sp_hoanTacChuyenChiNhanh"))
                {
                    try
                    {
                        /*string chiNhanhHienTai = Program.serverName;
                        string chiNhanhChuyenToi = Program.serverNameLeft;

                        Program.serverName = chiNhanhChuyenToi;
                        Program.mLogin = Program.remoteLogin;
                        Program.password = Program.remotePassword;*/
                        if (Program.Connecting() == 0)
                        {
                            return;
                        }
                        Program.ExecSqlNonQuery(cauTruyVanHoanTac);
                        MessageBox.Show("Chuyển nhân viên trở lại thành công", "Thông báo", MessageBoxButtons.OK);
                        /*Program.serverName = chiNhanhHienTai;
                        Program.mLogin = Program.currentLogin;
                        Program.password = Program.currentPassword;*/
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Chuyển nhân viên thất bại \n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    if (Program.Connecting() == 0)
                    {
                        return;
                    }
                    Program.ExecSqlNonQuery(cauTruyVanHoanTac);

                }
                tbaNhanVien.Fill(DS.NhanVien);
                gcNhanVien.Refresh();
            }
            if (undoList.Count == 0)
            {
                btnUndo.Enabled = false;
                if (Program.mRole.Equals("CONGTY"))
                {
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                }
                else
                {
                    // MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);                   
                    btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                }     
                return;
            }
            return;
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // Đổ dữ liệu mới vào lại DataSet
                tbaNhanVien.Fill(DS.NhanVien);
                gcNhanVien.Refresh();
                gcNhanVien.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void BtnCNN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormChonChiNhanhChuyenNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            FormChonChiNhanhChuyenNhanVien form = new FormChonChiNhanhChuyenNhanVien();
            form.Show();
        }

        private void BtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!flag.Equals(""))
            {
                if (MessageBox.Show("Bạn muốn thoát mà chưa lưu dữ liệu?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bdsNhanVien.CancelEdit();
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

        private bool CheckInputValidate()
        {
            if (txtMaNV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtMaNV.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Mã nhân viên chỉ chấp nhận giá trị là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return false;
            }
            else if (txtHo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Họ của nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHo.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtHo.Text, @"^[A-Za-zÀ-Ỹà-ỹ ]+$") == false)
            {
                MessageBox.Show("Họ của nhân viên chỉ bao gồm chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHo.Focus();
                return false;
            }
            else if (txtHo.Text.Length > 40)
            {
                MessageBox.Show("Họ của nhân viên không được quá 40 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHo.Focus();
                return false;
            }
            else if (txtTen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên của nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtTen.Text, @"^[A-Za-zÀ-Ỹà-ỹ]+$") == false)
            {
                MessageBox.Show("Tên của nhân viên chỉ bao gồm một từ, không chứa khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return false;
            }
            else if (txtTen.Text.Length > 10)
            {
                MessageBox.Show("Tên của nhân viên không được quá 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
                return false;
            }
            else if (txtCMND.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chứng minh nhân dân của nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtCMND.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Chứng minh nhân dân của nhân viên chỉ chấp nhận giá trị là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return false;
            }
            else if (txtCMND.Text.Length != 10)
            {
                MessageBox.Show("Chứng minh nhân dân của nhân viên bao gồm 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
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
                MessageBox.Show("Địa chỉ của nhân viên không được quá 100 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            else if (CalculateAge(dtpNgaySinh.DateTime) < 18 || CalculateAge(dtpNgaySinh.DateTime) > 60)
            {
                MessageBox.Show("Nhân viên có độ tuổi không phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgaySinh.Focus();
                return false;
            }
            else if (!decimal.TryParse(txtLuong.Text, out decimal luong) || luong < 4000000)
            {
                MessageBox.Show("Mức lương tối thiểu là 4.000.000 vnđ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuong.Focus();
                return false;
            }
            return true;
        }
        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;

            return age;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
    }
    
}