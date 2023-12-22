using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDonDatHang : DevExpress.XtraEditors.XtraForm
    {
        int viTri = 0;
        string flag = "";
        bool mode = true;
        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            /*Tắt kiểm tra khóa ngoại*/
            DS.EnforceConstraints = false;

            tbaDatHang.Connection.ConnectionString = Program.connectString;
            tbaDatHang.Fill(DS.DatHang);

            tbaTenVT.Connection.ConnectionString = Program.connectString;
            tbaTenVT.Fill(DS.TenVatTu);

            tbaCTDDH.Connection.ConnectionString = Program.connectString;
            tbaCTDDH.Fill(DS.CTDDH);

            tbaPhieuNhap.Connection.ConnectionString = Program.connectString;
            tbaPhieuNhap.Fill(DS.PhieuNhap);

            tbaKho.Connection.ConnectionString = Program.connectString;
            tbaKho.Fill(DS.Kho);

            tbaHoTen.Connection.ConnectionString = Program.connectString;
            tbaHoTen.Fill(DS.HoTen);

            tbaTenKho.Connection.ConnectionString = Program.connectString;
            tbaTenKho.Fill(DS.TenKho);

            /* Load lại dữ liệu để các combobox Nhân viên, kho được cập nhật chính xác */
            tbaDatHang.Fill(DS.DatHang);
            gcDatHang.Refresh();
            tbaCTDDH.Fill(DS.CTDDH);
            dgvCTDDH.Refresh();

            /* Đổ dữ liệu cho combobox Chi nhánh */
            cbbMaCN.DataSource = Program.bindingSource_listBranch;
            cbbMaCN.DisplayMember = "TENCN";
            cbbMaCN.ValueMember = "TENSERVER";
            cbbMaCN.SelectedIndex = Program.mBranch;

            /*Bật tắt*/
            gbDDH.Enabled = gbCTDDH.Enabled = false;
            gcDatHang.Enabled = dgvCTDDH.Enabled = true;
            cbbMaCN.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;

            mode = true;
            btnCheDo.Caption = "Chi tiết Đơn đặt hàng";

            /* Phân quyền cho Role CongTy */
            if (Program.mRole == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnCheDo.Enabled = false;
                btnRefresh.Enabled = btnThoat.Enabled = true;
                cbbMaCN.Enabled = true;
                gcNhapLieu.Enabled = false;
            }
            if ((mode == true & bdsDatHang.Count == 0) || (mode == false & bdsCTDDH.Count == 0))
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

                tbaDatHang.Connection.ConnectionString = Program.connectString;
                tbaDatHang.Fill(DS.DatHang);

                tbaTenVT.Connection.ConnectionString = Program.connectString;
                tbaTenVT.Fill(DS.TenVatTu);

                tbaCTDDH.Connection.ConnectionString = Program.connectString;
                tbaCTDDH.Fill(DS.CTDDH);

                tbaPhieuNhap.Connection.ConnectionString = Program.connectString;
                tbaPhieuNhap.Fill(DS.PhieuNhap);

                tbaKho.Connection.ConnectionString = Program.connectString;
                tbaKho.Fill(DS.Kho);

                tbaHoTen.Connection.ConnectionString = Program.connectString;
                tbaHoTen.Fill(DS.HoTen);

                tbaTenKho.Connection.ConnectionString = Program.connectString;
                tbaTenKho.Fill(DS.TenKho);

                /* Load lại dữ liệu để các combobox Nhân viên, kho được cập nhật chính xác */
                tbaDatHang.Fill(DS.DatHang);
                gcDatHang.Refresh();
                tbaCTDDH.Fill(DS.CTDDH);
                dgvCTDDH.Refresh();

                btnSua.Enabled = btnXoa.Enabled = btnCheDo.Enabled = false;
            }
        }

        private void BtnCheDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode == true)
            {
                // mode = false là mode "Chi tiết Đơn đặt hàng"
                mode = false;
                btnCheDo.Caption = "Đơn đặt hàng";

                // Bật tắt
                gbDDH.Enabled = false;

                if (bdsCTDDH.Count == 0)
                    btnXoa.Enabled = btnSua.Enabled = false;
                else
                    btnXoa.Enabled = btnSua.Enabled = true;
            }
            else
            {
                mode = true;
                btnCheDo.Caption = "Chi tiết Đơn đặt hàng";

                gbCTDDH.Enabled = false;
                if (SoSanhMaNV() == false)
                {
                    btnXoa.Enabled = btnSua.Enabled = btnCheDo.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = btnSua.Enabled = btnCheDo.Enabled = true;
                }
                if (SoSanhMaNV() == true && bdsDatHang.Count > 0)
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
            if (mode == true) // Chế độ "Đơn đặt hàng"
            {
                // bật tắt khu vực thao tác
                gbDDH.Enabled = txtMaDDH.Enabled = true;
                gcDatHang.Enabled = gbCTDDH.Enabled = false;
                // Lấy vị trí phục vụ undo
                viTri = bdsDatHang.Position;
                //thêm mới
                bdsDatHang.AddNew();
                // Thời gian mặc định là ngày hôm nay
                dtpNgayDat.EditValue = DateTime.Now;
                // Nhân viên tạo phải là nhân viên đăng nhập
                cbbTenNV.Text = Program.mFullName + " - " + Program.userName;
                txtMaNV.Text = Program.userName;
                // Xử lý lỗi logic không cho txtVattu có giá trị
                txtVatTu.Text = "";
                // Bật vì nếu trước đó thao tác sửa sẽ bị tắt
                txtMaDDH.Enabled = true;               
            }
            else // chế độ "Chi tiết đơn đặt hàng"
            {
                viTri = bdsCTDDH.Position;
                // bật tắt
                gbCTDDH.Enabled = true;
                bdsCTDDH.AddNew();
                txtCT_MaDDH.Text = txtMaDDH.Text;
                // Mặc định số lượng là 1
                seSoLuong.EditValue = 1;
                gcDatHang.Enabled = dgvCTDDH.Enabled = false;
                // Xử lý lỗi logic không cho txtVattu có giá trị
                txtVatTu.Text = "";
                btnHuyVattu.Enabled = false;
                /*}*/
            }
        }

        private void BtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode == true) // Mode "Đơn đặt hàng"
            {
                if (bdsCTDDH.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng vì đang tồn tại chi tiết đơn đặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (bdsPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng vì đang tồn tại trong phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa đơn đặt hàng này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        viTri = bdsDatHang.Position;
                        try
                        {
                            // Xóa dòng hiện tại
                            bdsDatHang.RemoveCurrent();
                            // Làm mới dữ liệu
                            tbaDatHang.Update(DS.DatHang);
                            tbaDatHang.Fill(DS.DatHang);
                            gcDatHang.Refresh();
                            // Trở lại vị trí trước khi xóa
                            bdsDatHang.Position = viTri;
                            // Bật/tắt nút Xóa và Sửa theo số lượng Đơn đặt hàng
                            if (bdsDatHang.Count == 0 || SoSanhMaNV() == false)
                                btnXoa.Enabled = btnSua.Enabled = false;
                            else
                                btnXoa.Enabled = btnSua.Enabled = true;
                            // Thông báo
                            MessageBox.Show("Xóa đơn đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        catch (Exception ex)
                        {
                            // Làm mới dữ liệu
                            tbaDatHang.Fill(DS.DatHang);
                            // Trở lại vị trí trước khi xóa
                            bdsDatHang.Position = viTri;
                            // Thông báo
                            MessageBox.Show("Xóa đơn đặt hàng thất bại!\n Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                /*}*/
            }
            else // mode "Chi tiết đơn đặt hàng"
            {
                if (KiemTraDieuKien(2) == 1)
                {
                    MessageBox.Show("Không xóa Chi tiết đơn đặt hàng đã được lập Chi tiết phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa chi tiết đơn đặt hàng này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        viTri = bdsCTDDH.Position;
                        try
                        {
                            // Xóa dòng hiện tại
                            bdsCTDDH.RemoveCurrent();
                            // Làm mới dữ liệu
                            tbaCTDDH.Update(DS.CTDDH);
                            tbaCTDDH.Fill(DS.CTDDH);
                            dgvCTDDH.Refresh();
                            // Trở lại vị trí trước khi xóa
                            bdsCTDDH.Position = viTri;
                            // Bật/tắt nút Xóa và Sửa theo số lượng Đơn đặt hàng
                            if (bdsCTDDH.Count == 0)
                                btnXoa.Enabled = btnSua.Enabled = false;
                            else
                                btnXoa.Enabled = btnSua.Enabled = true;
                            // Thông báo
                            MessageBox.Show("Xóa chi tiết đơn đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        catch (Exception ex)
                        {
                            // Làm mới dữ liệu
                            tbaCTDDH.Fill(DS.CTDDH);
                            // Trở lại vị trí trước khi xóa
                            bdsCTDDH.Position = viTri;
                            // Thông báo
                            MessageBox.Show("Lỗi xóa chi tiết đơn đặt hàng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Cập nhật giá trị biến cờ
            flag = "sua";
            //bật tắt các nút
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnCheDo.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = btnThoat.Enabled = true;
            if (mode == true)
            {
                viTri = bdsDatHang.Position;
                // bật tắt
                gcDatHang.Enabled = gbCTDDH.Enabled = false;
                gbDDH.Enabled = true;
                // Không cho chỉnh sửa mã DDH và nhân viên
                txtMaDDH.Enabled = txtMaNV.Enabled = cbbTenNV.Enabled = false;
                /*}*/
            }
            else
            {
                viTri = bdsCTDDH.Position;
                // bật tắt
                gbCTDDH.Enabled = true;
                dgvCTDDH.Enabled = false;
                txtCT_MaDDH.Enabled = txtMaVT.Enabled = txtVatTu.Enabled = false;
                gbDDH.Enabled = btnVattu.Enabled = btnHuyVattu.Enabled = false;
            }
        }

        private void BtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            else
            {
                if (mode == true)
                {
                    if (flag.Equals("them"))
                    {
                        if (KiemTraDieuKien(1) == 1)
                        {
                            MessageBox.Show("Mã Đơn đặt hàng đã tồn tại trên hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaDDH.Focus();
                            return;
                        }
                        else
                        {
                            if (MessageBox.Show("Bạn muốn thêm đơn đặt hàng mới vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                try
                                {
                                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = btnCheDo.Enabled = true;
                                    btnGhi.Enabled = btnUndo.Enabled = false;
                                    gcDatHang.Enabled = true;
                                    gbDDH.Enabled = false;
                                    /* Lưu dữ liệu thêm mới vào hệ thống */
                                    // Thêm dữ liệu
                                    bdsDatHang.EndEdit();
                                    tbaDatHang.Update(DS.DatHang);
                                    // Làm mới
                                    tbaDatHang.Fill(DS.DatHang);
                                    gcDatHang.Refresh();
                                    /*cập nhật lại trạng thái cờ*/
                                    flag = "";
                                    // trở lại vị trí cũ
                                    bdsDatHang.Position = viTri;
                                    if (SoSanhMaNV() == false)
                                        btnXoa.Enabled = btnSua.Enabled = false;
                                    else
                                        btnXoa.Enabled = btnSua.Enabled = true;
                                    MessageBox.Show("Thêm đơn đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    bdsDatHang.RemoveCurrent();
                                    MessageBox.Show("Thêm đơn đặt hàng thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                return;
                            }
                        }

                    }

                    if (flag.Equals("sua"))
                    {
                        if (MessageBox.Show("Bạn muốn cập nhật thông tin mới của đơn đặt hàng vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                // Bật tắt các nút
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = btnCheDo.Enabled = true;
                                gcDatHang.Enabled = true;
                                btnUndo.Enabled = btnGhi.Enabled = gbDDH.Enabled = gbCTDDH.Enabled = false;
                                // Thêm dữ liệu
                                bdsDatHang.EndEdit();
                                tbaDatHang.Update(DS.DatHang);
                                // Làm mới
                                tbaDatHang.Fill(DS.DatHang);
                                gcDatHang.Refresh();
                                /*cập nhật lại trạng thái cờ*/
                                flag = "";
                                // Trở lại vị trí cũ
                                bdsDatHang.Position = viTri;
                                MessageBox.Show("Cập nhật thông tin đơn đặt hàng thành công", "Thông báo", MessageBoxButtons.OK);
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
                else // Chế độ "Chi tiết đơn đặt hàng"
                {
                    if (flag.Equals("them"))
                    {
                        if (MessageBox.Show("Bạn muốn thêm chi tiết đơn đặt hàng mới vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                // Bật tắt
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = btnCheDo.Enabled = true;
                                btnUndo.Enabled = btnGhi.Enabled = false;
                                gcDatHang.Enabled = dgvCTDDH.Enabled = true;
                                gbDDH.Enabled = gbCTDDH.Enabled = false;
                                // Thêm dữ liệu
                                bdsCTDDH.EndEdit();
                                tbaCTDDH.Update(DS.CTDDH);
                                // Làm mới
                                tbaCTDDH.Fill(DS.CTDDH);
                                dgvCTDDH.Refresh();
                                /*cập nhật lại trạng thái cờ*/
                                flag = "";
                                bdsCTDDH.Position = viTri;
                                MessageBox.Show("Thêm chi tiết đơn đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                bdsCTDDH.RemoveCurrent();
                                MessageBox.Show("Thêm chi tiết đơn đặt hàng thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    if (flag.Equals("sua"))
                    {
                        if (MessageBox.Show("Bạn muốn cập nhật thông tin mới của chi tiết đơn đặt hàng này vào hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                // Bật tắt các nút
                                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                                gcDatHang.Enabled = true;
                                btnUndo.Enabled = btnGhi.Enabled = gbDDH.Enabled = gbCTDDH.Enabled = false;
                                // Thêm dữ liệu
                                bdsCTDDH.EndEdit();
                                tbaCTDDH.Update(DS.CTDDH);
                                // Làm mới
                                tbaCTDDH.Fill(DS.CTDDH);
                                dgvCTDDH.Refresh();
                                gcDatHang.Enabled = true;
                                /*cập nhật lại trạng thái cờ*/
                                flag = "";
                                bdsCTDDH.Position = viTri;
                                MessageBox.Show("Cập nhật thông tin chi tiết đơn đặt hàng thành công", "Thông báo", MessageBoxButtons.OK);
                                return;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Cập nhật thông tin chi tiết đơn đặt hàng thất bại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void BtnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Nếu cờ đang ở trạng thái thêm */
            if (flag.Equals("them") && btnThem.Enabled == false)
            {
                if (MessageBox.Show("Bạn muốn hủy thao tác thêm mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                    btnGhi.Enabled = btnUndo.Enabled = gbDDH.Enabled = gbCTDDH.Enabled = false;
                    gcDatHang.Enabled = dgvCTDDH.Enabled = true;
                    if (mode == true) // Đang ở trạng thái thêm ĐƠN ĐẶT HÀNG
                    {
                        bdsDatHang.CancelEdit();
                    }
                    else // Đang ở trạng thái thêm CHI TIẾT ĐƠN ĐẶT HÀNG
                    {
                        bdsCTDDH.CancelEdit();
                    }
                    /* trở về lúc đầu con trỏ đang đứng*/
                    bdsDatHang.Position = viTri;
                }
                else
                {
                    return;
                }

            }
            /* Nếu cờ đang ở trạng thái sửa */
            else if (flag.Equals("sua") && btnSua.Enabled == false)
            {
                if (MessageBox.Show("Bạn muốn hủy thao tác cập nhật mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = true;
                    gcDatHang.Enabled = dgvCTDDH.Enabled = true;
                    btnGhi.Enabled = btnUndo.Enabled = gbDDH.Enabled = gbCTDDH.Enabled = false;
                    if (mode == true) // Đang ở trạng thái sửa ĐƠN ĐẶT HÀNG
                    {
                        bdsDatHang.CancelEdit();
                    }
                    else // Đang ở trạng thái sửa CHI TIẾT ĐƠN ĐẶT HÀNG
                    {
                        bdsCTDDH.CancelEdit();
                    }
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
                tbaDatHang.Fill(DS.DatHang);
                gcDatHang.Refresh();
                // Đổ dữ liệu mới vào lại DataSet

                gcDatHang.Enabled = true;

                tbaCTDDH.Fill(DS.CTDDH);
                dgvCTDDH.Refresh();
                // Đổ dữ liệu mới vào lại DataSet

                dgvCTDDH.Enabled = true;
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
                    if (mode == true)
                    {
                        bdsDatHang.CancelEdit();
                    }
                    else
                    {
                        bdsCTDDH.CancelEdit();
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

        private bool SoSanhMaNV()
        {
            if (bdsDatHang.Count > 0)
            {
                DataRowView drv = (DataRowView)bdsDatHang[bdsDatHang.Position];
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

        private bool KiemTraDuLieuNhap()
        {
            if (mode == true) // Nếu mode là "Đơn đặt hàng"
            {
                if (txtMaDDH.Text.Equals(""))
                {
                    MessageBox.Show("Mã Đơn đặt hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDDH.Focus();
                    return false;
                }
                else if (txtMaDDH.Text.Length > 8)
                {
                    MessageBox.Show("Mã Đơn đặt hàng chỉ bao gồm 8 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDDH.Focus();
                    return false;
                }
                else if (!Regex.IsMatch(txtMaDDH.Text, @"^[A-Z0-9\s]+$"))
                {
                    MessageBox.Show("Mã Đơn đặt hàng chỉ bao gồm chữ cái IN HOA, số và có thể có khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaDDH.Focus();
                    return false;
                }
                else if ((KiemTraNgayDat(dtpNgayDat.DateTime) == false))
                {
                    dtpNgayDat.Focus();
                    return false;
                }
                else if (txtNhaCC.Text.Equals(""))
                {
                    MessageBox.Show("Nhà cung cấp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNhaCC.Focus();
                    return false;
                }
                else if (txtNhaCC.Text.Length > 100)
                {
                    MessageBox.Show("Nhà cung cấp không được quá 100 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNhaCC.Focus();
                    return false;
                }
                else if (Regex.IsMatch(txtNhaCC.Text, @"[^A-Za-z0-9,/\.\sÀ-Ỹà-ỹ]"))
                {
                    MessageBox.Show("Nhà cung cấp không chứa các kí tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNhaCC.Focus();
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
                if (txtVatTu.Text.Equals("") || txtMaVT.Text.Equals(""))
                {
                    MessageBox.Show("Vật tư không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnVattu.Focus();
                    return false;
                }
                else if (txtDonGia.Text.Equals(""))
                {
                    MessageBox.Show("Đơn giá không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonGia.Focus();
                    return false;
                }
                else if ((int)seSoLuong.Value <= 0)
                {
                    MessageBox.Show("Số lượng đặt phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    seSoLuong.Focus();
                    seSoLuong.Value = 1;
                    return false;
                }
            }
            return true;
        }

        private bool KiemTraNgayDat(DateTime ngayDat)
        {

            if (ngayDat > DateTime.Now.AddDays(14))
            {
                MessageBox.Show("Ngày đặt không được quá xa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private int KiemTraDieuKien(int lenh)
        {
            string cauTruyVanKiemTra = "";
            if (lenh == 1)
            {
                cauTruyVanKiemTra = "DECLARE @result int " + "EXEC @result = [dbo].[sp_kiemTraMaSoDHHThemMoi] '" + txtMaDDH.Text.Trim() + "' " + "SELECT 'Value' = @result";
            }
            else if (lenh == 2)
            {
                cauTruyVanKiemTra = "DECLARE @RESULT int " + "EXEC @RESULT = [dbo].[sp_kiemTraDieuKienXoaCTDDH] '" + txtMaDDH.Text.Trim() + "', '" + txtMaVT.Text.Trim() + "' SELECT 'Value' = @RESULT";
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
                if (bdsCTDDH.Count == 0 && mode == false)
                    btnXoa.Enabled = btnSua.Enabled = false;
                else
                    btnXoa.Enabled = btnSua.Enabled = true;
            }
        }

        private void BtnVattu_Click(object sender, EventArgs e)
        {
            FormDanhSachVatTuChuaCoCTDDH formDanhSachVatTuChuaCoCTDDH = Application.OpenForms.OfType<FormDanhSachVatTuChuaCoCTDDH>().FirstOrDefault();
            //Form form = isExists(typeof(FormDanhSachDonDatHangChuaCoPhieuNhap));
            if (formDanhSachVatTuChuaCoCTDDH != null)
                formDanhSachVatTuChuaCoCTDDH.Activate();
            else
            {
                FormDanhSachVatTuChuaCoCTDDH danhSachVatTuChuaCoCTDDH = new FormDanhSachVatTuChuaCoCTDDH();
                danhSachVatTuChuaCoCTDDH.txtMaDDH.Text = txtMaDDH.Text;
                danhSachVatTuChuaCoCTDDH.Show();
                if (danhSachVatTuChuaCoCTDDH.bdsVattu.Count == 0)
                {

                    MessageBox.Show("Không còn Vật tư nào chưa tồn tại trong Chi tiết Đơn đặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    danhSachVatTuChuaCoCTDDH.Close();
                    flag = "";
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnCheDo.Enabled = btnThoat.Enabled = btnUndo.Enabled = true;
                    gbCTDDH.Enabled = dgvCTDDH.Enabled = false;
                    gcDatHang.Enabled = btnGhi.Enabled = true;
                    btnHuyVattu.Enabled = false;
                    btnVattu.Enabled = true;
                    bdsCTDDH.CancelEdit();
                    return;
                }
            }
        }

        private void BtnHuyVattu_Click(object sender, EventArgs e)
        {
            txtMaVT.Text = "";
            txtVatTu.Text = "";
            seSoLuong.Value = 1;
            txtDonGia.EditValue = 10000;
            btnHuyVattu.Enabled = false;
        }

        private void DgvCTDDH_SelectionChanged(object sender, EventArgs e)
        {
            if (bdsCTDDH.Count > 0)
            {
                int rowIndex = bdsCTDDH.Position;

                if (dgvCTDDH.Rows[rowIndex].Cells["cbbTenVT"] is DataGridViewComboBoxCell comboBoxCell)
                {
                    if (comboBoxCell.Value == null)
                    {
                        txtVatTu.Text = "";
                    }
                    string selectedValue = comboBoxCell.Value.ToString();
                    DataRowView selectedRow = comboBoxCell.Items.Cast<DataRowView>().FirstOrDefault(item => item.Row["MAVT"].ToString() == selectedValue);

                    if (selectedRow != null)
                    {
                        string TenVT = selectedRow["TENVT"].ToString();
                        txtVatTu.Text = TenVT;
                    }
                }
            }
            else
            {
                txtVatTu.Text = "";
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