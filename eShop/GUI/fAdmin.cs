using eShop.Chung;
using eShop.DAO;
using eShop.From;
using eShop.Models;
using static eShop.Common.Enums;

namespace eShop.GUI
{
    public partial class fAdmin : Form
    {
        private readonly int _maNguoiDung = 0;
        public fAdmin(int maNguoiDung = 0)
        {
            InitializeComponent();
            // Tab sản phẩm (mặc định load đầu tiên)
            tabSanPham.Focus();
            LamMoiSanPham();
            _maNguoiDung = maNguoiDung;
        }

        #region Functions

        #region Tab Sản Phẩm

        public void HienThiDsSanPham(string? timKiem = null)
        {
            var danhSachSanPham = SanPhamDAO.Instance.LayDsSanPham(timKiem, isAdmin: true);
            lvSanPham.Items.Clear();
            int soTT = 1;
            foreach (var sanPham in danhSachSanPham)
            {
                ListViewItem lsvItem = new(soTT.ToString());
                lsvItem.SubItems.Add(sanPham.TenSanPham);
                lsvItem.SubItems.Add(sanPham.Gia);
                lsvItem.SubItems.Add(sanPham.SoLuong);
                lsvItem.SubItems.Add(sanPham.HienThi == true ? "Có" : "Không");
                lsvItem.SubItems.Add(sanPham.TenLoaiSanPham);
                lsvItem.SubItems.Add(sanPham.HinhAnh);
                lsvItem.SubItems.Add(sanPham.MaLoaiSanPham.ToString());
                lsvItem.SubItems.Add(sanPham.MaSanPham);

                lvSanPham.Items.Add(lsvItem);
                soTT++;
            }
            // Ẩn button
            btnChonAnh.Enabled = false;
            btnNhapLai.Enabled = false;
            btnXacNhan.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void NhapLai()
        {
            lbDuongDanAnh.Text = string.Empty;
            tbTenSanPham.Text = string.Empty;
            numGia.Value = 1;
            numSoLuong.Value = 1;
            pbAnhSanPham.ImageLocation = string.Empty;
            btnChonAnh.Focus();
            HienThiComboLoaiSanPham();
        }

        public void HienThiAnhSanPham(string anhSanPham)
        {
            string duongDanAnh = CauHinh.DuongDanThuMucAnh + anhSanPham;
            pbAnhSanPham.ImageLocation = string.Empty;
            // Kiểm tra xem đường dẫn hình ảnh có hợp lệ không trước khi tải lên
            if (File.Exists(duongDanAnh))
            {
                pbAnhSanPham.ImageLocation = duongDanAnh;
                lbDuongDanAnh.Text = duongDanAnh;
            }
            else
            {
                string duongDanAnhMacDinh = CauHinh.DuongDanThuMucAnh + CauHinh.AnhMacDinh;
                pbAnhSanPham.Image = Image.FromFile(duongDanAnhMacDinh); // hình ảnh mặc định
            }
        }

        public void HienThiComboLoaiSanPham()
        {
            var danhSachLoaiSanPham = LoaiSanPhamDAO.Instance.LayDsLoaiSanPham();

            // Tạo một tùy chọn chọn mặc định
            var defaultOption = new LoaiSanPhamModel { MaLoaiSanPham = 0, TenLoaiSanPham = "Chọn..." };
            danhSachLoaiSanPham.Insert(0, defaultOption); // Thêm tùy chọn vào đầu danh sách

            cbLoaiSanPham.DataSource = null;

            cbLoaiSanPham.DataSource = danhSachLoaiSanPham;

            cbLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            cbLoaiSanPham.ValueMember = "MaLoaiSanPham";
        }

        public bool KiemTraDuLieuSanPham()
        {
            int macDinh = 0;
            if (string.IsNullOrEmpty(lbDuongDanAnh.Text) == true ||
               string.IsNullOrWhiteSpace(lbDuongDanAnh.Text) == true)
            {
                MessageBox.Show("Vui lòng cung cấp hình ảnh cho sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnChonAnh.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tbTenSanPham.Text) == true ||
                string.IsNullOrWhiteSpace(tbTenSanPham.Text) == true)
            {
                MessageBox.Show("Tên sản phẩm không thể bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenSanPham.Focus();
                return false;
            }
            else if (cbLoaiSanPham.SelectedValue is int && (int)cbLoaiSanPham.SelectedValue == macDinh)
            {
                MessageBox.Show("Vui lòng chọn loại cho sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbLoaiSanPham.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LamMoiSanPham()
        {
            // Hiển thị lại button
            btnThem.Enabled = true;
            btnNhapLai.Enabled = true;
            btnXoa.Enabled = true;
            // Load lại form
            HienThiDsSanPham();
            NhapLai();

            lbMaSP.Text = null;
            tbTimKiem.Text = null;
            tbTimKiem.Focus();
            lvSanPham.Enabled = true;
        }
        #endregion

        #region Tab Loại sản phẩm
        public void HienThiDsLoaiSanPham(string? timKiem = null)
        {
            var danhSachSanPham = LoaiSanPhamDAO.Instance.LayDsLoaiSanPham(timKiem);
            lvLoaiSanPham.Items.Clear();
            int soTT = 1;
            foreach (var loaiSanPham in danhSachSanPham)
            {
                ListViewItem lsvItem = new(soTT.ToString());
                lsvItem.SubItems.Add(loaiSanPham.MaLoaiSanPham.ToString());
                lsvItem.SubItems.Add(loaiSanPham.TenLoaiSanPham);
                lvLoaiSanPham.Items.Add(lsvItem);
                soTT++;
            }
            // Ẩn button
            btnNhapLaiLoaiSP.Enabled = false;
            btnLuuLoaiSP.Enabled = false;
            btnXoaLoaiSanPham.Enabled = false;
            btnThemLoaiSP.Enabled = true;
            tbTimKiemLoaiSP.Focus();
        }

        public void LamMoiLoaiSanPham()
        {
            // Hiển thị lại button
            btnThemLoaiSP.Enabled = true;

            // Load lại form
            HienThiDsLoaiSanPham();

            lbMaLoaiSanPham.Text = null;
            tbTenLoaiSP.Text = null;
            tbTimKiemLoaiSP.Text = null;
            tbTimKiemLoaiSP.Focus();
            lvLoaiSanPham.Enabled = true;
        }
        #endregion

        #region Tab Người dùng
        public void LamMoiNguoiDung()
        {
            string ngayHienTai = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tbNgayTaoNguoiDung.Text = ngayHienTai;
            tbLanCuoiDN.Text = ngayHienTai;
            lbMaTK.Text = null;
            // An button
            btnNhapLaiNguoiDung.Enabled = false;
            btnXacNhanNguoiDung.Enabled = false;
            btnXoaNguoiDung.Enabled = false;
            btnThemNguoiDung.Enabled = true;
            lvNguoiDung.Enabled = true;
            //
            tbTimKiemNguoiDung.Text = null;
            tbTimKiemNguoiDung.Focus();
            HienThiDSNguoiDung();
            HienThiCbLoaiTaiKhoan();
            NhapLaiNguoiDung();
        }

        public void NhapLaiNguoiDung()
        {
            tbTenNguoiDung.Text = null;
            tbTenDangNhap.Text = null;
            tbMatKhau.Text = null;
            tbEmail.Text = null;
            cbTrangThai.Checked = true;
            cbLoaiTaiKhoan.SelectedValue = 0;
            tbTenNguoiDung.Focus();
        }

        public void HienThiDSNguoiDung(string? timKiem = null)
        {
            var dsTaiKhoan = TaiKhoanDAO.Instance.LayDsTaiKhoan(timKiem);
            lvNguoiDung.Items.Clear();
            int index = 1;
            foreach (var taiKhoan in dsTaiKhoan)
            {
                ListViewItem lsvItem = new(index.ToString());
                lsvItem.SubItems.Add(taiKhoan.MaTaiKhoan.ToString());
                lsvItem.SubItems.Add(taiKhoan.TenNguoiDung);
                lsvItem.SubItems.Add(taiKhoan.TenDangNhap);
                lsvItem.SubItems.Add(taiKhoan.MatKhau);
                lsvItem.SubItems.Add(taiKhoan.Email);
                lsvItem.SubItems.Add(taiKhoan.NgayTao.ToString("dd/MM/yyyy HH:mm:ss"));
                lsvItem.SubItems.Add(taiKhoan.LanDangNhapCuoi.ToString("dd/MM/yyyy HH:mm:ss"));
                lsvItem.SubItems.Add(taiKhoan.MaLoaiTaiKhoan.ToString());
                lsvItem.SubItems.Add(taiKhoan.TenLoaiTaiKhoan);
                lsvItem.SubItems.Add(taiKhoan.TrangThai == true ? "Có" : "Không");
                lvNguoiDung.Items.Add(lsvItem);
                index++;
            }
        }

        public void HienThiCbLoaiTaiKhoan()
        {
            var dsLoaiTaiKhoan = LoaiTaiKhoanDAO.Instance.LayDsLoaiTaiKhoan();

            // Tạo một tùy chọn chọn mặc định
            var defaultOption = new LoaiTaiKhoanModel { MaLoaiTaiKhoan = 0, TenLoaiTaiKhoan = "Chọn..." };
            dsLoaiTaiKhoan.Insert(0, defaultOption); // Thêm tùy chọn vào đầu danh sách

            cbLoaiTaiKhoan.DataSource = null;

            cbLoaiTaiKhoan.DataSource = dsLoaiTaiKhoan;

            cbLoaiTaiKhoan.DisplayMember = "TenLoaiTaiKhoan";
            cbLoaiTaiKhoan.ValueMember = "MaLoaiTaiKhoan";
        }

        public bool KiemTraDuLieuNguoiDung()
        {
            int macDinh = 0;
            int maTaiKhoan = string.IsNullOrEmpty(lbMaTK.Text) == false
                ? int.Parse(lbMaTK.Text) : macDinh;
            if (string.IsNullOrEmpty(tbTenNguoiDung.Text) == true ||
               string.IsNullOrWhiteSpace(tbTenNguoiDung.Text) == true)
            {
                MessageBox.Show("Tên người dùng không thể để trống!",
                    "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbTenNguoiDung.Focus();
                return false;
            }

            else if (string.IsNullOrEmpty(tbTenDangNhap.Text) == true ||
               string.IsNullOrWhiteSpace(tbTenDangNhap.Text) == true)
            {
                MessageBox.Show("Tên đăng nhập không thể để trống!",
                    "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbTenDangNhap.Focus();
                return false;
            }

            else if (string.IsNullOrEmpty(tbMatKhau.Text) == true ||
               string.IsNullOrWhiteSpace(tbMatKhau.Text) == true)
            {
                MessageBox.Show("Mật khẩu không thể để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbMatKhau.Focus();
                return false;
            }

            else if (cbLoaiTaiKhoan.SelectedValue is int cbLoaiTK && cbLoaiTK == macDinh)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản!",
                    "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                cbLoaiTaiKhoan.Focus();
                return false;
            }

            else if (_maNguoiDung > 0 && cbTrangThai.Checked == false && maTaiKhoan == _maNguoiDung)
            {
                MessageBox.Show("Không thể hủy kích hoạt tài khoản của bản thân!",
                   "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                cbTrangThai.Checked = true;

                return false;
            }

            return true;
        }

        private void DongTatCaFormDangMo()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
        }

        #endregion

        #region Tab Loại Người Dùng
        public void HienThiDsLoaiNguoiDung(string? timKiem = null)
        {
            var dsLoaiNguoiDung = LoaiTaiKhoanDAO.Instance.LayDsLoaiTaiKhoan(timKiem);
            lvLoaiND.Items.Clear();
            int soTT = 1;
            foreach (var loaiND in dsLoaiNguoiDung)
            {
                ListViewItem lsvItem = new(soTT.ToString());
                lsvItem.SubItems.Add(loaiND.MaLoaiTaiKhoan.ToString());
                lsvItem.SubItems.Add(loaiND.TenLoaiTaiKhoan);
                lvLoaiND.Items.Add(lsvItem);
                soTT++;
            }
            // Ẩn button
            btnNhapLaiLoaiND.Enabled = false;
            btnXacNhanLoaiND.Enabled = false;
            btnXoaLoaiND.Enabled = false;
            btnThemLoaiND.Enabled = true;

            tbTimKiemLoaiND.Focus();
        }

        public void LamMoiLoaiNguoiDung()
        {
            // Hiển thị lại button
            btnThemLoaiND.Enabled = true;

            // Load lại form
            HienThiDsLoaiNguoiDung();

            lbMaLoaiND.Text = null;
            tbTenLoaiND.Text = null;
            tbTimKiemLoaiND.Text = null;
            tbTimKiemLoaiND.Focus();
            lvLoaiND.Enabled = true;
        }
        #endregion

        #region Tab Đơn hàng

        /// <summary>
        /// Hàm hiển thị danh sách đơn hàng
        /// </summary>
        /// <param name="type">Loại (null: không lọc ngày, true: lọc theo ngày đặt, false: lọc theo ngày giao)</param>
        /// <param name="timKiem">Từ khóa tìm kiếm</param>
        public void HienThiDsDonHang(bool? type = null, string? timKiem = null)
        {
            List<DonHangModel> dsDonHang;
            lvDonHang.Items.Clear();
            // trường hợp không filter theo thời gian thì xử lý tìm kiếm theo từ nhập vào
            if (type is null)
            {
                dsDonHang = DonHangDAO.Instance.LayDsDonHang(timKiem: timKiem);
            }
            else
            {

                dsDonHang = DonHangDAO.Instance.LayDsDonHang(
                    loai: type.Value,
                    ngayTu: dtNgayBatDau.Value.Date,
                    ngayDen: dtNgayKetThuc.Value.Date,
                    timKiem: timKiem
                );
            }

            if (dsDonHang.Count > 0)
            {
                int soTT = 1;
                foreach (var donHang in dsDonHang)
                {
                    ListViewItem lsvItem = new(soTT.ToString());
                    lsvItem.SubItems.Add(donHang.MaDonHang.ToString());
                    lsvItem.SubItems.Add(donHang.NgayDat.ToString("dd/MM/yyyy"));
                    lsvItem.SubItems.Add(donHang.NgayGiao.ToString("dd/MM/yyyy"));
                    lsvItem.SubItems.Add(donHang.TenNguoiDat);
                    lsvItem.SubItems.Add(donHang.TrangThai);
                    lsvItem.SubItems.Add(donHang.TenNguoiNhan);
                    lsvItem.SubItems.Add(donHang.SoDT);
                    lsvItem.SubItems.Add(donHang.DiaChi);
                    lsvItem.SubItems.Add(donHang.MaTrangThai.ToString());
                    lsvItem.SubItems.Add(donHang.PhuongThucTT);
                    lvDonHang.Items.Add(lsvItem);
                    soTT++;
                }
            }
        }

        public void LayDsCTDonHang(int maDonHang)
        {
            if (maDonHang <= 0)
            {
                return;
            }
            else
            {
                var dsChiTiet = DonHangDAO.Instance.LayCTDonHang(maDonHang);
                lvCTDonHang.Items.Clear();
                int soTT = 1;
                decimal tongTien = 0;
                foreach (var chiTiet in dsChiTiet)
                {
                    ListViewItem lsvItem = new(soTT.ToString());
                    lsvItem.SubItems.Add(chiTiet.TenSanPham);
                    lsvItem.SubItems.Add(chiTiet.SoLuong.ToString());
                    lsvItem.SubItems.Add(string.Format("{0:N0}", chiTiet.ThanhTien));
                    tongTien += chiTiet.ThanhTien;
                    lvCTDonHang.Items.Add(lsvItem);
                    soTT++;
                }
                lb_TongTien.Text = string.Format("{0:N0} VND", tongTien);
            }
        }

        public void ThayDoiNgayLocTrongFormDonHang()
        {
            string? timKiem = string.IsNullOrEmpty(tbTraCuuNhanh.Text) == false
                      ? tbTraCuuNhanh.Text.Trim().ToLower()
                      : null;
            if (rbNgayDat.Checked == rbNgayGiao.Checked)
            {
                HienThiDsDonHang(null, timKiem);
                return;
            }
            else
            {
                if (dtNgayBatDau.Value.Date > dtNgayKetThuc.Value.Date)
                {
                    dtNgayBatDau.Focus();
                    MessageBox.Show("Ngày kết thúc không được nhỏ nhơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    bool loai = rbNgayDat.Checked;
                    HienThiDsDonHang(loai, timKiem);
                }
            }
        }

        public void HienThiCbTrangThaiDH()
        {
            // Tạo một tùy chọn chọn mặc định
            var dsTrangThai = new List<TrangThaiDonHangModel>
            {
                new() {MaTrangThai = 1, TenTrangThai = "Đã Đặt Hàng"},
                new() {MaTrangThai = 2, TenTrangThai = "Đang Giao Hàng"},
                new() {MaTrangThai = 3, TenTrangThai = "Thành Công"},
                new() {MaTrangThai = 4, TenTrangThai = "Đã Hủy"},
            };

            cb_TrangThai.DataSource = null;

            cb_TrangThai.DataSource = dsTrangThai;

            cb_TrangThai.DisplayMember = "TenTrangThai";
            cb_TrangThai.ValueMember = "MaTrangThai";
        }

        public void LamMoiDonHang()
        {
            btn_ChuyenTrangThai.Enabled = false;
            HienThiDsDonHang();
            HienThiCbTrangThaiDH();
            tbTraCuuNhanh.Focus();

            tb_MaDH.Text = null;
            tb_NgayDat.Text = null;
            tb_NguoiDat.Text = null;
            tb_NgayGiao.Text = null;
            tb_NguoiNhan.Text = null;
            tb_SdtNhan.Text = null;
            tb_DiaChiNhan.Text = null;
            tb_PTTT.Text = null;
            lb_TongTien.Text = null;
            tbTraCuuNhanh.Text = null;

            rbNgayDat.Checked = false;
            rbNgayGiao.Checked = false;
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayKetThuc.Value = DateTime.Now;

            lvCTDonHang.Items.Clear();
        }

        #endregion

        #endregion

        #region Events

        #region Tab Sản Phẩm
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new()
                {
                    Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.*",
                    FilterIndex = 1 // Mặc định focus vào .jpg
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(dialog.FileName).ToLower();
                    // Kiểm tra định dạng file (tránh tình trạng cố tình chọn sai định dạng)
                    if (extension == ".jpg" || extension == ".png")
                    {
                        string imageLocation = dialog.FileName;
                        lbDuongDanAnh.Text = dialog.FileName;
                        pbAnhSanPham.ImageLocation = imageLocation;
                        tbTenSanPham.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Chỉ chấp nhận file có định dạng PNG hoặc JPG.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool kiemTraDuLieu = KiemTraDuLieuSanPham();
            if (kiemTraDuLieu == false)
            {
                return;
            }

            int macDinh = 0;

            var sanPham = new SanPhamModel
            {
                MaSanPham = lbMaSP.Text,
                TenSanPham = tbTenSanPham.Text,
                Gia = numGia.Value.ToString(),
                SoLuong = numSoLuong.Value.ToString(),
                HinhAnh = lbDuongDanAnh.Text,
                HienThi = cbHienThi.Checked,
                MaLoaiSanPham = cbLoaiSanPham.SelectedValue != null
                    ? (int)cbLoaiSanPham.SelectedValue
                    : macDinh
            };

            int ketQua = SanPhamDAO.Instance.CapNhatSanPham(sanPham);

            if (ketQua < 0)
            {
                MessageBox.Show("File không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ketQua == 0)
            {
                LamMoiSanPham();
                MessageBox.Show("Thêm mới sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LamMoiSanPham();
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            if (tabControl.SelectedTab != null)
            {
                string selectedTabName = tabControl.SelectedTab.Name;
                switch (selectedTabName)
                {
                    case nameof(EAdminTab.tabSanPham):
                        LamMoiSanPham();
                        break;
                    case nameof(EAdminTab.tabLoaiSanPham):
                        LamMoiLoaiSanPham();
                        break;
                    case nameof(EAdminTab.tabNguoiDung):
                        // Mặc định
                        LamMoiNguoiDung();
                        break;
                    case nameof(EAdminTab.tabLoaiNguoiDung):
                        // Mặc định
                        LamMoiLoaiNguoiDung();
                        break;
                    case nameof(EAdminTab.tabDonHang):
                        LamMoiDonHang();
                        break;
                }
            }
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                // Lấy ra dòng dữ liệu được chọn
                ListViewItem selectedItem = lvSanPham.SelectedItems[0];
                if (selectedItem != null)
                {
                    // Mở button chức năng
                    btnThem.Enabled = false;
                    btnNhapLai.Enabled = false;
                    btnChonAnh.Enabled = true;
                    btnNhapLai.Enabled = true;
                    btnXacNhan.Enabled = true;
                    btnXoa.Enabled = true;
                    // Gán dữ liệu
                    HienThiAnhSanPham(selectedItem.SubItems[(int)ETableSanPham.colAnhSP].Text);
                    // Text tên sản phẩm
                    tbTenSanPham.Text = selectedItem.SubItems[(int)ETableSanPham.colTenSP].Text;
                    // Text giá
                    numGia.Value = decimal.Parse(selectedItem.SubItems[(int)ETableSanPham.colGiaSP].Text.Replace(",", ""));
                    // Text số lượng
                    numSoLuong.Value = decimal.Parse(selectedItem.SubItems[(int)ETableSanPham.colSoLuong].Text);
                    // Combo Loại sản phẩm
                    cbLoaiSanPham.SelectedValue = int.Parse(selectedItem.SubItems[(int)ETableSanPham.colMaLoaiSP].Text);
                    // Checkbox hiển thị
                    bool isChecked = selectedItem.SubItems[(int)ETableSanPham.colHienThi].Text.Equals("Có") ? true : false;
                    cbHienThi.Checked = isChecked;
                    // Lable mã sản phẩm (ẩn)
                    lbMaSP.Text = selectedItem.SubItems[(int)ETableSanPham.colMaSP].Text;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiSanPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnChonAnh.Focus();
            // Ẩn button xóa, thêm
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            // Mở button chức năng
            btnChonAnh.Enabled = true;
            btnNhapLai.Enabled = true;
            btnXacNhan.Enabled = true;
            // Disable listview
            lvSanPham.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn sản phẩm hay chưa
            if (string.IsNullOrEmpty(lbMaSP.Text) == true)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {tbTenSanPham.Text}?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _ = int.TryParse(lbMaSP.Text, out int maSP);
                int ketQua = SanPhamDAO.Instance.XoaSanPham(maSP);

                if (ketQua == (int)EKetQuaTruyVan.ThanhCong)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load lại danh sách
                    LamMoiSanPham();
                }
                else if (ketQua == (int)EKetQuaTruyVan.DangSuDung)
                {
                    MessageBox.Show("Sản phẩm đang được sử dụng trong hệ thống, không thể xóa!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LamMoiSanPham();
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LamMoiSanPham();
                }
            }

        }

        private void tbTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                string? timKiem = string.IsNullOrEmpty(tbTimKiem.Text) == false
                ? tbTimKiem.Text.Trim().ToLower()
                : null;

                HienThiDsSanPham(timKiem: timKiem);

            }
        }
        #endregion

        #region Tab Loại sản phẩm
        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            btnXoaLoaiSanPham.Enabled = false;
            btnNhapLaiLoaiSP.Enabled = true;
            btnLuuLoaiSP.Enabled = true;
            btnThemLoaiSP.Enabled = false;

            tbTenLoaiSP.Focus();
            lvLoaiSanPham.Enabled = false;
        }

        private void btnLamMoiLoaiSP_Click(object sender, EventArgs e)
        {
            LamMoiLoaiSanPham();
        }

        private void btnNhapLaiLoaiSP_Click(object sender, EventArgs e)
        {
            tbTenLoaiND.Focus();
            tbTenLoaiSP.Text = null;
        }

        private void btnLuuLoaiSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenLoaiSP.Text) == true
                || string.IsNullOrWhiteSpace(tbTenLoaiSP.Text) == true)
            {
                MessageBox.Show("Tên loại sản phẩm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenLoaiSP.Focus();
                return;
            }
            else
            {
                int maLoaiSP = string.IsNullOrEmpty(lbMaLoaiSanPham.Text) == true
                    ? 0 : int.Parse(lbMaLoaiSanPham.Text);

                var loaiSanPham = new LoaiSanPhamModel
                {
                    MaLoaiSanPham = maLoaiSP,
                    TenLoaiSanPham = tbTenLoaiSP.Text,
                };

                int ketQua = LoaiSanPhamDAO.Instance.LuuLoaiSanPham(loaiSanPham);

                if (ketQua == (int)ELoaiXuLy.ThemMoi)
                {
                    LamMoiLoaiSanPham();
                    MessageBox.Show("Thêm mới loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LamMoiLoaiSanPham();
                    MessageBox.Show("Cập nhật loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoaLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa loại sản phẩm {tbTenLoaiSP.Text} này không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _ = int.TryParse(lbMaLoaiSanPham.Text, out int maLoaiSanPham);
                int ketQua = LoaiSanPhamDAO.Instance.XoaLoaiSanPham(maLoaiSanPham);

                if (ketQua == (int)EKetQuaTruyVan.ThanhCong)
                {
                    MessageBox.Show("Xóa loại sản phẩm thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load lại danh sách
                    LamMoiLoaiSanPham();
                }
                else if (ketQua == (int)EKetQuaTruyVan.DangSuDung)
                {
                    MessageBox.Show("Loại sản phẩm này đang được sử dụng, không được phép xóa!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LamMoiLoaiSanPham();
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LamMoiLoaiSanPham();
                }
            }
        }

        private void lvLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLoaiSanPham.SelectedItems.Count > 0)
            {
                // Lấy ra dòng dữ liệu được chọn
                ListViewItem selectedItem = lvLoaiSanPham.SelectedItems[0];
                if (selectedItem != null)
                {
                    // Mở button chức năng
                    btnThemLoaiSP.Enabled = false;
                    btnNhapLaiLoaiSP.Enabled = true;
                    btnLuuLoaiSP.Enabled = true;
                    btnXoaLoaiSanPham.Enabled = true;
                    // Gán dữ liệu
                    // Text tên sản phẩm
                    tbTenLoaiSP.Text = selectedItem.SubItems[(int)ETableLoaiSanPham.colTenLoaiSP].Text;
                    // Lable mã sản phẩm (ẩn)
                    lbMaLoaiSanPham.Text = selectedItem.SubItems[(int)ETableLoaiSanPham.colMaLoaiSP].Text;
                }
            }
        }

        private void tbTimKiemLoaiSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                string? timKiem = string.IsNullOrEmpty(tbTimKiemLoaiSP.Text)
                ? null
                : tbTimKiemLoaiSP.Text.Trim().ToLower();

                HienThiDsLoaiSanPham(timKiem);

            }
        }

        #endregion

        #region Tab Người dùng
        private void lvNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNguoiDung.SelectedItems.Count > 0)
            {
                // Lấy ra dòng dữ liệu được chọn
                ListViewItem selectedItem = lvNguoiDung.SelectedItems[0];
                if (selectedItem != null)
                {
                    tbTenNguoiDung.Text = selectedItem.SubItems[(int)ETableNguoiDung.colTenNguoiDung].Text;
                    tbTenDangNhap.Text = selectedItem.SubItems[(int)ETableNguoiDung.colTenDangNhap].Text;
                    tbMatKhau.Text = selectedItem.SubItems[(int)ETableNguoiDung.colMatKhau].Text;
                    tbEmail.Text = selectedItem.SubItems[(int)ETableNguoiDung.colEmail].Text;
                    tbNgayTaoNguoiDung.Text = selectedItem.SubItems[(int)ETableNguoiDung.colNgayTao].Text;
                    tbLanCuoiDN.Text = selectedItem.SubItems[(int)ETableNguoiDung.colLanDangNhapCuoi].Text;
                    bool isChecked = selectedItem.SubItems[(int)ETableNguoiDung.colTrangThai].Text.Equals("Có") ? true : false;
                    cbTrangThai.Checked = isChecked;
                    lbMaTK.Text = selectedItem.SubItems[(int)ETableNguoiDung.colMaTaiKhoan].Text;
                    cbLoaiTaiKhoan.SelectedValue = int.Parse(selectedItem.SubItems[(int)ETableNguoiDung.colMaLoaiTaiKhoan].Text);

                    // Ẩn hiện control
                    btnThemNguoiDung.Enabled = false;
                    btnXoaNguoiDung.Enabled = true;
                    btnNhapLaiNguoiDung.Enabled = true;
                    btnXacNhanNguoiDung.Enabled = true;
                    tbTenNguoiDung.Focus();
                }
            }
        }

        private void btnXacNhanNguoiDung_Click(object sender, EventArgs e)
        {
            bool kiemTraDuLieu = KiemTraDuLieuNguoiDung();
            if (kiemTraDuLieu == false)
            {
                return;
            }

            int macDinh = 0;
            int maTaiKhoan = string.IsNullOrEmpty(lbMaTK.Text) == false
                ? int.Parse(lbMaTK.Text) : macDinh;

            var taiKhoan = new TaiKhoanModel
            {
                MaTaiKhoan = maTaiKhoan,
                TenDangNhap = tbTenDangNhap.Text,
                TenNguoiDung = tbTenNguoiDung.Text,
                Email = tbEmail.Text,
                MatKhau = tbMatKhau.Text,
                MaLoaiTaiKhoan = cbLoaiTaiKhoan.SelectedValue != null
                        ? (int)cbLoaiTaiKhoan.SelectedValue
                        : macDinh,
                TrangThai = cbTrangThai.Checked
            };

            int ketQua = TaiKhoanDAO.Instance.CapNhatTaiKhoan(taiKhoan);

            if (ketQua == (int)ELoaiXuLy.ThemMoi)
            {
                MessageBox.Show("Thêm mới người dùng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LamMoiNguoiDung();
            }
            else
            {
                MessageBox.Show("Cập nhật người dùng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_maNguoiDung > 0 && maTaiKhoan == _maNguoiDung)
                {
                    MessageBox.Show("Bạn vừa cập nhật thông tin tài khoản của chính mình, vui lòng đăng nhập lại hệ thống để áp dụng!",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DongTatCaFormDangMo();

                    var form = new fDangNhap();
                    form.Show();
                }

                LamMoiNguoiDung();
            }

        }

        private void btnNhapLaiNguoiDung_Click(object sender, EventArgs e)
        {
            NhapLaiNguoiDung();
        }

        private void btnLamMoiNguoiDung_Click(object sender, EventArgs e)
        {
            LamMoiNguoiDung();
        }

        private void tbTimKiemNguoiDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                string? timKiem = string.IsNullOrEmpty(tbTimKiemNguoiDung.Text) == false
                ? tbTimKiemNguoiDung.Text.Trim().ToLower()
                : null;

                HienThiDSNguoiDung(timKiem: timKiem);

            }
        }

        private void btnXoaNguoiDung_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn sản phẩm hay chưa
            if (string.IsNullOrEmpty(lbMaTK.Text) == true)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {tbTenDangNhap.Text}?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _ = int.TryParse(lbMaTK.Text, out int maTaiKhoan);
                int ketQua = TaiKhoanDAO.Instance.XoaTaiKhoan(maTaiKhoan);

                if (ketQua == (int)EKetQuaTruyVan.ThanhCong)
                {
                    MessageBox.Show("Xóa tài khoản thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load lại danh sách
                    LamMoiNguoiDung();
                }
                else if (ketQua == (int)EKetQuaTruyVan.DangSuDung)
                {
                    MessageBox.Show("Tài khoản đang được sử dụng trong hệ thống, không thể xóa!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LamMoiNguoiDung();
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LamMoiNguoiDung();
                }
            }
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            btnThemNguoiDung.Enabled = false;
            btnXoaNguoiDung.Enabled = false;
            btnNhapLaiNguoiDung.Enabled = true;
            btnXacNhanNguoiDung.Enabled = true;
            lvNguoiDung.Enabled = false;

            NhapLaiNguoiDung();
        }


        #endregion

        #region Tab Loại Người Dùng
        private void btnNhapLaiLoaiND_Click(object sender, EventArgs e)
        {
            tbTenLoaiND.Focus();
            tbTenLoaiND.Text = null;
        }

        private void btnXacNhanLoaiND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenLoaiND.Text) == true
                || string.IsNullOrWhiteSpace(tbTenLoaiND.Text) == true)
            {
                MessageBox.Show("Tên loại người dùng không được để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                tbTenLoaiND.Focus();
                return;
            }
            else
            {
                int maLoaiND = string.IsNullOrEmpty(lbMaLoaiND.Text) == true
                    ? 0 : int.Parse(lbMaLoaiND.Text);

                var loaiTaiKhoan = new LoaiTaiKhoanModel
                {
                    MaLoaiTaiKhoan = maLoaiND,
                    TenLoaiTaiKhoan = tbTenLoaiND.Text,
                };

                int ketQua = LoaiTaiKhoanDAO.Instance.LuuLoaiTaiKhoan(loaiTaiKhoan);

                if (ketQua == (int)ELoaiXuLy.ThemMoi)
                {
                    LamMoiLoaiNguoiDung();
                    MessageBox.Show("Thêm mới loại tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LamMoiLoaiNguoiDung();
                    MessageBox.Show("Cập nhật loại tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThemLoaiND_Click(object sender, EventArgs e)
        {
            btnXoaLoaiND.Enabled = false;
            btnNhapLaiLoaiND.Enabled = true;
            btnXacNhanLoaiND.Enabled = true;
            btnThemLoaiND.Enabled = false;

            tbTenLoaiND.Focus();
            lvLoaiND.Enabled = false;
        }

        private void btnXoaLoaiND_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa loại người dùng {tbTenLoaiND.Text} này không?",
                "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _ = int.TryParse(lbMaLoaiND.Text, out int maLoaiND);
                int ketQua = LoaiTaiKhoanDAO.Instance.XoaLoaiTaiKhoan(maLoaiND);

                if (ketQua == (int)EKetQuaTruyVan.ThanhCong)
                {
                    MessageBox.Show("Xóa loại người dùng thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load lại danh sách
                    LamMoiLoaiNguoiDung();
                }
                else if (ketQua == (int)EKetQuaTruyVan.DangSuDung)
                {
                    MessageBox.Show("Loại người dùng này đang được sử dụng, không được phép xóa!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LamMoiLoaiNguoiDung();
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LamMoiLoaiNguoiDung();
                }
            }
        }

        private void btnLamMoiLoaiND_Click(object sender, EventArgs e)
        {
            LamMoiLoaiNguoiDung();
        }

        private void tbTimKiemLoaiND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                string? timKiem = string.IsNullOrEmpty(tbTimKiemLoaiND.Text)
                ? null
                : tbTimKiemLoaiND.Text.Trim().ToLower();

                HienThiDsLoaiNguoiDung(timKiem);
            }
        }

        private void lvLoaiND_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLoaiND.SelectedItems.Count > 0)
            {
                // Lấy ra dòng dữ liệu được chọn
                ListViewItem selectedItem = lvLoaiND.SelectedItems[0];
                if (selectedItem != null)
                {
                    // Mở button chức năng
                    btnThemLoaiND.Enabled = false;
                    btnNhapLaiLoaiND.Enabled = true;
                    btnXacNhanLoaiND.Enabled = true;
                    btnXoaLoaiND.Enabled = true;

                    // Gán dữ liệu
                    // Text tên sản phẩm
                    tbTenLoaiND.Text = selectedItem.SubItems[(int)ETableLoaiNguoiDung.colTenLoaiND].Text;
                    // Lable mã sản phẩm (ẩn)
                    lbMaLoaiND.Text = selectedItem.SubItems[(int)ETableLoaiNguoiDung.colMaLoaiND].Text;
                }
            }
        }

        #endregion

        #region Tab Đơn hàng

        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            rbNgayDat.Checked = false;
            rbNgayGiao.Checked = false;
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayKetThuc.Value = DateTime.Now;

            HienThiDsDonHang();
        }

        private void rbNgayDat_CheckedChanged(object sender, EventArgs e)
        {
            ThayDoiNgayLocTrongFormDonHang();
        }

        private void dtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            ThayDoiNgayLocTrongFormDonHang();
        }

        private void dtNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            ThayDoiNgayLocTrongFormDonHang();
        }

        private void rbNgayGiao_CheckedChanged(object sender, EventArgs e)
        {
            ThayDoiNgayLocTrongFormDonHang();
        }

        private void tbTraCuuNhanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                ThayDoiNgayLocTrongFormDonHang();

            }
        }


        private void lvDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDonHang.SelectedItems.Count > 0)
            {
                // Lấy ra dòng dữ liệu được chọn
                ListViewItem selectedItem = lvDonHang.SelectedItems[0];
                if (selectedItem != null)
                {
                    _ = int.TryParse(selectedItem.SubItems[(int)ETableDonHang.colMaDH].Text, out int maDH);
                    // Hiển thị CT đơn hàng
                    LayDsCTDonHang(maDH);
                    tb_MaDH.Text = selectedItem.SubItems[(int)ETableDonHang.colMaDH].Text;
                    tb_NgayDat.Text = selectedItem.SubItems[(int)ETableDonHang.colNgayDat].Text;
                    tb_NguoiDat.Text = selectedItem.SubItems[(int)ETableDonHang.colNguoiDat].Text;
                    tb_NgayGiao.Text = selectedItem.SubItems[(int)ETableDonHang.colNgayGiao].Text;
                    tb_NguoiNhan.Text = selectedItem.SubItems[(int)ETableDonHang.colNguoiNhan].Text;
                    tb_SdtNhan.Text = selectedItem.SubItems[(int)ETableDonHang.colSdtNhan].Text;
                    tb_DiaChiNhan.Text = selectedItem.SubItems[(int)ETableDonHang.colDiaChiNhan].Text;
                    cb_TrangThai.SelectedValue = int.Parse(selectedItem.SubItems[(int)ETableDonHang.colMaTrangThai].Text);
                    tb_PTTT.Text = "Thanh toán khi nhận hàng";
                    btn_ChuyenTrangThai.Enabled = true;
                    btn_LamMoiDH.Enabled = true;
                }
            }
        }

        private void btn_LamMoiDH_Click(object sender, EventArgs e)
        {
            LamMoiDonHang();
        }

        private void btn_ChuyenTrangThai_Click(object sender, EventArgs e)
        {
            _ = int.TryParse(tb_MaDH.Text, out int maDonHang);
            if (maDonHang == 0)
            {
                MessageBox.Show($"Bạn chưa chọn đơn hàng!",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (cb_TrangThai.SelectedValue != null)
                {
                    _ = int.TryParse(cb_TrangThai.SelectedValue.ToString(), out int maTrangThai);

                    DonHangDAO.Instance.ChuyenTrangThaiDonHang(maDonHang, maTrangThai);

                    MessageBox.Show($"Cập nhật trạng thái đơn hàng thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LamMoiDonHang();
                }

            }
        }
        #endregion

        #endregion

    }
}
