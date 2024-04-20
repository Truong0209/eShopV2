using eShop.Chung;
using eShop.Data;
using eShop.DTOs;
using eShop.ThongBao;
using System.Data.SqlClient;

namespace eShop.XuLyNghiepVu.HeThong;

public class DangKyBL
{
    public KetQua XuLy(DangKyDto thongTinDangKy)
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

    private KetQua LuuDuLieu(DangKyDto dangNhap)
    {
        const string tenProc = "sp_DangKyTaiKhoan";
        const string paramTenDangNhap = "@TenDangNhap";
        const string paramMatKhau = "@MatKhau";
        const string paramEmail = "@Email";
        const string paramTenHienThi = "@TenHienThi";

        var dal = new DataAccessLayer();

        SqlParameter[] parameters =
        [
            new(paramTenDangNhap, dangNhap.TenDangNhap),
            new(paramMatKhau, dangNhap.MatKhau),
            new(paramEmail, dangNhap.Email),
            new(paramTenHienThi, dangNhap.TenHienThi),
        ];

        var ketQua = dal.ExecuteScalarStoredProcedure(tenProc, parameters);

        if (ketQua is null)
        {
            return KetQua.ThatBai(DangKyTB.LoiHeThong);
        }
       
        if(ketQua.Equals(nameof(DangKyTB.TrungTaiKhoan)) is true)
        {
            return KetQua.ThatBai(DangKyTB.TrungTaiKhoan);
        }

        return KetQua.ThanhCong(DangKyTB.ThanhCong);
    }

    private KetQua KiemTraDinhDang(DangKyDto duLieu)
    {
        if (duLieu is null)
        {
            return KetQua.ThatBai(DangKyTB.DuLieuSaiDinhDang);
        }

        else if (string.IsNullOrEmpty(duLieu.TenDangNhap) == true
            || string.IsNullOrWhiteSpace(duLieu.TenDangNhap))
        {
            return KetQua.ThatBai(DangKyTB.TenDangNhapSai);
        }

        else if (string.IsNullOrEmpty(duLieu.MatKhau) == true
            || string.IsNullOrWhiteSpace(duLieu.MatKhau))
        {
            return KetQua.ThatBai(DangKyTB.MatKhauSai);
        }

        else if (string.IsNullOrEmpty(duLieu.MatKhauNhapLai) == true
            || string.IsNullOrWhiteSpace(duLieu.MatKhauNhapLai))
        {
            return KetQua.ThatBai(DangKyTB.NhapLaiMkKhongKhop);
        }

        else if (duLieu.MatKhau.Equals(duLieu.MatKhauNhapLai) != true)
        {
            return KetQua.ThatBai(DangKyTB.NhapLaiMkKhongKhop);
        }

        else
        {
            return KetQua.ThanhCong();
        }
    }


}
