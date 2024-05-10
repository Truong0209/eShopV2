using System.Data;

namespace eShop.Models;

public class CtDonHangModel
{
    public string TenSanPham { get; set; }
    public int SoLuong { get; set; }
    public decimal ThanhTien { get; set; }

    public CtDonHangModel(DataRow row)
    {
        TenSanPham = row.Field<string>("TenSanPham") ?? string.Empty;
        SoLuong = row.Field<int>("SoLuong");
        ThanhTien = row.Field<decimal>("ThanhTien");
    }
}
