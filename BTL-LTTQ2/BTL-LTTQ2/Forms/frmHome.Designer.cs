namespace BTL_LTTQ2.Forms
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCaiDat = new FontAwesome.Sharp.IconButton();
            this.btnTroGiup = new FontAwesome.Sharp.IconButton();
            this.btnNCC = new FontAwesome.Sharp.IconButton();
            this.panelDoanhThu = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsta = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnFaceBook = new System.Windows.Forms.Button();
            this.btnDoanhThu = new FontAwesome.Sharp.IconButton();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.btnHDB = new System.Windows.Forms.Button();
            this.btnHDN = new System.Windows.Forms.Button();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.panelDanhMuc = new System.Windows.Forms.Panel();
            this.btnXeSo = new System.Windows.Forms.Button();
            this.btnDanhMuc = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconList = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShowForm = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelDoanhThu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            this.panelDanhMuc.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconList)).BeginInit();
            this.panelShowForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnCaiDat);
            this.panelMenu.Controls.Add(this.btnTroGiup);
            this.panelMenu.Controls.Add(this.btnNCC);
            this.panelMenu.Controls.Add(this.panelDoanhThu);
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.btnDoanhThu);
            this.panelMenu.Controls.Add(this.btnKhachHang);
            this.panelMenu.Controls.Add(this.btnNhanVien);
            this.panelMenu.Controls.Add(this.panelHoaDon);
            this.panelMenu.Controls.Add(this.btnHoaDon);
            this.panelMenu.Controls.Add(this.panelDanhMuc);
            this.panelMenu.Controls.Add(this.btnDanhMuc);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 749);
            this.panelMenu.TabIndex = 1;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCaiDat.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.btnCaiDat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCaiDat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCaiDat.IconSize = 32;
            this.btnCaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.Location = new System.Drawing.Point(0, 640);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCaiDat.Size = new System.Drawing.Size(200, 50);
            this.btnCaiDat.TabIndex = 15;
            this.btnCaiDat.Text = "Cài Đặt";
            this.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTroGiup.FlatAppearance.BorderSize = 0;
            this.btnTroGiup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroGiup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTroGiup.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnTroGiup.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTroGiup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTroGiup.IconSize = 32;
            this.btnTroGiup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroGiup.Location = new System.Drawing.Point(0, 590);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTroGiup.Size = new System.Drawing.Size(200, 50);
            this.btnTroGiup.TabIndex = 14;
            this.btnTroGiup.Text = "Trợ Giúp";
            this.btnTroGiup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroGiup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTroGiup.UseVisualStyleBackColor = true;
            this.btnTroGiup.Click += new System.EventHandler(this.btnTroGiup_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNCC.IconChar = FontAwesome.Sharp.IconChar.ProjectDiagram;
            this.btnNCC.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNCC.IconSize = 32;
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(0, 540);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNCC.Size = new System.Drawing.Size(200, 50);
            this.btnNCC.TabIndex = 13;
            this.btnNCC.Text = "Nhà CC";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // panelDoanhThu
            // 
            this.panelDoanhThu.Controls.Add(this.btnThongKe);
            this.panelDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoanhThu.Location = new System.Drawing.Point(0, 490);
            this.panelDoanhThu.Name = "panelDoanhThu";
            this.panelDoanhThu.Size = new System.Drawing.Size(200, 50);
            this.panelDoanhThu.TabIndex = 10;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.Location = new System.Drawing.Point(0, 0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(200, 40);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsta);
            this.groupBox1.Controls.Add(this.btnGmail);
            this.groupBox1.Controls.Add(this.btnFaceBook);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 694);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liên Hệ";
            // 
            // btnInsta
            // 
            this.btnInsta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsta.BackgroundImage")));
            this.btnInsta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsta.FlatAppearance.BorderSize = 0;
            this.btnInsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsta.Location = new System.Drawing.Point(123, 19);
            this.btnInsta.Name = "btnInsta";
            this.btnInsta.Size = new System.Drawing.Size(30, 36);
            this.btnInsta.TabIndex = 2;
            this.btnInsta.UseVisualStyleBackColor = true;
            this.btnInsta.Click += new System.EventHandler(this.btnInsta_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGmail.BackgroundImage")));
            this.btnGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGmail.FlatAppearance.BorderSize = 0;
            this.btnGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGmail.Location = new System.Drawing.Point(77, 19);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(30, 36);
            this.btnGmail.TabIndex = 1;
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnFaceBook
            // 
            this.btnFaceBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFaceBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFaceBook.BackgroundImage")));
            this.btnFaceBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFaceBook.FlatAppearance.BorderSize = 0;
            this.btnFaceBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaceBook.Location = new System.Drawing.Point(31, 19);
            this.btnFaceBook.Name = "btnFaceBook";
            this.btnFaceBook.Size = new System.Drawing.Size(30, 36);
            this.btnFaceBook.TabIndex = 0;
            this.btnFaceBook.UseVisualStyleBackColor = true;
            this.btnFaceBook.Click += new System.EventHandler(this.btnFaceBook_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoanhThu.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnDoanhThu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDoanhThu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoanhThu.IconSize = 32;
            this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.Location = new System.Drawing.Point(0, 440);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDoanhThu.Size = new System.Drawing.Size(200, 50);
            this.btnDoanhThu.TabIndex = 7;
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.btnKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.IconSize = 32;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 390);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(200, 50);
            this.btnKhachHang.TabIndex = 6;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.Child;
            this.btnNhanVien.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.IconSize = 32;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 340);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(200, 50);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.btnHDB);
            this.panelHoaDon.Controls.Add(this.btnHDN);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHoaDon.Location = new System.Drawing.Point(0, 250);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(200, 90);
            this.panelHoaDon.TabIndex = 4;
            // 
            // btnHDB
            // 
            this.btnHDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnHDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHDB.FlatAppearance.BorderSize = 0;
            this.btnHDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDB.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHDB.Location = new System.Drawing.Point(0, 40);
            this.btnHDB.Name = "btnHDB";
            this.btnHDB.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHDB.Size = new System.Drawing.Size(200, 40);
            this.btnHDB.TabIndex = 1;
            this.btnHDB.Text = "Hóa Đơn Bán";
            this.btnHDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHDB.UseVisualStyleBackColor = false;
            this.btnHDB.Click += new System.EventHandler(this.btnHDB_Click);
            // 
            // btnHDN
            // 
            this.btnHDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnHDN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHDN.FlatAppearance.BorderSize = 0;
            this.btnHDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDN.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHDN.Location = new System.Drawing.Point(0, 0);
            this.btnHDN.Name = "btnHDN";
            this.btnHDN.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHDN.Size = new System.Drawing.Size(200, 40);
            this.btnHDN.TabIndex = 0;
            this.btnHDN.Text = "Hóa Đơn Nhập";
            this.btnHDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHDN.UseVisualStyleBackColor = false;
            this.btnHDN.Click += new System.EventHandler(this.btnHDN_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnHoaDon.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDon.IconSize = 32;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 200);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(200, 50);
            this.btnHoaDon.TabIndex = 3;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.Controls.Add(this.btnXeSo);
            this.panelDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhMuc.Location = new System.Drawing.Point(0, 150);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(200, 50);
            this.panelDanhMuc.TabIndex = 2;
            // 
            // btnXeSo
            // 
            this.btnXeSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnXeSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXeSo.FlatAppearance.BorderSize = 0;
            this.btnXeSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXeSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXeSo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXeSo.Location = new System.Drawing.Point(0, 0);
            this.btnXeSo.Name = "btnXeSo";
            this.btnXeSo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnXeSo.Size = new System.Drawing.Size(200, 40);
            this.btnXeSo.TabIndex = 0;
            this.btnXeSo.Text = "Mặt Hàng";
            this.btnXeSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXeSo.UseVisualStyleBackColor = false;
            this.btnXeSo.Click += new System.EventHandler(this.btnXeSo_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDanhMuc.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnDanhMuc.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhMuc.IconSize = 32;
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 100);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(200, 50);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh Mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 80);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTitleBar.Controls.Add(this.iconList);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(804, 50);
            this.panelTitleBar.TabIndex = 2;
            // 
            // iconList
            // 
            this.iconList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconList.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconList.IconColor = System.Drawing.Color.Gainsboro;
            this.iconList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconList.Location = new System.Drawing.Point(3, 12);
            this.iconList.Name = "iconList";
            this.iconList.Size = new System.Drawing.Size(32, 32);
            this.iconList.TabIndex = 2;
            this.iconList.TabStop = false;
            this.iconList.Click += new System.EventHandler(this.iconList_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(323, 12);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(78, 29);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelShowForm
            // 
            this.panelShowForm.AutoSize = true;
            this.panelShowForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShowForm.BackgroundImage")));
            this.panelShowForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShowForm.Controls.Add(this.lblUserName);
            this.panelShowForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowForm.Location = new System.Drawing.Point(200, 50);
            this.panelShowForm.Name = "panelShowForm";
            this.panelShowForm.Size = new System.Drawing.Size(804, 699);
            this.panelShowForm.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUserName.Location = new System.Drawing.Point(0, 675);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(44, 24);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "huy";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 749);
            this.Controls.Add(this.panelShowForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelDoanhThu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panelHoaDon.ResumeLayout(false);
            this.panelDanhMuc.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconList)).EndInit();
            this.panelShowForm.ResumeLayout(false);
            this.panelShowForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnTroGiup;
        private FontAwesome.Sharp.IconButton btnNCC;
        private System.Windows.Forms.Panel panelDoanhThu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsta;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnFaceBook;
        private FontAwesome.Sharp.IconButton btnDoanhThu;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.Button btnHDB;
        private System.Windows.Forms.Button btnHDN;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Button btnXeSo;
        private FontAwesome.Sharp.IconButton btnDanhMuc;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconList;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShowForm;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconButton btnCaiDat;
        private System.Windows.Forms.Timer timer1;
    }
}