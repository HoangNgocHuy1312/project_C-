using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ2.PrintLuong
{
    public partial class frmPrintLuong : Form
    {
        public frmPrintLuong()
        {
            InitializeComponent();
        }

        private void frmPrintLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLuong.tblLuong' table. You can move, or remove it, as needed.
            this.tblLuongTableAdapter.Fill(this.DataSetLuong.tblLuong);

            this.reportViewer1.RefreshReport();
        }
    }
}
