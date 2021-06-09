using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTL_LTTQ2.Forms
{
    public partial class frmNhanVien : Form
    {
        string tenAnh;
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cboGioiTinh.Text = "";
            dtpNS.Value = DateTime.Today;
            txtDT.Text = "";
            txtDC.Text = "";
            cboCongViec.Text = "";
            txtTKMaNV.Text = "";
            txtTKTenNV.Text = "";
            txtAnh.ResetText();
            picAnh.Image = null;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable tableNV = dtBase.DataReader("select * from tblNhanVien");
            dgvNhanVien.DataSource = tableNV;
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới Tính";
            dgvNhanVien.Columns[3].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns[4].HeaderText = "Điện Thoại";
            dgvNhanVien.Columns[5].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns[6].HeaderText = "Công Việc";
            dgvNhanVien.Columns[7].HeaderText = "Ảnh NV";
            dgvNhanVien.Columns[1].Width = 150;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtpNS.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNS, "Ngày bán không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            dtBase.DataChanger("update tblNhanVien set TenNV=N'" + txtTenNV.Text + "',GioiTinh=N'" + cboGioiTinh.Text + "',NgaySinh=N'" + dtpNS.Value + "',DienThoai=N'" + txtDT.Text + "',DiaChi=N'" + txtDC.Text + "',CongViec=N'" + cboCongViec.Text + "',AnhNV='" + tenAnh + "' where MaNV='" + txtMaNV.Text + "'");
            ResetValue();
            dgvNhanVien.DataSource = dtBase.DataReader("select * from tblNhanVien");
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên có mã là: " + txtMaNV.Text + " không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                dtBase.DataChanger("delete from tblNhanVien where MaNV='" + txtMaNV.Text + "'");
                dgvNhanVien.DataSource = dtBase.DataReader("select * from tblNhanVien");
                ResetValue();
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
                btnThem.Enabled = true;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            frmNhanVien_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtMaNV, "Bạn không được để trống mã nhân viên!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (txtTenNV.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenNV, "Bạn không được để trống tên nhân viên!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (txtDT.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDT, "Bạn không được để trống số điện thoại!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (txtDC.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDC, "Bạn không được để trống địa chỉ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            if (dtpNS.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNS, "Ngày bán không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            DataTable dtNV = dtBase.DataReader("select * from tblNhanVien where MaNV='" + txtMaNV.Text + "'");
            if (dtNV.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại. Vui lòng nhập mã khác");
                txtMaNV.Focus();
                return;
            }
            dtBase.DataChanger("insert into tblNhanVien values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + cboGioiTinh.Text + "','" + dtpNS.Value + "',N'" + txtDT.Text + "',N'" + txtDC.Text + "',N'" + cboCongViec.Text + "','" + tenAnh + "')");
            ResetValue();
            frmNhanVien_Load(sender, e);
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                cboGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                dtpNS.Value = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                txtDT.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtDC.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                cboCongViec.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                tenAnh = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
                picAnh.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().ToString() + "\\Images\\AnhNV\\" + tenAnh);
                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            catch (Exception ex)
            {

            }

            txtMaNV.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "TÌM KIẾM NHÂN VIÊN";

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            string sql = "SELECT * FROM tblNhanVien where MaNV is not null ";
            if (txtTKMaNV.Text.Trim() != "")
            {
                sql += " and MaNV like '%" + txtTKMaNV.Text + "%'";
            }
            if (txtTKTenNV.Text.Trim() != "")
            {
                sql += " AND TenNV like N'%" + txtTKTenNV.Text + "%'";
            }
            if (cboGioiTinh.Text.Trim() != "")
            {
                sql += " AND GioiTinh like N'%" + cboGioiTinh.Text + "%'";
            }
            if (cboCongViec.Text.Trim() != "")
            {
                sql += " AND CongViec like N'%" + cboCongViec.Text + "%'";
            }
            dgvNhanVien.DataSource = dtBase.DataReader(sql);
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') ||
                Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) &&
                Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn chỉ được nhập số nguyên");
                txtDT.Focus();
                e.Handled = true; //Xóa kí tự đã nhập vào textbox nhưng ko đc phép
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            string[] anhpath;
            OpenFileDialog odlgOpen = new OpenFileDialog();
            odlgOpen.Filter = "JPEG Images|*.jpg|All Files|*.*";
            odlgOpen.FilterIndex = 2;
            odlgOpen.RestoreDirectory = true;
            if (odlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.ImageLocation = odlgOpen.FileName;
                txtAnh.Text = odlgOpen.FileName;
                anhpath = odlgOpen.FileName.Split('\\');
                tenAnh = anhpath[anhpath.Length - 1];
            }
        }

        private void btnLuongNV_Click(object sender, EventArgs e)
        {
            Forms.frmLuongNV frmLuongNV = new frmLuongNV();
            frmLuongNV.ShowDialog();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            PrintNV.frmPrintNV frmPrintNV = new PrintNV.frmPrintNV();
            frmPrintNV.ShowDialog();
        }
    }
}
