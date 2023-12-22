using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        string flag = "";
        bool mode = true;
        private static int soLuongGoc;
        public FormPhieuXuat()
        {
            InitializeComponent();
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            /*Tắt kiểm tra khóa ngoại*/
            DS.EnforceConstraints = false;

            tbaPhieuXuat.Connection.ConnectionString = Program.connectString;
            tbaPhieuXuat.Fill(DS.PhieuXuat);

            tbaCTPX.Connection.ConnectionString = Program.connectString;
            tbaCTPX.Fill(DS.CTPX);

            tbaTenKho.Connection.ConnectionString = Program.connectString;
            tbaTenKho.Fill(DS.TenKho);

            tbaTenNhanVien.Connection.ConnectionString = Program.connectString;
            tbaTenNhanVien.Fill(DS.HoTen);

            tbaTenVattu.Connection.ConnectionString = Program.connectString;
            tbaTenVattu.Fill(DS.TenVatTu);

            /* Load lại dữ liệu để các combobox Nhân viên, kho được cập nhật chính xác */
            tbaPhieuXuat.Fill(DS.PhieuXuat);
            gcPhieuXuat.Refresh();
            tbaCTPX.Fill(DS.CTPX);
            dgvCTPX.Refresh();

            /* Đổ dữ liệu cho combobox Chi nhánh */
            cbbMaCN.DataSource = Program.bindingSource_listBranch;
            cbbMaCN.DisplayMember = "TENCN";
            cbbMaCN.ValueMember = "TENSERVER";
            cbbMaCN.SelectedIndex = Program.mBranch;

            /*Bật tắt*/
            gbPhieuXuat.Enabled = gbCTPX.Enabled = false;
            gcPhieuXuat.Enabled = dgvCTPX.Enabled = true;
            cbbMaCN.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;

            mode = true;
            btnCheDo.Caption = "Chi tiết Phiếu xuất";

            /* Phân quyền cho Role CongTy */
            if (Program.mRole == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnCheDo.Enabled = false;
                btnRefresh.Enabled = btnThoat.Enabled = true;
                cbbMaCN.Enabled = true;
                gcNhapLieu.Enabled = false;
            }
            if ((mode == true & bdsPhieuXuat.Count == 0) || (mode == false & bdsCTPX.Count == 0))
                btnXoa.Enabled = false;
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
            /*Nếu chi nhánh được chọn là chi nhánh được chọn lúc đăng nhập*/
            else
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

                tbaPhieuXuat.Connection.ConnectionString = Program.connectString;
                tbaPhieuXuat.Fill(DS.PhieuXuat);

                tbaCTPX.Connection.ConnectionString = Program.connectString;
                tbaCTPX.Fill(DS.CTPX);

                tbaTenKho.Connection.ConnectionString = Program.connectString;
                tbaTenKho.Fill(DS.TenKho);

                tbaTenNhanVien.Connection.ConnectionString = Program.connectString;
                tbaTenNhanVien.Fill(DS.HoTen);

                tbaTenVattu.Connection.ConnectionString = Program.connectString;
                tbaTenVattu.Fill(DS.TenVatTu);

                /* Load lại dữ liệu để các combobox Nhân viên, kho được cập nhật chính xác */
                tbaPhieuXuat.Fill(DS.PhieuXuat);
                gcPhieuXuat.Refresh();
                tbaCTPX.Fill(DS.CTPX);
                dgvCTPX.Refresh();

                btnSua.Enabled = btnXoa.Enabled = btnCheDo.Enabled = false;
            }
        }


        private void BtnCheDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode == true)
            {
                // mode = false là mode "Chi tiết Đơn đặt hàng"
                mode = false;
                btnCheDo.Caption = "Phiếu xuất";

                // Bật tắt
                gbPhieuXuat.Enabled = false;

                if (bdsCTPX.Count == 0)
                    btnXoa.Enabled = btnSua.Enabled = false;
                else
                    btnXoa.Enabled = btnSua.Enabled = true;
            }
            else
            {
                mode = true;
                btnCheDo.Caption = "Chi tiết Phiếu xuất";

                gbCTPX.Enabled = false;
                if (SoSanhMaNV() == false)
                {
                    btnXoa.Enabled = btnSua.Enabled = btnCheDo.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = btnSua.Enabled = btnCheDo.Enabled = true;
                }
                if (SoSanhMaNV() == true && bdsPhieuXuat.Count > 0)
                {
                    btnXoa.Enabled = btnSua.Enabled = true;
                }
                else
                {
                    btnXoa.Enabled = btnSua.Enabled = false;
                }
            }
        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Cập giá trị nhật biến cờ
            flag = "them";
            // Bật/tắt các nút làm việc
            btnGhi.Enabled = btnUndo.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = false;
            /* Xử lý cho từng chế độ */
            if (mode == true) // Chế độ Phiếu xuất
            {
                // Bật tắt khu vực làm việc
                gbPhieuXuat.Enabled = txtMaPhieuXuat.Enabled = true;
                gbCTPX.Enabled = gcPhieuXuat.Enabled = dgvCTPX.Enabled = false;
                // Lấy vị trí để phục vụ nút Undo
                viTri = bdsPhieuXuat.Position;
                // Thêm mới
                bdsPhieuXuat.AddNew();
                /* Khởi tạo các giá trị mặc định*/
                // Ngày mặc định là ngày hiện tại
                dtpNgayXuat.EditValue = DateTime.Now;
                // Nhân viên phải là nhân viên đang đăng nhập
                cbbTenNV.Text = Program.mFullName + " - " + Program.userName;
                txtMaNhanVien.Text = Program.userName;
                // Xử lý lỗi logic không cho txtVattu có giá trị
                txtTenVattu.Text = "";
            }
            else // Chế độ Chi tiết phiếu xuất
            {
                // Bật tắt khu vực làm việc
                gbCTPX.Enabled = true;
                gbPhieuXuat.Enabled = gcPhieuXuat.Enabled = dgvCTPX.Enabled = false;
                // Lấy vị trí để phục vụ nút Undo
                viTri = bdsCTPX.Position;
                // Thêm mới
                bdsCTPX.AddNew();
                /* Khởi tạo các giá trị mặc định*/
                // Mã Phiếu nhập là Phiếu nhập mà bdsPhieuNhap.Position đang trỏ tới, không được tự nhập
                txtCT_MaPhieuXuat.Text = txtMaPhieuXuat.Text;
                // Số lượng mặc định là 1 và đơn giá mặc định là 10.000
                seSoLuongXuat.Value = 1;
                txtDonGia.EditValue = 10000;
                // Xử lý lỗi logic không cho txtVattu có giá trị
                txtTenVattu.Text = "";
                btnHuyVattu.Enabled = false;
            }
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode == true) // Chế độ Phiếu xuất
            {
                if (bdsCTPX.Count > 0)
                {
                    MessageBox.Show("Không thể xóa phiếu xuất này vì đang tồn tại chi tiết phiếu xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa Phiếu xuất này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        // Lấy vị trí
                        viTri = bdsPhieuXuat.Position;
                        try
                        {
                            // Xóa dòng hiện tại
                            bdsPhieuXuat.RemoveCurrent();
                            // Làm mới dữ liệu
                            tbaPhieuXuat.Update(DS.PhieuXuat);
                            tbaPhieuXuat.Fill(DS.PhieuXuat);
                            gcPhieuXuat.Refresh();
                            // Trở lại vị trí trước khi xóa
                            bdsCTPX.Position = viTri;
                            // Bật/tắt nút Xóa và Sửa theo số lượng Phiếu xuất
                            if (bdsPhieuXuat.Count == 0 || SoSanhMaNV() == false)
                                btnXoa.Enabled = btnSua.Enabled = false;
                            else
                                btnXoa.Enabled = btnSua.Enabled = true;
                            // Thông báo
                            MessageBox.Show("Xóa phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return;
                        }
                        catch (Exception ex)
                        {
                            // Làm mới dữ liệu
                            tbaPhieuXuat.Fill(DS.PhieuXuat);
                            // Trở lại vị trí trước khi xóa
                            bdsPhieuXuat.Position = viTri;
                            // Thông báo
                            MessageBox.Show("Xóa phiếu xuất thất bại!\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else // Chế độ Chi tiết Phiếu xuất
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa Chi tiết phiếu xuất này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Lấy vị trí và các giá trị để phục vụ cập nhật số liệu
                    viTri = bdsCTPX.Position;
                    string maVT = txtMaVatTu.Text;
                    int soLuong = (int)seSoLuongXuat.Value;
                    try
                    {
                        // Xóa dòng hiện tại
                        bdsCTPX.RemoveCurrent();
                        // Cập nhật lại số lượng vật tư
                        Program.CapNhatSoLuongVatTu("IMPORT", maVT, soLuong);
                        // Làm mới dữ liệu
                        tbaPhieuXuat.Update(DS.PhieuXuat);
                        tbaPhieuXuat.Fill(DS.PhieuXuat);
                        dgvCTPX.Refresh();
                        // Trở lại vị trí trước khi xóa
                        bdsPhieuXuat.Position = viTri;
                        // Bật/tắt nút Xóa và Sửa theo số lượng Chi tiết phiếu xuất
                        if (bdsPhieuXuat.Count == 0 || SoSanhMaNV() == false)
                            btnXoa.Enabled = btnSua.Enabled = false;
                        else
                            btnXoa.Enabled = btnSua.Enabled = true;
                        // thông báo
                        MessageBox.Show("Xóa phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    catch (Exception ex)
                    {
                        // Làm mới dữ liệu
                        tbaPhieuXuat.Fill(DS.PhieuXuat);
                        // Trở lại vị trí trước khi xóa
                        bdsPhieuXuat.Position = viTri;
                        // Thông báo
                        MessageBox.Show("Xóa phiếu xuất thất bại!\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Cập nhật giá trị biến cờ
            flag = "sua";
            // Bật tắt nút làm việc
            btnGhi.Enabled = btnUndo.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = false;
            /* Xử lý cho từng chế độ */
            if (mode == true) // Chế độ Phiếu xuất
            {
                viTri = bdsPhieuXuat.Position;
                // Bật tắt khu vực làm việc
                gbPhieuXuat.Enabled = true;
                gbCTPX.Enabled = false;
                // không cho sửa mã Phiếu xuất, chỉ cho sửa ngày, khách, và kho
                txtMaPhieuXuat.Enabled = false;
                dtpNgayXuat.Enabled = txtKhachHang.Enabled = cbbTenKho.Enabled = true;
            }
            else // Chế độ Chi tiết phiếu xuất
            {
                viTri = bdsCTPX.Position;
                // Bật tắt khu vực làm việc
                gbPhieuXuat.Enabled = false;
                gbCTPX.Enabled = true;
                // Chỉ cho sửa số lượng và đơn giá
                txtCT_MaPhieuXuat.Enabled = btnVattu.Enabled = btnHuyVattu.Enabled = false;
                soLuongGoc = (int)seSoLuongXuat.Value;
            }
        }

        private void BtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            /* Nếu cờ đang ở trạng thái thêm */
            if (flag.Equals("them"))
            {
                if (MessageBox.Show("Bạn muốn hủy thao tác thêm mới?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                    btnGhi.Enabled = gbPhieuXuat.Enabled = gbCTPX.Enabled = false;
                    gcPhieuXuat.Enabled = dgvCTPX.Enabled = true;
                    if (mode == true) // Đang ở trạng thái thêm Phiếu xuất
                    {
                        bdsPhieuXuat.CancelEdit();
                    }
                    else // Đang ở trạng thái thêm Chi tiết Phiếu xuất
                    {
                        bdsCTPX.CancelEdit();
                    }
                    /* trở về lúc đầu con trỏ đang đứng*/
                    bdsPhieuXuat.Position = viTri;
                    btnUndo.Enabled = false;
                    if (SoSanhMaNV() == false)
                    {
                        btnXoa.Enabled = btnSua.Enabled = false;
                    }
                    else
                    {
                        btnXoa.Enabled = btnSua.Enabled = true;
                    }
                }
                else
                {
                    return;
                }
            }
            /* Nếu cờ đang ở trạng thái sửa */
            else if (flag.Equals("sua"))
            {
                if (MessageBox.Show("Bạn muốn hủy thao tác cập nhật?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                    btnGhi.Enabled = gbPhieuXuat.Enabled = gbCTPX.Enabled = false;
                    gcPhieuXuat.Enabled = dgvCTPX.Enabled = true;
                    if (mode == true) // Đang ở trạng thái thêm Phiếu xuất
                    {
                        bdsPhieuXuat.CancelEdit();
                    }
                    else // Đang ở trạng thái thêm Chi tiết Phiếu xuất
                    {
                        bdsCTPX.CancelEdit();
                    }
                    btnUndo.Enabled = false;
                }
                else
                {
                    return;
                }
            }
        }

        private void BtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            else
            {
                if (mode == true) // Chế độ Phiếu xuất
                {
                    if (flag.Equals("them")) // Nếu thêm một phiếu xuất
                    {
                        if (KiemTraDieuKien(1) == 1)
                        {
                            MessageBox.Show("Mã Phiếu xuất này đã tồn tại trên hệ thống, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaPhieuXuat.Focus();
                            return;
                        }
                        else
                        {
                            if (MessageBox.Show("Bạn muốn thêm mới Phiếu xuất này vào hệ thống?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                try
                                {
                                    // Bật/tắt nút và khu vực hoạt động
                                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                                    btnGhi.Enabled = btnUndo.Enabled = false;
                                    gcPhieuXuat.Enabled = true;
                                    gbPhieuXuat.Enabled = false;
                                    /* Lưu dữ liệu thêm mới vào hệ thống */
                                    // Thêm dữ liệu
                                    bdsPhieuXuat.EndEdit();
                                    tbaPhieuXuat.Update(DS.PhieuXuat);
                                    // Làm mới dữ liệu
                                    tbaPhieuXuat.Fill(DS.PhieuXuat);
                                    gcPhieuXuat.Refresh();
                                    // Cập nhật trạng thái cờ
                                    flag = "";
                                    // TRở lại vị trí trước khi thêm mới
                                    bdsPhieuXuat.Position = viTri;
                                    if (SoSanhMaNV() == false)
                                        btnXoa.Enabled = btnSua.Enabled = false;
                                    else 
                                        btnXoa.Enabled = btnSua.Enabled = true;
                                    // Thông báo
                                    MessageBox.Show("Thêm phiếu nhập mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                } 
                                catch (Exception ex)
                                {
                                    bdsPhieuXuat.RemoveCurrent();
                                    MessageBox.Show("Thêm phiếu nhập mới thất bại!\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else if (flag.Equals("sua")) // Nếu sửa một phiếu xuất
                    {
                        if (MessageBox.Show("Bạn muốn cập nhật thông tin mới của phiếu nhập vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                // Bật tắt các nút
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                                gcPhieuXuat.Enabled = true;
                                btnUndo.Enabled = btnGhi.Enabled = gbPhieuXuat.Enabled = false;
                                // Thêm dữ liệu
                                bdsPhieuXuat.EndEdit();
                                tbaPhieuXuat.Update(DS.PhieuXuat);
                                // Làm mới
                                tbaPhieuXuat.Fill(DS.PhieuXuat);
                                gcPhieuXuat.Refresh();
                                /*cập nhật lại trạng thái cờ*/
                                flag = "";
                                bdsPhieuXuat.Position = viTri;
                                MessageBox.Show("Cập nhật thông tin phiếu xuất thành công", "Thông báo", MessageBoxButtons.OK);
                                return;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Cập nhật thông tin đơn đặt hàng thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else  // Chế độ Chi tiết Phiếu xuất
                {
                    if (KiemTraDieuKien(2) == 1)
                    {
                        MessageBox.Show("Số lượng xuất không được lớn hơn số lượng tồn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        seSoLuongXuat.Focus();
                        return;
                    }
                    else
                    {
                        if (flag.Equals("them")) // Nếu thêm một Chi tiết phiếu xuất
                        {
                            if (MessageBox.Show("Bạn muốn thêm chi tiết phiếu xuất mới vào hệ thống?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                try
                                {
                                    // Bật tắt
                                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                                    btnUndo.Enabled = btnGhi.Enabled = false;
                                    gcPhieuXuat.Enabled = dgvCTPX.Enabled = true;
                                    gbPhieuXuat.Enabled = gbCTPX.Enabled = false;
                                    // Thêm dữ liệu
                                    bdsCTPX.EndEdit();
                                    // Cập nhật số lượng vật tư trên hệ thống
                                    int soLuong = (int)seSoLuongXuat.Value;
                                    float donGia = float.Parse(txtDonGia.Text);
                                    Program.CapNhatSoLuongVatTu("EXPORT", txtMaVatTu.Text, soLuong);
                                    tbaCTPX.Update(DS.CTPX);
                                    // Làm mới
                                    tbaCTPX.Fill(DS.CTPX);
                                    dgvCTPX.Refresh();
                                    /*cập nhật lại trạng thái cờ*/
                                    flag = "";
                                    bdsCTPX.Position = viTri;
                                    MessageBox.Show("Thêm chi tiết phiếu xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    bdsCTPX.RemoveCurrent();
                                    MessageBox.Show("Thêm chi tiết phiếu xuất thất bại.\nLỗi:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        else if (flag.Equals("sua")) // Nếu sửa một Chi tiết phiếu xuất
                        {
                            int soLuongMoi = (int)seSoLuongXuat.Value;
                            string maVatTu = txtMaVatTu.Text;
                            if (MessageBox.Show("Bạn muốn cập nhật dữ liệu mới của Chi tiết phiếu xuất vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                try
                                {
                                    // Bật tắt các nút
                                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                                    gcPhieuXuat.Enabled = true;
                                    btnUndo.Enabled = btnGhi.Enabled = gbPhieuXuat.Enabled = gbCTPX.Enabled = false;
                                    // Thêm dữ liệu
                                    bdsCTPX.EndEdit();
                                    tbaCTPX.Update(DS.CTPX);
                                    tbaCTPX.Fill(DS.CTPX);
                                    dgvCTPX.Refresh();
                                    gcPhieuXuat.Enabled = true;
                                    /*cập nhật lại trạng thái cờ*/
                                    flag = "";
                                    MessageBox.Show("Cập nhật thông tin Chi tiết phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK);
                                    int chenhLech = soLuongGoc - soLuongMoi;
                                    // Cập nhật số lượng vật tư
                                    Program.CapNhatSoLuongVatTu("IMPORT", maVatTu, chenhLech);
                                    // Làm mới
                                    tbaCTPX.Fill(DS.CTPX);
                                    dgvCTPX.Refresh();
                                    bdsCTPX.Position = viTri;
                                    return;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Cập nhật thông tin chi tiết phiếu nhập thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tbaPhieuXuat.Fill(DS.PhieuXuat);
                gcPhieuXuat.Refresh();
                tbaCTPX.Fill(DS.CTPX);
                dgvCTPX.Refresh();
                gcPhieuXuat.Enabled = dgvCTPX.Enabled = true;
                if (SoSanhMaNV() == false)
                {
                    btnXoa.Enabled = btnSua.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void BtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!flag.Equals(""))
            {
                if (MessageBox.Show("Bạn muốn thoát mà chưa lưu dữ liệu?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (mode == true) /* Chế độ Phiếu xuất */
                    {
                        bdsPhieuXuat.CancelEdit();
                    }
                    else /* Chế độ Chi tiết Phiếu xuất */
                    {
                        bdsCTPX.CancelEdit();
                    }
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
                return;
            }
        }

        private void DgvCTPX_SelectionChanged(object sender, EventArgs e)
        {
            if (bdsCTPX.Count > 0)
            {
                int rowIndex = bdsCTPX.Position;

                if (dgvCTPX.Rows[rowIndex].Cells["dgvVattu"] is DataGridViewComboBoxCell comboBoxCell)
                {
                    if (comboBoxCell.Value == null)
                    {
                        txtTenVattu.Text = "";
                    }
                    string selectedValue = comboBoxCell.Value.ToString();
                    DataRowView selectedRow = comboBoxCell.Items.Cast<DataRowView>().FirstOrDefault(item => item.Row["MAVT"].ToString() == selectedValue);

                    if (selectedRow != null)
                    {
                        string TenVT = selectedRow["TENVT"].ToString();
                        txtTenVattu.Text = TenVT;
                    }
                }
            }
            else
            {
                txtTenVattu.Text = "";
            }
        }

        private void CbbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenNV.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                txtMaNhanVien.Text = cbbTenNV.SelectedValue.ToString();
            }
        }

        private void CbbTenKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenKho.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                txtMaKho.Text = cbbTenKho.SelectedValue.ToString();
            }
        }

        private bool SoSanhMaNV()
        {
            if (bdsPhieuXuat.Count > 0)
            {
                DataRowView drv = (DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position];
                string maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (SoSanhMaNV() == false)
            {
                btnXoa.Enabled = btnSua.Enabled = false;
                if (mode == true)
                    btnCheDo.Enabled = false;
                else
                    btnCheDo.Enabled = true;
            }
            else
            {
                btnCheDo.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                if (bdsCTPX.Count == 0 && mode == false)
                    btnXoa.Enabled = btnSua.Enabled = false;
                else
                    btnXoa.Enabled = btnSua.Enabled = true;
            }
        }

        private bool KiemTraDuLieuNhap()
        {
            if (mode == true) // Nếu mode là "Đơn đặt hàng"
            {
                if (txtMaPhieuXuat.Text.Equals(""))
                {
                    MessageBox.Show("Mã Phiếu xuất không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPhieuXuat.Focus();
                    return false;
                }
                else if (txtMaPhieuXuat.Text.Length > 8)
                {
                    MessageBox.Show("Mã Phiếu nhập chỉ bao gồm 8 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPhieuXuat.Focus();
                    return false;
                }
                else if (!Regex.IsMatch(txtMaPhieuXuat.Text, @"^[A-Z0-9\s]+$"))
                {
                    MessageBox.Show("Mã phiếu xuất chỉ bao gồm chữ cái IN HOA, số và có thể có khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPhieuXuat.Focus();
                    return false;
                }
                else if (txtKhachHang.Text.Equals(""))
                {
                    MessageBox.Show("Họ tên khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKhachHang.Focus();
                    return false;
                }
                else if (txtKhachHang.Text.Length > 100)
                {
                    MessageBox.Show("Họ tên khách hàng không được quá 100 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKhachHang.Focus();
                    return false;
                }
                else if (Regex.IsMatch(txtKhachHang.Text, @"[^A-Za-z0-9,/\.\sÀ-Ỹà-ỹ]"))
                {
                    MessageBox.Show("Họ tên khách hàng không chứa các kí tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKhachHang.Focus();
                    return false;
                }
                else if (cbbTenKho.SelectedValue == null || cbbTenKho.Text.Equals(""))
                {
                    MessageBox.Show("Kho không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbbTenKho.Focus();
                    return false;
                }
            }
            else
            {
                if (txtTenVattu.Text.Equals("") || txtMaVatTu.Text.Equals(""))
                {
                    MessageBox.Show("Vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbbTenKho.Focus();
                    return false;
                }
                else if (txtDonGia.Text.Equals(""))
                {
                    MessageBox.Show("Đơn giá không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbbTenKho.Focus();
                    return false;
                }
                else if ((int)seSoLuongXuat.Value <= 0)
                {
                    MessageBox.Show("Số lượng xuất phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    seSoLuongXuat.Focus();
                    seSoLuongXuat.Value = 1;
                    return false;
                }
            }
            return true;
        }

        private int KiemTraDieuKien(int lenh)
        {
            string cauTruyVanKiemTra = "";
            if (lenh == 1)
            {
                cauTruyVanKiemTra = "DECLARE @result int " + "EXEC @result = [dbo].[sp_kiemTraMaPhieuXuatThemMoi] '" + txtMaPhieuXuat.Text.Trim() + "' " + "SELECT 'Value' = @result";
            }
            else if (lenh ==2)
            {
                cauTruyVanKiemTra = "DECLARE @RESULT int " + "EXEC @RESULT = [dbo].[sp_soSanhSoLuongTonVatTu_CTPX] '" + txtMaVatTu.Text.Trim() + "', " + (int)seSoLuongXuat.Value + " SELECT 'Value' = @RESULT";
            }
            try
            {
                Program.sqlDataReader = Program.ExecSqlDataReader(cauTruyVanKiemTra);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.sqlDataReader == null)
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            Program.sqlDataReader.Read();
            int result = int.Parse(Program.sqlDataReader.GetValue(0).ToString());
            Program.sqlDataReader.Close();

            Program.sqlDataReader.Close();
            return result;
        }

        private void btnVattu_Click(object sender, EventArgs e)
        {
            FormDanhSachVatTuChuaCoCTPX formDanhSachVatTuChuaCoCTPX = Application.OpenForms.OfType<FormDanhSachVatTuChuaCoCTPX>().FirstOrDefault();
            if (formDanhSachVatTuChuaCoCTPX != null)
                formDanhSachVatTuChuaCoCTPX.Activate();
            else
            {
                FormDanhSachVatTuChuaCoCTPX formDanhSachVatTuChuaCoCTPX1 = new FormDanhSachVatTuChuaCoCTPX();
                formDanhSachVatTuChuaCoCTPX1.txtMaPX.Text = txtMaPhieuXuat.Text;
                formDanhSachVatTuChuaCoCTPX1.Show();
                if (formDanhSachVatTuChuaCoCTPX1.bdsVattu.Count == 0)
                {

                    MessageBox.Show("Không còn Vật tư nào chưa tồn tại trong Chi tiết phiếu xuất này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    formDanhSachVatTuChuaCoCTPX1.Close();
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                    gbCTPX.Enabled = false;
                    dgvCTPX.Enabled = true;
                    btnHuyVattu.Enabled = false;
                    btnVattu.Enabled = true;
                    bdsCTPX.CancelEdit();
                    return;
                }
            }
        }

        private void btnHuyVattu_Click(object sender, EventArgs e)
        {
            txtTenVattu.Text = txtMaVatTu.Text = "";
            btnHuyVattu.Enabled = false;
            seSoLuongXuat.Value = 1;
            txtDonGia.EditValue = 10000;
            btnVattu.Focus();
        }
    }
}