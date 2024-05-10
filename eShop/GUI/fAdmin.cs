using eShop.Chung;
using eShop.DAO;
using eShop.Models;
using System.Reflection.PortableExecutable;
using static eShop.Common.Enums;

namespace eShop.GUI
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            // Tab sản phẩm (mặc định load đầu tiên)
            tabSanPham.Focus();
            HienThiDanhSachSanPham();
            HienThiComboLoaiSanPham();
        }


        #region Functions

        #region Tab Sản Phẩm

        public void HienThiDanhSachSanPham(string? timKiem = null)
        {
            var danhSachSanPham = SanPhamDAO.Instance.LayDsSanPham(timKiem, isAdmin: true);
            lvSanPham.Items.Clear();
            foreach (var sanPham in danhSachSanPham)
            {
                ListViewItem lsvItem = new(sanPham.TenSanPham);
                lsvItem.SubItems.Add(sanPham.Gia);
                lsvItem.SubItems.Add(sanPham.SoLuong);
                lsvItem.SubItems.Add(sanPham.HienThi == true ? "Có" : "Không");
                lsvItem.SubItems.Add(sanPham.TenLoaiSanPham);
                lsvItem.SubItems.Add(sanPham.HinhAnh);
                lsvItem.SubItems.Add(sanPham.MaLoaiSanPham.ToString());
                lsvItem.SubItems.Add(sanPham.MaSanPham);

                lvSanPham.Items.Add(lsvItem);
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

        public void LamMoi()
        {
            // Hiển thị lại button
            btnThem.Enabled = true;
            btnNhapLai.Enabled = true;
            btnXoa.Enabled = true;
            // Load lại form
            HienThiDanhSachSanPham();
            NhapLai();

            lbMaSP.Text = null;
        }
        #endregion

        #region Tab Loại sản phẩm
        public void HienThiDanhSachLoaiSanPham()
        {
            var danhSachSanPham = LoaiSanPhamDAO.Instance.LayDsLoaiSanPham();
            lvLoaiSanPham.Items.Clear();
            foreach (var loaiSanPham in danhSachSanPham)
            {
                ListViewItem lsvItem = new(loaiSanPham.MaLoaiSanPham.ToString());
                lsvItem.SubItems.Add(loaiSanPham.TenLoaiSanPham);

                lvLoaiSanPham.Items.Add(lsvItem);
            }
            // Ẩn button
            btnNhapLaiLoaiSP.Enabled = false;
            btnLuuLoaiSP.Enabled = false;
            btnXoaLoaiSanPham.Enabled = false;
        }

        public void LamMoiLoaiSanPham()
        {
            // Hiển thị lại button
            btnThemLoaiSP.Enabled = true;

            // Load lại form
            HienThiDanhSachLoaiSanPham();

            lbMaSP.Text = null;
            tbTenLoaiSP.Text = null;
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


        #region Tab Báo cáo đơn hàng

        public void LamMoiBaoCao()
        {
            rbThangNay.Checked = false;
            rbHomNay.Checked = false;

            dt_NgayBD_BC.Value = DateTime.Now;
            dt_NgayKT_BC.Value = DateTime.Now;

            lvBaoCaoDH.Items.Clear();
            tbSanPhamBanChay.Text = null;
            tbSoLuongDaBan.Text = null;
            tbDoanhThuBC.Text = null;
        }

        public void HienThiBaoCao(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            List<BaoCaoDhModel> duLieuBaoCao = BaoCaoDhDAO.Instance.LayBaoCaoDonHang(ngayBatDau, ngayKetThuc);
            lvBaoCaoDH.Items.Clear();

            if (duLieuBaoCao.Count > 0)
            {
                int soTT = 1;
                foreach (var duLieu in duLieuBaoCao)
                {
                    ListViewItem lsvItem = new(soTT.ToString());
                    lsvItem.SubItems.Add(duLieu.MaDonHang.ToString());
                    lsvItem.SubItems.Add(duLieu.TenSP);
                    lsvItem.SubItems.Add(duLieu.SoLuong.ToString());
                    lsvItem.SubItems.Add(string.Format("{0:N0}", duLieu.ThanhTien));
                    lsvItem.SubItems.Add(duLieu.NgayDat.ToString("dd/MM/yyyy"));
                    lsvItem.SubItems.Add(duLieu.PhuongThucTT);
                    lsvItem.SubItems.Add(duLieu.TrangThai);
                    lvBaoCaoDH.Items.Add(lsvItem);
                    soTT++;
                }
                tbSoLuongDaBan.Text = duLieuBaoCao.Sum(item => item.SoLuong).ToString();
                tbDoanhThuBC.Text = string.Format("{0:N0} VND", duLieuBaoCao.Sum(item => item.ThanhTien));
                var nhomDuLieuTheoTen = duLieuBaoCao
                    .GroupBy(c => c.TenSP)
                    .Select(g => new { SanPham = g.Key, SoLuong = g.Sum(c => c.SoLuong) });
                var soLuongLonNhat = nhomDuLieuTheoTen.Max(c => c.SoLuong);
                var dsSanPhamBanChay = nhomDuLieuTheoTen
                    .OrderByDescending(c => c.SoLuong)
                    .Where(c => c.SoLuong == soLuongLonNhat)
                    .Select(c => c.SanPham);

                tbSanPhamBanChay.Text = string.Join(", ", dsSanPhamBanChay);
            }
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
                LamMoi();
                MessageBox.Show("Thêm mới sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LamMoi();
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
                        HienThiComboLoaiSanPham();
                        HienThiDanhSachSanPham();
                        break;
                    case nameof(EAdminTab.tabLoaiSanPham):
                        HienThiDanhSachLoaiSanPham();
                        break;
                    case nameof(EAdminTab.tabDonHang):
                        LamMoiDonHang();
                        break;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string? timKiem = string.IsNullOrEmpty(tbTimKiem.Text)
                ? null
                : tbTimKiem.Text.Trim().ToLower();

            HienThiDanhSachSanPham(timKiem: timKiem);
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
            LamMoi();
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
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Load lại danh sách
                }
            }

        }
        #endregion

        #region Tab Loại sản phẩm
        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            btnXoaLoaiSanPham.Enabled = false;
            btnNhapLaiLoaiSP.Enabled = true;
            btnLuuLoaiSP.Enabled = true;

            tbTenLoaiSP.Focus();
        }

        private void btnLamMoiLoaiSP_Click(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiSanPham();
            // Clear text
            tbTenLoaiSP.Text = string.Empty;
            lbMaLoaiSanPham.Text = string.Empty;
        }

        private void btnTimKiemLoaiSP_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapLaiLoaiSP_Click(object sender, EventArgs e)
        {
            tbTenLoaiSP.Text = string.Empty;
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
                    MessageBox.Show("Thêm mới sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LamMoiLoaiSanPham();
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoaLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa loại sản phẩm {tbTenLoaiSP.Text} này không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _ = int.TryParse(lbMaLoaiSanPham.Text, out int maLoaiSanPham);
                int ketQua = LoaiSanPhamDAO.Instance.XoaSanPham(maLoaiSanPham);

                if (ketQua == (int)EKetQuaTruyVan.ThanhCong)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Load lại danh sách
                    LamMoiLoaiSanPham();
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm này đang được sử dụng, không được phép xóa!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

<<<<<<< HEAD
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
=======
        #endregion
>>>>>>> parent of 8b0ea01 (Thêm tính năng tìm kiếm sản phẩm, loại sản phẩm (khi ấn enter), thêm ràng buộc cảnh báo khi xóa sản phẩm đang nằm trong đơn hàng, Thêm cột stt vào các bảng sản phẩm, loại sản phẩm. Thêm form quản lý người dùng và loại người dùng)

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

        #region Tab Báo cáo đơn hàng
        private void rbHomNay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHomNay.Checked == true)
            {
                DateTime ngayHienTai = DateTime.Now.Date;
                dt_NgayBD_BC.Value = ngayHienTai;
                dt_NgayKT_BC.Value = ngayHienTai;
                HienThiBaoCao(ngayHienTai, ngayHienTai);
            }
        }

        private void rbThangNay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThangNay.Checked == true)
            {
                DateTime ngayHienTai = DateTime.Now.Date;
                DateTime ngayDauThang = new(ngayHienTai.Year, ngayHienTai.Month, 1);
                dt_NgayBD_BC.Value = ngayDauThang;
                dt_NgayKT_BC.Value = ngayHienTai;
                HienThiBaoCao(ngayDauThang, ngayHienTai);
            }
        }

        private void btn_TraCuuBC_Click(object sender, EventArgs e)
        {
            // Lọc theo ngày
            rbThangNay.Checked = false;
            rbHomNay.Checked = false;

            if (dt_NgayKT_BC.Value.Date < dt_NgayBD_BC.Value.Date)
            {
                dt_NgayKT_BC.Focus();
                MessageBox.Show("Ngày kết thúc không được nhỏ nhơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                HienThiBaoCao(dt_NgayBD_BC.Value.Date, dt_NgayKT_BC.Value.Date);
            }
        }

        private void btn_LamMoiBC_Click(object sender, EventArgs e)
        {
            LamMoiBaoCao();
        }
        #endregion

        #endregion

    }
}
