using System.Data;

namespace eShop.Models;

public class NguoiDungModel
{
    public int MaTaiKhoan { get; set; }
    public string TenNguoiDung { get; set; }
    public int MaLoaiTaiKhoan { get; set; }
    public string TenLoaiTaiKhoan { get; set; }

    public NguoiDungModel() { }

    public NguoiDungModel(DataRow row)
    {
        MaTaiKhoan = row.Field<int>("MaTaiKhoan");
        TenNguoiDung = row.Field<string>("TenNguoiDung") ?? string.Empty;
        MaLoaiTaiKhoan = row.Field<int>("MaLoaiTaiKhoan");
        TenLoaiTaiKhoan = row.Field<string>("TenLoaiTaiKhoan") ?? string.Empty;
    }
}
