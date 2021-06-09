using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ2.Forms
{
    public partial class frmHDB : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmHDB()
        {
            InitializeComponent();
        }

        void ResetValue()
        {
            txtMahd.Text = "";
            dtpNgayBan.Value = DateTime.Today;
            txtTenNV.Text = "";
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
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

        private void frmHDB_Load(object sender, EventArgs e)
        {
            DataTable tableHDB = dtBase.DataReader("select * from tblHoaDonBan");
            dgvHDB.DataSource = tableHDB;
            dgvHDB.Columns[0].HeaderText = "Số HDB";
            dgvHDB.Columns[1].HeaderText = "Mã NV";
            dgvHDB.Columns[2].HeaderText = "Ngày Bán";
            dgvHDB.Columns[3].HeaderText = "Mã Khách";
            dgvHDB.Columns[4].HeaderText = "Mã Hàng";
            dgvHDB.Columns[5].HeaderText = "Số Lượng";
            dgvHDB.Columns[6].HeaderText = "Đơn Giá";
            dgvHDB.Columns[7].HeaderText = "Thành Tiền";
            dgvHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable dtNhanVien;
            dtNhanVien = dtBase.DataReader("select * from tblNhanVien");
            cboMaNV.DataSource = dtNhanVien;
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";
            
            DataTable dtKhach;
            dtKhach = dtBase.DataReader("select * from tblKhachHang");
            cboMaKH.DataSource = dtKhach;
            cboMaKH.ValueMember = "MaKhach";
            cboMaKH.DisplayMember = "MaKhach";

            DataTable dtHang;
            dtHang = dtBase.DataReader("select * from tblDMHang");
            cboMaHang.DataSource = dtHang;
            cboMaHang.DisplayMember = "MaHang";
            cboMaHang.ValueMember = "MaHang";
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtKH = dtBase.DataReader("Select * from tblKhachhang where MaKhach='" + cboMaKH.SelectedValue.ToString() + "'");
                txtTenKH.Text = dtKH.Rows[0]["TenKhach"].ToString();
                txtDienThoai.Text= dtKH.Rows[0]["DienThoai"].ToString();
            }
            catch
            {
                txtTenKH.Text = "";
                txtDienThoai.Text = "";
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

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahd.Enabled = false;
            try
            {
                txtMahd.Text = dgvHDB.CurrentRow.Cells["SoHDB"].Value.ToString();
                cboMaNV.Text = dgvHDB.CurrentRow.Cells["MaNV"].Value.ToString();
                dtpNgayBan.Value = Convert.ToDateTime(dgvHDB.CurrentRow.Cells["NgayBan"].Value);
                cboMaKH.Text = dgvHDB.CurrentRow.Cells["MaKhach"].Value.ToString();
                cboMaHang.Text = dgvHDB.CurrentRow.Cells["MaHang"].Value.ToString();
                txtSoLuong.Text = dgvHDB.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = dgvHDB.CurrentRow.Cells["DonGia"].Value.ToString();
                txtThanhTien.Text = dgvHDB.CurrentRow.Cells["ThanhTien"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double sl, gb, tt;
            if (txtDonGia.Text == "")
                gb = 0;
            else
                gb = Convert.ToDouble(txtDonGia.Text);
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            tt = gb * sl;
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
                dtBase.DataChanger("update tblHoaDonBan set MaNV='" + cboMaNV.SelectedValue.ToString() + "',NgayBan='" + dtpNgayBan.Value.Date + "',MaKhach='" + cboMaKH.SelectedValue.ToString() + "',MaHang='" + cboMaHang.SelectedValue.ToString() + "',SoLuong='" + txtSoLuong.Text + "',DonGia='" + txtDonGia.Text + "',ThanhTien='" + txtThanhTien.Text + "' where SoHDB='" + txtMahd.Text + "'");
                ResetValue();
                dgvHDB.DataSource = dtBase.DataReader("select * from tblHoaDonBan");
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
            
            if (dtpNgayBan.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNgayBan, "Ngày bán không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            DataTable dtHDB = dtBase.DataReader("select * from tblHoaDonBan where MaHang='" + txtMahd.Text + "'");
            if (dtHDB.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại. Vui lòng nhập mã khác");
                txtMahd.Focus();
                return;
            }
            dtBase.DataChanger("insert into tblHoaDonBan values('" + txtMahd.Text + "','" + cboMaNV.SelectedValue.ToString() + "','" + dtpNgayBan.Value.Date + "','" + cboMaKH.SelectedValue.ToString() + "','" + cboMaHang.SelectedValue.ToString() + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "','" + txtThanhTien.Text + "')");
            ResetValue();
            DataTable tableHDB = dtBase.DataReader("select * from tblHoaDonBan");
            dgvHDB.DataSource = tableHDB;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn có mã là: " + txtMahd.Text + " không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                dtBase.DataChanger("delete tblHoaDonBan where SoHDB='" + txtMahd.Text + "'");
                dgvHDB.DataSource = dtBase.DataReader("select * from tblHoaDonBan");
                MessageBox.Show("Xóa dữ liệu thành công");
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMahd.Enabled = true;
            DataTable tableHDB = dtBase.DataReader("select * from tblHoaDonBan");
            dgvHDB.DataSource = tableHDB;
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
            int sc = dgvHDB.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvHDB.Rows[i].Cells["ThanhTien"].Value.ToString());
            txtTongTien.Text = thanhtien.ToString();
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblKhachHang where MaKhach is not null ";
            if (cboMaKH.Text.Trim() != "")
            {
                sql += " and MaKhach like '%" + cboMaKH.Text + "%'";
            }
            if (txtTenKH.Text.Trim() != "")
            {
                sql += " AND TenKhach like N'%" + txtTenKH.Text + "%'";
            }
            if (txtDienThoai.Text.Trim() != "")
            {
                sql += " AND DienThoai like N'%" + txtDienThoai.Text + "%'";
            }
            dgvHDB.DataSource = dtBase.DataReader(sql);
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
            dgvHDB.DataSource = dtBase.DataReader(sql);
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
            dgvHDB.DataSource = dtBase.DataReader(sql);
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            PrintHDB.frmPrintHDB frmPrintHDB = new PrintHDB.frmPrintHDB();
            frmPrintHDB.ShowDialog();
        }
    }
}
