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
    public partial class frmNCC : Form
    {
        string tenAnh;
        Classes.DataProcess dtBase = new Classes.DataProcess();

        public frmNCC()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            string[] anhpath;
            OpenFileDialog odlgOpen = new OpenFileDialog();
            odlgOpen.Filter = "JPEG Images|*.jpg|All Files|*.*";
            odlgOpen.FilterIndex = 2;
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
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSelectImage.Text = "";
            picAnh.Image = null;
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            DataTable tableNCC = dtBase.DataReader("select * from tblNhaCungCap");
            dgvNCC.DataSource = tableNCC;
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaNCC.Enabled = true;
            txtMaNCC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dtNCC = dtBase.DataReader("select * from tblNhaCungCap where MaNCC='" + txtMaNCC.Text + "'");
            if (dtNCC.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại. Vui lòng nhập mã khác");
                txtMaNCC.Focus();
                return;
            }
            dtBase.DataChanger("insert into tblNhaCungCap values('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "','" + tenAnh + "')");
            ResetValue();
            frmNCC_Load(sender, e);
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Enabled = false;
            try
            {
                txtMaNCC.Text = dgvNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = dgvNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
                tenAnh = dgvNCC.CurrentRow.Cells["AnhLogo"].Value.ToString();
                picAnh.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().ToString() + "\\Images\\LogoHangXe\\" + tenAnh);
                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Dữ liệu sẽ bị thay đổi!", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                dtBase.DataChanger("update tblNhaCungCap set TenNCC=N'" + txtTenNCC.Text + "',AnhLogo='" + tenAnh + "' where MaNCC='" + txtMaNCC.Text + "'");
                ResetValue();
                dgvNCC.DataSource = dtBase.DataReader("select * from tblNhaCungCap");
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + txtTenNCC.Text + " không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                dtBase.DataChanger("delete tblNhaCungCap where MaNCC='" + txtMaNCC.Text + "'");
                dgvNCC.DataSource = dtBase.DataReader("select * from tblNhaCungCap");
                MessageBox.Show("Xóa dữ liệu thành công");
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaNCC.Enabled = true;
            dgvNCC.DataSource = dtBase.DataReader("select * from tblNhaCungCap");
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
            string sql = "SELECT * FROM tblNhaCungCap where MaNCC is not null ";

            if (txtMaNCC.Text.Trim() != "")
            {
                sql += " and MaNCC like '%" + txtMaNCC.Text + "%'";
            }
            
            if (txtTenNCC.Text.Trim() != "")
            {
                sql += " AND TenNCC like N'%" + txtTenNCC.Text + "%'";
            }

            dgvNCC.DataSource = dtBase.DataReader(sql);
        }
    }
}
