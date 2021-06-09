namespace BTL_LTTQ2.Forms
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.dtpTimeSau = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeTruoc = new System.Windows.Forms.DateTimePicker();
            this.btnTimTime = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "VNĐ";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(99, 221);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(602, 206);
            this.dgvThongKe.TabIndex = 108;
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(492, 157);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(165, 27);
            this.txtTong.TabIndex = 112;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.BackColor = System.Drawing.Color.Transparent;
            this.btnTinhTong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTinhTong.BackgroundImage")));
            this.btnTinhTong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTong.Location = new System.Drawing.Point(510, 76);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(136, 50);
            this.btnTinhTong.TabIndex = 111;
            this.btnTinhTong.UseVisualStyleBackColor = false;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(238, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 36);
            this.label2.TabIndex = 110;
            this.label2.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBoQua);
            this.groupBox3.Controls.Add(this.dtpTimeSau);
            this.groupBox3.Controls.Add(this.dtpTimeTruoc);
            this.groupBox3.Controls.Add(this.btnTimTime);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(99, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 120);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo thời gian";
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.Transparent;
            this.btnBoQua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoQua.BackgroundImage")));
            this.btnBoQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoQua.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoQua.Location = new System.Drawing.Point(179, 63);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBoQua.Size = new System.Drawing.Size(145, 48);
            this.btnBoQua.TabIndex = 86;
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // dtpTimeSau
            // 
            this.dtpTimeSau.CustomFormat = "MM/dd/yyyy";
            this.dtpTimeSau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeSau.Location = new System.Drawing.Point(179, 26);
            this.dtpTimeSau.Name = "dtpTimeSau";
            this.dtpTimeSau.Size = new System.Drawing.Size(149, 27);
            this.dtpTimeSau.TabIndex = 85;
            // 
            // dtpTimeTruoc
            // 
            this.dtpTimeTruoc.CustomFormat = "MM/dd/yyyy";
            this.dtpTimeTruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeTruoc.Location = new System.Drawing.Point(6, 26);
            this.dtpTimeTruoc.Name = "dtpTimeTruoc";
            this.dtpTimeTruoc.Size = new System.Drawing.Size(139, 27);
            this.dtpTimeTruoc.TabIndex = 84;
            // 
            // btnTimTime
            // 
            this.btnTimTime.BackColor = System.Drawing.Color.Transparent;
            this.btnTimTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimTime.BackgroundImage")));
            this.btnTimTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimTime.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimTime.Location = new System.Drawing.Point(0, 63);
            this.btnTimTime.Name = "btnTimTime";
            this.btnTimTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTimTime.Size = new System.Drawing.Size(145, 48);
            this.btnTimTime.TabIndex = 4;
            this.btnTimTime.UseVisualStyleBackColor = false;
            this.btnTimTime.Click += new System.EventHandler(this.btnTimTime_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(587, 454);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 55);
            this.btnThoat.TabIndex = 114;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(35, 454);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(114, 55);
            this.btnDoanhThu.TabIndex = 115;
            this.btnDoanhThu.Text = "Biểu Đồ";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.DateTimePicker dtpTimeSau;
        private System.Windows.Forms.DateTimePicker dtpTimeTruoc;
        private System.Windows.Forms.Button btnTimTime;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoanhThu;
    }
}