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
    public partial class frmHDN : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmHDN()
        {
            InitializeComponent();
        }

        void ResetValue()
        {
            txtMahd.Text = "";
            dtpNgayNhap.Value = DateTime.Today;
            txtTenNV.Text = "";
            txtTenNCC.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
        }

        private void frmHDN_Load(object sender, EventArgs e)
        {
            DataTable tableHDN = dtBase.DataReader("select * from tblHoaDonNhap");
            dgvHDN.DataSource = tableHDN;
            dgvHDN.Columns[0].HeaderText = "Số HDN";
            dgvHDN.Columns[1].HeaderText = "Mã NV";
            dgvHDN.Columns[2].HeaderText = "Ngày Nhập";
            dgvHDN.Columns[3].HeaderText = "Mã Hàng";
            dgvHDN.Columns[4].HeaderText = "Số Lượng";
            dgvHDN.Columns[5].HeaderText = "Đơn Giá";
            dgvHDN.Columns[6].HeaderText = "Thành Tiền";
            dgvHDN.Columns[7].HeaderText = "Mã NCC";
            dgvHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable dtNhanVien;
            dtNhanVien = dtBase.DataReader("select * from tblNhanVien");
            cboMaNV.DataSource = dtNhanVien;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";

            DataTable dtNhaCungCap;
            dtNhaCungCap = dtBase.DataReader("select * from tblNhaCungCap");
            cboMaNCC.DataSource = dtNhaCungCap;
            cboMaNCC.DisplayMember = "MaNCC";
            cboMaNCC.ValueMember = "MaNCC";

            DataTable dtHang;
            dtHang = dtBase.DataReader("select * from tblDMHang");
            cboMaHang.DataSource = dtHang;
            cboMaHang.DisplayMember = "MaHang";
            cboMaHang.ValueMember = "MaHang";
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

        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNCC = dtBase.DataReader("Select * from tblNhaCungCap where MaNCC='" + cboMaNCC.SelectedValue.ToString() + "'");
                txtTenNCC.Text = dtNCC.Rows[0]["TenNCC"].ToString();
            }
            catch
            {
                txtTenNCC.Text = "";
            }
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHang = dtBase.DataReader("select * from tblDMHang where MaHang='" + cboMaHang.SelectedValue.ToString() + "'");
                txtTenHang.Text = dtHang.Rows[0]["TenHang"].ToString();
                txtDonGia.Text = dtHang.Rows[0]["DonGiaBan"].ToString();
            }
            catch
            {
                txtDonGia.Text = "";
                txtTenHang.Text = "";
            }
        }

        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMahd.Text = dgvHDN.CurrentRow.Cells["SoHDN"].Value.ToString();
                cboMaNV.Text = dgvHDN.CurrentRow.Cells["MaNV"].Value.ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(dgvHDN.CurrentRow.Cells["NgayNhap"].Value);
                cboMaHang.Text = dgvHDN.CurrentRow.Cells["MaHang"].Value.ToString();
                txtSoLuong.Text = dgvHDN.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = dgvHDN.CurrentRow.Cells["DonGia"].Value.ToString();
                txtThanhTien.Text = dgvHDN.CurrentRow.Cells["ThanhTien"].Value.ToString();
                cboMaNCC.Text = dgvHDN.CurrentRow.Cells["MaNCC"].Value.ToString();

                txtMahd.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double sl, gn, tt;
            if (txtDonGia.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txtDonGia.Text);
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            tt = gn * sl;
            txtThanhTien.Text = tt.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMahd.Enabled = true;
            txtMahd.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dữ liệu sẽ bị thay đổi! ",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                dtBase.DataChanger("update tblHoaDonNhap set MaNV='" + cboMaNV.SelectedValue.ToString() + "',NgayNhap='" + dtpNgayNhap.Value.Date + "',MaHang='" + cboMaHang.SelectedValue.ToString() + "',SoLuong='" + txtSoLuong.Text + "',DonGia='" + txtDonGia.Text + "',ThanhTien='" + txtThanhTien.Text + "',MaNCC='" + cboMaNCC.SelectedValue.ToString() + "' where SoHDN='" + txtMahd.Text + "'");
                ResetValue();
                dgvHDN.DataSource = dtBase.DataReader("select * from tblHoaDonNhap");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (txtSoLuong.Text.Trim() == "")
            {
                errChiTiet.SetError(txtSoLuong, "Bạn không được để trống số lượng!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (dtpNgayNhap.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNgayNhap, "Ngày bán không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            DataTable dtHDN = dtBase.DataReader("select * from tblHoaDonNhap where SoHDN='" + txtMahd.Text + "'");
            if (dtHDN.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại. Vui lòng nhập mã khác");
                txtMahd.Focus();
                return;
            }
            dtBase.DataChanger("insert into tblHoaDonNhap values('" + txtMahd.Text + "','" + cboMaNV.SelectedValue.ToString() + "','" + dtpNgayNhap.Value.Date + "','" + cboMaHang.SelectedValue.ToString() + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "','" + txtThanhTien.Text + "','" + cboMaNCC.SelectedValue.ToString() + "')");
            ResetValue();
            DataTable tableHDN = dtBase.DataReader("select * from tblHoaDonNhap");
            dgvHDN.DataSource = tableHDN;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn có mã là: " + txtMahd.Text + " không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                dtBase.DataChanger("delete tblHoaDonNhap where SoHDN='" + txtMahd.Text + "'");
                dgvHDN.DataSource = dtBase.DataReader("select * from tblHoaDonNhap");
                MessageBox.Show("Xóa dữ liệu thành công");
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMahd.Enabled = true;
            DataTable tableHDN = dtBase.DataReader("select * from tblHoaDonNhap");
            dgvHDN.DataSource = tableHDN;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (btnLuu.Enabled == true)
                {
                    if (MessageBox.Show("Bạn có muốn lưu lại thao tác đang thực hiện không?",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                        btnLuu_Click(sender, e);
                    else
                        this.Close();
                }
                else
                    this.Close();
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int sc = dgvHDN.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvHDN.Rows[i].Cells["ThanhTien"].Value.ToString());
            txtTongTien.Text = thanhtien.ToString();
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblNhanVien where MaNV is not null ";
            if (cboMaNV.Text.Trim() != "")
            {
                sql += " and MaNV like '%" + cboMaNV.Text + "%'";
            }
            if (txtTenNV.Text.Trim() != "")
            {
                sql += " AND TenNV like N'%" + txtTenNV.Text + "%'";
            }
            dgvHDN.DataSource = dtBase.DataReader(sql);
        }

        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblNhaCungCap where MaNCC is not null ";
            if (cboMaNCC.Text.Trim() != "")
            {
                sql += " and MaNCC like '%" + cboMaNCC.Text + "%'";
            }
            if (txtTenNCC.Text.Trim() != "")
            {
                sql += " AND TenNCC like N'%" + txtTenNCC.Text + "%'";
            }
            dgvHDN.DataSource = dtBase.DataReader(sql);
        }

        private void btnTKHang_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblDMHang where MaHang is not null ";
            if (cboMaHang.Text.Trim() != "")
            {
                sql += " and MaHang like '%" + cboMaHang.Text + "%'";
            }
            if (txtTenHang.Text.Trim() != "")
            {
                sql += " AND TenHang like N'%" + txtTenHang.Text + "%'";
            }
            dgvHDN.DataSource = dtBase.DataReader(sql);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') ||
                Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) &&
                Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn chỉ được nhập số nguyên");
                e.Handled = true;
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            PrintHDN.frmPrintHDN frmPrintHDN = new PrintHDN.frmPrintHDN();
            frmPrintHDN.ShowDialog();
        }
    }
}
