using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSP1
{
    public partial class frmLoad : Form
    {
        frmLogin lg = new frmLogin();
        public frmLoad()
        {
            InitializeComponent();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            pv.Width += 3;
            if (pv.Width > 599)
            {
                timerLoad.Stop();
                lg.Show();
                
            }
        }
    }
}
