using QLVT.SubForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        bool mode = true;
        string flag = "";
        private static int soLuongGoc;
        private static float donGiaGoc;

        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            /*Tắt kiểm tra khóa ngoại*/
            DS.EnforceConstraints = false;

            tbaPhieuNhap.Connection.ConnectionString = Program.connectString;
            tbaPhieuNhap.Fill(DS.PhieuNhap);

            tbaCTPN.Connection.ConnectionString = Program.connectString;
            tbaCTPN.Fill(DS.CTPN);

            tbaTenKho.Connection.ConnectionString = Program.connectString;
            tbaTenKho.Fill(DS.TenKho);

            tbaTenNV.Connection.ConnectionString = Program.connectString;
            tbaTenNV.Fill(DS.HoTen);

            tbaTenVT.Connection.ConnectionString = Program.connectString;
            tbaTenVT.Fill(DS.TenVatTu);

            /* Đổ dữ liệu cho combobox Chi nhánh */
            cbbMaCN.DataSource = Program.bindingSource_listBranch;
            cbbMaCN.DisplayMember = "TENCN";
            cbbMaCN.ValueMember = "TENSERVER";
            cbbMaCN.SelectedIndex = Program.mBranch;

            mode = true;
            btnCheDo.Caption = "Chi tiết Phiếu nhập";

            /*Bật tắt*/
            gbPhieuNhap.Enabled = gbCTPN.Enabled = false;
            gcPhieuNhap.Enabled = dgvCTPN.Enabled = true;
            cbbMaCN.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;

            /* Load lại dữ liệu để các combobox Nhân viên, kho được cập nhật chính xác */
            tbaPhieuNhap.Fill(DS.PhieuNhap);
            gcPhieuNhap.Refresh();
            tbaCTPN.Fill(DS.CTPN);
            dgvCTPN.Refresh();

            /* Phân quyền cho Role CongTy */
            if (Program.mRole == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnCheDo.Enabled = false;
                btnRefresh.Enabled = true;
                cbbMaCN.Enabled = true;
                gcNhapLieu.Enabled = false;
            }
            if ((mode == true & bdsPhieuNhap.Count == 0) || (mode == false & bdsCTPN.Count == 0))
                btnXoa.Enabled = btnSua.Enabled = false;
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
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                /*Đổ dữ liệu từ dataset vào girdControl*/
                tbaPhieuNhap.Connection.ConnectionString = Program.connectString;
                tbaPhieuNhap.Fill(DS.PhieuNhap);

                tbaCTPN.Connection.ConnectionString = Program.connectString;
                tbaCTPN.Fill(DS.CTPN);

                tbaTenKho.Connection.ConnectionString = Program.connectString;
                tbaTenKho.Fill(DS.TenKho);

                tbaTenNV.Connection.ConnectionString = Program.connectString;
                tbaTenNV.Fill(DS.HoTen);

                tbaTenVT.Connection.ConnectionString = Program.connectString;
                tbaTenVT.Fill(DS.TenVatTu);

                /* Load lại dữ liệu để các combobox Nhân viên, kho được cập nhật chính xác */
                tbaPhieuNhap.Fill(DS.PhieuNhap);
                gcPhieuNhap.Refresh();
                tbaCTPN.Fill(DS.CTPN);
                dgvCTPN.Refresh();

                btnSua.Enabled = btnXoa.Enabled = btnCheDo.Enabled = false;
            }
        }

        private void BtnCheDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode == true)
            {
                // mode = false là mode "Chi tiết Đơn đặt hàng"
                mode = false;
                btnCheDo.Caption = "Phiếu nhập";
                // Bật tắt
                gbPhieuNhap.Enabled = false;

                if (bdsCTPN.Count == 0)
                    btnXoa.Enabled = btnSua.Enabled = false;
                else
                    btnXoa.Enabled = btnSua.Enabled = true;
            }
            else
            {
                mode = true;
                btnCheDo.Caption = "Chi tiết Phiếu nhập";

                gbCTPN.Enabled = false;
                if (SoSanhMaNV() == false)
                {
                    btnXoa.Enabled = btnSua.Enabled = btnCheDo.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = btnSua.Enabled = btnCheDo.Enabled = true;
                }
                if (SoSanhMaNV() == true && bdsPhieuNhap.Count > 0)
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
            // Cập nhật biến cờ
            flag = "them";
            //bật tắt các nút
            btnGhi.Enabled = btnUndo.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = false;
            /* Xử lý cho từng chế độ */
            if (mode == true) // Chế độ phiếu nhập
            {
                // bật tắt khu vực thao tác
                gbCTPN.Enabled = gcPhieuNhap.Enabled = btnHuyCTDDH.Enabled = false;
                gbPhieuNhap.Enabled = txtMaPN.Enabled = btnDDH.Enabled = true;
                // Lấy vị trí phục vụ nút hoàn tác
                viTri = bdsPhieuNhap.Position;
                bdsPhieuNhap.AddNew();
                // Nhân viên tạo phải là nhân viên đăng nhập
                txtMaNV.Text = Program.userName;
                cbbTenNV.Text = Program.mFullName + " - " + Program.userName;
                // Thời gian mặc định là ngày hôm nay
                dtpNgay.EditValue = DateTime.Now;
                // Xử lý lỗi logic không cho txtVattu có giá trị
                txtTenVT.Text = "";
                // Bật vì nếu trước đó thao tác sửa sẽ bị tắt
                btnHuyDDH.Enabled = false;
            }
            else /* Chế độ chi tiết phiếu nhập */
            {
                gbCTPN.Enabled = btnCTDDH.Enabled = true;
                gbPhieuNhap.Enabled = gcPhieuNhap.Enabled = seSoLuong.Enabled = txtDonGia.Enabled = false;
                // Lấy vị trí phục vụ nút hoàn tác
                viTri = bdsCTPN.Position;
                bdsCTPN.AddNew();
                // Mã phiếu nhập thêm mới phải là mã phiếu nhập đang chọn ở gcPhieuNhap
                txtCT_MaPN.Text = txtMaPN.Text;
                // Xử lý lỗi logic không cho txtVattu có giá trị
                txtTenVT.Text = "";
                btnHuyDDH.Enabled = false;
            }
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode == true) // Chế độ Phiếu nhập
            {
                if (CheckMAPN(txtMaPN.Text, 0) == 1)
                {
                    MessageBox.Show("Không thể xóa phiếu nhập này vì đã tồn tại trong Chi tiết phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        viTri = bdsPhieuNhap.Position;
                        try
                        {
                            // Xóa dòng hiện tại
                            bdsPhieuNhap.RemoveCurrent();
                            // Bật/tắt nút Xóa và Sửa theo số lượng Phiếu nhập
                            if (bdsPhieuNhap.Count == 0 || SoSanhMaNV() == false)
                                btnXoa.Enabled = btnSua.Enabled = false;
                            else
                                btnXoa.Enabled = btnSua.Enabled = true;
                            // Làm mới dữ liệu
                            tbaPhieuNhap.Update(DS.PhieuNhap);
                            tbaPhieuNhap.Fill(DS.PhieuNhap);
                            gcPhieuNhap.Refresh();
                            // Trở lại vị trí trước khi xóa
                            bdsPhieuNhap.Position = viTri;
                            // Thông báo
                            MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        catch (Exception ex)
                        {
                            // Làm mới dữ liệu
                            tbaPhieuNhap.Fill(DS.PhieuNhap);
                            // Trở lại vị trí trước khi xóa
                            bdsPhieuNhap.Position = viTri;
                            // Thông báo
                            MessageBox.Show("Xóa phiếu nhập thất bại!\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else // Chế độ Chi tiết Phiếu nhập
            {

                if (MessageBox.Show("Bạn chắc chắn muốn xóa chi tiết phiếu nhập này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    viTri = bdsCTPN.Position;
                    int soLuong = (int)seSoLuong.Value;
                    string maVT = txtMaVT.Text;
                    try
                    {
                        // Xóa dòng hiện tại
                        bdsCTPN.RemoveCurrent();
                        // Cập nhật số lượng vật tư
                        Program.CapNhatSoLuongVatTu("EXPORT", maVT, soLuong);
                        // Làm mới dữ liệu
                        tbaCTPN.Update(DS.CTPN);
                        tbaCTPN.Fill(DS.CTPN);
                        dgvCTPN.Refresh();
                        // Trở lại vị trí trước khi xóa
                        bdsCTPN.Position = viTri;
                        // Bật/tắt theo số lượng CTPN
                        if (bdsCTPN.Count == 0)
                            btnXoa.Enabled = btnSua.Enabled = false;
                        else
                            btnXoa.Enabled = btnSua.Enabled = true;
                        // Thông báo
                        MessageBox.Show("Xóa chi tiết phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    catch (Exception ex)
                    {
                        // Làm mới dữ liệu
                        tbaCTPN.Fill(DS.CTPN);
                        // Trở lại vị trí trước khi xóa
                        bdsCTPN.Position = viTri;
                        // thông báo
                        MessageBox.Show("Lỗi xóa chi tiết phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
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
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnCheDo.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            
            if (mode == true) // Chế độ Phiếu nhập
            {
                gbCTPN.Enabled = gcPhieuNhap.Enabled = false;
                gbPhieuNhap.Enabled = dtpNgay.Enabled = true;
                txtMaPN.Enabled = cbbTenKho.Enabled = txtMaDDH.Enabled = btnDDH.Enabled = btnHuyDDH.Enabled = false;
            }
            else // Chế độ Chi tiết phiếu nhập
            {
                gbCTPN.Enabled = true;
                gbPhieuNhap.Enabled = gcPhieuNhap.Enabled = false;
                txtCT_MaPN.Enabled = btnCTDDH.Enabled = btnHuyCTDDH.Enabled = false;
                soLuongGoc = (int)seSoLuong.Value;
                donGiaGoc = float.Parse(txtDonGia.Text);
            }
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KiemTraDuLieuDauVao() == false)
            {
                return;
            }
            else
            {
                if (mode == true) // Chế độ Phiếu nhập
                {
                    if (flag.Equals("them"))
                    {
                        if (CheckMAPN(txtMaPN.Text.Trim(), 1) == 1)
                        {
                            MessageBox.Show("Mã phiếu nhập này đã tồn tại trên hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        } 
                        else
                        {
                            if (MessageBox.Show("Bạn muốn thêm phiếu nhập mới vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                try
                                {
                                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                                    btnGhi.Enabled = btnUndo.Enabled = false;
                                    gcPhieuNhap.Enabled = true;
                                    gbPhieuNhap.Enabled = false;
                                    flag = "";
                                    // Thêm dữ liệu
                                    bdsPhieuNhap.EndEdit();
                                    tbaPhieuNhap.Update(DS.PhieuNhap);
                                    // Tạo danh sách các CTPN + Cập nhật số lượng vật tư
                                    InsertDDH(txtMaDDH.Text.Trim(), txtMaPN.Text);
                                    tbaPhieuNhap.Fill(DS.PhieuNhap);
                                    tbaCTPN.Fill(DS.CTPN);
                                    gcPhieuNhap.Refresh();
                                    dgvCTPN.Refresh();
                                    bdsPhieuNhap.Position = viTri;
                                    if (SoSanhMaNV() == false)
                                        btnXoa.Enabled = btnSua.Enabled = false;
                                    else
                                        btnXoa.Enabled = btnSua.Enabled = true;

                                    MessageBox.Show("Thêm phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    bdsPhieuNhap.RemoveCurrent();
                                    MessageBox.Show("Thêm phiếu nhập thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else if (flag.Equals("sua"))
                    {
                        if (MessageBox.Show("Bạn muốn cập nhật thông tin mới của phiếu nhập vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                // Bật tắt các nút
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                                gcPhieuNhap.Enabled = true;
                                btnGhi.Enabled = gbPhieuNhap.Enabled = gbCTPN.Enabled = btnUndo.Enabled = false;
                                // Thêm dữ liệu
                                bdsPhieuNhap.EndEdit();
                                tbaPhieuNhap.Update(DS.PhieuNhap);
                                // Làm mới
                                tbaPhieuNhap.Fill(DS.PhieuNhap);
                                gcPhieuNhap.Refresh();
                                /*cập nhật lại trạng thái cờ*/
                                flag = "";
                                bdsPhieuNhap.Position = viTri;
                                MessageBox.Show("Cập nhật thông tin phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK);
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
                else // Chế độ chi tiết phiếu nhập
                {
                    if (flag.Equals("them"))
                    {
                        if (MessageBox.Show("Bạn muốn thêm chi tiết phiếu nhập mới vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                // Bật tắt
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                                btnGhi.Enabled = btnUndo.Enabled = false;
                                gcPhieuNhap.Enabled = dgvCTPN.Enabled = true;
                                gbPhieuNhap.Enabled = gbCTPN.Enabled = false;
                                flag = "";
                                // Thêm dữ liệu
                                bdsCTPN.EndEdit();
                                // Cập nhật số lượng vật tư trên hệ thống
                                int soLuong = (int)seSoLuong.Value;
                                float donGia = float.Parse(txtDonGia.Text);
                                Program.CapNhatSoLuongVatTu("IMPORT", txtMaVT.Text, soLuong);
                                // Làm mới
                                tbaCTPN.Update(DS.CTPN);
                                tbaCTPN.Fill(DS.CTPN);
                                dgvCTPN.Refresh();
                                bdsCTPN.Position = viTri;
                                MessageBox.Show("Thêm chi tiết phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;

                            }
                            catch (Exception ex)
                            {
                                bdsCTPN.RemoveCurrent();
                                MessageBox.Show("Thêm chi tiết phiếu nhập thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (flag.Equals("sua"))
                    {
                        int soLuongMoi = (int)seSoLuong.Value;
                        string maVatTu = txtMaVT.Text;
                        if (MessageBox.Show("Bạn muốn cập nhật dữ liệu mới của Chi tiết phiếu nhập vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                // Bật tắt các nút
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                                gcPhieuNhap.Enabled = true;
                                btnUndo.Enabled = btnGhi.Enabled = gbPhieuNhap.Enabled = gbCTPN.Enabled = false;
                                // Thêm dữ liệu
                                bdsCTPN.EndEdit();
                                tbaCTPN.Update(DS.CTPN);
                                tbaCTPN.Fill(DS.CTPN);
                                gcPhieuNhap.Enabled = true;
                                /*cập nhật lại trạng thái cờ*/
                                flag = "";
                                MessageBox.Show("Cập nhật thông tin Chi tiết phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK);
                                int chenhLech = soLuongGoc - soLuongMoi;
                                // Cập nhật số lượng vật tư
                                Program.CapNhatSoLuongVatTu("EXPORT", maVatTu, chenhLech);
                                // Làm mới
                                tbaCTPN.Fill(DS.CTPN);
                                dgvCTPN.Refresh();
                                bdsCTPN.Position = viTri;
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


        private void BtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag.Equals("them"))
            {
                if (MessageBox.Show("Bạn muốn hủy thao tác thêm mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (mode == true) // Đang ở trạng thái thêm ĐƠN ĐẶT HÀNG
                    {
                        bdsPhieuNhap.CancelEdit();
                    }
                    else // Đang ở trạng thái thêm CHI TIẾT ĐƠN ĐẶT HÀNG
                    {
                        bdsCTPN.CancelEdit();
                    }
                    /* trở về lúc đầu con trỏ đang đứng*/
                    bdsPhieuNhap.Position = viTri;
                    btnUndo.Enabled = false;
                    if (SoSanhMaNV() == false)
                    {
                        btnXoa.Enabled = btnSua.Enabled = false;
                    }
                    else
                    {
                        btnXoa.Enabled = btnSua.Enabled = true;
                    }
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                    btnGhi.Enabled = gbCTPN.Enabled = gbCTPN.Enabled = false;
                    gcPhieuNhap.Enabled = dgvCTPN.Enabled = true;
                }
                else
                {
                    return;
                }

            }
            else if (flag.Equals("sua"))
            {
                if (MessageBox.Show("Bạn muốn hủy thao tác cập nhật mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (mode == true) // Đang ở trạng thái thêm ĐƠN ĐẶT HÀNG
                    {
                        bdsPhieuNhap.CancelEdit();
                    }
                    else // Đang ở trạng thái thêm CHI TIẾT ĐƠN ĐẶT HÀNG
                    {
                        bdsCTPN.CancelEdit();
                    }
                    btnUndo.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                    btnGhi.Enabled = gbCTPN.Enabled = gbCTPN.Enabled = false;
                    gcPhieuNhap.Enabled = dgvCTPN.Enabled = true;
                }
                else
                {
                    return;
                }

            }

        }
        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // Đổ dữ liệu mới vào lại DataSet
                tbaPhieuNhap.Fill(DS.PhieuNhap);
                gcPhieuNhap.Enabled = true;
                gcPhieuNhap.Refresh();

                // Đổ dữ liệu mới vào lại DataSet
                tbaCTPN.Fill(DS.CTPN);
                dgvCTPN.Enabled = true;
                dgvCTPN.Refresh();
                if (SoSanhMaNV() == false)
                {
                    btnXoa.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
        }

        private void BtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!flag.Equals(""))
            {
                if (MessageBox.Show("Bạn muốn thoát mà chưa lưu dữ liệu?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (mode == true)
                    {
                        bdsPhieuNhap.CancelEdit();
                    }
                    else
                    {
                        bdsCTPN.CancelEdit();
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
            }
        }

        private bool KiemTraDuLieuDauVao()
        {
            if (mode == true)
            {
                if (txtMaPN.Text.Equals(""))
                {
                    MessageBox.Show("Mã phiếu nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPN.Focus();
                    return false;
                }
                else if (txtMaPN.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu nhập chỉ cho phép 8 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaPN.Focus();
                    return false;
                }
                else if (!Regex.IsMatch(txtMaPN.Text, @"^[a-zA-Z0-9\s]+$"))
                {
                    MessageBox.Show("Mã phiếu nhập chỉ bao gồm chữ cái và số", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtMaPN.Focus();
                    return false;
                }
                else if (cbbMaCN.Text.Equals("") || txtMaKho.Text.Equals(""))
                {
                    MessageBox.Show("Thông tin kho không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbbTenKho.Focus();
                    return false;
                }
                else if (txtMaDDH.Text.Equals(""))
                {
                    MessageBox.Show("Mã đơn đặt hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FormDanhSachDonDatHangChuaCoPhieuNhap danhSachDonDatHangChuaCoPhieuNhap = Application.OpenForms.OfType<FormDanhSachDonDatHangChuaCoPhieuNhap>().FirstOrDefault();
                    if (danhSachDonDatHangChuaCoPhieuNhap != null)
                        danhSachDonDatHangChuaCoPhieuNhap.Activate();
                    else
                    {
                        FormDanhSachDonDatHangChuaCoPhieuNhap datHangChuaCoPhieuNhap = new FormDanhSachDonDatHangChuaCoPhieuNhap();
                        datHangChuaCoPhieuNhap.Show();
                    }
                    txtMaPN.Focus();
                    return false;
                }
                else if (KiemTraNgayDat(dtpNgay.DateTime, txtMaDDH.Text) == false)
                {
                    dtpNgay.Focus();
                    return false;
                }
            }
            else
            {
                if (KiemTraSoLuongThayDoi(txtMaDDH.Text, txtMaVT.Text, (int)seSoLuong.Value) == 1)
                {
                    MessageBox.Show("Số lượng vật tư trong chi tiết phiếu nhập không được lớn hơn số lượng vật tư trong chi tiết đơn đặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    seSoLuong.EditValue = soLuongGoc;
                    seSoLuong.Focus();
                    return false;
                }
                else if ((int)seSoLuong.Value <= 0)
                {
                    MessageBox.Show("Số lượng vật tư phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    seSoLuong.Focus();
                    return false;
                }
                else if (float.Parse(txtDonGia.Text) <= 10000)
                {
                    MessageBox.Show("Đơn giá phải lớn hơn 10.000", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonGia.Focus();
                    return false;
                }
            }
            return true;
        }

        private int KiemTraSoLuongThayDoi(string maDDH, string maVT, int soLuong)
        {

            try
            {
                string cauTruyVanKiemTra = "DECLARE @RESULT int " + "EXEC @RESULT = [dbo].[sp_soSanhSoLuongCTPN_CTDDH] '" + maDDH + "', '" + maVT + "', " + soLuong + " SELECT 'Value' = @RESULT";
                Console.WriteLine(cauTruyVanKiemTra);
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
        private bool KiemTraNgayDat(DateTime date, string maDDH)
        {

            string cautruyVankiemTra = "DECLARE @result int " + "EXEC @result = [dbo].[sp_kiemTraNgayPhieuNhapVaDonDH] '" + date.ToString("yyyy-MM-dd") + "',  '" + maDDH + "' " + "SELECT 'Value' = @result";
            Program.sqlDataReader = Program.ExecSqlDataReader(cautruyVankiemTra);
            Program.sqlDataReader.Read();
            int result = int.Parse(Program.sqlDataReader.GetValue(0).ToString());
            Program.sqlDataReader.Close();
            if (result == 1)
            {
                MessageBox.Show("Ngày nhập phải lớn hơn ngày đặt hàng. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormDanhSachDonDatHangChuaCoPhieuNhap danhSachDonDatHangChuaCoPhieuNhap = Application.OpenForms.OfType<FormDanhSachDonDatHangChuaCoPhieuNhap>().FirstOrDefault();
                if (danhSachDonDatHangChuaCoPhieuNhap != null)
                    danhSachDonDatHangChuaCoPhieuNhap.Activate();
                else
                {
                    FormDanhSachDonDatHangChuaCoPhieuNhap datHangChuaCoPhieuNhap = new FormDanhSachDonDatHangChuaCoPhieuNhap();
                    datHangChuaCoPhieuNhap.Show();
                }

                return false;
            }
            else
            {
                return true;
            }
        }

        private bool SoSanhMaNV()
        {
            if (bdsPhieuNhap.Count > 0)
            {
                DataRowView drv = (DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position];
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

        private int CheckMAPN(string maPhieuNhap, int lenh)
        {
            string cauTruyVanKiemTra = "";
            if (lenh == 0)
            {
                cauTruyVanKiemTra = "DECLARE @result int " + "EXEC @result = [dbo].[sp_kiemTraXoaPN] '" + maPhieuNhap + "' " + "SELECT 'Value' = @result";
            } if (lenh == 1)
            {
                cauTruyVanKiemTra = "DECLARE @result int " + "EXEC @result = [dbo].[sp_kiemTraMaPhieuNhapThemMoi] '" + maPhieuNhap + "' " + "SELECT 'Value' = @result";
            }
            
            Program.sqlDataReader = Program.ExecSqlDataReader(cauTruyVanKiemTra);
            Program.sqlDataReader.Read();
            int result = int.Parse(Program.sqlDataReader.GetValue(0).ToString());
            Program.sqlDataReader.Close();
            if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void BtnDDH_Click_1(object sender, EventArgs e)
        {
            FormDanhSachDonDatHangChuaCoPhieuNhap danhSachDonDatHangChuaCoPhieuNhap = Application.OpenForms.OfType<FormDanhSachDonDatHangChuaCoPhieuNhap>().FirstOrDefault();
            if (danhSachDonDatHangChuaCoPhieuNhap != null)
                danhSachDonDatHangChuaCoPhieuNhap.Activate();
            else
            {
                FormDanhSachDonDatHangChuaCoPhieuNhap datHangChuaCoPhieuNhap = new FormDanhSachDonDatHangChuaCoPhieuNhap();
                datHangChuaCoPhieuNhap.Show();

                if (datHangChuaCoPhieuNhap.bdsDDH.Count == 0)
                {

                    MessageBox.Show("Không còn Đơn đặt hàng nào chưa tồn tại phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    datHangChuaCoPhieuNhap.Close();
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = btnThoat.Enabled = true;
                    gbCTPN.Enabled = gbPhieuNhap.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
                    gcPhieuNhap.Enabled = dgvCTPN.Enabled = true;
                    bdsPhieuNhap.CancelEdit();
                    return;
                }
            }
        }


        private void BtnCTDDH_Click(object sender, EventArgs e)
        {

            FormDanhSachCTDDHChuaCoCTPN formanhSachCTDDHChuaCoCTPN = Application.OpenForms.OfType<FormDanhSachCTDDHChuaCoCTPN>().FirstOrDefault();
            //Form form = isExists(typeof(FormDanhSachDonDatHangChuaCoPhieuNhap));
            if (formanhSachCTDDHChuaCoCTPN != null)
                formanhSachCTDDHChuaCoCTPN.Activate();
            else
            {
                FormDanhSachCTDDHChuaCoCTPN CTDDHChuaCoCTPN = new FormDanhSachCTDDHChuaCoCTPN();
                CTDDHChuaCoCTPN.txtMaDDH.Text = txtMaDDH.Text;
                CTDDHChuaCoCTPN.Show();
                if (CTDDHChuaCoCTPN.bdsVattu.Count == 0)
                {

                    MessageBox.Show("Không còn Chi tiết Đơn đặt hàng nào chưa tồn tại trong CTPN phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    CTDDHChuaCoCTPN.Close();
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = btnThoat.Enabled = true;
                    gbCTPN.Enabled = dgvCTPN.Enabled = btnUndo.Enabled = false;
                    gcPhieuNhap.Enabled = btnGhi.Enabled = true;
                    bdsCTPN.CancelEdit();
                    return;
                }
            }
        }

        private void BtnHuyDDH_Click_1(object sender, EventArgs e)
        {
            txtMaDDH.Text = "";
            cbbTenKho.SelectedIndex = -1;
            btnDDH.Focus();
            btnHuyDDH.Enabled = false;
            btnDDH.Enabled = true;
        }

        private void BtnHuyCTDDH_Click(object sender, EventArgs e)
        {
            txtTenVT.Text = txtMaVT.Text = "";
            txtDonGia.EditValue = 10000;
            seSoLuong.Value = 0;
            txtTenVT.Enabled = txtMaVT.Enabled = seSoLuong.Enabled = txtDonGia.Enabled = false;
            btnCTDDH.Enabled = true;
        }

        private void GridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                if (bdsCTPN.Count == 0 && mode == false)
                    btnXoa.Enabled = btnSua.Enabled = false;
                else
                    btnXoa.Enabled = btnSua.Enabled = true;
            }
        }

        private void DgvCTPN_SelectionChanged(object sender, EventArgs e)
        {
            if (bdsCTPN.Count > 0)
            {

                int rowIndex = bdsCTPN.Position;
                if (rowIndex >= 0 && rowIndex < dgvCTPN.Rows.Count)
                {
                    if (dgvCTPN.Rows[rowIndex].Cells["cbbTenVT"] is DataGridViewComboBoxCell comboBoxCell)
                    {
                        if (comboBoxCell.Value == null)
                        {
                            txtTenVT.Text = "";
                        }
                        string selectedValue = comboBoxCell.Value.ToString();
                        if (comboBoxCell.Items.Count > 0)
                        {
                            DataRowView selectedRow = comboBoxCell.Items.Cast<DataRowView>().FirstOrDefault(item => item.Row["MAVT"].ToString() == selectedValue);
                            if (selectedRow != null)
                            {
                                string TenVT = selectedRow["TENVT"].ToString();
                                txtTenVT.Text = TenVT;
                            }
                        }
                        else
                        {
                            txtTenVT.Text = "";
                        }
                    }
                }
                else
                {
                    txtTenVT.Text = "";
                }

            }
            else
            {
                txtTenVT.Text = "";
            }
        }

        private void InsertDDH(string maDDH, string maPN)
        {
            if (Program.sqlConnection != null && Program.sqlConnection.State == System.Data.ConnectionState.Open)
            {
                Program.sqlConnection.Close();
            }
            try
            {
                Program.sqlConnection.Open();
                SqlCommand command = new SqlCommand("sp_VTNotInCTPN", Program.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MasoDDH", maDDH);
                Console.WriteLine(maDDH);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(DS.sp_VTNotInCTPN);

                Console.WriteLine(bdsVattuChuaCoPhieuNhap.Count);
                if (bdsVattuChuaCoPhieuNhap.Count > 0)
                {                   
                    for (int i = 0; i < bdsVattuChuaCoPhieuNhap.Count; i++)
                    {
                        DataRowView rowView = (DataRowView)bdsVattuChuaCoPhieuNhap[i];
                        int soLuong = Convert.ToInt32(rowView["SOLUONG"]);
                        float donGia = (float)Convert.ToDecimal(rowView["DONGIA"]);
                        string maVT = rowView["MAVT"].ToString();
                        string cauTruyVan = "EXEC [dbo].[sp_tangSoLuongVattu] N'" + maPN + "',  N'" + maVT + "', " + soLuong + ", " + donGia;
                        Console.WriteLine(cauTruyVan);
                        Program.ExecSqlNonQuery(cauTruyVan);
                        dgvCTPN.Refresh();
                        tbaCTPN.Fill(DS.CTPN);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối Cơ sở dữ liệu" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void CbbTenKho_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbTenKho.SelectedIndex == -1)
            {
                txtMaKho.Text = "";
                return;
            }
            else
            {
                txtMaKho.Text = cbbTenKho.SelectedValue.ToString();
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
                txtMaNV.Text = cbbTenNV.SelectedValue.ToString();
            }
        }
    }
}