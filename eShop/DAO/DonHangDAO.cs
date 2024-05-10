using eShop.Data;
using eShop.Models;
using System.Data.SqlClient;
using System.Data;

namespace eShop.DAO;

public class DonHangDAO
{
    private static DonHangDAO _instance;

    public static DonHangDAO Instance
    {
        get { _instance ??= new DonHangDAO(); return _instance; }
        private set => _instance = value;
    }

    private DonHangDAO()
    {

    }

    public List<DonHangModel> LayDsDonHang(
        int? maTaiKhoan = null,
        bool? loai = null, // Loại: true => ngày đặt hàng, false => ngày giao hàng
        DateTime? ngayTu = null,
        DateTime? ngayDen = null,
        string? timKiem = null)
    {
        const string tenProc = "sp_LayDsDonHang";
        const string paramMaTaiKhoan = "@MaTaiKhoan";
        const string paramLoai = "@Loai";
        const string paramNgayTu = "@NgayTu";
        const string paramNgayDen = "@NgayDen";
        const string paramTimKiem = "@TimKiem";

        SqlParameter[] parameters =
        [
            new(paramMaTaiKhoan, maTaiKhoan),
            new(paramLoai, loai),
            new(paramNgayTu, ngayTu),
            new(paramNgayDen, ngayDen),
            new(paramTimKiem, timKiem),
        ];

        var dsDonHang = new List<DonHangModel>();

        var data = DataProvider.Instance
            .ExecuteStoredProcedure(tenProc, parameters);

        if (data is null)
        {
            return dsDonHang;
        }

        foreach (DataRow row in data.Rows)
        {
            var donHang = new DonHangModel(row);
            dsDonHang.Add(donHang);
        }

        return dsDonHang;
    }

    /// <summary>
    /// Lấy chi Tiết đơn hàng
    /// </summary>
    /// <param name="maDonHang">Mã đơn hàng</param>
    /// <returns>Chi tiết đơn hàng</returns>
    public List<CtDonHangModel> LayCTDonHang(int maDonHang)
    {
        const string tenProc = "sp_LayCTDonHang";
        const string paramMaDonHang = "@MaDonHang";

        SqlParameter[] parameters =
        [
            new(paramMaDonHang, maDonHang),
        ];

        var dsChiTiet = new List<CtDonHangModel>();

        var data = DataProvider.Instance
            .ExecuteStoredProcedure(tenProc, parameters);

        if (data is null)
        {
            return dsChiTiet;
        }

        foreach (DataRow row in data.Rows)
        {
            var donHang = new CtDonHangModel(row);
            dsChiTiet.Add(donHang);
        }

        return dsChiTiet;
    }

    public void ChuyenTrangThaiDonHang(int maDonHang, int maTrangThai)
    {
        const string tenProc = "sp_ChuyenTtDonHang";
        const string paramMaDonHang = "@MaDonHang";
        const string paramMaTrangThai = "@MaTrangThai";

        SqlParameter[] parameters =
        [
           new(paramMaDonHang, maDonHang),
           new(paramMaTrangThai, maTrangThai),
        ];

        DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);
    }
}
