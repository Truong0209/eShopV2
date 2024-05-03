namespace eShop.GUI
{
    partial class fAdmin
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
            tabAdmin = new TabControl();
            tabSanPham = new TabPage();
            panel4 = new Panel();
            tbTimKiem = new TextBox();
            btnTimKiem = new Button();
            panel3 = new Panel();
            lvSanPham = new ListView();
            colTenSP = new ColumnHeader();
            colGiaSP = new ColumnHeader();
            colSoLuong = new ColumnHeader();
            colHienThi = new ColumnHeader();
            colLoaiSP = new ColumnHeader();
            colAnhSP = new ColumnHeader();
            colMaLoaiSP = new ColumnHeader();
            colMaSP = new ColumnHeader();
            panel2 = new Panel();
            lbMaSP = new Label();
            panel9 = new Panel();
            cbHienThi = new CheckBox();
            lbDuongDanAnh = new Label();
            btnNhapLai = new Button();
            btnXacNhan = new Button();
            panel8 = new Panel();
            label5 = new Label();
            cbLoaiSanPham = new ComboBox();
            panel7 = new Panel();
            numSoLuong = new NumericUpDown();
            label3 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            numGia = new NumericUpDown();
            label2 = new Label();
            panel5 = new Panel();
            tbTenSanPham = new TextBox();
            label1 = new Label();
            btnChonAnh = new Button();
            pbAnhSanPham = new PictureBox();
            panel1 = new Panel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            tabLoaiSanPham = new TabPage();
            panel12 = new Panel();
            lvLoaiSanPham = new ListView();
            colMaLoaiSanPham = new ColumnHeader();
            colTenLoaiSanPham = new ColumnHeader();
            panel10 = new Panel();
            textBox1 = new TextBox();
            btnTimKiemLoaiSP = new Button();
            panel11 = new Panel();
            lbMaLoaiSanPham = new Label();
            label6 = new Label();
            label7 = new Label();
            btnNhapLaiLoaiSP = new Button();
            btnLuuLoaiSP = new Button();
            panel16 = new Panel();
            tbTenLoaiSP = new TextBox();
            label12 = new Label();
            panel17 = new Panel();
            btnXoaLoaiSanPham = new Button();
            btnLamMoiLoaiSP = new Button();
            btnThemLoaiSP = new Button();
            tabNguoiDung = new TabPage();
            tabDonHang = new TabPage();
            tabAdmin.SuspendLayout();
            tabSanPham.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGia).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhSanPham).BeginInit();
            panel1.SuspendLayout();
            tabLoaiSanPham.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tabSanPham);
            tabAdmin.Controls.Add(tabLoaiSanPham);
            tabAdmin.Controls.Add(tabNguoiDung);
            tabAdmin.Controls.Add(tabDonHang);
            tabAdmin.Dock = DockStyle.Fill;
            tabAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabAdmin.Location = new Point(0, 0);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.SelectedIndex = 0;
            tabAdmin.Size = new Size(941, 651);
            tabAdmin.TabIndex = 0;
            tabAdmin.SelectedIndexChanged += tabAdmin_SelectedIndexChanged;
            // 
            // tabSanPham
            // 
            tabSanPham.Controls.Add(panel4);
            tabSanPham.Controls.Add(panel3);
            tabSanPham.Controls.Add(panel2);
            tabSanPham.Controls.Add(panel1);
            tabSanPham.Location = new Point(4, 26);
            tabSanPham.Name = "tabSanPham";
            tabSanPham.Padding = new Padding(3);
            tabSanPham.Size = new Size(933, 621);
            tabSanPham.TabIndex = 0;
            tabSanPham.Text = "Sản phẩm";
            tabSanPham.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbTimKiem);
            panel4.Controls.Add(btnTimKiem);
            panel4.Location = new Point(550, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 50);
            panel4.TabIndex = 3;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTimKiem.Location = new Point(2, 11);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(236, 29);
            tbTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(244, 8);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(127, 35);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lvSanPham);
            panel3.Location = new Point(6, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(538, 553);
            panel3.TabIndex = 2;
            // 
            // lvSanPham
            // 
            lvSanPham.Columns.AddRange(new ColumnHeader[] { colTenSP, colGiaSP, colSoLuong, colHienThi, colLoaiSP, colAnhSP, colMaLoaiSP, colMaSP });
            lvSanPham.Dock = DockStyle.Fill;
            lvSanPham.GridLines = true;
            lvSanPham.Location = new Point(0, 0);
            lvSanPham.Name = "lvSanPham";
            lvSanPham.ShowItemToolTips = true;
            lvSanPham.Size = new Size(538, 553);
            lvSanPham.TabIndex = 0;
            lvSanPham.UseCompatibleStateImageBehavior = false;
            lvSanPham.View = View.Details;
            lvSanPham.SelectedIndexChanged += lvSanPham_SelectedIndexChanged;
            // 
            // colTenSP
            // 
            colTenSP.Text = "Tên SP";
            colTenSP.Width = 210;
            // 
            // colGiaSP
            // 
            colGiaSP.Text = "Giá SP";
            colGiaSP.Width = 100;
            // 
            // colSoLuong
            // 
            colSoLuong.Text = "SL";
            colSoLuong.Width = 40;
            // 
            // colHienThi
            // 
            colHienThi.Text = "Hiển Thị";
            colHienThi.TextAlign = HorizontalAlignment.Center;
            // 
            // colLoaiSP
            // 
            colLoaiSP.Text = "Loại SP";
            colLoaiSP.Width = 120;
            // 
            // colAnhSP
            // 
            colAnhSP.Text = "Ảnh";
            colAnhSP.Width = 0;
            // 
            // colMaLoaiSP
            // 
            colMaLoaiSP.Text = "Mã Loại SP";
            colMaLoaiSP.Width = 0;
            // 
            // colMaSP
            // 
            colMaSP.Text = "Mã SP";
            colMaSP.Width = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbMaSP);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(lbDuongDanAnh);
            panel2.Controls.Add(btnNhapLai);
            panel2.Controls.Add(btnXacNhan);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnChonAnh);
            panel2.Controls.Add(pbAnhSanPham);
            panel2.Location = new Point(550, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 551);
            panel2.TabIndex = 1;
            // 
            // lbMaSP
            // 
            lbMaSP.AutoSize = true;
            lbMaSP.Location = new Point(197, 132);
            lbMaSP.Name = "lbMaSP";
            lbMaSP.Size = new Size(0, 17);
            lbMaSP.TabIndex = 11;
            lbMaSP.Visible = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(cbHienThi);
            panel9.Location = new Point(9, 438);
            panel9.Name = "panel9";
            panel9.Size = new Size(358, 56);
            panel9.TabIndex = 10;
            // 
            // cbHienThi
            // 
            cbHienThi.AutoSize = true;
            cbHienThi.Checked = true;
            cbHienThi.CheckState = CheckState.Checked;
            cbHienThi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbHienThi.Location = new Point(9, 15);
            cbHienThi.Name = "cbHienThi";
            cbHienThi.Size = new Size(75, 21);
            cbHienThi.TabIndex = 1;
            cbHienThi.Text = "Hiển thị";
            cbHienThi.UseVisualStyleBackColor = true;
            // 
            // lbDuongDanAnh
            // 
            lbDuongDanAnh.AutoSize = true;
            lbDuongDanAnh.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbDuongDanAnh.Location = new Point(9, 176);
            lbDuongDanAnh.Name = "lbDuongDanAnh";
            lbDuongDanAnh.Size = new Size(0, 17);
            lbDuongDanAnh.TabIndex = 9;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(107, 500);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(127, 43);
            btnNhapLai.TabIndex = 8;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(240, 500);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(127, 43);
            btnXacNhan.TabIndex = 7;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(label5);
            panel8.Controls.Add(cbLoaiSanPham);
            panel8.Location = new Point(9, 375);
            panel8.Name = "panel8";
            panel8.Size = new Size(358, 56);
            panel8.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(3, 19);
            label5.Name = "label5";
            label5.Size = new Size(102, 17);
            label5.TabIndex = 1;
            label5.Text = "Loại sản phẩm*";
            // 
            // cbLoaiSanPham
            // 
            cbLoaiSanPham.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbLoaiSanPham.FormattingEnabled = true;
            cbLoaiSanPham.Location = new Point(108, 17);
            cbLoaiSanPham.Name = "cbLoaiSanPham";
            cbLoaiSanPham.Size = new Size(239, 24);
            cbLoaiSanPham.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(numSoLuong);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(9, 313);
            panel7.Name = "panel7";
            panel7.Size = new Size(358, 56);
            panel7.TabIndex = 4;
            // 
            // numSoLuong
            // 
            numSoLuong.Font = new Font("Microsoft Sans Serif", 9.75F);
            numSoLuong.Location = new Point(108, 17);
            numSoLuong.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(91, 22);
            numSoLuong.TabIndex = 1;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 0;
            label3.Text = "Số lượng";
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Controls.Add(numGia);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(9, 251);
            panel6.Name = "panel6";
            panel6.Size = new Size(358, 56);
            panel6.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(304, 18);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 2;
            label4.Text = "VNĐ";
            // 
            // numGia
            // 
            numGia.Font = new Font("Microsoft Sans Serif", 9.75F);
            numGia.Location = new Point(108, 17);
            numGia.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            numGia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numGia.Name = "numGia";
            numGia.Size = new Size(190, 22);
            numGia.TabIndex = 1;
            numGia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(3, 19);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 0;
            label2.Text = "Giá sản phẩm*";
            // 
            // panel5
            // 
            panel5.Controls.Add(tbTenSanPham);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(9, 189);
            panel5.Name = "panel5";
            panel5.Size = new Size(358, 56);
            panel5.TabIndex = 2;
            // 
            // tbTenSanPham
            // 
            tbTenSanPham.Font = new Font("Microsoft Sans Serif", 9.75F);
            tbTenSanPham.Location = new Point(108, 17);
            tbTenSanPham.Name = "tbTenSanPham";
            tbTenSanPham.Size = new Size(239, 22);
            tbTenSanPham.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm*";
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(197, 67);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(140, 33);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn hình ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // pbAnhSanPham
            // 
            pbAnhSanPham.BackgroundImageLayout = ImageLayout.Stretch;
            pbAnhSanPham.BorderStyle = BorderStyle.FixedSingle;
            pbAnhSanPham.ErrorImage = null;
            pbAnhSanPham.Location = new Point(3, 0);
            pbAnhSanPham.Name = "pbAnhSanPham";
            pbAnhSanPham.Size = new Size(159, 164);
            pbAnhSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            pbAnhSanPham.TabIndex = 0;
            pbAnhSanPham.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 50);
            panel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(359, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(170, 43);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(182, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(170, 43);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(170, 43);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // tabLoaiSanPham
            // 
            tabLoaiSanPham.Controls.Add(panel12);
            tabLoaiSanPham.Controls.Add(panel10);
            tabLoaiSanPham.Controls.Add(panel11);
            tabLoaiSanPham.Controls.Add(panel17);
            tabLoaiSanPham.Location = new Point(4, 26);
            tabLoaiSanPham.Name = "tabLoaiSanPham";
            tabLoaiSanPham.Padding = new Padding(3);
            tabLoaiSanPham.Size = new Size(933, 621);
            tabLoaiSanPham.TabIndex = 1;
            tabLoaiSanPham.Text = "Loại sản phẩm";
            tabLoaiSanPham.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(lvLoaiSanPham);
            panel12.Location = new Point(6, 62);
            panel12.Name = "panel12";
            panel12.Size = new Size(532, 551);
            panel12.TabIndex = 8;
            // 
            // lvLoaiSanPham
            // 
            lvLoaiSanPham.Columns.AddRange(new ColumnHeader[] { colMaLoaiSanPham, colTenLoaiSanPham });
            lvLoaiSanPham.Dock = DockStyle.Fill;
            lvLoaiSanPham.GridLines = true;
            lvLoaiSanPham.Location = new Point(0, 0);
            lvLoaiSanPham.Name = "lvLoaiSanPham";
            lvLoaiSanPham.ShowItemToolTips = true;
            lvLoaiSanPham.Size = new Size(532, 551);
            lvLoaiSanPham.TabIndex = 1;
            lvLoaiSanPham.UseCompatibleStateImageBehavior = false;
            lvLoaiSanPham.View = View.Details;
            lvLoaiSanPham.SelectedIndexChanged += lvLoaiSanPham_SelectedIndexChanged;
            // 
            // colMaLoaiSanPham
            // 
            colMaLoaiSanPham.Text = "Mã loại sản phẩm";
            colMaLoaiSanPham.Width = 150;
            // 
            // colTenLoaiSanPham
            // 
            colTenLoaiSanPham.Text = "Tên loại sản phẩm";
            colTenLoaiSanPham.Width = 350;
            // 
            // panel10
            // 
            panel10.Controls.Add(textBox1);
            panel10.Controls.Add(btnTimKiemLoaiSP);
            panel10.Location = new Point(550, 6);
            panel10.Name = "panel10";
            panel10.Size = new Size(375, 50);
            panel10.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(2, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 29);
            textBox1.TabIndex = 5;
            // 
            // btnTimKiemLoaiSP
            // 
            btnTimKiemLoaiSP.Location = new Point(244, 8);
            btnTimKiemLoaiSP.Name = "btnTimKiemLoaiSP";
            btnTimKiemLoaiSP.Size = new Size(127, 35);
            btnTimKiemLoaiSP.TabIndex = 4;
            btnTimKiemLoaiSP.Text = "Tìm kiếm";
            btnTimKiemLoaiSP.UseVisualStyleBackColor = true;
            btnTimKiemLoaiSP.Click += btnTimKiemLoaiSP_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(lbMaLoaiSanPham);
            panel11.Controls.Add(label6);
            panel11.Controls.Add(label7);
            panel11.Controls.Add(btnNhapLaiLoaiSP);
            panel11.Controls.Add(btnLuuLoaiSP);
            panel11.Controls.Add(panel16);
            panel11.Location = new Point(550, 62);
            panel11.Name = "panel11";
            panel11.Size = new Size(375, 551);
            panel11.TabIndex = 6;
            // 
            // lbMaLoaiSanPham
            // 
            lbMaLoaiSanPham.AutoSize = true;
            lbMaLoaiSanPham.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbMaLoaiSanPham.Location = new Point(9, 122);
            lbMaLoaiSanPham.Name = "lbMaLoaiSanPham";
            lbMaLoaiSanPham.Size = new Size(0, 17);
            lbMaLoaiSanPham.TabIndex = 12;
            lbMaLoaiSanPham.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 132);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 11;
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 176);
            label7.Name = "label7";
            label7.Size = new Size(0, 17);
            label7.TabIndex = 9;
            // 
            // btnNhapLaiLoaiSP
            // 
            btnNhapLaiLoaiSP.Location = new Point(111, 65);
            btnNhapLaiLoaiSP.Name = "btnNhapLaiLoaiSP";
            btnNhapLaiLoaiSP.Size = new Size(127, 43);
            btnNhapLaiLoaiSP.TabIndex = 8;
            btnNhapLaiLoaiSP.Text = "Nhập lại";
            btnNhapLaiLoaiSP.UseVisualStyleBackColor = true;
            btnNhapLaiLoaiSP.Click += btnNhapLaiLoaiSP_Click;
            // 
            // btnLuuLoaiSP
            // 
            btnLuuLoaiSP.Location = new Point(244, 65);
            btnLuuLoaiSP.Name = "btnLuuLoaiSP";
            btnLuuLoaiSP.Size = new Size(127, 43);
            btnLuuLoaiSP.TabIndex = 7;
            btnLuuLoaiSP.Text = "Xác nhận";
            btnLuuLoaiSP.UseVisualStyleBackColor = true;
            btnLuuLoaiSP.Click += btnLuuLoaiSP_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(tbTenLoaiSP);
            panel16.Controls.Add(label12);
            panel16.Location = new Point(0, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(375, 56);
            panel16.TabIndex = 2;
            // 
            // tbTenLoaiSP
            // 
            tbTenLoaiSP.Font = new Font("Microsoft Sans Serif", 9.75F);
            tbTenLoaiSP.Location = new Point(133, 17);
            tbTenLoaiSP.Name = "tbTenLoaiSP";
            tbTenLoaiSP.Size = new Size(238, 22);
            tbTenLoaiSP.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label12.Location = new Point(3, 19);
            label12.Name = "label12";
            label12.Size = new Size(124, 17);
            label12.TabIndex = 0;
            label12.Text = "Tên loại sản phẩm*";
            // 
            // panel17
            // 
            panel17.Controls.Add(btnXoaLoaiSanPham);
            panel17.Controls.Add(btnLamMoiLoaiSP);
            panel17.Controls.Add(btnThemLoaiSP);
            panel17.Location = new Point(6, 6);
            panel17.Name = "panel17";
            panel17.Size = new Size(532, 50);
            panel17.TabIndex = 4;
            // 
            // btnXoaLoaiSanPham
            // 
            btnXoaLoaiSanPham.Location = new Point(181, 3);
            btnXoaLoaiSanPham.Name = "btnXoaLoaiSanPham";
            btnXoaLoaiSanPham.Size = new Size(170, 43);
            btnXoaLoaiSanPham.TabIndex = 3;
            btnXoaLoaiSanPham.Text = "Xóa";
            btnXoaLoaiSanPham.UseVisualStyleBackColor = true;
            btnXoaLoaiSanPham.Click += btnXoaLoaiSanPham_Click;
            // 
            // btnLamMoiLoaiSP
            // 
            btnLamMoiLoaiSP.Location = new Point(357, 3);
            btnLamMoiLoaiSP.Name = "btnLamMoiLoaiSP";
            btnLamMoiLoaiSP.Size = new Size(170, 43);
            btnLamMoiLoaiSP.TabIndex = 2;
            btnLamMoiLoaiSP.Text = "Làm mới";
            btnLamMoiLoaiSP.UseVisualStyleBackColor = true;
            btnLamMoiLoaiSP.Click += btnLamMoiLoaiSP_Click;
            // 
            // btnThemLoaiSP
            // 
            btnThemLoaiSP.Location = new Point(6, 3);
            btnThemLoaiSP.Name = "btnThemLoaiSP";
            btnThemLoaiSP.Size = new Size(170, 43);
            btnThemLoaiSP.TabIndex = 0;
            btnThemLoaiSP.Text = "Thêm mới";
            btnThemLoaiSP.UseVisualStyleBackColor = true;
            btnThemLoaiSP.Click += btnThemLoaiSP_Click;
            // 
            // tabNguoiDung
            // 
            tabNguoiDung.Location = new Point(4, 26);
            tabNguoiDung.Name = "tabNguoiDung";
            tabNguoiDung.Padding = new Padding(3);
            tabNguoiDung.Size = new Size(933, 621);
            tabNguoiDung.TabIndex = 2;
            tabNguoiDung.Text = "Người dùng";
            tabNguoiDung.UseVisualStyleBackColor = true;
            // 
            // tabDonHang
            // 
            tabDonHang.Location = new Point(4, 26);
            tabDonHang.Name = "tabDonHang";
            tabDonHang.Padding = new Padding(3);
            tabDonHang.Size = new Size(933, 621);
            tabDonHang.TabIndex = 3;
            tabDonHang.Text = "Đơn Hàng";
            tabDonHang.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 651);
            Controls.Add(tabAdmin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabAdmin.ResumeLayout(false);
            tabSanPham.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGia).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhSanPham).EndInit();
            panel1.ResumeLayout(false);
            tabLoaiSanPham.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdmin;
        private TabPage tabSanPham;
        private TabPage tabLoaiSanPham;
        private TabPage tabNguoiDung;
        private TabPage tabDonHang;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnThem;
        private ListView lvSanPham;
        private Button btnChonAnh;
        private PictureBox pbAnhSanPham;
        private Panel panel5;
        private TextBox tbTenSanPham;
        private Label label1;
        private Panel panel6;
        private Label label2;
        private Panel panel7;
        private Label label3;
        private Panel panel8;
        private Button btnNhapLai;
        private Button btnXacNhan;
        private NumericUpDown numSoLuong;
        private NumericUpDown numGia;
        private Label label4;
        private Label lbDuongDanAnh;
        private Button btnTimKiem;
        private TextBox tbTimKiem;
        private ColumnHeader colLoaiSP;
        private ColumnHeader colTenSP;
        private ColumnHeader colGiaSP;
        private ColumnHeader colSoLuong;
        private ColumnHeader colHienThi;
        private Panel panel9;
        private CheckBox cbHienThi;
        private Label label5;
        private ComboBox cbLoaiSanPham;
        private ColumnHeader colAnhSP;
        private ColumnHeader colMaLoaiSP;
        private Label lbMaSP;
        private ColumnHeader colMaSP;
        private Panel panel10;
        private TextBox textBox1;
        private Button btnTimKiemLoaiSP;
        private Panel panel11;
        private Label label6;
        private Label label7;
        private Button btnNhapLaiLoaiSP;
        private Button btnLuuLoaiSP;
        private Panel panel16;
        private TextBox tbTenLoaiSP;
        private Label label12;
        private Panel panel17;
        private Button btnLamMoiLoaiSP;
        private Button btnThemLoaiSP;
        private Panel panel12;
        private ListView lvLoaiSanPham;
        private ColumnHeader colMaLoaiSanPham;
        private ColumnHeader colTenLoaiSanPham;
        private Label lbMaLoaiSanPham;
        private Button btnXoaLoaiSanPham;
    }
}