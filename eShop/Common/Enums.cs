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

    public enum ETableDonHang
    {
        colMaDH = 1,
        colNgayDat = 2,
        colNgayGiao = 3,
        colNguoiDat = 4,
        colTrangThai = 5,
        colNguoiNhan = 6,
        colSdtNhan = 7,
        colDiaChiNhan = 8,
        colMaTrangThai = 9,
        colPTTT = 10
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

    public enum ETrangThaiDH
    {
        DaDatHang = 1,
        DangGiaoHang = 2,
        ThanhCong = 3,
        Huy = 4
    }
}
