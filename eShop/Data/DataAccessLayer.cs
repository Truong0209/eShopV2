using System.Data.SqlClient;
using System.Data;

namespace eShop.Data;

public class DataAccessLayer
{
    private readonly string connectionString = "Server=.;Database=eShop;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;";

    /// <summary>
    /// Lớp thực thi StoreProcedure
    /// </summary>
    /// <param name="procedureName">Tên StoreProcedure</param>
    /// <param name="parameters">Tham số (có thể truyền hoặc không)</param>
    /// ** Lưu ý: Phải truyền đúng tham số giống với tên đã đặt ở store nếu không sẽ lỗi
    /// VD: Bên store tạo 1 hàm truyền 2 biến @username và password thì bên code cũng truyền @username và password
    /// <returns></returns>
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
}
