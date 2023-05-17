using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSP1
{
    public partial class frmLogin : Form
    {
        BD bd = new BD();
        frmBienvenida bv = new frmBienvenida();
    


        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdCancelar2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void CmdAceptar2_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string Modulo = cboxMódulo.SelectedItem.ToString();
            int Intentos = 0;
            

            switch(true)
            {
                case var _ when Usuario == bd.Usuario[0, 3] && Contraseña == bd.Contraseña[0, 3] && (Modulo == bd.Modulo[0, 0] || Modulo == bd.Modulo[0, 1] || Modulo == bd.Modulo[0, 2] || Modulo == bd.Modulo[0, 3]):

                    MessageBox.Show("Bienvenido GOD");
                    bv.Show();
                    this.Hide();

                    break;

                case var _ when Usuario == bd.Usuario[0, 0] &&  Contraseña == bd.Contraseña[0, 0] && (Modulo == bd.Modulo[0, 0] || Modulo == bd.Modulo[0, 2] || Modulo == bd.Modulo[0, 3]):

                    MessageBox.Show("Bienvenido Admin");
                    bv.Show();
                    this.Hide();

                    break;

                case var _ when Usuario == bd.Usuario[0, 2] && Contraseña == bd.Contraseña[0, 2] && (Modulo == bd.Modulo[0, 0] || Modulo == bd.Modulo[0, 3]):

                    MessageBox.Show("Bienvenido Ceci");
                    bv.Show();
                    this.Hide();

                    break;

                case var _ when Usuario == bd.Usuario[0, 1] && Contraseña == bd.Contraseña[0, 1] &&  Modulo == bd.Modulo[0, 1]:

                    MessageBox.Show("Bienvenido John");
                    bv.Show();
                    this.Hide();

                    break;

                default:

                    if (Intentos > 3)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        Intentos++;
                        MessageBox.Show("Los datos ingresados son incorrectos. Por favor, intenta nuevamente.");
                    }


                    break;

            }
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 10;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.MaxLength = 10;
            txtContraseña.PasswordChar = '#';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
