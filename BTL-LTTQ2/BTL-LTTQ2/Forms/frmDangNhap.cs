using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_LTTQ2.Forms
{
    public partial class frmDangNhap : Form
    {
        string strConnect = "Data Source=ADMIN\\SQLEXPRESS01; DataBase=QLXeMay; Integrated Security=true";

        public static string MaNhanVien;
        public bool login { get; set; }
        public frmDangNhap()
        {
            InitializeComponent();
            login = false;
        }

        private string getID(string TaiKhoan, string MatKhau)
        {
            string id = "";
            SqlConnection sqlconnect = new SqlConnection(strConnect);
            try
            {
                if (sqlconnect.State != ConnectionState.Open)
                {
                    sqlconnect.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM tblLogin WHERE TaiKhoan ='" + TaiKhoan + "' and MatKhau='" + MatKhau + "'", sqlconnect);

                SqlDataAdapter adapterLogin = new SqlDataAdapter(cmd);

                DataTable tableLogin = new DataTable();

                adapterLogin.Fill(tableLogin);

                if (tableLogin != null)
                {
                    foreach (DataRow dr in tableLogin.Rows)
                    {
                        id = dr["MaNV"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            if (sqlconnect.State != ConnectionState.Closed)
            {
                sqlconnect.Close();
                sqlconnect.Dispose();
            }
            return id;
        }

        public static string MaNV = "";

        int dem = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MaNV = getID(txtTK.Text, txtMK.Text);
            if (MaNV != "")
            {
                MessageBox.Show("Đăng nhập thành công", "Thông Báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                login = true;
                frmHome.userName = txtTK.Text;
                this.Close();
            }
            else
            {
                dem++;
                MessageBox.Show("Tài khoản và mật khẩu không đúng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTK.Text = "";
                txtMK.Text = "";
                txtTK.Focus();
                if(dem==2)
                {
                    MessageBox.Show("Bạn đã hết lượt đăng nhập. Hãy thử lại sau!", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }    
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            Environment.Exit(0);
        }
    }
}
