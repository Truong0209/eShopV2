using System.Data;

namespace eShop.Models;

public class DonHangModel
{
    public int MaDonHang { get; set; }
    public DateTime NgayDat { get; set; }
    public DateTime NgayGiao { get; set; }
    public int MaTrangThai { get; set; }
    public string TrangThai { get; set; }
    public string TenNguoiNhan { get; set; }
    public string DiaChi { get; set; }
    public string SoDT { get; set; }
    public string PhuongThucTT { get; set; }
    public int MaNguoiDat { get; set; }
    public string TenNguoiDat { get; set; }

    public DonHangModel(DataRow row)
    {
        MaDonHang = row.Field<int>("MaDonHang");
        NgayDat = row.Field<DateTime>("NgayDat");
        NgayGiao = row.Field<DateTime>("NgayGiao");
        MaTrangThai = row.Field<int>("MaTrangThai");
        TrangThai = row.Field<string>("TrangThai") ?? string.Empty;
        TenNguoiNhan = row.Field<string>("TenNguoiNhan") ?? string.Empty;
        DiaChi = row.Field<string>("DiaChi") ?? string.Empty;
        SoDT = row.Field<string>("SoDT") ?? string.Empty;
        PhuongThucTT = row.Field<string>("PhuongThucTT") ?? string.Empty;
        MaNguoiDat = row.Field<int>("MaNguoiDat");
        TenNguoiDat = row.Field<string>("TenNguoiDat") ?? string.Empty;
    }
}
