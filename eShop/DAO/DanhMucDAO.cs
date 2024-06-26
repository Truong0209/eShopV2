﻿using eShop.Data;
using static System.Windows.Forms.ListView;
using System.Data;
using eShop.Models;
using System.Data.SqlClient;

namespace eShop.DAO;

public class DanhMucDAO
{
    private static DanhMucDAO _instance;

    public static DanhMucDAO Instance
    {
        get { _instance ??= new DanhMucDAO(); return _instance; }
        private set => _instance = value;
    }

    private DanhMucDAO()
    {

    }

    /// <summary>
    /// Kiểm tra sản phẩm đã tồn tại trong giỏ hàng hay chưa (Khi thêm sản phẩm và giỏ hàng)
    /// </summary>
    /// <param name="gioHang">Dữ liệu giỏ hàng hiện tại</param>
    /// <param name="MaSP">Mã sản phẩm cần kiểm tra</param>
    /// <returns>true/ false (tồn tại hoặc không tồn tại)</returns>
    public bool KiemTraSanPhamDaTonTaiTrongGioHang(ListViewItemCollection gioHang, string MaSP)
    {
        foreach (ListViewItem item in gioHang)
        {
            if (int.Parse(item.SubItems[3].Text) == int.Parse(MaSP))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Hàm tính tổng tiền (truyền vào danh sách sản phẩm trong giỏ hàng)
    /// </summary>
    /// <param name="items">danh sách sản phẩm trong giỏ hàng</param>
    /// <returns>tổng tiền</returns>
    public decimal TinhTongTien(ListViewItemCollection items)
    {
        if (items.Count == 0)
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
