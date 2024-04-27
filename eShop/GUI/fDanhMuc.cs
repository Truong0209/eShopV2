using eShop.Chung;
using eShop.Common.CustomUI;
using eShop.DAO;
using eShop.GUI;
using eShop.Models;
using static eShop.Common.Enums;

namespace eShop.From
{
    public partial class fDanhMuc : Form
    {
        private NguoiDungModel _nguoiDungHienTai;

        public fDanhMuc(string tenDangNhap = null)
        {
            InitializeComponent();
            HienThiDanhSachSanPham();
            HienThiComboLoaiSanPham();

            _nguoiDungHienTai = DangNhapDAO.Instance.LayThongTinNguoiDung(tenDangNhap);
            PhanQuyen();
        }

        #region Functions
        public void HienThiDanhSachSanPham(int? maLoaiSanPham = null, string? timKiem = null)
        {

            pnSanPham.Controls.Clear();

            var danhSachSanPham = DanhMucDAO.Instance.LayDsSanPham(timKiem);

            // Trường hợp filter theo combobox loại sản phẩm
            if (maLoaiSanPham != null)
            {
                danhSachSanPham = danhSachSanPham.Where(sp => sp.MaLoaiSanPham.Equals(maLoaiSanPham)).ToList();
            }

            foreach (var sanPham in danhSachSanPham)
            {
                SanPhamUC hinhAnhSP = new(sanPham)
                {
                    Width = CauHinh.ChieuRongSanPham,
                    Height = CauHinh.ChieuCaoSanPham
                };

                hinhAnhSP.Click += Click_ChonSanPham;
                hinhAnhSP.Tag = sanPham;

                pnSanPham.Controls.Add(hinhAnhSP);
            }
        }

        public void HienThiComboLoaiSanPham()
        {
            var danhSachLoaiSanPham = DanhMucDAO.Instance.LayDsLoaiSanPham();

            // Tạo một tùy chọn chọn mặc định
            var defaultOption = new LoaiSanPhamModel { MaLoaiSanPham = 0, TenLoaiSanPham = "Chọn loại sản phẩm..." };
            danhSachLoaiSanPham.Insert(0, defaultOption); // Thêm tùy chọn vào đầu danh sách

            cbLoaiSanPham.DataSource = null;

            cbLoaiSanPham.DataSource = danhSachLoaiSanPham;

            cbLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            cbLoaiSanPham.ValueMember = "MaLoaiSanPham";
        }

        public void PhanQuyen()
        {
            // Chỉ hiện thị trang admin với loại tài khoản admin
            if (_nguoiDungHienTai.MaLoaiTaiKhoan != (int)LoaiTaiKhoan.Admin)
            {
                menuAdmin.Visible = false;
            }
        }
        #endregion

        #region Events
        public void Click_ChonSanPham(object? sender, EventArgs e)
        {
            numSoLuong.Value = 1;
            if (sender is SanPhamUC { Tag: SanPhamModel sanPham })
            {
                lblMaSP.Text = sanPham.MaSanPham.ToString();
                tbTenSanPham.Text = sanPham.TenSanPham;
                tbGiaTien.Text = string.Format("{0:N0}", sanPham.Gia);
                //cbLoaiSanPham.SelectedValue = sanPham.MaLoaiSanPham;
                numSoLuong.Focus();
            }
        }

