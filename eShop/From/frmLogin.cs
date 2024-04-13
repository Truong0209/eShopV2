using eShop.XuLyNghiepVu.HeThong;
using eShop.DTOs;

namespace eShop.From
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhapBL xuLyDangNhap = new();

            var thongtinDangNhap = new DangNhapDto
            {
                TenDangNhap = tbTaiKhoan.Text.ToLower(),
                MatKhau = tbMatKhau.Text.ToLower(),
            };

            var ketqua = xuLyDangNhap.XuLy(thongtinDangNhap);

            // Thành công
            if(ketqua.TrangThai == true)
            {
                MessageBox.Show(ketqua.ThongBao, "Thông báo");

                // chuyển sang from chính
                var form = new frmMenu();
                form.Show();
                // Ẩn from củ
                Hide();
            }
            else
            {
                MessageBox.Show(ketqua.ThongBao, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
