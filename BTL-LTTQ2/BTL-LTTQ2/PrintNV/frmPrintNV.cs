using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ2.PrintNV
{
    public partial class frmPrintNV : Form
    {
        public frmPrintNV()
        {
            InitializeComponent();
        }

        private void frmPrintNV_Load(object sender, EventArgs e)
        {
            this.tblNhanVienTableAdapter.Fill(this.DataSetNV.tblNhanVien);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
