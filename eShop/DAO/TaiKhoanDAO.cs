using eShop.Data;
using eShop.Models;
using System.Data.SqlClient;
using System.Data;

namespace eShop.DAO;

public class TaiKhoanDAO
{
    private static TaiKhoanDAO? _instance;

    public static TaiKhoanDAO Instance
    {
        get { _instance ??= new TaiKhoanDAO(); return _instance; }
        private set => _instance = value;
    }

    private TaiKhoanDAO()
    {

    }

    /// <summary>
    /// Hàm lấy danh sách tài khoản (lấy tất cả hoặc theo tìm kiếm)
    /// </summary>
    /// <param name="timKiem">Giá trị tìm kiếm (lấy all thì không truyền)</param>
    /// <returns>Danh sách tài khoản</returns>
    public List<TaiKhoanModel> LayDsTaiKhoan(string? timKiem)
    {
        const string tenProc = "sp_LayDsTaiKhoan";
        const string paramTimKiem = "@TimKiem";

        SqlParameter[] parameters =
        [
            new(paramTimKiem, timKiem),
        ];

        var dsTaiKhoan = new List<TaiKhoanModel>();

        var data = DataProvider.Instance.ExecuteStoredProcedure(tenProc, parameters);

        if (data is null)
        {
            return dsTaiKhoan;
        }

        foreach (DataRow row in data.Rows)
        {
            var sanPham = new TaiKhoanModel(row);
            dsTaiKhoan.Add(sanPham);
        }

        return dsTaiKhoan;
    }

    public int XoaTaiKhoan(int maTaiKhoan)
    {
        const string tenProc = "sp_XoaTaiKhoan";
        const string paramMaTaiKhoan = "@MaTaiKhoan";

        SqlParameter[] parameters =
        [
           new(paramMaTaiKhoan, maTaiKhoan),
        ];

        int ketQua = (int)DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);
        return ketQua;
    }

    public int CapNhatTaiKhoan(TaiKhoanModel taiKhoan)
    {
        const string tenProc = "sp_CapNhatTaiKhoan";
        const string paramMaTaiKhoan = "@MaTaiKhoan";
        const string paramTenDangNhap = "@TenDangNhap";
        const string paramTenNguoiDung = "@TenNguoiDung";
        const string paramEmail = "@Email";
        const string paramMatKhau = "@MatKhau";
        const string paramMaLoaiTaiKhoan = "@MaLoaiTaiKhoan";
        const string paramTrangThai = "@TrangThai";

        SqlParameter[] parameters =
        [
           new(paramMaTaiKhoan, taiKhoan.MaTaiKhoan),
           new(paramTenDangNhap, taiKhoan.TenDangNhap),
           new(paramTenNguoiDung, taiKhoan.TenNguoiDung),
           new(paramEmail, taiKhoan.Email),
           new(paramMatKhau, taiKhoan.MatKhau),
           new(paramMaLoaiTaiKhoan, taiKhoan.MaLoaiTaiKhoan),
           new(paramTrangThai, taiKhoan.TrangThai),
        ];

        int ketQua = (int)DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);

        return ketQua;
    }
}
