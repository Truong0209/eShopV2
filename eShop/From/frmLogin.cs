using eShop.XuLyNghiepVu.HeThong;
using eShop.DTOs;
using eShop.ThongBao;

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
                TenDangNhap = tbTaiKhoan.Text,
                MatKhau = tbMatKhau.Text,
            };

            var ketqua = xuLyDangNhap.XuLy(thongtinDangNhap);

            // Thành công
            if (ketqua.TrangThai == true)
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

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // chuyển sang from chính
            var form = new frmDangKy();
            form.Show();
            // Ẩn from củ
            Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", HeThongTB.ThongBao, MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
