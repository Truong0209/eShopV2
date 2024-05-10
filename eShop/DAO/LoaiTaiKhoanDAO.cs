
using eShop.Data;
using eShop.Models;
using System.Data.SqlClient;
using System.Data;

namespace eShop.DAO;

public class LoaiTaiKhoanDAO
{
    private static LoaiTaiKhoanDAO? _instance;

    public static LoaiTaiKhoanDAO Instance
    {
        get { _instance ??= new LoaiTaiKhoanDAO(); return _instance; }
        private set => _instance = value;
    }

    private LoaiTaiKhoanDAO()
    {

    }


    /// <summary>
    /// Lấy danh sách loại tài khoản
    /// </summary>
    /// <returns>Danh sách loại sản phẩm</returns>
    public List<LoaiTaiKhoanModel> LayDsLoaiTaiKhoan(string? timKiem = null)
    {
        const string tenProc = "sp_LayDsLoaiTaiKhoan";
        const string paramTimKiem = "@TimKiem";

        SqlParameter[] parameters =
        [
            new(paramTimKiem, timKiem)
        ];

        var dsLoaiTaiKhoan = new List<LoaiTaiKhoanModel>();

        var data = DataProvider.Instance.ExecuteStoredProcedure(tenProc, parameters);

        if (data is null)
        {
            return dsLoaiTaiKhoan;
        }

        foreach (DataRow row in data.Rows)
        {
            var loaiTaiKhoan = new LoaiTaiKhoanModel(row);
            dsLoaiTaiKhoan.Add(loaiTaiKhoan);
        }

        return dsLoaiTaiKhoan;
    }

    public int XoaLoaiTaiKhoan(int maLoaiTaiKhoan)
    {
        const string tenProc = "sp_XoaLoaiNguoiDung";
        const string paramMaLoaiNguoiDung = "@MaLoaiTaiKhoan";

        SqlParameter[] parameters =
        [
           new(paramMaLoaiNguoiDung, maLoaiTaiKhoan),
        ];

        int ketQua = (int)DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);
        return ketQua;
    }

    public int LuuLoaiTaiKhoan(LoaiTaiKhoanModel loaiTaiKhoan)
    {
        const string tenProc = "sp_CapNhatLoaiTK";
        const string paramMaLoaiTK = "@MaLoaiTK";
        const string paramTenLoaiTK = "@TenLoaiTK";

        SqlParameter[] parameters =
        [
           new(paramMaLoaiTK, loaiTaiKhoan.MaLoaiTaiKhoan),
           new(paramTenLoaiTK, loaiTaiKhoan.TenLoaiTaiKhoan),
        ];

        int ketQua = (int)DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);

        return ketQua;
    }
}
