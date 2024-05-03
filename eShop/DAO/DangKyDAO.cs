using eShop.Chung;
using eShop.Data;
using eShop.Models;
using System.Data.SqlClient;

namespace eShop.DAO;

public class DangKyDAO
{
    private static DangKyDAO? _instance;

    public static DangKyDAO Instance
    {
        get { _instance ??= new DangKyDAO(); return _instance; }
        private set => _instance = value;
    }

    private DangKyDAO()
    {

    }

    /// <summary>
    /// Hàm xử lý chức năng đăng ký
    /// </summary>
    /// <param name="thongTinDangKy">Thông tin nhập</param>
    /// <returns>Object kết quả</returns>
    public KetQua DangKy(DangKyModel thongTinDangKy)
    {
        // Kiểm tra định dạng dữ liệu
        var ktDinhDang = KiemTraDinhDang(thongTinDangKy);
        // Nếu dữ liệu không đúng thì trả kết quả luôn
        if (ktDinhDang.TrangThai == false)
        {
            return ktDinhDang;
        }

        return LuuDuLieu(thongTinDangKy);
    }

    /// <summary>
    /// Hàm lưu dữ liệu đăng ký
    /// </summary>
    /// <param name="thongTin">Thông tin đăng ký</param>
    /// <returns>Object Kết quả</returns>
    private KetQua LuuDuLieu(DangKyModel thongTin)
    {
        const string tenProc = "sp_DangKyTaiKhoan";
        const string paramTenDangNhap = "@TenDangNhap";
        const string paramMatKhau = "@MatKhau";
        const string paramEmail = "@Email";
        const string paramTenHienThi = "@TenHienThi";

        SqlParameter[] parameters =
        [
            new(paramTenDangNhap, thongTin.TenDangNhap),
            new(paramMatKhau, thongTin.MatKhau),
            new(paramEmail, thongTin.Email),
            new(paramTenHienThi, thongTin.TenHienThi),
        ];

        string ketQua = (string)DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);

        if (ketQua is null)
        {
            return KetQua.ThatBai("Lỗi hệ thống! Vui lòng liên hệ người quản lý!");
        }

        if (ketQua.Equals("TrungTaiKhoan") is true)
        {
            return KetQua.ThatBai("Tài khoản bị trùng, vui lòng thay đổi!");
        }

        return KetQua.ThanhCong("Đăng ký thành công!");
    }

    /// <summary>
    /// Hàm kiểm tra định dạng dữ liệu đăng ký
    /// </summary>
    /// <param name="thongTin">Thông tin đăng ký</param>
    /// <returns>Object Kết quả</returns>
    private KetQua KiemTraDinhDang(DangKyModel thongTin)
    {
        if (thongTin is null)
        {
            return KetQua.ThatBai("Dữ liệu chưa đúng định dạng!");
        }

        else if (string.IsNullOrEmpty(thongTin.TenDangNhap) == true
            || string.IsNullOrWhiteSpace(thongTin.TenDangNhap))
        {
            return KetQua.ThatBai("Tên đăng nhập chưa đúng định dạng!");
        }

        else if (string.IsNullOrEmpty(thongTin.MatKhau) == true
            || string.IsNullOrWhiteSpace(thongTin.MatKhau))
        {
            return KetQua.ThatBai("Mật khẩu chưa đúng định dạng!");
        }

        else if (string.IsNullOrEmpty(thongTin.MatKhauNhapLai) == true
            || string.IsNullOrWhiteSpace(thongTin.MatKhauNhapLai))
        {
            return KetQua.ThatBai("Mật khẩu nhập lại chưa khớp với mật khẩu đã nhập!");
        }

        else if (thongTin.MatKhau.Equals(thongTin.MatKhauNhapLai) != true)
        {
            return KetQua.ThatBai("Mật khẩu nhập lại chưa khớp với mật khẩu đã nhập!");
        }

        else
        {
            return KetQua.ThanhCong();
        }
    }
}
