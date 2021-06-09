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
    public partial class frmLuongNV : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmLuongNV()
        {
            InitializeComponent();
        }

        void ResetValue()
        {
            cboNgayCong.ResetText();
            cboThue.ResetText();
            txtTienLuong.ResetText();
            cboMaNV.ResetText();
            cboThang.ResetText();
            cboMucLuong.ResetText();
            txtTong.ResetText();
            txtTenNV.ResetText();
        }

        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            dgvLuong.DataSource = dtBase.DataReader("select * from tblLuong");
            dgvLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cboMaNV_Click(object sender, EventArgs e)
        {
            DataTable dtNhanVien;
            dtNhanVien = dtBase.DataReader("select * from tblNhanVien");
            cboMaNV.DataSource = dtNhanVien;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNV = dtBase.DataReader("Select * from tblNhanVien where MaNV='" + cboMaNV.SelectedValue.ToString() + "'");
                txtTenNV.Text = dtNV.Rows[0]["TenNV"].ToString();
            }
            catch
            {
                txtTenNV.Text = "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Lưu Tiền Lương Của Nhân Viên : " + cboMaNV.Text + "  Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable dtHD = dtBase.DataReader("select * from tblLuong where MaNV='" + cboMaNV.Text + "'");
                if (dtHD.Rows.Count > 0)
                {
                    MessageBox.Show("Mã này đã tồn tại. Vui lòng nhập mã khác");
                    cboMaNV.Focus();
                    return;
                }
                dtBase.DataChanger("insert into tblLuong values('" + cboMaNV.Text + "',N'" + cboThang.Text + "','" + cboNgayCong.Text + "','" + cboMucLuong.Text + "','" + cboThue.Text + "','" + txtTienLuong.Text + "')");
                ResetValue();
                frmLuongNV_Load(sender, e);
            }
        }

        private void cboThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sl, gn, Thue, tt;
            if (cboNgayCong.SelectedItem == "")
                gn = 0;
            else
                gn = Convert.ToDouble(cboNgayCong.SelectedItem);
            if (cboMucLuong.SelectedItem == "")
                sl = 0;
            else
                sl = Convert.ToDouble(cboMucLuong.SelectedItem);
            if (cboThue.SelectedItem == "")
                Thue = 0;
            else
                Thue = Convert.ToDouble(cboThue.SelectedItem);
            tt = gn * sl - Thue;
            txtTienLuong.Text = tt.ToString();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sc = dgvLuong.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvLuong.Rows[i].Cells["TienLuong"].Value.ToString());
            txtTong.Text = thanhtien.ToString();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tiền lương của nhân viên có mã " + cboMaNV.Text + " không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                dtBase.DataChanger("delete from tblLuong where MaNV='" + cboMaNV.Text + "'");
                dgvLuong.DataSource = dtBase.DataReader("select * from tblLuong");
                MessageBox.Show("Xóa dữ liệu thành công");
                ResetValue();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cboMaNV.Text = dgvLuong.CurrentRow.Cells[0].Value.ToString();
                cboThang.Text = dgvLuong.CurrentRow.Cells[1].Value.ToString();
                cboNgayCong.Text = dgvLuong.CurrentRow.Cells[2].Value.ToString();
                cboMucLuong.Text = dgvLuong.CurrentRow.Cells[3].Value.ToString();
                cboThue.Text = dgvLuong.CurrentRow.Cells[4].Value.ToString();
                txtTienLuong.Text = dgvLuong.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            PrintLuong.frmPrintLuong frmPrintLuong = new PrintLuong.frmPrintLuong();
            frmPrintLuong.ShowDialog();
        }
    }
}
