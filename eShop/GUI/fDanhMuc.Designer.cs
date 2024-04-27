namespace eShop.From
{
    partial class fDanhMuc
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
            menuStrip1 = new MenuStrip();
            menuDanhMuc = new ToolStripMenuItem();
            menuTaiKhoan = new ToolStripMenuItem();
            menuDangXuat = new ToolStripMenuItem();
            menuDonHang = new ToolStripMenuItem();
            menuAdmin = new ToolStripMenuItem();
            panel2 = new Panel();
            btnXoaTatCa = new Button();
            btnXoaMucDaChon = new Button();
            lvGioHang = new ListView();
            colTenSanPham = new ColumnHeader();
            colSoLuong = new ColumnHeader();
            colGia = new ColumnHeader();
            colMaSP = new ColumnHeader();
            panel4 = new Panel();
            lblMaSP = new Label();
            tbGiaTien = new TextBox();
            tbTenSanPham = new TextBox();
            btnThemGioHang = new Button();
            numSoLuong = new NumericUpDown();
            cbLoaiSanPham = new ComboBox();
            btnDatHang = new Button();
            panel3 = new Panel();
            lblTongTien = new Label();
            label2 = new Label();
            pnSanPham = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            tbTimKiem = new TextBox();
            btnLamMoi = new Button();
            btnLoc = new Button();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDanhMuc, menuDonHang, menuTaiKhoan, menuAdmin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(937, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuDanhMuc
            // 
            menuDanhMuc.Name = "menuDanhMuc";
            menuDanhMuc.Size = new Size(74, 20);
            menuDanhMuc.Text = "Danh Mục";
            // 
            // menuTaiKhoan
            // 
            menuTaiKhoan.DropDownItems.AddRange(new ToolStripItem[] { menuDangXuat });
            menuTaiKhoan.Name = "menuTaiKhoan";
            menuTaiKhoan.Size = new Size(69, 20);
            menuTaiKhoan.Text = "Tài khoản";
            // 
            // menuDangXuat
            // 
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.Size = new Size(180, 22);
            menuDangXuat.Text = "Đăng xuất";
            menuDangXuat.Click += menuDangXuat_Click;
            // 
            // menuDonHang
            // 
            menuDonHang.Name = "menuDonHang";
            menuDonHang.Size = new Size(116, 20);
            menuDonHang.Text = "Đơn hàng của bạn";
            menuDonHang.Click += menuDonHang_Click;
            // 
            // menuAdmin
            // 
            menuAdmin.Name = "menuAdmin";
            menuAdmin.Size = new Size(55, 20);
            menuAdmin.Text = "Admin";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoaTatCa);
            panel2.Controls.Add(btnXoaMucDaChon);
            panel2.Controls.Add(lvGioHang);
            panel2.Location = new Point(557, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 469);
            panel2.TabIndex = 2;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaTatCa.Location = new Point(191, 431);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(173, 35);
            btnXoaTatCa.TabIndex = 5;
            btnXoaTatCa.Text = "Xóa tất cả";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            btnXoaTatCa.Click += btnXoaTatCa_Click;
            // 
            // btnXoaMucDaChon
            // 
            btnXoaMucDaChon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaMucDaChon.Location = new Point(0, 431);
            btnXoaMucDaChon.Name = "btnXoaMucDaChon";
            btnXoaMucDaChon.Size = new Size(185, 35);
            btnXoaMucDaChon.TabIndex = 4;
            btnXoaMucDaChon.Text = "Xóa các mục đã chọn";
            btnXoaMucDaChon.UseVisualStyleBackColor = true;
            btnXoaMucDaChon.Click += btnXoaMucDaChon_Click;
            // 
            // lvGioHang
            // 
            lvGioHang.CheckBoxes = true;
            lvGioHang.Columns.AddRange(new ColumnHeader[] { colTenSanPham, colSoLuong, colGia, colMaSP });
            lvGioHang.Dock = DockStyle.Top;
            lvGioHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvGioHang.Location = new Point(0, 0);
            lvGioHang.Name = "lvGioHang";
            lvGioHang.Size = new Size(372, 425);
            lvGioHang.TabIndex = 0;
            lvGioHang.UseCompatibleStateImageBehavior = false;
            lvGioHang.View = View.Details;
            // 
            // colTenSanPham
            // 
            colTenSanPham.Text = "Tên Sản Phẩm";
            colTenSanPham.Width = 220;
            // 
            // colSoLuong
            // 
            colSoLuong.Text = "SL";
            colSoLuong.Width = 40;
            // 
            // colGia
            // 
            colGia.Text = "Giá";
            colGia.Width = 100;
            // 
            // colMaSP
            // 
            colMaSP.Width = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMaSP);
            panel4.Controls.Add(tbGiaTien);
            panel4.Controls.Add(tbTenSanPham);
            panel4.Controls.Add(btnThemGioHang);
            panel4.Controls.Add(numSoLuong);
            panel4.Location = new Point(557, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(372, 70);
            panel4.TabIndex = 4;
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(212, 13);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(0, 15);
            lblMaSP.TabIndex = 5;
            lblMaSP.Visible = false;
            // 
            // tbGiaTien
            // 
            tbGiaTien.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbGiaTien.Location = new Point(5, 36);
            tbGiaTien.Name = "tbGiaTien";
            tbGiaTien.ReadOnly = true;
            tbGiaTien.Size = new Size(197, 25);
            tbGiaTien.TabIndex = 2;
            // 
            // tbTenSanPham
            // 
            tbTenSanPham.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTenSanPham.Location = new Point(5, 9);
            tbTenSanPham.Name = "tbTenSanPham";
            tbTenSanPham.ReadOnly = true;
            tbTenSanPham.Size = new Size(197, 25);
            tbTenSanPham.TabIndex = 1;
            // 
            // btnThemGioHang
            // 
            btnThemGioHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemGioHang.Location = new Point(254, 9);
            btnThemGioHang.Name = "btnThemGioHang";
            btnThemGioHang.Size = new Size(110, 52);
            btnThemGioHang.TabIndex = 4;
            btnThemGioHang.Text = "Thêm giỏ hàng";
            btnThemGioHang.UseVisualStyleBackColor = true;
            btnThemGioHang.Click += btnThemGioHang_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Font = new Font("Segoe UI", 9.75F);
            numSoLuong.Location = new Point(208, 36);
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(40, 25);
            numSoLuong.TabIndex = 3;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbLoaiSanPham
            // 
            cbLoaiSanPham.Font = new Font("Segoe UI", 9.75F);
            cbLoaiSanPham.FormattingEnabled = true;
            cbLoaiSanPham.Location = new Point(6, 19);
            cbLoaiSanPham.Name = "cbLoaiSanPham";
            cbLoaiSanPham.Size = new Size(197, 25);
            cbLoaiSanPham.TabIndex = 0;
            cbLoaiSanPham.SelectedIndexChanged += cbLoaiSanPham_SelectedIndexChanged;
            // 
            // btnDatHang
            // 
            btnDatHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDatHang.Location = new Point(254, 5);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(110, 54);
            btnDatHang.TabIndex = 3;
            btnDatHang.Text = "Đặt Hàng";
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTongTien);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnDatHang);
            panel3.Location = new Point(557, 578);
            panel3.Name = "panel3";
            panel3.Size = new Size(372, 64);
            panel3.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(106, 22);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(19, 21);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 22);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 5;
            label2.Text = "TỔNG TIỀN";
            // 
            // pnSanPham
            // 
            pnSanPham.AutoScroll = true;
            pnSanPham.Location = new Point(12, 110);
            pnSanPham.Name = "pnSanPham";
            pnSanPham.Size = new Size(539, 532);
            pnSanPham.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbTimKiem);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(cbLoaiSanPham);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 80);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc theo điều kiện";
            // 
            // tbTimKiem
            // 
            tbTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTimKiem.Location = new Point(209, 19);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.PlaceholderText = "Nhập từ khóa tìm kiếm...";
            tbTimKiem.Size = new Size(324, 25);
            tbTimKiem.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(459, 47);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(74, 25);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLoc
            // 
            btnLoc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoc.Location = new Point(379, 47);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(74, 25);
            btnLoc.TabIndex = 5;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // fDanhMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 647);
            Controls.Add(groupBox1);
            Controls.Add(pnSanPham);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "fDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chung";
            FormClosing += frmDanhMuc_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDanhMuc;
        private ToolStripMenuItem menuTaiKhoan;
        private ToolStripMenuItem menuDangXuat;
        private ToolStripMenuItem menuAdmin;
        private Panel panel2;
        private ListView lvGioHang;
        private Panel panel4;
        private ComboBox cbLoaiSanPham;
        private NumericUpDown numSoLuong;
        private Button btnThemGioHang;
        private Button btnDatHang;
        private Panel panel3;
        private Label label2;
        private Label lblTongTien;
        private FlowLayoutPanel pnSanPham;
        private TextBox tbTenSanPham;
        private ColumnHeader colTenSanPham;
        private ColumnHeader colSoLuong;
        private Button btnXoaTatCa;
        private Button btnXoaMucDaChon;
        private GroupBox groupBox1;
        private Button btnLoc;
        private Button btnLamMoi;
        private TextBox tbTimKiem;
        private TextBox tbGiaTien;
        private ColumnHeader colGia;
        private ColumnHeader colMaSP;
        private Label lblMaSP;
        private ToolStripMenuItem menuDonHang;
    }
}