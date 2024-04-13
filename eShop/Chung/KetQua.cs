namespace eShop.Chung;

/// <summary>
/// Lớp kết quả (dùng nếu muốn truyền kết quả từ xử lý nghiệp vụ sang form để tường minh)
/// </summary>
/// <param name="trangThai">Trạng thái (thành công hoặc thất bại)</param>
/// <param name="ThongBao">Thông báo (có thể truyền hoặc không)</param>
/// ** Class đang viết theo kiểu primary constructor c#
public class KetQua(bool trangThai, string ThongBao)
{
    public bool TrangThai { get; set; } = trangThai;
    public string ThongBao { get; set; } = ThongBao;

    public static KetQua ThanhCong(string msg = "")
    {
        return new KetQua(true, msg);
    }

    public static KetQua ThatBai(string msg = "")
    {
        return new KetQua(false, msg);
    }
}
