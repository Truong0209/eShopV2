using System.Data.SqlClient;
using System.Data;

namespace eShop.Data;

public class DataProvider
{
    private readonly string connectionString = "Server=.;Database=eShop;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;";

    private static DataProvider instance;

    public static DataProvider Instance
    {
        get { if (instance == null) instance = new DataProvider(); return instance; }
        private set => instance = value;
    }

    private DataProvider()
    {

    }

    /// <summary>
    /// Lớp thực thi StoreProcedure
    /// </summary>
    /// <param name="procedureName">Tên StoreProcedure</param>
    /// <param name="parameters">Tham số (có thể truyền hoặc không)</param>
    /// ** Lưu ý: Phải truyền đúng tham số giống với tên đã đặt ở store nếu không sẽ lỗi
    /// VD: Bên store tạo 1 hàm truyền 2 biến @username và password thì bên code cũng truyền @username và password
    /// <returns>Record kết quả</returns>
    public DataTable ExecuteStoredProcedure(string procedureName, SqlParameter[]? parameters = null)
    {
        using SqlConnection connection = new(connectionString);
        using SqlCommand command = new(procedureName, connection);

        command.CommandType = CommandType.StoredProcedure;

        if (parameters != null)
        {
            command.Parameters.AddRange(parameters);
        }

        DataTable dataTable = new();
        SqlDataAdapter adapter = new(command);
        adapter.Fill(dataTable);

        return dataTable;
    }

    /// <summary>
    /// Lớp thực thi StoreProcedure
    /// </summary>
    /// <param name="procedureName">Tên StoreProcedure</param>
    /// <param name="parameters">Tham số (có thể truyền hoặc không)</param>
    /// ** Lưu ý: Phải truyền đúng tham số giống với tên đã đặt ở store nếu không sẽ lỗi
    /// VD: Bên store tạo 1 hàm truyền 2 biến @username và password thì bên code cũng truyền @username và password
    /// <returns>Trả về chuổi kết quả</returns>
    public string? ExecuteScalarStoredProcedure(string procedureName, SqlParameter[]? parameters = null)
    {
        using SqlConnection connection = new(connectionString);
        using SqlCommand command = new(procedureName, connection);

        command.CommandType = CommandType.StoredProcedure;


        if (parameters != null)
        {
            command.Parameters.AddRange(parameters);
        }

        connection.Open();

        // Thực thi stored procedure
        object result = command.ExecuteScalar();

        connection.Close();

        // Chuyển đổi kết quả thành chuỗi
        return result != null ? result.ToString() : string.Empty;
    }
}
