using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase1;

namespace Vistas
{
    public partial class formLogin : Form
    {
        /* se declara el formulario principal para verificar los datos de usuario*/
        FormPrincipal formularioPrincial;


        public formLogin()
        {
            InitializeComponent();

            formularioPrincial = new FormPrincipal();

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            lblDatosIncorrectos.Text = "";
            //TODO ...
            
        }


        /*con el evento click se guardan los datos de los textbox y se llama al metodo verficiarUsuario
         * del formulario principal*/
        //User: vendito, Pass= 123;
        //(Y)
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nombreUsuarioActual = txtUser.Text;
            string passUsuarioActual = txtPass.Text;

            if (formularioPrincial.verificarUsuario(nombreUsuarioActual, passUsuarioActual))
            {
                this.Hide();
                MessageBox.Show("Bienvenido/a al sistema: " + nombreUsuarioActual);
                formularioPrincial.ShowDialog();
                this.Close();
            }
            else
            {
                lblDatosIncorrectos.Text = "Datos incorrectos";
            }
        }

        /*eventos para cambiar los colores de los textbox*/
        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.Gainsboro;
            txtUser.ForeColor = Color.Black;
            lblDatosIncorrectos.Text = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.Gray;
            txtUser.ForeColor = Color.White;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.Gray;
            txtPass.ForeColor = Color.White;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.Gainsboro;
            txtPass.ForeColor = Color.Black;
            lblDatosIncorrectos.Text = "";
        }

        private void btnVerificar_MouseHover(object sender, EventArgs e)
        {
            btnVerificar.BackColor = Color.FromArgb(91, 192, 222);
            btnVerificar.ForeColor = Color.White;

        }

        private void btnVerificar_MouseLeave(object sender, EventArgs e)
        {
            btnVerificar.ForeColor = Color.FromArgb(91, 192, 222);
            btnVerificar.BackColor = Color.Transparent;
        }

        private void btnRegistarse_MouseHover(object sender, EventArgs e)
        {
            btnRegistarse.ForeColor = Color.White;
            btnRegistarse.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void btnRegistarse_MouseLeave(object sender, EventArgs e)
        {
            btnRegistarse.ForeColor = Color.FromArgb(0, 192, 192);
            btnRegistarse.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Acá borré el metodo pictureBox1_Click estaba demas
        //????
    }
}

