namespace eShop.Common;

public class Enums
{
    public enum ELoaiTaiKhoan
    {
        KhachHang = 1,
        NhanVien = 2,
        Admin = 3,
    }

    public enum EAdminTab
    {
        tabSanPham,
        tabLoaiSanPham,
        tabNguoiDung,
        tabDonHang
    }

    public enum ETableSanPham
    {
        colTenSP = 0,
        colGiaSP = 1,
        colSoLuong = 2,
        colHienThi = 3,
        colLoaiSP = 4,
        colAnhSP = 5,
        colMaLoaiSP = 6,
        colMaSP = 7,
    }

    public enum ETableLoaiSanPham
    {
        colMaLoaiSP = 0,
        colTenLoaiSP = 1     
    }

    public enum EKetQuaTruyVan
    {
        KhongTonTai = 404, // Không tồn tại
        ThanhCong = 1, // Thành công
        ThatBai = 0 // Thât bại
    }

    public enum ELoaiXuLy
    {
        ThemMoi = 0,
        CapNhat = 1
    }
}
