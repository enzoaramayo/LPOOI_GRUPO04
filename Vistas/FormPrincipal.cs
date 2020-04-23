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
    public partial class FormPrincipal : Form
    {
        /*se declaran 2 array de roles y usuarios para el logeo*/
        private Rol[] roles;
        private Usuario[] usuarios;

        public FormPrincipal()
        {
            InitializeComponent();

            roles = new Rol[3];
            usuarios = new Usuario[3];

            roles[0] = new Rol("V1", "Vendedor");
            roles[1] = new Rol("A1", "Administrador");
            roles[2] = new Rol("AU1", "Auditor");

            usuarios[0] = new Usuario(1, "vendito", "123", "Vendito Vendido", roles[0].ROL_Codigo);
            usuarios[1] = new Usuario(2, "admin", "123", "admin administrado", roles[1].ROL_Codigo);
            usuarios[2] = new Usuario(3, "audito", "123", "audusto faustor", roles[2].ROL_Codigo);
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void abrirFormularioHija(object formulario)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form formularioHija = formulario as Form;
            formularioHija.TopLevel = false;
            formularioHija.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formularioHija);
            this.pnlContenedor.Tag = formularioHija;
            formularioHija.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            abrirFormularioHija(new FormCliente());
        }




        /*metodo para verificar los usuarios del sistema*/
        public bool verificarUsuario(string nombre, string pass)
        {
            bool encontrado = false;
            foreach (Usuario u in usuarios)
            {
                if (nombre.Equals(u.USU_NombreUser) && pass.Equals(u.USU_Contrasena))
                    encontrado = true;
            }
            return encontrado;
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            abrirFormularioHija(new FormVehiculo());
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {

        }

        //Punto 11 
        private void btnSalir_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure want to exit??",
                                     "Confirm Si/No",
                                     MessageBoxButtons.YesNo);
            //Aca falta una validación de campos vacios
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Bye bye");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Canceled");
            };
        }
    }
}
