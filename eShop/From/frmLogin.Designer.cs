namespace eShop.From
{
    partial class frmLogin
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
            panel1 = new Panel();
            linkDangKy = new LinkLabel();
            btnDangNhap = new Button();
            btnThoat = new Button();
            tbMatKhau = new TextBox();
            tbTaiKhoan = new TextBox();
            lblMatKhau = new Label();
            lblTaiKhoan = new Label();
            lblDangNhap = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkDangKy);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(tbMatKhau);
            panel1.Controls.Add(tbTaiKhoan);
            panel1.Controls.Add(lblMatKhau);
            panel1.Controls.Add(lblTaiKhoan);
            panel1.Controls.Add(lblDangNhap);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 220);
            panel1.TabIndex = 0;
            // 
            // linkDangKy
            // 
            linkDangKy.AutoSize = true;
            linkDangKy.Cursor = Cursors.Hand;
            linkDangKy.Location = new Point(207, 191);
            linkDangKy.Name = "linkDangKy";
            linkDangKy.Size = new Size(129, 15);
            linkDangKy.TabIndex = 14;
            linkDangKy.TabStop = true;
            linkDangKy.Text = "Bạn chưa có tài khoản?";
            linkDangKy.LinkClicked += linkDangKy_LinkClicked;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.Font = new Font("Segoe UI", 12F);
            btnDangNhap.Location = new Point(112, 137);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(149, 42);
            btnDangNhap.TabIndex = 13;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F);
            btnThoat.Location = new Point(283, 137);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(141, 42);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Font = new Font("Segoe UI", 12F);
            tbMatKhau.Location = new Point(113, 92);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(311, 29);
            tbMatKhau.TabIndex = 10;
            tbMatKhau.UseSystemPasswordChar = true;
            // 
            // tbTaiKhoan
            // 
            tbTaiKhoan.Font = new Font("Segoe UI", 12F);
            tbTaiKhoan.Location = new Point(113, 48);
            tbTaiKhoan.Name = "tbTaiKhoan";
            tbTaiKhoan.Size = new Size(311, 29);
            tbTaiKhoan.TabIndex = 9;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F);
            lblMatKhau.Location = new Point(25, 92);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(75, 21);
            lblMatKhau.TabIndex = 8;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 12F);
            lblTaiKhoan.Location = new Point(25, 51);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(75, 21);
            lblTaiKhoan.TabIndex = 7;
            lblTaiKhoan.Text = "Tài khoản";
            // 
            // lblDangNhap
            // 
            lblDangNhap.Anchor = AnchorStyles.None;
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangNhap.Location = new Point(188, 10);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(113, 25);
            lblDangNhap.TabIndex = 6;
            lblDangNhap.Text = "Đăng Nhập";
            // 
            // frmLogin
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(476, 245);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += frmLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThoat;
        private TextBox tbMatKhau;
        private TextBox tbTaiKhoan;
        private Label lblMatKhau;
        private Label lblTaiKhoan;
        private Label lblDangNhap;
        private Button btnDangNhap;
        private LinkLabel linkDangKy;
    }
}