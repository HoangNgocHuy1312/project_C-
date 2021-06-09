using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ2.PrintHDB
{
    public partial class frmPrintHDB : Form
    {
        public frmPrintHDB()
        {
            InitializeComponent();
        }

        private void frmPrintHDB_Load(object sender, EventArgs e)
        {
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetHDB.tblHoaDonBan' table. You can move, or remove it, as needed.
            this.tblHoaDonBanTableAdapter.Fill(this.DataSetHDB.tblHoaDonBan,txtHDB.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
