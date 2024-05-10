using eShop.DAO;
using eShop.Models;
using static eShop.Common.Enums;

namespace eShop.GUI
{
    public partial class fDonHang : Form
    {
        private readonly int _maTaiKhoan;
        public fDonHang(int maTaiKhoan)
        {
            InitializeComponent();
            _maTaiKhoan = maTaiKhoan;
            LamMoiDonHang();
        }

        #region Functions

        /// <summary>
        /// Hàm hiển thị danh sách đơn hàng
        /// </summary>
        /// <param name="type">Loại (null: không lọc ngày, true: lọc theo ngày đặt, false: lọc theo ngày giao)</param>
        /// <param name="timKiem">Từ khóa tìm kiếm</param>
        public void HienThiDsDonHang(int maTaiKhoan, bool? type = null)
        {
            List<DonHangModel> dsDonHang;
            lvDonHang.Items.Clear();
            // trường hợp không filter theo thời gian thì xử lý tìm kiếm theo từ nhập vào
            if (type is null)
            {
                dsDonHang = DonHangDAO.Instance.LayDsDonHang(maTaiKhoan: maTaiKhoan);
            }
            else
            {

                dsDonHang = DonHangDAO.Instance.LayDsDonHang(
                    maTaiKhoan: maTaiKhoan,
                    loai: type.Value,
                    ngayTu: dtNgayBatDau.Value.Date,
                    ngayDen: dtNgayKetThuc.Value.Date
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

        public void LamMoiDonHang()
        {
            HienThiDsDonHang(_maTaiKhoan);

            tb_MaDH.Text = null;
            tb_NgayDat.Text = null;
            tb_NguoiDat.Text = null;
            tb_NgayGiao.Text = null;
            tb_NguoiNhan.Text = null;
            tb_SdtNhan.Text = null;
            tb_DiaChiNhan.Text = null;
            tb_PTTT.Text = null;
            lb_TongTien.Text = null;
            tb_TrangThai.Text = null;   

            rbNgayDat.Checked = false;
            rbNgayGiao.Checked = false;
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayKetThuc.Value = DateTime.Now;

            lvCTDonHang.Items.Clear();
        }

        public void ThayDoiNgayLocTrongFormDonHang()
        {
            if (rbNgayDat.Checked == rbNgayGiao.Checked)
            {
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
                    HienThiDsDonHang(maTaiKhoan: _maTaiKhoan, loai);
                }
            }
        }

        #endregion

        #region Events
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
                    tb_TrangThai.Text = selectedItem.SubItems[(int)ETableDonHang.colTrangThai].Text;
                    tb_PTTT.Text = "Thanh toán khi nhận hàng";
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiDonHang();
        }

        private void dtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            ThayDoiNgayLocTrongFormDonHang();
        }

        private void dtNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            ThayDoiNgayLocTrongFormDonHang();
        }

        private void rbNgayDat_CheckedChanged(object sender, EventArgs e)
        {
            ThayDoiNgayLocTrongFormDonHang();
        }

        private void rbNgayGiao_CheckedChanged(object sender, EventArgs e)
        {
            ThayDoiNgayLocTrongFormDonHang();
        }

        #endregion

    }
}
