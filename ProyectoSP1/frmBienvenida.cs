using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSP1
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void cmdCerrar_MouseEnter(object sender, EventArgs e)
        {
            cmdCerrar.ForeColor = Color.Black;
        }

        private void cmdCerrar_MouseLeave(object sender, EventArgs e)
        {
            cmdCerrar.ForeColor = Color.Red;
        }
    }
}
