using eShop.DTOs;
using eShop.ThongBao;
using eShop.XuLyNghiepVu.HeThong;

namespace eShop.From;

public partial class frmDangKy : Form
{
    public frmDangKy()
    {
        InitializeComponent();
    }

    private void btnTroVe_Click(object sender, EventArgs e)
    {
        // chuyển sang from chính
        var form = new frmLogin();
        form.Show();
        // Ẩn from củ
        Hide();
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        DangKyBL xuLyDangKy = new();

        var thongTinDangKy = new DangKyDto
        {
            TenDangNhap = tbTenDangNhap.Text,
            MatKhau = tbMatKhau.Text,
            MatKhauNhapLai = tbNLMatKhau.Text,
            Email = tbEmail.Text,
            TenHienThi = tbTenHienThi.Text,
        };

        var ketqua = xuLyDangKy.XuLy(thongTinDangKy);

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
            MessageBox.Show(ketqua.ThongBao, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", HeThongTB.ThongBao, MessageBoxButtons.OKCancel) != DialogResult.OK)
        {
            e.Cancel = true;
        }
        else
        {
            Application.ExitThread();
        }
    }
}
