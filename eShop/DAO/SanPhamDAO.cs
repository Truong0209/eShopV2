using eShop.Data;
using eShop.Models;
using System.Data.SqlClient;
using System.Data;
using eShop.Chung;

namespace eShop.DAO;

public class SanPhamDAO
{
    private static SanPhamDAO? _instance;

    public static SanPhamDAO Instance
    {
        get { _instance ??= new SanPhamDAO(); return _instance; }
        private set => _instance = value;
    }

    private SanPhamDAO()
    {

    }

    /// <summary>
    /// Hàm lấy danh sách sản phẩm (lấy tất cả hoặc theo tìm kiếm)
    /// </summary>
    /// <param name="timKiem">Giá trị tìm kiếm (lấy all thì không truyền)</param>
    /// <param name="isAdmin">Nếu là admin (isAdmin = true) thì load hết</param>
    /// <returns>Danh sách sản phẩm</returns>
    public List<SanPhamModel> LayDsSanPham(string? timKiem, bool isAdmin = false)
    {
        const string tenProc = "sp_LayDsSanPham";
        const string paramTimKiem = "@TimKiem";
        const string paramIsAdmin = "@IsAdmin";

        SqlParameter[] parameters =
        [
            new(paramTimKiem, timKiem),
            new(paramIsAdmin, isAdmin),
        ];

        var danhSachSanPham = new List<SanPhamModel>();

        var data = DataProvider.Instance.ExecuteStoredProcedure(tenProc, parameters);

        if (data is null)
        {
            return danhSachSanPham;
        }

        foreach (DataRow row in data.Rows)
        {
            var sanPham = new SanPhamModel(row);
            danhSachSanPham.Add(sanPham);
        }

        return danhSachSanPham;
    }

    /// <summary>
    /// Hàm thêm/sửa sản phẩm
    /// </summary>
    /// <returns>thêm => return 0, sửa => return Id sửa</returns>
    public int CapNhatSanPham(SanPhamModel sanPham)
    {
        const string tenProc = "sp_CapNhatSanPham";
        const string paramMaSP = "@MaSP";
        const string paramTenSP = "@TenSP";
        const string paramHinhAnh = "@HinhAnh";
        const string paramGiaSP = "@GiaSP";
        const string paramSoLuongSP = "@SoLuongSP";
        const string paramHienThiSP = "@HienThiSP";
        const string paramMaLoaiSP = "@MaLoaiSP";

        int maSP = string.IsNullOrEmpty(sanPham.MaSanPham) == true
            ? 0 : int.Parse(sanPham.MaSanPham);

        string? tenFile = LuuAnhSanPham(sanPham.HinhAnh);

        const int loiFileKhongTonTai = -1;

        if (tenFile is null)
        {
            return loiFileKhongTonTai;
        }

        SqlParameter[] parameters =
        [
           new(paramMaSP, maSP),
           new(paramTenSP, sanPham.TenSanPham),
           new(paramHinhAnh, tenFile),
           new(paramGiaSP, sanPham.Gia),
           new(paramSoLuongSP, sanPham.SoLuong),
           new(paramHienThiSP, sanPham.HienThi),
           new(paramMaLoaiSP, sanPham.MaLoaiSanPham)
        ];

        int ketQua = (int)DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);

        return ketQua;
    }

    /// <summary>
    /// Lưu hình ảnh vào thư mục images
    /// </summary>
    /// <param name="duongDan"></param>
    /// <returns></returns>
    private string? LuuAnhSanPham(string duongDan)
    {
        if (File.Exists(duongDan))
        {
            string currentTime = DateTime.Now.ToString("yyyy/MM/dd");
            string duongDanThuMuc = Path.Combine(CauHinh.DuongDanThuMucAnh, currentTime);
            if (Directory.Exists(duongDanThuMuc) == false)
            {
                Directory.CreateDirectory(duongDanThuMuc);
            }

            if (File.Exists(Path.Combine(duongDanThuMuc, Path.GetFileName(duongDan))))
            {
                return $"{currentTime}/{Path.GetFileName(duongDan)}";
            }

            // Thêm guid id để chắc chắn không bị trùng file
            Guid guid = Guid.NewGuid();
            // Tên file
            string tenFile = guid + "_" + Path.GetFileName(duongDan);
            // Đường dẫn mới
            string duongDanMoi = Path.Combine(duongDanThuMuc, tenFile);

            // Sao chép hình ảnh từ đường dẫn nguồn sang đường dẫn đích với tên mới
            File.Copy(duongDan, duongDanMoi, true);

            return $"{currentTime}/{tenFile}";

        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// Ẩn sản phẩm (chuyển thuộc tính hienthi thành false và 
    /// cập nhật lại thuộc tính ngaycapnhat thành ngày hiện tại)
    /// </summary>
    /// <param name="maSanPham"></param>
    public int XoaSanPham(int maSanPham)
    {
        const string tenProc = "sp_XoaSanPham";
        const string paramMaSP = "@MaSP";

        SqlParameter[] parameters =
        [
           new(paramMaSP, maSanPham),
        ];

        int ketQua = (int)DataProvider.Instance.ExecuteScalarStoredProcedure(tenProc, parameters);
        return ketQua;
    }
}
