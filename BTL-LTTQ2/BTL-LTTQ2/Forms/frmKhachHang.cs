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
    public partial class frmKhachHang : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        void ResetValue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDCKH.Text = "";
            txtDTKH.Text = "";
            txtTKMaKH.Text = "";
            txtTKTenKH.Text = "";
            txtTKDTKH.Text = "";
            cboQuan.ResetText();
            cboQuan.Items.Clear();
            cboTinh.ResetText();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable tableKH = dtBase.DataReader("select * from tblKhachHang");
            dgvKhachHang.DataSource = tableKH;
            dgvKhachHang.Columns[0].HeaderText = "Mã Khách";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách";
            dgvKhachHang.Columns[2].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[3].HeaderText = "Tỉnh/Thành phố";
            dgvKhachHang.Columns[4].HeaderText = "Quận/Huyện";
            dgvKhachHang.Columns[5].HeaderText = "Chi Tiết";
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            txtMaKH.Enabled = true;
            txtMaKH.Focus();

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = true;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtDTKH.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                cboTinh.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                cboQuan.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
                txtDCKH.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

            }

            txtMaKH.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dtBase.DataChanger("update tblKhachHang set TenKhach=N'" + txtTenKH.Text + "',DienThoai=N'" + txtDTKH.Text + "',Tinh=N'" + cboTinh.Text + "',Quan=N'" + cboQuan.Text + "',Pho=N'" + txtDCKH.Text + "' where MaKhach='" + txtMaKH.Text + "'");
            ResetValue();
            dgvKhachHang.DataSource = dtBase.DataReader("select * from tblKhachHang");
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng có mã là: " + txtMaKH.Text + " không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                dtBase.DataChanger("delete tblKhachHang where MaKhach='" + txtMaKH.Text + "'");
                dgvKhachHang.DataSource = dtBase.DataReader("select * from tblKhachHang");
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
            frmKhachHang_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dtKH = dtBase.DataReader("select * from tblKhachHang where MaKhach='" + txtMaKH.Text + "'");
            if (dtKH.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại. Vui lòng nhập mã khác");
                txtMaKH.Focus();
                return;
            }
            dtBase.DataChanger("insert into tblKhachHang values('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDTKH.Text + "',N'" + cboTinh.Text + "',N'" + cboQuan.Text + "',N'" + txtDCKH.Text + "')");
            frmKhachHang_Load(sender, e);
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
            lblTieuDe.Text = "TÌM KIẾM KHÁCH HÀNG";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            string sql = "SELECT * FROM tblKhachHang where MaKhach is not null ";
            if (txtTKMaKH.Text.Trim() != "")
            {
                sql += " and MaKhach like '%" + txtTKMaKH.Text + "%'";
            }
            if (txtTKDTKH.Text.Trim() != "")
            {
                sql += " AND DienThoai like N'%" + txtTKDTKH.Text + "%'";
            }
            dgvKhachHang.DataSource = dtBase.DataReader(sql);
        }

        private void txtDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') ||
                Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) &&
                Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Bạn chỉ được nhập số nguyên");
                txtDTKH.Focus();
                e.Handled = true; //Xóa kí tự đã nhập vào textbox nhưng ko đc phép
            }
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinh.SelectedItem == "Hà Nội")
            {
                cboQuan.ResetText();
                cboQuan.Items.Clear();
                cboQuan.Items.Add("Ba Đình");
                cboQuan.Items.Add("Tây Hồ");
                cboQuan.Items.Add("Đống Đa");
                cboQuan.Items.Add("Cầu Giấy");
                cboQuan.Items.Add("Hoàn Kiếm");
            }

            if (cboTinh.Text == "Nam Định")
            {
                cboQuan.ResetText();
                cboQuan.Items.Clear();
                cboQuan.Items.AddRange(new object[] {
                    "Hải Hậu",
                    "Giao Thủy",
                    "Nghĩa Hưng",
                    "Vụ Bản",
                    "Mỹ Lộc" });
            }

            if (cboTinh.SelectedItem == "Nghệ An")
            {
                cboQuan.ResetText();
                cboQuan.Items.Clear();
                cboQuan.Items.Add("Quế Phong");
                cboQuan.Items.Add("Anh Sơn");
                cboQuan.Items.Add("Đô Lương");
                cboQuan.Items.Add("Yên Thành");
                cboQuan.Items.Add("Diễn Châu");
            }

            if (cboTinh.Text == "Thái Bình")
            {
                cboQuan.ResetText();
                cboQuan.Items.Clear();
                cboQuan.Items.AddRange(new object[] {
                    "Kiến Xương",
                    "Lê Lợi",
                    "Tiền Hải",
                    "Đông Hưng",
                    "Thái Thụy" });
            }
        }
    }
}
