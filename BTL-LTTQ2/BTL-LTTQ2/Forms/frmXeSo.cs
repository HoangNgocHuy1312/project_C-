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
    public partial class frmXeSo : Form
    {
        string tenAnh;
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmXeSo()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            string[] anhpath;
            OpenFileDialog odlgOpen = new OpenFileDialog();
            odlgOpen.Filter = "JPEG Images|*.jpg|All Files|*.*";
            odlgOpen.FilterIndex = 1;
            odlgOpen.RestoreDirectory = true;
            if (odlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.ImageLocation = odlgOpen.FileName;
                txtSelectImage.Text = odlgOpen.FileName;
                anhpath = odlgOpen.FileName.Split('\\');
                tenAnh = anhpath[anhpath.Length - 1];
            }
        }

        void ResetValue()
        {
            txtMaXe.Text = "";
            txtTenXe.Text = "";
            cboLoaiXe.Text = "";
            dtpNamSX.Value = DateTime.Today;
            txtBX.Text = "";
            txtTT.Text = "";
            txtSL.Text = "";
            txtDGN.Text = "";
            txtDGB.Text = "";
            txtMau.Text = "";
            txtHangSX.Text = "";
            txtNuocSX.Text = "";
            txtDongCo.Text = "";
            txtSelectImage.Text = "";
            picAnh.Image = null;
        }

        private void frmXeSo_Load(object sender, EventArgs e)
        {
            DataTable tableDM = dtBase.DataReader("select * from tblDMHang");
            dgvXeSo.DataSource = tableDM;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaXe.Enabled = true;
            txtMaXe.Focus();

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = true;
        }

        private void dgvXeSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaXe.Text = dgvXeSo.CurrentRow.Cells[0].Value.ToString();
                txtTenXe.Text = dgvXeSo.CurrentRow.Cells[1].Value.ToString();
                cboLoaiXe.SelectedValue = dgvXeSo.CurrentRow.Cells[2].Value.ToString();
                dtpNamSX.Value = Convert.ToDateTime(dgvXeSo.CurrentRow.Cells["NamSX"].Value);
                txtBX.Text = dgvXeSo.CurrentRow.Cells[4].Value.ToString();
                txtTT.Text = dgvXeSo.CurrentRow.Cells[5].Value.ToString();
                txtSL.Text = dgvXeSo.CurrentRow.Cells[6].Value.ToString();
                txtDGN.Text = dgvXeSo.CurrentRow.Cells[7].Value.ToString();
                txtDGB.Text = dgvXeSo.CurrentRow.Cells[8].Value.ToString();
                txtMau.Text = dgvXeSo.CurrentRow.Cells[9].Value.ToString();
                txtHangSX.Text = dgvXeSo.CurrentRow.Cells[10].Value.ToString();
                txtNuocSX.Text = dgvXeSo.CurrentRow.Cells[11].Value.ToString();
                txtDongCo.Text = dgvXeSo.CurrentRow.Cells[12].Value.ToString();
                tenAnh = dgvXeSo.CurrentRow.Cells[13].Value.ToString();
                picAnh.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().ToString() + "\\Images\\DMHang\\" + tenAnh);
                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {

            }

            txtMaXe.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtpNamSX.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNamSX, "Năm sản xuất không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            dtBase.DataChanger("update tblDMHang set TenHang=N'" + txtTenXe.Text + "',MaLoai=N'" + cboLoaiXe.SelectedValue.ToString() + "',NamSX=N'" + dtpNamSX.Value + "',DungTichBinhXang=N'" + txtBX.Text + "',TenTinhTrang=N'" + txtTT.Text + "',SoLuong=N'" + txtSL.Text + "',DonGiaNhap=N'" + txtDGN.Text + "',DonGiaBan=N'" + txtDGB.Text + "',TenMau=N'" + txtMau.Text + "',TenHangSX=N'" + txtHangSX.Text + "',TenNuocSX=N'" + txtNuocSX.Text + "',TenDongCo=N'" + txtDongCo.Text + "',Image='" + tenAnh + "' where MaHang='" + txtMaXe.Text + "'");
            ResetValue();
            dgvXeSo.DataSource = dtBase.DataReader("select * from tblDMHang");
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm có mã là: " + txtMaXe.Text + " không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                dtBase.DataChanger("delete tblDMHang where MaHang='" + txtMaXe.Text + "'");
                dgvXeSo.DataSource = dtBase.DataReader("select * from tblDMHang");
                MessageBox.Show("Xóa dữ liệu thành công");
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
            frmXeSo_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtpNamSX.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNamSX, "Năm sản xuất không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            DataTable dtXS = dtBase.DataReader("select * from tblDMHang where MaHang='" + txtMaXe.Text + "'");
            if (dtXS.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại. Vui lòng nhập mã khác");
                txtMaXe.Focus();
                return;
            }
            dtBase.DataChanger("insert into tblDMHang values('" + txtMaXe.Text + "',N'" + txtTenXe.Text + "',N'" + cboLoaiXe.SelectedValue.ToString() + "',N'" + dtpNamSX.Value + "',N'" + txtBX.Text + "',N'" + txtTT.Text + "',N'" + txtSL.Text + "',N'" + txtDGN.Text + "',N'" + txtDGB.Text + "',N'" + txtMau.Text + "',N'" + txtHangSX.Text + "',N'" + txtNuocSX.Text + "',N'" + txtDongCo.Text + "','" + tenAnh + "')");
            ResetValue();
            frmXeSo_Load(sender, e);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lblXeSo.Text = "TÌM KIẾM MẶT HÀNG";

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            string sql = "SELECT * FROM tblDMHang where MaHang is not null ";
            if (txtMaXe.Text.Trim() != "")
            {
                sql += " and MaHang like '%" + txtMaXe.Text + "%'";
            }
            if (txtTenXe.Text.Trim() != "")
            {
                sql += " AND TenHang like N'%" + txtTenXe.Text + "%'";
            }
            if (txtMau.Text.Trim() != "")
            {
                sql += " and TenMau like '%" + txtMau.Text + "%'";
            }
            if (txtHangSX.Text.Trim() != "")
            {
                sql += " and TenHangSX like '%" + txtHangSX.Text + "%'";
            }
            if (txtNuocSX.Text.Trim() != "")
            {
                sql += " and TenNuocSX like '%" + txtNuocSX.Text + "%'";
            }

            dgvXeSo.DataSource = dtBase.DataReader(sql);
        }

        private void cboLoaiXe_Click(object sender, EventArgs e)
        {
            cboLoaiXe.DataSource = dtBase.DataReader("select * from tblTheLoai");
            //Giá trị của phần tử 
            cboLoaiXe.ValueMember = "MaLoai";
            //Chuỗi hiển thị của phần tử
            cboLoaiXe.DisplayMember = "TenLoai";
        }

        private void txtDGN_TextChanged(object sender, EventArgs e)
        {
            double gn, gb;
            if (txtDGN.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txtDGN.Text);
            gb = gn + (gn * 30 / 100);
            txtDGB.Text = gb.ToString();
        }
    }
}
