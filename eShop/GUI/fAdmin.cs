using eShop.Chung;
using eShop.Common.CustomUI;
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

        #endregion

        #endregion


    }
}
