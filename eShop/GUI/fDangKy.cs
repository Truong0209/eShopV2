using eShop.DAO;
using eShop.Models;

namespace eShop.From;

public partial class fDangKy : Form
{
    public fDangKy()
    {
        InitializeComponent();
    }

    #region Events
    private void btnTroVe_Click(object sender, EventArgs e)
    {
        // chuyển sang from chính
        var form = new fDangNhap();
        form.Show();
        // Ẩn from củ
        Hide();
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        var thongTinDangKy = new DangKyModel
        {
            TenDangNhap = tbTenDangNhap.Text,
            MatKhau = tbMatKhau.Text,
            MatKhauNhapLai = tbNLMatKhau.Text,
            Email = tbEmail.Text,
            TenHienThi = tbTenHienThi.Text,
        };

        var ketqua = DangKyDAO.Instance.DangKy(thongTinDangKy);

        // Thành công
        if (ketqua.TrangThai == true)
        {
            MessageBox.Show(ketqua.ThongBao, "Thông báo");

            // chuyển sang from chính
            var form = new fDanhMuc(tbTenDangNhap.Text);
            form.Show();
            // Ẩn from củ
            Hide();
        }
        else
        {
            MessageBox.Show(ketqua.ThongBao, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
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
    #endregion
}
