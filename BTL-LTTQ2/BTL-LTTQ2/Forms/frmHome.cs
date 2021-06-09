using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace BTL_LTTQ2.Forms
{
    public partial class frmHome : Form
    {
        public static string userName;
        bool Hided;
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public frmHome()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            customizeDesing();
            Hided = false;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(24, 161, 25);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(232, 191, 51);
            public static Color color7 = Color.FromArgb(189, 103, 94);
            public static Color color8 = Color.FromArgb(203, 77, 206);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                panelTitleBar.BackColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            lblTitleChildForm.Text = "Home";
            customizeDesing();
            panelTitleBar.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void customizeDesing()
        {
            panelDanhMuc.Visible = false;
            panelHoaDon.Visible = false;
            panelDoanhThu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDanhMuc.Visible == true)
                panelDanhMuc.Visible = false;
            if (panelHoaDon.Visible == true)
                panelHoaDon.Visible = false;
            if (panelDoanhThu.Visible == true)
                panelDoanhThu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(panelDanhMuc);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            Forms.frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.ShowDialog();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Xin chào nhân viên " + userName;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            showSubMenu(panelHoaDon);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            showSubMenu(panelDoanhThu);
        }

        private void btnXeSo_Click(object sender, EventArgs e)
        {
            Forms.frmXeSo frmDMHang = new frmXeSo();
            frmDMHang.ShowDialog();
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            Forms.frmHDN frmHDN = new frmHDN();
            frmHDN.ShowDialog();
        }

        private void btnHDB_Click(object sender, EventArgs e)
        {
            Forms.frmHDB frmHDB = new frmHDB();
            frmHDB.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            Forms.frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Forms.frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.ShowDialog();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Forms.frmNCC frmNCC = new frmNCC();
            frmNCC.ShowDialog();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            Forms.frmTroGiup frmTroGiup = new frmTroGiup();
            frmTroGiup.ShowDialog();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            Forms.frmFixPass frmFixPass = new frmFixPass();
            frmFixPass.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                panelMenu.Width = panelMenu.Width + 20;
                if (panelMenu.Width == 200)
                {
                    timer1.Stop();
                    Hided = false;
                }
            }
            else
            {
                panelMenu.Width = panelMenu.Width - 20;
                if (panelMenu.Width == 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void iconList_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnFaceBook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100024326620813");
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com");
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/huy.ero7309/");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
