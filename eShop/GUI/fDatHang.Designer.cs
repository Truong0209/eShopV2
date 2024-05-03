namespace eShop.GUI
{
    partial class fDatHang
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
            pnlDatHang = new Panel();
            lblTTDatHang = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            dtGiaoHang = new DateTimePicker();
            label1 = new Label();
            dtNgayDat = new DateTimePicker();
            lbNgayDat = new Label();
            groupBox2 = new GroupBox();
            tbDiaChi = new RichTextBox();
            label4 = new Label();
            tbSdtNguoiNhan = new TextBox();
            label3 = new Label();
            tbTenNguoiNhan = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            cbPhuongThucTT = new CheckBox();
            btnThoat = new Button();
            btnDatHang = new Button();
            groupBox4 = new GroupBox();
            lvGioHang = new ListView();
            colTenSanPham = new ColumnHeader();
            colSoLuong = new ColumnHeader();
            colGia = new ColumnHeader();
            colMaSP = new ColumnHeader();
            lblTongTien = new Label();
            label6 = new Label();
            pnlDatHang.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDatHang
            // 
            pnlDatHang.Controls.Add(lblTTDatHang);
            pnlDatHang.Dock = DockStyle.Top;
            pnlDatHang.Location = new Point(0, 0);
            pnlDatHang.Name = "pnlDatHang";
            pnlDatHang.Size = new Size(475, 35);
            pnlDatHang.TabIndex = 0;
            // 
            // lblTTDatHang
            // 
            lblTTDatHang.Anchor = AnchorStyles.None;
            lblTTDatHang.AutoSize = true;
            lblTTDatHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTTDatHang.Location = new Point(128, 5);
            lblTTDatHang.Name = "lblTTDatHang";
            lblTTDatHang.Size = new Size(200, 25);
            lblTTDatHang.TabIndex = 0;
            lblTTDatHang.Text = "Thông Tin Đơn Hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtGiaoHang);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtNgayDat);
            groupBox1.Controls.Add(lbNgayDat);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 136);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thời gian";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(149, 110);
            label5.Name = "label5";
            label5.Size = new Size(256, 17);
            label5.TabIndex = 6;
            label5.Text = "* Đơn hàng có thể giao chậm hơn dự kiến ";
            // 
            // dtGiaoHang
            // 
            dtGiaoHang.Anchor = AnchorStyles.None;
            dtGiaoHang.Enabled = false;
            dtGiaoHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtGiaoHang.Format = DateTimePickerFormat.Short;
            dtGiaoHang.Location = new Point(149, 72);
            dtGiaoHang.Name = "dtGiaoHang";
            dtGiaoHang.Size = new Size(287, 29);
            dtGiaoHang.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 72);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 4;
            label1.Text = "Ngày Giao Hàng:";
            // 
            // dtNgayDat
            // 
            dtNgayDat.Anchor = AnchorStyles.None;
            dtNgayDat.Enabled = false;
            dtNgayDat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtNgayDat.Format = DateTimePickerFormat.Short;
            dtNgayDat.Location = new Point(149, 28);
            dtNgayDat.Name = "dtNgayDat";
            dtNgayDat.Size = new Size(287, 29);
            dtNgayDat.TabIndex = 3;
            // 
            // lbNgayDat
            // 
            lbNgayDat.AutoSize = true;
            lbNgayDat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNgayDat.Location = new Point(11, 30);
            lbNgayDat.Name = "lbNgayDat";
            lbNgayDat.Size = new Size(124, 21);
            lbNgayDat.TabIndex = 2;
            lbNgayDat.Text = "Ngày Đặt Hàng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbDiaChi);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbSdtNguoiNhan);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbTenNguoiNhan);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(451, 234);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin người nhận";
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(158, 124);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(278, 94);
            tbDiaChi.TabIndex = 5;
            tbDiaChi.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 127);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ nhận (*):";
            // 
            // tbSdtNguoiNhan
            // 
            tbSdtNguoiNhan.Location = new Point(158, 76);
            tbSdtNguoiNhan.Name = "tbSdtNguoiNhan";
            tbSdtNguoiNhan.Size = new Size(278, 29);
            tbSdtNguoiNhan.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 80);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 2;
            label3.Text = "SĐT người nhận (*):";
            // 
            // tbTenNguoiNhan
            // 
            tbTenNguoiNhan.Location = new Point(158, 30);
            tbTenNguoiNhan.Name = "tbTenNguoiNhan";
            tbTenNguoiNhan.Size = new Size(278, 29);
            tbTenNguoiNhan.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 34);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên người nhận (*):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbPhuongThucTT);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(13, 599);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(450, 69);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thanh Toán";
            // 
            // cbPhuongThucTT
            // 
            cbPhuongThucTT.AutoSize = true;
            cbPhuongThucTT.Checked = true;
            cbPhuongThucTT.CheckState = CheckState.Checked;
            cbPhuongThucTT.Location = new Point(10, 28);
            cbPhuongThucTT.Name = "cbPhuongThucTT";
            cbPhuongThucTT.Size = new Size(210, 25);
            cbPhuongThucTT.TabIndex = 0;
            cbPhuongThucTT.Text = "Thanh toán khi nhận hàng";
            cbPhuongThucTT.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(157, 674);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(149, 43);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDatHang
            // 
            btnDatHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDatHang.Location = new Point(312, 674);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(151, 43);
            btnDatHang.TabIndex = 6;
            btnDatHang.Text = "Đặt Hàng";
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lvGioHang);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(12, 420);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(451, 143);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Các mặt hàng đã đặt";
            // 
            // lvGioHang
            // 
            lvGioHang.Columns.AddRange(new ColumnHeader[] { colTenSanPham, colSoLuong, colGia, colMaSP });
            lvGioHang.Dock = DockStyle.Fill;
            lvGioHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvGioHang.Location = new Point(3, 25);
            lvGioHang.Name = "lvGioHang";
            lvGioHang.Size = new Size(445, 115);
            lvGioHang.TabIndex = 1;
            lvGioHang.UseCompatibleStateImageBehavior = false;
            lvGioHang.View = View.Details;
            // 
            // colTenSanPham
            // 
            colTenSanPham.Text = "Tên Sản Phẩm";
            colTenSanPham.Width = 280;
            // 
            // colSoLuong
            // 
            colSoLuong.Text = "SL";
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
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(276, 575);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(19, 21);
            lblTongTien.TabIndex = 9;
            lblTongTien.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(175, 575);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 8;
            label6.Text = "TỔNG TIỀN";
            // 
            // fDatHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 726);
            Controls.Add(lblTongTien);
            Controls.Add(label6);
            Controls.Add(groupBox4);
            Controls.Add(btnDatHang);
            Controls.Add(btnThoat);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlDatHang);
            Name = "fDatHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Hàng";
            Load += fDatHang_Load;
            pnlDatHang.ResumeLayout(false);
            pnlDatHang.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDatHang;
        private Label lblTTDatHang;
        private GroupBox groupBox1;
        private DateTimePicker dtNgayDat;
        private Label lbNgayDat;
        private DateTimePicker dtGiaoHang;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tbTenNguoiNhan;
        private Label label2;
        private RichTextBox tbDiaChi;
        private Label label4;
        private TextBox tbSdtNguoiNhan;
        private Label label3;
        private Label label5;
        private GroupBox groupBox3;
        private CheckBox cbPhuongThucTT;
        private Button btnThoat;
        private Button btnDatHang;
        private GroupBox groupBox4;
        private ListView lvGioHang;
        private ColumnHeader colTenSanPham;
        private ColumnHeader colSoLuong;
        private ColumnHeader colGia;
        private ColumnHeader colMaSP;
        private Label lblTongTien;
        private Label label6;
    }
}