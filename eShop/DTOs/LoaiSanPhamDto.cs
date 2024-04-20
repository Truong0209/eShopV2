using System.Data;

namespace eShop.DTOs;

public class LoaiSanPhamDto
{
    public int MaLoaiSanPham { get; set; }
    public string TenLoaiSanPham { get; set; }

    public LoaiSanPhamDto(DataRow row)
    {
        MaLoaiSanPham = row.Field<int>("MaLoaiSanPham");
        TenLoaiSanPham = row.Field<string>("TenLoaiSanPham") ?? string.Empty;
    }
}
