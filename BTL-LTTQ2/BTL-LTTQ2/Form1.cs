using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_LTTQ2.Forms;
using FontAwesome.Sharp;

namespace BTL_LTTQ2
{
    public partial class Form1 : Form
    {
        public static string userName;
        bool Hided;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor - Hàm tạo
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            Hided = false;
            customizeDesing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Xin chào nhân viên " + userName;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(24, 161, 25);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(232, 191, 51);
        }    

        //Kích hoạt các button
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
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

        //Vô hiệu hóa các button
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }    
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(panelDanhMuc);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            showSubMenu(panelHoaDon);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new frmNhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frmKhachHang());
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            showSubMenu(panelDoanhThu);
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmTroGiup());
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            lblTitleChildForm.Text = "Home";
            customizeDesing();
            panelTitleBar.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                panelMenu.Width = panelMenu.Width + 40;
                if (panelMenu.Width == 200)
                {
                    timer1.Stop();
                    Hided = false;
                }
            }
            else
            {
                panelMenu.Width = panelMenu.Width - 40;
                if (panelMenu.Width == 0)
                {
                   
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
            panelShowForm.Width = this.Width;
        }

        private void iconList_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void btnXeSo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new frmXeSo());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new frmHDN());
        }

        private void btnHDB_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new frmHDB());
        }

        private void btnFaceBook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100024326620813");
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com");
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //chỉ mở duy nhất một form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelShowForm.Dock = DockStyle.Fill;
            panelShowForm.Controls.Add(childForm);
            panelShowForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = currentBtn.Text;
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/huy.ero7309/");
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frmNCC());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new frmThongKe());
        }
    }
}