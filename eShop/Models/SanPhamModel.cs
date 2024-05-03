using System.Data;

namespace eShop.Models;

public class SanPhamModel
{
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public string SoLuong { get; set; }
    public string HinhAnh { get; set; }
    public string Gia { get; set; }
    public bool HienThi { get; set; }
    public int MaLoaiSanPham { get; set; }
    public string TenLoaiSanPham { get; set; }

    public SanPhamModel(DataRow row)
    {
        MaSanPham = row.Field<int>("MaSanPham").ToString();
        TenSanPham = row.Field<string>("TenSanPham") ?? string.Empty;
        SoLuong = row.Field<int>("SoLuong").ToString();
        HinhAnh = row.Field<string>("HinhAnh") ?? string.Empty;
        Gia = string.Format("{0:N0}", row.Field<decimal>("Gia"));
        HienThi = row.Field<bool>("HienThi") == true;
        MaLoaiSanPham = row.Field<int>("MaLoaiSanPham");
        TenLoaiSanPham = row.Field<string>("TenLoaiSanPham") ?? string.Empty;
    }

    public SanPhamModel() { }
}
