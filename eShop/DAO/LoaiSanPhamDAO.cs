using eShop.Data;
using eShop.Models;
using System.Data;
using System.Data.SqlClient;

namespace eShop.DAO;

public class LoaiSanPhamDAO
{
    private static LoaiSanPhamDAO? _instance;

    public static LoaiSanPhamDAO Instance
    {
        get { _instance ??= new LoaiSanPhamDAO(); return _instance; }
        private set => _instance = value;
    }

    private LoaiSanPhamDAO()
    {

    }

    /// <summary>
    /// Lấy danh sách loại sản phẩm
    /// </summary>
    /// <returns>Danh sách loại sản phẩm</returns>
    public List<LoaiSanPhamModel> LayDsLoaiSanPham(string? timKiem = null)
    {
        const string tenProc = "sp_LayDsLoaiSanPham";
        const string paramTimKiem = "@TimKiem";

        SqlParameter[] parameters =
        [
            new(paramTimKiem, timKiem)
        ];

        var danhSachLoaiSanPham = new List<LoaiSanPhamModel>();

        var data = DataProvider.Instance.ExecuteStoredProcedure(tenProc, parameters);

        if (data is null)
        {
            return danhSachLoaiSanPham;
        }

        foreach (DataRow row in data.Rows)
        {
            var loaiSanPham = new LoaiSanPhamModel(row);
            danhSachLoaiSanPham.Add(loaiSanPham);
        }

        return danhSachLoaiSanPham;
    }

    public int LuuLoaiSanPham(LoaiSanPhamModel loaiSanPham)
    {
        const string tenProc = "sp_CapNhatLoaiSanPham";
        const string paramMaLoaiSP = "@MaLoaiSP";
        const string paramTenLoaiSP = "@TenLoaiSP";

        SqlParameter[] parameters =
        [
           new(paramMaLoaiSP, loaiSanPham.MaLoaiSanPham),
           new(paramTenLoaiSP, loaiSanPham.TenLoaiSanPham),
        ];

        int ketQua = (int)DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);

        return ketQua;
    }

    public int XoaLoaiSanPham(int maLoaiSanPham)
    {
        const string tenProc = "sp_XoaLoaiSanPham";
        const string paramMaLoaiSanPham = "@MaLoaiSP";

        SqlParameter[] parameters =
        [
           new(paramMaLoaiSanPham, maLoaiSanPham),
        ];

        int ketQua = (int)DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);
        return ketQua;
    }
}
