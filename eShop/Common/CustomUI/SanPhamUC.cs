﻿using eShop.Chung;
using eShop.Models;

namespace eShop.Common.CustomUI;

public class SanPhamUC : UserControl
{
    private PictureBox _anhSanPham;
    private Label _tenSanPham;
    private Label _gia;
    public event EventHandler Click;
    private ToolTip _tenSpToolTip; // Biến lưu trữ ToolTip cho PictureBox

    public SanPhamUC(SanPhamModel sanPham)
    {
        InitializeComponents();
        _tenSanPham.Text = ThuGonChuoi(sanPham.TenSanPham);
        _gia.Text = string.Format("Giá: {0:N0} VNĐ", sanPham.Gia);

        string duongDanAnh = CauHinh.DuongDanThuMucAnh + sanPham.HinhAnh;
        // Kiểm tra xem đường dẫn hình ảnh có hợp lệ không trước khi tải lên
        if (File.Exists(duongDanAnh))
        {
            _anhSanPham.Image = Image.FromFile(duongDanAnh);
        }
        else
        {
            string duongDanAnhMacDinh = CauHinh.DuongDanThuMucAnh + CauHinh.AnhMacDinh;
            _anhSanPham.Image = Image.FromFile(duongDanAnhMacDinh); // hình ảnh mặc định
        }

        _anhSanPham.Click += HinhAnhSanPham_Click;
        _anhSanPham.MouseHover += HinhAnhSanPham_Hover;
        _anhSanPham.Tag = sanPham;
    }

    // Hiển thị đầy đủ tên sản phẩm khi hover chuột
    private void HinhAnhSanPham_Hover(object? sender, EventArgs e)
    {
        if (_anhSanPham.Tag is SanPhamModel sanPham)
        {
            _tenSpToolTip.Show(sanPham.TenSanPham, _anhSanPham);
        }
    }

    /// <summary>
    /// Xử lý việc chọn sản phẩm
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HinhAnhSanPham_Click(object? sender, EventArgs e)
    {
        EventHandler clickEvent = Click;
        if (clickEvent != null)
        {
            clickEvent(this, e);
        }
    }

    /// <summary>
    /// Xử lý rút gọn chuổi (Dài hơn 10 kí tự sẽ thay bằng ... phía sau)
    /// </summary>
    /// <param name="chuoi"></param>
    /// <returns></returns>
    private string ThuGonChuoi(string chuoi)
    {
        if (chuoi.Length > 10)
        {
            chuoi = chuoi.Substring(0, 10) + "...";
        }

        return chuoi;
    }

    /// <summary>
    /// Khởi tạo các thành phần
    /// </summary>
    private void InitializeComponents()
    {
        _anhSanPham = new PictureBox
        {
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.StretchImage
        };

        _tenSanPham = new Label
        {
            Dock = DockStyle.Bottom,
            TextAlign = ContentAlignment.MiddleCenter
        };


        _gia = new Label
        {
            Dock = DockStyle.Bottom,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 9.75F, FontStyle.Italic),
            ForeColor = Color.Red
        };

        _tenSpToolTip = new ToolTip();


        Controls.Add(_anhSanPham);
        Controls.Add(_tenSanPham);
        Controls.Add(_gia);
    }
}
