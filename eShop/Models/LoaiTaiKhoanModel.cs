using System.Data;

namespace eShop.Models;

public class LoaiTaiKhoanModel
{
    public int MaLoaiTaiKhoan { get; set; }
    public string TenLoaiTaiKhoan { get; set; } = string.Empty;

    public LoaiTaiKhoanModel(DataRow row)
    {
        MaLoaiTaiKhoan = row.Field<int>("MaLoaiTaiKhoan");
        TenLoaiTaiKhoan = row.Field<string>("TenLoaiTaiKhoan") ?? string.Empty;
    }

    public LoaiTaiKhoanModel() { }
}
