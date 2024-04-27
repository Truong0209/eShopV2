using eShop.Data;
using eShop.Models;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.ListView;

namespace eShop.GUI
{
    public partial class fDatHang : Form
    {
        private int _maNguoiDung;
        public fDatHang(
            ListViewItemCollection gioHang,
            string tongTien,
            int maNguoiDung)
        {
            InitializeComponent();
            dtNgayDat.Value = DateTime.Now;
            // Ngày giao cách ngày đặt 3 ngày
            dtGiaoHang.Value = DateTime.Now.AddDays(3);
            KhoiTaoDuLieu(gioHang, tongTien, maNguoiDung);
        }

        public void KhoiTaoDuLieu(ListViewItemCollection gioHang, string TongTien, int maNguoiDung)
        {
            lblTongTien.Text = TongTien + " VNĐ";
            _maNguoiDung = maNguoiDung;
            // Thêm các mục mới từ ListViewItemCollection vào ListView giỏ hàng
            foreach (ListViewItem item in gioHang)
            {
                lvGioHang.Items.Add((ListViewItem)item.Clone());
            }
        }

        private void fDatHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenNguoiNhan.Text) == true)
            {
                MessageBox.Show("Vui lòng nhập tên người nhận!",
                "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                tbTenNguoiNhan.Focus();
            }

            else if (string.IsNullOrEmpty(tbSdtNguoiNhan.Text) == true)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại người nhận!",
                "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                tbSdtNguoiNhan.Focus();
            }

            else if (string.IsNullOrEmpty(tbDiaChi.Text) == true)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhận!",
                "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                tbDiaChi.Focus();
            }
            else
            {
                const string tenProc = "sp_DatHang";
                const string paramDiaChi = "@DiaChi";
                const string paramDsSanPham = "@DsSanPham";
                const string paramMaTaiKhoan = "@MaTaiKhoan";
                const string paramSoDt = "@SoDt";
                const string paramTenNguoiNhan = "@TenNguoiNhan";

                var dsSanPham = LayDsSanPham();

                SqlParameter[] parameters =
                [
                    new(paramDiaChi, tbDiaChi.Text),
                new(paramDsSanPham, dsSanPham),
                new(paramMaTaiKhoan, _maNguoiDung),
                new(paramSoDt, tbSdtNguoiNhan.Text),
                new(paramTenNguoiNhan, tbTenNguoiNhan.Text),
            ];

                var data = DataProvider.Instance.ExecuteStoredProcedure(tenProc, parameters);
                if (data is null)
                {
                    MessageBox.Show("Lỗi hệ thống!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đặt hàng thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Hide();
                }
            }
        }

        public DataTable LayDsSanPham()
        {
            var dsSanPham = new DataTable();
            dsSanPham.Columns.Add("MaSanPham", typeof(int));
            dsSanPham.Columns.Add("SoLuong", typeof(int));
            dsSanPham.Columns.Add("ThanhTien", typeof(decimal));

            foreach (ListViewItem item in lvGioHang.Items)
            {
                int maSP = int.Parse(item.SubItems[3].Text);
                int soLuong = int.Parse(item.SubItems[1].Text);
                decimal giaTien = decimal.Parse(item.SubItems[2].Text);
                decimal thanhTien = soLuong * giaTien;
                dsSanPham.Rows.Add(maSP, soLuong, thanhTien);
            }

            return dsSanPham;
        }
    }
}
