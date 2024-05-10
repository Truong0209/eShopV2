using System.Data;

namespace eShop.Models;

public class BaoCaoDhModel
{
    public int MaDonHang { get; set; }
    public string TenSP { get; set; } = string.Empty;
    public int SoLuong { get; set; }
    public decimal ThanhTien { get; set; }
    public DateTime NgayDat { get; set; }
    public string PhuongThucTT { get; set; } = string.Empty;
    public string TrangThai { get; set; } = string.Empty;

    public BaoCaoDhModel(DataRow row)
    {
        MaDonHang = row.Field<int>("MaDonHang");
        TenSP = row.Field<string>("TenSP") ?? string.Empty;
        SoLuong = row.Field<int>("SoLuong");
        ThanhTien = row.Field<decimal>("ThanhTien");
        NgayDat = row.Field<DateTime>("NgayDat");
        PhuongThucTT = row.Field<string>("PhuongThucTT") ?? string.Empty;
        TrangThai = row.Field<string>("TrangThai") ?? string.Empty;
    }
}
