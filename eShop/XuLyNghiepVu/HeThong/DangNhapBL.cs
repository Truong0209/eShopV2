using eShop.Chung;
using eShop.Data;
using eShop.DTOs;
using System.Data.SqlClient;

namespace eShop.XuLyNghiepVu.HeThong;

/// <summary>
/// Lớp xử lý các hàm liên quan đến đăng nhập
/// **BL là viết tắt của business logic dùng để phân biệt
/// </summary>
public class DangNhapBL
{

    public KetQua XuLy(DangNhapDto thongTinDangNhap)
    {
        // Kiểm tra định dạng dữ liệu
        var ktDinhDang = KiemTraDinhDang(thongTinDangNhap);
        // Nếu dữ liệu không đúng thì trả kết quả luôn
        if(ktDinhDang.TrangThai == false)
        {
            return ktDinhDang;
        }

        return KiemTraDuLieu(thongTinDangNhap);
    }

    private KetQua KiemTraDuLieu(DangNhapDto dangNhap)
    {
        const string tenProc = "sp_DangNhap";
        const string paramTenDangNhap = "@TenDangNhap";
        const string paramMatKhau = "@MatKhau";

        var dal = new DataAccessLayer();

        SqlParameter[] parameters =
        [
            new(paramTenDangNhap, dangNhap.TenDangNhap),
            new(paramMatKhau, dangNhap.MatKhau)
        ];

        var result = dal.ExecuteStoredProcedure(tenProc, parameters);

        if (result.Rows.Count == 0)
        {
            return KetQua.ThatBai("Tên đăng nhập hoặc mật khẩu chưa đúng!!");
        }

        return KetQua.ThanhCong("Đăng nhập thành công!!");
    }

    private KetQua KiemTraDinhDang(DangNhapDto dangNhap)
    {
        if(string.IsNullOrEmpty(dangNhap.TenDangNhap) == true || string.IsNullOrWhiteSpace(dangNhap.TenDangNhap))
        {
            return KetQua.ThatBai("Tên đăng nhập chưa đúng định dạng!");
        }

        else if (string.IsNullOrEmpty(dangNhap.MatKhau) == true || string.IsNullOrWhiteSpace(dangNhap.MatKhau))
        {
            return KetQua.ThatBai("Mật khẩu chưa đúng định dạng!");
        }

        else
        {
            return KetQua.ThanhCong();
        }
    }
}
