using eShop.Chung;
using eShop.DTOs;
using eShop.ThongBao;
using eShop.XuLyNghiepVu.DanhMuc;
using System.Globalization;

namespace eShop.From
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            HienThiDanhSachSanPham();
            HienThiComboLoaiSanPham();
        }

        public void HienThiDanhSachSanPham(int? maLoaiSanPham = null)
        {
            DanhMucBL xuLyDanhMuc = new();

            pnSanPham.Controls.Clear();

            var danhSachSanPham = xuLyDanhMuc.LayDanhSachSanPham();

            // Trường hợp filter theo combobox loại sản phẩm
            if (maLoaiSanPham != null)
            {
                danhSachSanPham = danhSachSanPham.Where(sp => sp.MaLoaiSanPham.Equals(maLoaiSanPham)).ToList();
            }

            foreach (var sanPham in danhSachSanPham)
            {
                HinhAnhSanPham hinhAnhSP = new HinhAnhSanPham(sanPham);
                hinhAnhSP.Width = CauHinh.ChieuRongSanPham;
                hinhAnhSP.Height = CauHinh.ChieuCaoSanPham;

                hinhAnhSP.Click += Click_ChonSanPham;
                hinhAnhSP.Tag = sanPham;

                pnSanPham.Controls.Add(hinhAnhSP);
            }
        }

        public void HienThiComboLoaiSanPham()
        {
            DanhMucBL xuLyDanhMuc = new();
            var danhSachLoaiSanPham = xuLyDanhMuc.LayDanhSachLoaiSanPham();
            cbLoaiSanPham.DataSource = null;

            cbLoaiSanPham.DataSource = danhSachLoaiSanPham;

            cbLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            cbLoaiSanPham.ValueMember = "MaLoaiSanPham";
        }

        #region Event
        public void Click_ChonSanPham(object? sender, EventArgs e)
        {
            SanPhamDto? sanPham = ((HinhAnhSanPham)sender).Tag as SanPhamDto;
            numSoLuong.Value = 1;
            if (sanPham != null)
            {
                tbTenSanPham.Text = sanPham.TenSanPham;
                tbGiaTien.Text = string.Format("{0:N0}", sanPham.Gia);
                cbLoaiSanPham.SelectedValue = sanPham.MaLoaiSanPham;
                numSoLuong.Focus();
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(HeThongTB.CanhBaoThoat, HeThongTB.ThongBao, MessageBoxButtons.OKCancel) != DialogResult.OK)
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

            ListViewItem lsvItem = new(tbTenSanPham.Text);
            lsvItem.SubItems.Add(numSoLuong.Value.ToString());
            lsvItem.SubItems.Add(tbGiaTien.Text);
            lvGioHang.Items.Add(lsvItem);

            DanhMucBL xuLyDanhMuc = new();
            var tongTien = xuLyDanhMuc.TinhTongTien(lvGioHang.Items);
            lblTongTien.Text = string.Format("{0:N0}", tongTien);
        }

        private void btnXoaMucDaChon_Click(object sender, EventArgs e)
        {
            if (lvGioHang.CheckedItems.Count <= 0)
            {
                MessageBox.Show(DanhMucTB.ChonMucDeXoa, HeThongTB.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            for (int i = 0; i < lvGioHang.CheckedItems.Count; i++)
            {
                lvGioHang.CheckedItems[i].Remove();
                i--;
            }

            DanhMucBL xuLyDanhMuc = new();
            var tongTien = xuLyDanhMuc.TinhTongTien(lvGioHang.Items);
            lblTongTien.Text = string.Format("{0:N0}", tongTien);
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(DanhMucTB.CanhBaoXoaGioHang, HeThongTB.ThongBao, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {

            }
            else
            {
                lvGioHang.Items.Clear();
                lblTongTien.Text = "0";
                MessageBox.Show(DanhMucTB.XoaThanhCongGioHang, HeThongTB.ThongBao, MessageBoxButtons.OK);
            }
        }
        #endregion

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
            HienThiComboLoaiSanPham();
            tbTimKiem.Clear();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HeThongTB.KhongKhaDung, HeThongTB.ThongBao, MessageBoxButtons.OK);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HeThongTB.KhongKhaDung, HeThongTB.ThongBao, MessageBoxButtons.OK);
        }
    }
}
