using eShop.DAO;
using eShop.Models;

namespace eShop.From
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        #region Events
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var thongtinDangNhap = new DangNhapModel
            {
                TenDangNhap = tbTaiKhoan.Text,
                MatKhau = tbMatKhau.Text,
            };

            var ketqua = DangNhapDAO.Instance.DangNhap(thongtinDangNhap);

            // Thành công
            if (ketqua.TrangThai == true)
            {
                MessageBox.Show(ketqua.ThongBao, "Thông báo");

                // chuyển sang from chính
                var form = new fDanhMuc(tenDangNhap: tbTaiKhoan.Text);
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
            var form = new fDangKy();
            form.Show();
            // Ẩn from củ
            Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
