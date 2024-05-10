using eShop.Data;
using eShop.Models;
using System.Data.SqlClient;
using System.Data;

namespace eShop.DAO;

public class BaoCaoDhDAO
{
    private static BaoCaoDhDAO? _instance;

    public static BaoCaoDhDAO Instance
    {
        get { _instance ??= new BaoCaoDhDAO(); return _instance; }
        private set => _instance = value;
    }

    private BaoCaoDhDAO()
    {

    }

    /// <summary>
    /// Hàm lấy danh sách sản phẩm (lấy tất cả hoặc theo tìm kiếm)
    /// </summary>
    /// <param name="timKiem">Giá trị tìm kiếm (lấy all thì không truyền)</param>
    /// <param name="isAdmin">Nếu là admin (isAdmin = true) thì load hết</param>
    /// <returns>Danh sách sản phẩm</returns>
    public List<BaoCaoDhModel> LayBaoCaoDonHang(DateTime ngayBatDau, DateTime ngayKetThuc)
    {
        const string tenProc = "sp_BaoCaoDH";
        const string paramNgayBatDau = "@NgayBatDau";
        const string paramNgayKetThuc = "@NgayKetThuc";

        SqlParameter[] parameters =
        [
            new(paramNgayBatDau, ngayBatDau),
            new(paramNgayKetThuc, ngayKetThuc),
        ];

        var duLieuBaoCao = new List<BaoCaoDhModel>();

        var data = DataProvider.Instance.ExecuteStoredProcedure(tenProc, parameters);

        if (data is null)
        {
            return duLieuBaoCao;
        }

        foreach (DataRow row in data.Rows)
        {
            var duLieu = new BaoCaoDhModel(row);
            duLieuBaoCao.Add(duLieu);
        }

        return duLieuBaoCao;
    }
}
