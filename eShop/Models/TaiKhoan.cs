namespace eShop.Models;

/// <summary>
/// Lớp tài khoản
/// Tương ứng bảng TaiKhoan trong cơ sở dữ liệu
/// </summary>
public class TaiKhoan
{
    public int MaTaiKhoan { get; set; }
    public string TenDangNhap { get; set; }
    public string MatKhau { get; set; }
    public string Email { get; set; }
    public string TenNguoiDung { get; set; }
    public DateTime NgayTao { get; set; }
    public DateTime LanDangNhapCuoi { get; set; }
    public int MaLoaiTaiKhoan { get; set; }
    public bool TrangThai { get; set; }
}
