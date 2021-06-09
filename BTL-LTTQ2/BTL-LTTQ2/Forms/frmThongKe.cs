using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ2.Forms
{
    public partial class frmThongKe : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnTimTime_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblHoaDonBan where SoHDB is not null ";
            if ((dtpTimeTruoc.Text != "") && (dtpTimeSau.Text != ""))
            {
                sql += " AND NgayBan >= '" + dtpTimeTruoc.Text + "' AND NgayBAN <= '" + dtpTimeSau.Text + "'";
            }
            dgvThongKe.DataSource = dtBase.DataReader(sql);
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int sc = dgvThongKe.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvThongKe.Rows[i].Cells["ThanhTien"].Value.ToString());
            txtTong.Text = thanhtien.ToString();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            dtpTimeTruoc.Value = DateTime.Today;
            dtpTimeSau.Value = DateTime.Today;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            Forms.frmDoanhThu frmDoanhThu = new frmDoanhThu();
            frmDoanhThu.ShowDialog();
        }
    }
}
