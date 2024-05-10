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
        tabLoaiNguoiDung,
        tabDonHang
    }

    public enum ETableSanPham
    {
        colSTT = 0,
        colTenSP = 1,
        colGiaSP = 2,
        colSoLuong = 3,
        colHienThi = 4,
        colLoaiSP = 5,
        colAnhSP = 6,
        colMaLoaiSP = 7,
        colMaSP = 8,
    }

    public enum ETableNguoiDung
    {
        colSTT = 0,
        colMaTaiKhoan = 1,
        colTenNguoiDung = 2,
        colTenDangNhap = 3,
        colMatKhau = 4,
        colEmail = 5,
        colNgayTao = 6,
        colLanDangNhapCuoi = 7,
        colMaLoaiTaiKhoan = 8,
        colTenLoaiTaiKhoan = 9,
        colTrangThai = 10
    }

    public enum ETableLoaiSanPham
    {
        colMaLoaiSP = 1,
        colTenLoaiSP = 2     
    }

    public enum ETableLoaiNguoiDung
    {
        colMaLoaiND = 1,
        colTenLoaiND = 2
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
        ThatBai = 0, // Thât bại
        DangSuDung = -1
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
