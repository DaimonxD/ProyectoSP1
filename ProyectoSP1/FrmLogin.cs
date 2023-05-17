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
        int Intentos = 0;
    


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
            string Modulo = cboxMódulo.SelectedItem?.ToString();


            
            if(!string.IsNullOrEmpty(Modulo))
            {
                switch (true)
                {
                    case var _ when Usuario == bd.Usuario[0, 3] && Contraseña == bd.Contraseña[0, 3] && (Modulo == bd.Modulo[0, 0] || Modulo == bd.Modulo[0, 1] || Modulo == bd.Modulo[0, 2] || Modulo == bd.Modulo[0, 3]):

                        MessageBox.Show("Bienvenido GOD.");
                        bv.Show();
                        this.Hide();

                        break;

                    case var _ when Usuario == bd.Usuario[0, 0] && Contraseña == bd.Contraseña[0, 0] && (Modulo == bd.Modulo[0, 0] || Modulo == bd.Modulo[0, 2] || Modulo == bd.Modulo[0, 3]):

                        MessageBox.Show("Bienvenido Admin.");
                        bv.Show();
                        this.Hide();

                        break;

                    case var _ when Usuario == bd.Usuario[0, 2] && Contraseña == bd.Contraseña[0, 2] && (Modulo == bd.Modulo[0, 0] || Modulo == bd.Modulo[0, 3]):

                        MessageBox.Show("Bienvenido Ceci.");
                        bv.Show();
                        this.Hide();

                        break;

                    case var _ when Usuario == bd.Usuario[0, 1] && Contraseña == bd.Contraseña[0, 1] && Modulo == bd.Modulo[0, 1]:

                        MessageBox.Show("Bienvenido John.");
                        bv.Show();
                        this.Hide();

                        break;

                    default:

                        Intentos++;
                        MessageBox.Show("Usuario y/o Contraseña incorrecto(s) para el Módulo seleccionado. \nIntento  " + Intentos + " de 3.");
                        txtUsuario.Clear();
                        txtContraseña.Clear();

                        break;

                }
             

            }
            else
            {
                MessageBox.Show("Selecciona un Módulo antes de continuar.");
            }
            if (Intentos == 3)
            {
                MessageBox.Show("Cantidad de intentos excedida \nCerrando programa...");
                Process.GetCurrentProcess().Kill();
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

        private void CmdAceptar2_MouseEnter(object sender, EventArgs e)
        {
            CmdAceptar2.ForeColor = Color.Black;
        }

        private void CmdAceptar2_MouseLeave(object sender, EventArgs e)
        {
            CmdAceptar2.ForeColor = Color.Lime;

        }

        private void cmdCancelar2_MouseEnter(object sender, EventArgs e)
        {
            cmdCancelar2.ForeColor = Color.Black;
        }

        private void cmdCancelar2_MouseLeave(object sender, EventArgs e)
        {
            cmdCancelar2.ForeColor = Color.Red;
        }
    }
}
