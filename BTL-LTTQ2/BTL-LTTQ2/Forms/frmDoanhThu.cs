using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BTL_LTTQ2.Forms
{
    public partial class frmDoanhThu : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS01; Initial Catalog = QLXeMay ; Integrated Security=true");
        Classes.DataProcess dtBase = new Classes.DataProcess();
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select sum(ThanhTien) as N'Doanh Thu', MONTH(NgayBan) as Thang from tblHoaDonBan group by MONTH(NgayBan) ", conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh Thu";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //  chart1.Series["Series1"].XValueMember = "thang";
            //   chart1.Series["Series1"].YValueMembers = "doanhthu";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(dt.Rows[i]["Thang"], dt.Rows[i]["Doanh Thu"]);
            }
            btnLoad.Enabled = false;
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            DataTable dtDoanhThu = dtBase.DataReader("select sum(ThanhTien) as N'Doanh Thu', MONTH(NgayBan) as Thang from tblHoaDonBan group by MONTH(NgayBan)");
            dgv.DataSource = dtDoanhThu;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
    }
}
