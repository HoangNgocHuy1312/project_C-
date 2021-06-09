using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ2.PrintHDN
{
    public partial class frmPrintHDN : Form
    {
        public frmPrintHDN()
        {
            InitializeComponent();
        }

        private void frmPrintHDN_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetHDN.tblHoaDonNhap' table. You can move, or remove it, as needed.
            this.tblHoaDonNhapTableAdapter.Fill(this.DataSetHDN.tblHoaDonNhap,txtHDN.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
