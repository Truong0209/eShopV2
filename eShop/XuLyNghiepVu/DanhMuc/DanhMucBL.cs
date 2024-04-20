using eShop.Data;
using eShop.DTOs;
using System.Data;
using static System.Windows.Forms.ListView;

namespace eShop.XuLyNghiepVu.DanhMuc;

public class DanhMucBL
{
    public List<SanPhamDto> LayDanhSachSanPham()
    {
        const string tenProc = "sp_LayDsSanPham";

        var dal = new DataAccessLayer();

        var danhSachSanPham = new List<SanPhamDto>();

        var data = dal.ExecuteStoredProcedure(tenProc);

        if(data is null)
        {
            return danhSachSanPham;
        }

        foreach(DataRow row in data.Rows)
        {
            var sanPham = new SanPhamDto(row);
            danhSachSanPham.Add(sanPham);
        }

        return danhSachSanPham;
    }

    public List<LoaiSanPhamDto> LayDanhSachLoaiSanPham()
    {
        const string tenProc = "sp_LayDsLoaiSanPham";

        var dal = new DataAccessLayer();

        var danhSachLoaiSanPham = new List<LoaiSanPhamDto>();

        var data = dal.ExecuteStoredProcedure(tenProc);

        if (data is null)
        {
            return danhSachLoaiSanPham;
        }

        foreach (DataRow row in data.Rows)
        {
            var sanPham = new LoaiSanPhamDto(row);
            danhSachLoaiSanPham.Add(sanPham);
        }

        return danhSachLoaiSanPham;
    }

    public decimal TinhTongTien(ListViewItemCollection items)
    {
        if(items.Count == 0)
        {
            return 0;
        }
        // Tính tổng tiền
        decimal tongTien = 0;
        foreach (ListViewItem item in items)
        {
            decimal soLuong = decimal.Parse(item.SubItems[1].Text); 
            decimal giaTien = decimal.Parse(item.SubItems[2].Text);
            tongTien += soLuong * giaTien;
        }

        return tongTien;
    }
}
