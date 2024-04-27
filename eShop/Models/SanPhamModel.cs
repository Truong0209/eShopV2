using System.Data;

namespace eShop.Models;

public class SanPhamModel
{
    public int MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public int SoLuong { get; set; }
    public string HinhAnh { get; set; }
    public decimal Gia { get; set; }
    public bool HienThi { get; set; }
    public int MaLoaiSanPham { get; set; }

    public SanPhamModel(DataRow row)
    {
        MaSanPham = row.Field<int>("MaSanPham");
        TenSanPham = row.Field<string>("TenSanPham") ?? string.Empty;
        SoLuong = row.Field<int>("SoLuong");
        HinhAnh = row.Field<string>("HinhAnh") ?? string.Empty;
        Gia = row.Field<decimal>("Gia");
        HienThi = row.Field<bool>("HienThi");
        MaLoaiSanPham = row.Field<int>("MaLoaiSanPham");
    }
}
