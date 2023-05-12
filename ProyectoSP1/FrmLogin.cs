using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
            if (txtUsuario.Text == bd.Usuario[0, 0])
            {
                if (txtContraseña.Text == bd.Contraseña[0, 0])
                {
                    if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 0])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Administración");
                    }
                    else if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 2])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Compra");
                    }
                    else if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 3])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Venta");
                    }
                    else
                    {
                        MessageBox.Show("Módulo seleccionado incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            if (txtUsuario.Text == bd.Usuario[0, 1])
            {
                if (txtContraseña.Text == bd.Contraseña[0, 1])
                {
                    if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 1])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Sistema");
                    }
                    else
                    {
                        MessageBox.Show("Módulo seleccionado incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            if (txtUsuario.Text == bd.Usuario[0, 2])
            {
                if (txtContraseña.Text == bd.Contraseña[0, 2])
                {
                    if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 0])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Administración");
                    }
                    else if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 3])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Venta");
                    }
                    else
                    {
                        MessageBox.Show("Módulo seleccionado incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            if (txtUsuario.Text == bd.Usuario[0, 3])
            {
                if (txtContraseña.Text == bd.Contraseña[0, 3])
                {
                    if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 0])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Administración");
                    }
                    else if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 1])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Sistema");
                    }
                    else if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 2])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Compra");
                    }
                    else if (cboxMódulo.SelectedItem.ToString() == bd.Modulo[0, 3])
                    {
                        MessageBox.Show("Se inició sesión correctamente con módulo de Venta");
                    }
                    else
                    {
                        MessageBox.Show("Módulo seleccionado incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
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
