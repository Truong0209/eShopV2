using System.Data;

namespace eShop.Models;

public class DonHangModel
{
    public string MaDonHang { get; set; }
    public string NgayDat { get; set; }
    public string NgayGiao { get; set; }
    public string TrangThai { get; set; }

    public DonHangModel(DataRow row)
    {
        MaDonHang = row.Field<string>("MaDonHang") ?? string.Empty; ;
        NgayDat = row.Field<string>("NgayDat") ?? string.Empty;
        NgayGiao = row.Field<string>("NgayGiao") ?? string.Empty; ;
        TrangThai = row.Field<string>("TrangThai") ?? string.Empty;
    }
}
