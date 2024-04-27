using System.Data;

namespace eShop.Models;

public class LoaiSanPhamModel
{
    public int MaLoaiSanPham { get; set; }
    public string TenLoaiSanPham { get; set; }

    public LoaiSanPhamModel(DataRow row)
    {
        MaLoaiSanPham = row.Field<int>("MaLoaiSanPham");
        TenLoaiSanPham = row.Field<string>("TenLoaiSanPham") ?? string.Empty;
    }

    public LoaiSanPhamModel() { }
}