        private void frmDanhMuc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMaSP.Text) == true)
            {
                return;
            }

            var kiemTraTonTai = DanhMucDAO.Instance.KiemTraSanPhamDaTonTaiTrongGioHang(
                lvGioHang.Items, lblMaSP.Text);

            if (kiemTraTonTai == true)
            {
                // Cập nhật lại giỏ hàng
                foreach (ListViewItem item in lvGioHang.Items)
                {
                    if (int.Parse(item.SubItems[3].Text) == int.Parse(lblMaSP.Text))
                    {
                        decimal soLuong = decimal.Parse(item.SubItems[1].Text);
                        decimal newSoLuong = soLuong + numSoLuong.Value;
                        item.SubItems[1].Text = newSoLuong.ToString();
                    }
                }
            }
            else
            {
                ListViewItem lsvItem = new(tbTenSanPham.Text);
                lsvItem.SubItems.Add(numSoLuong.Value.ToString());
                lsvItem.SubItems.Add(tbGiaTien.Text);
                lsvItem.SubItems.Add(lblMaSP.Text);

                lvGioHang.Items.Add(lsvItem);
            }

            var tongTien = DanhMucDAO.Instance.TinhTongTien(lvGioHang.Items);
            lblTongTien.Text = string.Format("{0:N0}", tongTien);
        }

        private void btnXoaMucDaChon_Click(object sender, EventArgs e)
        {
            if (lvGioHang.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn vào mặt hàng bạn muốn xóa và thử lại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            for (int i = 0; i < lvGioHang.CheckedItems.Count; i++)
            {
                lvGioHang.CheckedItems[i].Remove();
                i--;
            }

            var tongTien = DanhMucDAO.Instance.TinhTongTien(lvGioHang.Items);
            lblTongTien.Text = string.Format("{0:N0}", tongTien);
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắn chắn muốn làm sạch giỏ hàng?",
                "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) != DialogResult.OK)
            {

            }
            else
            {
                lvGioHang.Items.Clear();
                lblTongTien.Text = "0";
                MessageBox.Show("Đã làm sạch giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
            HienThiComboLoaiSanPham();
            tbTimKiem.Clear();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (lvGioHang.Items.Count > 0)
            {
                var form = new fDatHang(
                    lvGioHang.Items,
                    lblTongTien.Text,
                    _nguoiDungHienTai.MaTaiKhoan);

                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào giỏ hàng!!",
                "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string? timKiem = string.IsNullOrEmpty(tbTimKiem.Text)
                ? null
                : tbTimKiem.Text.Trim().ToLower();
            int macDinh = 0;
            int selectedValue = cbLoaiSanPham.SelectedValue is int
                ? int.Parse(cbLoaiSanPham.SelectedValue.ToString())
                : macDinh;

            if (string.IsNullOrEmpty(timKiem))
            {
                if (selectedValue == macDinh)
                {
                    HienThiDanhSachSanPham();
                }
                else
                {
                    HienThiDanhSachSanPham(maLoaiSanPham: selectedValue, timKiem: timKiem);
                }
                MessageBox.Show(
                    "Vui lòng nhập từ khóa tìm kiếm!",
                    "Thông báo",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                HienThiDanhSachSanPham(
                    maLoaiSanPham: selectedValue > 0 ? selectedValue : null,
                    timKiem: timKiem);
            }
        }

        private void cbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int macDinh = 0;
            string? timKiem = string.IsNullOrEmpty(tbTimKiem.Text) ? null : tbTimKiem.Text.Trim().ToLower();
            if (cbLoaiSanPham.SelectedValue is int selectedValue && selectedValue > macDinh)
            {
                HienThiDanhSachSanPham(maLoaiSanPham: selectedValue, timKiem);
            }
            else
            {
                HienThiDanhSachSanPham();
            }

            // Clear sản phẩm đã chọn
            lblMaSP.Text = "";
            tbTenSanPham.Text = "";
            tbGiaTien.Text = "";
            numSoLuong.Value = 1;

        }
        #endregion

        private void menuCapNhatTT_Click(object sender, EventArgs e)
        {

        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            _nguoiDungHienTai = new NguoiDungModel();
            // chuyển sang from chính
            var form = new fDangNhap();
            form.Show();
            // Ẩn from củ
            this.Hide();
        }

        private void menuDonHang_Click(object sender, EventArgs e)
        {
            var form = new fDonHang(maTaiKhoan: _nguoiDungHienTai.MaTaiKhoan);
            form.ShowDialog();
        }
    }
}
