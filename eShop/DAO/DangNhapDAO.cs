using eShop.Chung;
using eShop.Data;
using eShop.Models;
using System.Data;
using System.Data.SqlClient;

namespace eShop.DAO;

public class DangNhapDAO
{
    private static DangNhapDAO? _instance;

    public static DangNhapDAO Instance
    {
        get { _instance ??= new DangNhapDAO(); return _instance; }
        private set => _instance = value;
    }

    private DangNhapDAO()
    {

    }

    /// <summary>
    /// Hàm xử lý chức năng đăng nhập
    /// </summary>
    /// <param name="thongTinDangNhap">Thông tin nhập</param>
    /// <returns>Object kết quả</returns>
    public KetQua DangNhap(DangNhapModel thongTinDangNhap)
    {
        // Kiểm tra định dạng dữ liệu
        var ktDinhDang = KiemTraDinhDang(thongTinDangNhap);
        // Nếu dữ liệu không đúng thì trả kết quả luôn
        if (ktDinhDang.TrangThai == false)
        {
            return ktDinhDang;
        }

        return KiemTraDuLieu(thongTinDangNhap);
    }

    /// <summary>
    /// Hàm kiểm tra so sánh dữ liệu nhập với dữ liệu lưu trữ ở database
    /// </summary>
    /// <param name="thongTin">Thông tin đăng nhập</param>
    /// <returns>Object Kết quả</returns>
    private KetQua KiemTraDuLieu(DangNhapModel thongTin)
    {
        const string tenProc = "sp_DangNhap";
        const string paramTenDangNhap = "@TenDangNhap";
        const string paramMatKhau = "@MatKhau";

        SqlParameter[] parameters =
        [
            new(paramTenDangNhap, thongTin.TenDangNhap),
            new(paramMatKhau, thongTin.MatKhau)
        ];

        var result = DataProvider.Instance.ExecuteStoredProcedure(tenProc, parameters);

        if (result.Rows.Count == 0)
        {
            return KetQua.ThatBai("Tên đăng nhập hoặc mật khẩu chưa đúng!");
        }

        return KetQua.ThanhCong("Đăng nhập thành công!");
    }

    /// <summary>
    /// Hàm kiểm tra định dạng dữ liệu đăng nhập
    /// </summary>
    /// <param name="thongTin">Thông tin đăng nhập</param>
    /// <returns>Object Kết quả</returns>
    private KetQua KiemTraDinhDang(DangNhapModel thongTin)
    {
        if (string.IsNullOrEmpty(thongTin.TenDangNhap) == true
            || string.IsNullOrWhiteSpace(thongTin.TenDangNhap))
        {
            return KetQua.ThatBai("Tên đăng nhập chưa đúng định dạng!");
        }

        else if (string.IsNullOrEmpty(thongTin.MatKhau) == true
            || string.IsNullOrWhiteSpace(thongTin.MatKhau))
        {
            return KetQua.ThatBai("Mật khẩu chưa đúng định dạng!");
        }

        else
        {
            return KetQua.ThanhCong();
        }
    }

    public NguoiDungModel LayThongTinNguoiDung(string tenDangNhap)
    {
        const string tenProc = "sp_LayThongTinNguoiDung";

        var nguoiDung = new NguoiDungModel();

        const string paramTenDangNhap = "@TenDangNhap";

        SqlParameter[] parameters =
        [
            new(paramTenDangNhap, tenDangNhap),
        ];

        var data = DataProvider.Instance.ExecuteStoredProcedure(tenProc, parameters);

        if (data is null)
        {
            return nguoiDung;
        }

        var ketqua = data.Rows[0];
        nguoiDung = new NguoiDungModel(ketqua);

        return nguoiDung;
    }
}
