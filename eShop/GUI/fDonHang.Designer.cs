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
            lbDonHang = new Label();
            groupBox5 = new GroupBox();
            btnLamMoi = new Button();
            panel31 = new Panel();
            rbNgayGiao = new RadioButton();
            rbNgayDat = new RadioButton();
            label22 = new Label();
            label21 = new Label();
            panel33 = new Panel();
            dtNgayKetThuc = new DateTimePicker();
            label20 = new Label();
            panel32 = new Panel();
            dtNgayBatDau = new DateTimePicker();
            label19 = new Label();
            groupBox2 = new GroupBox();
            lvDonHang = new ListView();
            colSTT_DH = new ColumnHeader();
            colMaDH = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            colNguoiDat = new ColumnHeader();
            colTrangThaiDH = new ColumnHeader();
            colNguoiNhan = new ColumnHeader();
            colSdtNhan = new ColumnHeader();
            colDiaChiNhan = new ColumnHeader();
            colMaTT = new ColumnHeader();
            colPTTT = new ColumnHeader();
            groupBox3 = new GroupBox();
            panel44 = new Panel();
            tb_TrangThai = new TextBox();
            label32 = new Label();
            panel42 = new Panel();
            tb_PTTT = new TextBox();
            label31 = new Label();
            panel41 = new Panel();
            lb_TongTien = new Label();
            label30 = new Label();
            panel40 = new Panel();
            tb_DiaChiNhan = new TextBox();
            label29 = new Label();
            panel39 = new Panel();
            tb_SdtNhan = new TextBox();
            label28 = new Label();
            panel38 = new Panel();
            tb_NguoiNhan = new TextBox();
            label27 = new Label();
            panel37 = new Panel();
            tb_NguoiDat = new TextBox();
            label26 = new Label();
            panel36 = new Panel();
            tb_NgayGiao = new TextBox();
            label25 = new Label();
            panel35 = new Panel();
            tb_NgayDat = new TextBox();
            label24 = new Label();
            panel34 = new Panel();
            tb_MaDH = new TextBox();
            label23 = new Label();
            gbChiTietHH = new GroupBox();
            lvCTDonHang = new ListView();
            colSTT_CTDH = new ColumnHeader();
            colTenSP_CTDH = new ColumnHeader();
            colSoLuong_CTDH = new ColumnHeader();
            colThanhTien_CTDH = new ColumnHeader();
            groupBox5.SuspendLayout();
            panel31.SuspendLayout();
            panel33.SuspendLayout();
            panel32.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel44.SuspendLayout();
            panel42.SuspendLayout();
            panel41.SuspendLayout();
            panel40.SuspendLayout();
            panel39.SuspendLayout();
            panel38.SuspendLayout();
            panel37.SuspendLayout();
            panel36.SuspendLayout();
            panel35.SuspendLayout();
            panel34.SuspendLayout();
            gbChiTietHH.SuspendLayout();
            SuspendLayout();
            // 
            // lbDonHang
            // 
            lbDonHang.AutoSize = true;
            lbDonHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDonHang.Location = new Point(308, 9);
            lbDonHang.Name = "lbDonHang";
            lbDonHang.Size = new Size(301, 25);
            lbDonHang.TabIndex = 1;
            lbDonHang.Text = "Danh sách các đơn hàng của bạn";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnLamMoi);
            groupBox5.Controls.Add(panel31);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(panel33);
            groupBox5.Controls.Add(panel32);
            groupBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(12, 34);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(912, 76);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Bộ lọc";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(486, 21);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(80, 44);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panel31
            // 
            panel31.Controls.Add(rbNgayGiao);
            panel31.Controls.Add(rbNgayDat);
            panel31.Controls.Add(label22);
            panel31.Location = new Point(307, 21);
            panel31.Name = "panel31";
            panel31.Size = new Size(174, 44);
            panel31.TabIndex = 4;
            // 
            // rbNgayGiao
            // 
            rbNgayGiao.AutoSize = true;
            rbNgayGiao.Location = new Point(86, 22);
            rbNgayGiao.Name = "rbNgayGiao";
            rbNgayGiao.Size = new Size(87, 21);
            rbNgayGiao.TabIndex = 3;
            rbNgayGiao.TabStop = true;
            rbNgayGiao.Text = "Ngày giao";
            rbNgayGiao.UseVisualStyleBackColor = true;
            rbNgayGiao.CheckedChanged += rbNgayGiao_CheckedChanged;
            // 
            // rbNgayDat
            // 
            rbNgayDat.AutoSize = true;
            rbNgayDat.Location = new Point(2, 22);
            rbNgayDat.Name = "rbNgayDat";
            rbNgayDat.Size = new Size(81, 21);
            rbNgayDat.TabIndex = 2;
            rbNgayDat.Text = "Ngày Đặt";
            rbNgayDat.UseVisualStyleBackColor = true;
            rbNgayDat.CheckedChanged += rbNgayDat_CheckedChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Top;
            label22.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(32, 17);
            label22.TabIndex = 1;
            label22.Text = "Loại";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(138, 42);
            label21.Name = "label21";
            label21.Size = new Size(28, 21);
            label21.TabIndex = 3;
            label21.Text = "->";
            // 
            // panel33
            // 
            panel33.Controls.Add(dtNgayKetThuc);
            panel33.Controls.Add(label20);
            panel33.Location = new Point(169, 21);
            panel33.Name = "panel33";
            panel33.Size = new Size(130, 44);
            panel33.TabIndex = 2;
            // 
            // dtNgayKetThuc
            // 
            dtNgayKetThuc.Dock = DockStyle.Bottom;
            dtNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtNgayKetThuc.Location = new Point(0, 19);
            dtNgayKetThuc.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            dtNgayKetThuc.Name = "dtNgayKetThuc";
            dtNgayKetThuc.Size = new Size(130, 25);
            dtNgayKetThuc.TabIndex = 3;
            dtNgayKetThuc.ValueChanged += dtNgayKetThuc_ValueChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Top;
            label20.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label20.Location = new Point(0, 0);
            label20.Name = "label20";
            label20.Size = new Size(93, 17);
            label20.TabIndex = 1;
            label20.Text = "Ngày kết thúc";
            // 
            // panel32
            // 
            panel32.Controls.Add(dtNgayBatDau);
            panel32.Controls.Add(label19);
            panel32.Location = new Point(6, 21);
            panel32.Name = "panel32";
            panel32.Size = new Size(130, 44);
            panel32.TabIndex = 1;
            // 
            // dtNgayBatDau
            // 
            dtNgayBatDau.Dock = DockStyle.Bottom;
            dtNgayBatDau.Format = DateTimePickerFormat.Short;
            dtNgayBatDau.Location = new Point(0, 19);
            dtNgayBatDau.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            dtNgayBatDau.Name = "dtNgayBatDau";
            dtNgayBatDau.Size = new Size(130, 25);
            dtNgayBatDau.TabIndex = 2;
            dtNgayBatDau.ValueChanged += dtNgayBatDau_ValueChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Top;
            label19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.Location = new Point(0, 0);
            label19.Name = "label19";
            label19.Size = new Size(88, 17);
            label19.TabIndex = 1;
            label19.Text = "Ngày bắt đầu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvDonHang);
            groupBox2.Location = new Point(10, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 293);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách đơn hàng";
            // 
            // lvDonHang
            // 
            lvDonHang.BorderStyle = BorderStyle.FixedSingle;
            lvDonHang.Columns.AddRange(new ColumnHeader[] { colSTT_DH, colMaDH, columnHeader1, columnHeader2, colNguoiDat, colTrangThaiDH, colNguoiNhan, colSdtNhan, colDiaChiNhan, colMaTT, colPTTT });
            lvDonHang.Dock = DockStyle.Fill;
            lvDonHang.FullRowSelect = true;
            lvDonHang.GridLines = true;
            lvDonHang.Location = new Point(3, 19);
            lvDonHang.Name = "lvDonHang";
            lvDonHang.Size = new Size(539, 271);
            lvDonHang.TabIndex = 0;
            lvDonHang.UseCompatibleStateImageBehavior = false;
            lvDonHang.View = View.Details;
            lvDonHang.SelectedIndexChanged += lvDonHang_SelectedIndexChanged;
            // 
            // colSTT_DH
            // 
            colSTT_DH.Text = "STT";
            colSTT_DH.Width = 40;
            // 
            // colMaDH
            // 
            colMaDH.Text = "Mã ĐH";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ngày Đặt";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ngày giao";
            columnHeader2.Width = 90;
            // 
            // colNguoiDat
            // 
            colNguoiDat.Text = "Người đặt";
            colNguoiDat.Width = 120;
            // 
            // colTrangThaiDH
            // 
            colTrangThaiDH.Text = "Trạng thái";
            colTrangThaiDH.Width = 130;
            // 
            // colNguoiNhan
            // 
            colNguoiNhan.Text = "Người nhận";
            colNguoiNhan.Width = 0;
            // 
            // colSdtNhan
            // 
            colSdtNhan.Text = "colSDTNhan";
            colSdtNhan.Width = 0;
            // 
            // colDiaChiNhan
            // 
            colDiaChiNhan.Text = "colDiaChiNhan";
            colDiaChiNhan.Width = 0;
            // 
            // colMaTT
            // 
            colMaTT.Text = "colMaTT";
            colMaTT.Width = 0;
            // 
            // colPTTT
            // 
            colPTTT.Text = "colPTTT";
            colPTTT.Width = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel44);
            groupBox3.Controls.Add(panel42);
            groupBox3.Controls.Add(panel41);
            groupBox3.Controls.Add(panel40);
            groupBox3.Controls.Add(panel39);
            groupBox3.Controls.Add(panel38);
            groupBox3.Controls.Add(panel37);
            groupBox3.Controls.Add(panel36);
            groupBox3.Controls.Add(panel35);
            groupBox3.Controls.Add(panel34);
            groupBox3.Location = new Point(10, 415);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(914, 232);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin đơn hàng";
            // 
            // panel44
            // 
            panel44.Controls.Add(tb_TrangThai);
            panel44.Controls.Add(label32);
            panel44.Location = new Point(574, 128);
            panel44.Name = "panel44";
            panel44.Size = new Size(334, 46);
            panel44.TabIndex = 10;
            // 
            // tb_TrangThai
            // 
            tb_TrangThai.BorderStyle = BorderStyle.None;
            tb_TrangThai.Enabled = false;
            tb_TrangThai.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            tb_TrangThai.Location = new Point(135, 11);
            tb_TrangThai.Name = "tb_TrangThai";
            tb_TrangThai.Size = new Size(196, 21);
            tb_TrangThai.TabIndex = 2;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label32.Location = new Point(4, 15);
            label32.Name = "label32";
            label32.Size = new Size(73, 17);
            label32.TabIndex = 0;
            label32.Text = "Trạng thái:";
            // 
            // panel42
            // 
            panel42.Controls.Add(tb_PTTT);
            panel42.Controls.Add(label31);
            panel42.Location = new Point(290, 178);
            panel42.Name = "panel42";
            panel42.Size = new Size(423, 46);
            panel42.TabIndex = 8;
            // 
            // tb_PTTT
            // 
            tb_PTTT.BorderStyle = BorderStyle.None;
            tb_PTTT.Enabled = false;
            tb_PTTT.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            tb_PTTT.Location = new Point(113, 14);
            tb_PTTT.Name = "tb_PTTT";
            tb_PTTT.Size = new Size(295, 21);
            tb_PTTT.TabIndex = 1;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label31.Location = new Point(4, 15);
            label31.Name = "label31";
            label31.Size = new Size(107, 17);
            label31.TabIndex = 0;
            label31.Text = "Phương thức TT:";
            // 
            // panel41
            // 
            panel41.Controls.Add(lb_TongTien);
            panel41.Controls.Add(label30);
            panel41.Location = new Point(6, 178);
            panel41.Name = "panel41";
            panel41.Size = new Size(278, 46);
            panel41.TabIndex = 7;
            // 
            // lb_TongTien
            // 
            lb_TongTien.AutoSize = true;
            lb_TongTien.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_TongTien.ForeColor = Color.Red;
            lb_TongTien.Location = new Point(97, 12);
            lb_TongTien.Name = "lb_TongTien";
            lb_TongTien.Size = new Size(0, 20);
            lb_TongTien.TabIndex = 1;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label30.Location = new Point(4, 15);
            label30.Name = "label30";
            label30.Size = new Size(68, 17);
            label30.TabIndex = 0;
            label30.Text = "Tổng tiền:";
            // 
            // panel40
            // 
            panel40.Controls.Add(tb_DiaChiNhan);
            panel40.Controls.Add(label29);
            panel40.Location = new Point(6, 128);
            panel40.Name = "panel40";
            panel40.Size = new Size(562, 46);
            panel40.TabIndex = 6;
            // 
            // tb_DiaChiNhan
            // 
            tb_DiaChiNhan.BorderStyle = BorderStyle.None;
            tb_DiaChiNhan.Enabled = false;
            tb_DiaChiNhan.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            tb_DiaChiNhan.Location = new Point(97, 13);
            tb_DiaChiNhan.Name = "tb_DiaChiNhan";
            tb_DiaChiNhan.Size = new Size(462, 21);
            tb_DiaChiNhan.TabIndex = 1;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label29.Location = new Point(4, 15);
            label29.Name = "label29";
            label29.Size = new Size(89, 17);
            label29.TabIndex = 0;
            label29.Text = "Địa chỉ nhận:";
            // 
            // panel39
            // 
            panel39.Controls.Add(tb_SdtNhan);
            panel39.Controls.Add(label28);
            panel39.Location = new Point(574, 74);
            panel39.Name = "panel39";
            panel39.Size = new Size(334, 46);
            panel39.TabIndex = 5;
            // 
            // tb_SdtNhan
            // 
            tb_SdtNhan.BorderStyle = BorderStyle.None;
            tb_SdtNhan.Enabled = false;
            tb_SdtNhan.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            tb_SdtNhan.Location = new Point(135, 13);
            tb_SdtNhan.Name = "tb_SdtNhan";
            tb_SdtNhan.Size = new Size(196, 21);
            tb_SdtNhan.TabIndex = 1;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label28.Location = new Point(4, 15);
            label28.Name = "label28";
            label28.Size = new Size(120, 17);
            label28.TabIndex = 0;
            label28.Text = "Số ĐT người nhận:";
            // 
            // panel38
            // 
            panel38.Controls.Add(tb_NguoiNhan);
            panel38.Controls.Add(label27);
            panel38.Location = new Point(290, 74);
            panel38.Name = "panel38";
            panel38.Size = new Size(278, 46);
            panel38.TabIndex = 4;
            // 
            // tb_NguoiNhan
            // 
            tb_NguoiNhan.BorderStyle = BorderStyle.None;
            tb_NguoiNhan.Enabled = false;
            tb_NguoiNhan.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            tb_NguoiNhan.Location = new Point(93, 14);
            tb_NguoiNhan.Name = "tb_NguoiNhan";
            tb_NguoiNhan.Size = new Size(182, 21);
            tb_NguoiNhan.TabIndex = 1;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label27.Location = new Point(4, 15);
            label27.Name = "label27";
            label27.Size = new Size(83, 17);
            label27.TabIndex = 0;
            label27.Text = "Người nhận:";
            // 
            // panel37
            // 
            panel37.Controls.Add(tb_NguoiDat);
            panel37.Controls.Add(label26);
            panel37.Location = new Point(6, 74);
            panel37.Name = "panel37";
            panel37.Size = new Size(278, 46);
            panel37.TabIndex = 3;
            // 
            // tb_NguoiDat
            // 
            tb_NguoiDat.BorderStyle = BorderStyle.None;
            tb_NguoiDat.Enabled = false;
            tb_NguoiDat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            tb_NguoiDat.Location = new Point(97, 13);
            tb_NguoiDat.Name = "tb_NguoiDat";
            tb_NguoiDat.Size = new Size(176, 21);
            tb_NguoiDat.TabIndex = 1;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label26.Location = new Point(4, 15);
            label26.Name = "label26";
            label26.Size = new Size(71, 17);
            label26.TabIndex = 0;
            label26.Text = "Người đặt:";
            // 
            // panel36
            // 
            panel36.Controls.Add(tb_NgayGiao);
            panel36.Controls.Add(label25);
            panel36.Location = new Point(574, 22);
            panel36.Name = "panel36";
            panel36.Size = new Size(334, 46);
            panel36.TabIndex = 2;
            // 
            // tb_NgayGiao
            // 
            tb_NgayGiao.BorderStyle = BorderStyle.None;
            tb_NgayGiao.Enabled = false;
            tb_NgayGiao.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            tb_NgayGiao.Location = new Point(135, 13);
            tb_NgayGiao.Name = "tb_NgayGiao";
            tb_NgayGiao.Size = new Size(196, 21);
            tb_NgayGiao.TabIndex = 1;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label25.Location = new Point(4, 15);
            label25.Name = "label25";
            label25.Size = new Size(128, 17);
            label25.TabIndex = 0;
            label25.Text = "Ngày giao (dự kiến):";
            // 
            // panel35
            // 
            panel35.Controls.Add(tb_NgayDat);
            panel35.Controls.Add(label24);
            panel35.Location = new Point(290, 22);
            panel35.Name = "panel35";
            panel35.Size = new Size(278, 46);
            panel35.TabIndex = 1;
            // 
            // tb_NgayDat
            // 
            tb_NgayDat.BorderStyle = BorderStyle.None;
            tb_NgayDat.Enabled = false;
            tb_NgayDat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            tb_NgayDat.Location = new Point(93, 14);
            tb_NgayDat.Name = "tb_NgayDat";
            tb_NgayDat.Size = new Size(182, 21);
            tb_NgayDat.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label24.Location = new Point(4, 15);
            label24.Name = "label24";
            label24.Size = new Size(65, 17);
            label24.TabIndex = 0;
            label24.Text = "Ngày đặt:";
            // 
            // panel34
            // 
            panel34.Controls.Add(tb_MaDH);
            panel34.Controls.Add(label23);
            panel34.Location = new Point(6, 22);
            panel34.Name = "panel34";
            panel34.Size = new Size(278, 46);
            panel34.TabIndex = 0;
            // 
            // tb_MaDH
            // 
            tb_MaDH.BorderStyle = BorderStyle.None;
            tb_MaDH.Enabled = false;
            tb_MaDH.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            tb_MaDH.Location = new Point(97, 12);
            tb_MaDH.Name = "tb_MaDH";
            tb_MaDH.Size = new Size(176, 21);
            tb_MaDH.TabIndex = 1;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label23.Location = new Point(4, 13);
            label23.Name = "label23";
            label23.Size = new Size(95, 17);
            label23.TabIndex = 0;
            label23.Text = "Mã Đơn Hàng:";
            // 
            // gbChiTietHH
            // 
            gbChiTietHH.Controls.Add(lvCTDonHang);
            gbChiTietHH.Location = new Point(558, 116);
            gbChiTietHH.Name = "gbChiTietHH";
            gbChiTietHH.Size = new Size(366, 293);
            gbChiTietHH.TabIndex = 19;
            gbChiTietHH.TabStop = false;
            gbChiTietHH.Text = "Chi tiết các mặt hàng trong đơn";
            // 
            // lvCTDonHang
            // 
            lvCTDonHang.Columns.AddRange(new ColumnHeader[] { colSTT_CTDH, colTenSP_CTDH, colSoLuong_CTDH, colThanhTien_CTDH });
            lvCTDonHang.Dock = DockStyle.Fill;
            lvCTDonHang.GridLines = true;
            lvCTDonHang.Location = new Point(3, 19);
            lvCTDonHang.Name = "lvCTDonHang";
            lvCTDonHang.Size = new Size(360, 271);
            lvCTDonHang.TabIndex = 0;
            lvCTDonHang.UseCompatibleStateImageBehavior = false;
            lvCTDonHang.View = View.Details;
            // 
            // colSTT_CTDH
            // 
            colSTT_CTDH.Text = "STT";
            colSTT_CTDH.Width = 40;
            // 
            // colTenSP_CTDH
            // 
            colTenSP_CTDH.Text = "Tên Sản Phẩm";
            colTenSP_CTDH.Width = 150;
            // 
            // colSoLuong_CTDH
            // 
            colSoLuong_CTDH.Text = "SL";
            colSoLuong_CTDH.Width = 50;
            // 
            // colThanhTien_CTDH
            // 
            colThanhTien_CTDH.Text = "Thành Tiền";
            colThanhTien_CTDH.Width = 110;
            // 
            // fDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 651);
            Controls.Add(gbChiTietHH);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(lbDonHang);
            Name = "fDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đơn hàng";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel33.ResumeLayout(false);
            panel33.PerformLayout();
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel44.ResumeLayout(false);
            panel44.PerformLayout();
            panel42.ResumeLayout(false);
            panel42.PerformLayout();
            panel41.ResumeLayout(false);
            panel41.PerformLayout();
            panel40.ResumeLayout(false);
            panel40.PerformLayout();
            panel39.ResumeLayout(false);
            panel39.PerformLayout();
            panel38.ResumeLayout(false);
            panel38.PerformLayout();
            panel37.ResumeLayout(false);
            panel37.PerformLayout();
            panel36.ResumeLayout(false);
            panel36.PerformLayout();
            panel35.ResumeLayout(false);
            panel35.PerformLayout();
            panel34.ResumeLayout(false);
            panel34.PerformLayout();
            gbChiTietHH.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbDonHang;
        private GroupBox groupBox5;
        private Button btnLamMoi;
        private Panel panel31;
        private RadioButton rbNgayGiao;
        private RadioButton rbNgayDat;
        private Label label22;
        private Label label21;
        private Panel panel33;
        private DateTimePicker dtNgayKetThuc;
        private Label label20;
        private Panel panel32;
        private DateTimePicker dtNgayBatDau;
        private Label label19;
        private GroupBox groupBox2;
        private ListView lvDonHang;
        private ColumnHeader colSTT_DH;
        private ColumnHeader colMaDH;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader colNguoiDat;
        private ColumnHeader colTrangThaiDH;
        private ColumnHeader colNguoiNhan;
        private ColumnHeader colSdtNhan;
        private ColumnHeader colDiaChiNhan;
        private ColumnHeader colMaTT;
        private ColumnHeader colPTTT;
        private GroupBox groupBox3;
        private Panel panel44;
        private Label label32;
        private Panel panel42;
        private TextBox tb_PTTT;
        private Label label31;
        private Panel panel41;
        private Label lb_TongTien;
        private Label label30;
        private Panel panel40;
        private TextBox tb_DiaChiNhan;
        private Label label29;
        private Panel panel39;
        private TextBox tb_SdtNhan;
        private Label label28;
        private Panel panel38;
        private TextBox tb_NguoiNhan;
        private Label label27;
        private Panel panel37;
        private TextBox tb_NguoiDat;
        private Label label26;
        private Panel panel36;
        private TextBox tb_NgayGiao;
        private Label label25;
        private Panel panel35;
        private TextBox tb_NgayDat;
        private Label label24;
        private Panel panel34;
        private TextBox tb_MaDH;
        private Label label23;
        private GroupBox gbChiTietHH;
        private ListView lvCTDonHang;
        private ColumnHeader colSTT_CTDH;
        private ColumnHeader colTenSP_CTDH;
        private ColumnHeader colSoLuong_CTDH;
        private ColumnHeader colThanhTien_CTDH;
        private TextBox tb_TrangThai;
    }
}