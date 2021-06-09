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
    public partial class frmFixPass : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmFixPass()
        {
            InitializeComponent();
        }

        private void HidePass(bool hide)
        {
            txtPassCu.UseSystemPasswordChar = hide;
            txtPassMoi.UseSystemPasswordChar = hide;
            txtNhapLai.UseSystemPasswordChar = hide;
        }    

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblLogin where MaNV is not null ";
            
            if(txtPassCu.Text.Trim() != "")
            {
                sql += " and MatKhau like '%" + txtPassCu.Text + "%'";
            }

            if(txtNhapLai.Text == txtPassMoi.Text)
            {
                dtBase.DataChanger("update tblLogin set MatKhau=N'" + txtPassMoi.Text + "' where MaNV='A07'");
                txtPassCu.ResetText();
                txtPassMoi.ResetText();
                txtNhapLai.ResetText();
                HidePass(true);
                MessageBox.Show("Thay đổi mật khẩu thành công", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại chưa khớp với mật khẩu mới!", "Thông Báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void frmFixPass_Load(object sender, EventArgs e)
        {
               
        }

        private void chkHidePass_Click(object sender, EventArgs e)
        {
            if(chkHidePass.Checked == true)
            {
                HidePass(false);
            }
            if(chkHidePass.Checked == false)
            {
                HidePass(true);
            }    
        }
    }
}
