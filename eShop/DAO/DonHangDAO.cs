using eShop.Data;
using eShop.Models;
using System.Data.SqlClient;
using System.Data;

namespace eShop.DAO;

public class DonHangDAO
{
    private static DonHangDAO _instance;

    public static DonHangDAO Instance
    {
        get { _instance ??= new DonHangDAO(); return _instance; }
        private set => _instance = value;
    }

    private DonHangDAO()
    {

    }

    public List<DonHangModel> LayDsDonHang(int maTaiKhoan)
    {
        const string tenProc = "LayDsDonHangTheoTaiKhoan";
        const string paramMaTaiKhoan = "@MaTaiKhoan";

        SqlParameter[] parameters =
        [
            new(paramMaTaiKhoan, maTaiKhoan),
        ];

        var dsDonHang = new List<DonHangModel>();

        var data = DataProvider.Instance
            .ExecuteStoredProcedure(tenProc, parameters);

        if (data is null)
        {
            return dsDonHang;
        }

        foreach (DataRow row in data.Rows)
        {
            var donHang = new DonHangModel(row);
            dsDonHang.Add(donHang);
        }

        return dsDonHang;
    }
}
