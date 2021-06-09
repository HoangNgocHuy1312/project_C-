using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Forms.frmDangNhap frmlogin = new Forms.frmDangNhap();
            Application.Run(frmlogin);
            if(frmlogin.login==true)
            {
                Application.Run(new Forms.frmHome());
            }    
        }
    }
}
