using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSP1
{
    public partial class frmLogin : Form
    {
        BD bd = new BD();

        private  bool Mensaje = false;

        private void UnMensaje()
        {
            if (!Mensaje)
            {
                Mensaje = true;
            }
        }


        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboxMódulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdCancelar2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void CmdAceptar2_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == bd.Usuario[0, 0] && txtContraseña.Text == bd.Contraseña[0, 0] && cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 0])
            {
                MessageBox.Show("Se inicio sesión correctamente con módulo de Administración");
                UnMensaje();
            }
            if (txtUsuario.Text == bd.Usuario[0, 0] && txtContraseña.Text == bd.Contraseña[0, 0] && cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 2])
            {
                MessageBox.Show("Se inicio sesión correctamente con módulo de Compra");
                UnMensaje();
            }
            if (txtUsuario.Text == bd.Usuario[0, 0] && txtContraseña.Text == bd.Contraseña[0, 0] && cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 3])
            {
                MessageBox.Show("Se inicio sesión correctamente con módulo de Venta");
                UnMensaje();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña/Moódulo seleccionado incorrecto/s");
                UnMensaje();
            }

            if (txtUsuario.Text == bd.Usuario[0,1] && txtContraseña.Text == bd.Contraseña[0,1] && cboxMódulo.SelectedItem.ToString() == bd.Modulo[0,1])
            {
                MessageBox.Show("Se inicio sesión correctamente con módulo de Sistema");
                UnMensaje();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña/Moódulo seleccionado incorrecto/s");
                UnMensaje();
            }    








        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 10;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.MaxLength = 10;
        }
    }
}
