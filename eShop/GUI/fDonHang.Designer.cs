namespace eShop.GUI
{
    partial class fDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvDonHang = new ListView();
            colMaDonHang = new ColumnHeader();
            colNgayDat = new ColumnHeader();
            colNgayGiao = new ColumnHeader();
            colTrangThai = new ColumnHeader();
            lbDonHang = new Label();
            SuspendLayout();
            // 
            // lvDonHang
            // 
            lvDonHang.Columns.AddRange(new ColumnHeader[] { colMaDonHang, colNgayDat, colNgayGiao, colTrangThai });
            lvDonHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvDonHang.Location = new Point(12, 37);
            lvDonHang.Name = "lvDonHang";
            lvDonHang.Size = new Size(628, 336);
            lvDonHang.TabIndex = 0;
            lvDonHang.UseCompatibleStateImageBehavior = false;
            lvDonHang.View = View.Details;
            // 
            // colMaDonHang
            // 
            colMaDonHang.Text = "Mã đơn hàng";
            colMaDonHang.Width = 120;
            // 
            // colNgayDat
            // 
            colNgayDat.Text = "Ngày đặt hàng";
            colNgayDat.TextAlign = HorizontalAlignment.Center;
            colNgayDat.Width = 150;
            // 
            // colNgayGiao
            // 
            colNgayGiao.Text = "Ngày Giao Hàng";
            colNgayGiao.TextAlign = HorizontalAlignment.Center;
            colNgayGiao.Width = 150;
            // 
            // colTrangThai
            // 
            colTrangThai.Text = "Trạng Thái";
            colTrangThai.TextAlign = HorizontalAlignment.Center;
            colTrangThai.Width = 200;
            // 
            // lbDonHang
            // 
            lbDonHang.AutoSize = true;
            lbDonHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDonHang.Location = new Point(166, 6);
            lbDonHang.Name = "lbDonHang";
            lbDonHang.Size = new Size(301, 25);
            lbDonHang.TabIndex = 1;
            lbDonHang.Text = "Danh sách các đơn hàng của bạn";
            // 
            // fDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 385);
            Controls.Add(lbDonHang);
            Controls.Add(lvDonHang);
            Name = "fDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đơn hàng";
            Load += fDonHang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvDonHang;
        private ColumnHeader colMaDonHang;
        private ColumnHeader colNgayDat;
        private ColumnHeader colNgayGiao;
        private ColumnHeader colTrangThai;
        private Label lbDonHang;
    }
}