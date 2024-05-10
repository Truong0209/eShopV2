using System.Data;

namespace eShop.Models;

public class TaiKhoanModel
{
    public int MaTaiKhoan { get; set; }
    public string TenNguoiDung { get; set; } = string.Empty;
    public string TenDangNhap { get; set; } = string.Empty;
    public string MatKhau { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime NgayTao { get; set; }
    public DateTime LanDangNhapCuoi { get; set; }
    public int MaLoaiTaiKhoan { get; set; }
    public string TenLoaiTaiKhoan { get; set; } = string.Empty;
    public bool TrangThai { get; set; }

    public TaiKhoanModel(DataRow row)
    {
        MaTaiKhoan = row.Field<int>("MaTaiKhoan");
        TenNguoiDung = row.Field<string>("TenNguoiDung") ?? string.Empty;
        TenDangNhap = row.Field<string>("TenDangNhap") ?? string.Empty;
        MatKhau = row.Field<string>("MatKhau") ?? string.Empty;
        Email = row.Field<string>("Email") ?? string.Empty;
        NgayTao = row.Field<DateTime>("NgayTao");
        LanDangNhapCuoi = row.Field<DateTime>("LanDangNhapCuoi");
        MaLoaiTaiKhoan = row.Field<int>("MaLoaiTaiKhoan");
        TenLoaiTaiKhoan = row.Field<string>("TenLoaiTaiKhoan") ?? string.Empty;
        TrangThai = row.Field<bool>("TrangThai");
    }

    public TaiKhoanModel() { }
}
