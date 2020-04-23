using ClasesBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmLogin : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean bandUsuEncontrado = false;
           
            CrearUsuarios();
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            bandUsuEncontrado = ValidarUsuario(usuario, contrasena);
            Form message = new msgBoxForm();
            Form messageError = new msgBoxFormError();
            if (bandUsuEncontrado)
            {
               
                msgBoxForm.mensaje = txtUsuario.Text;
                message.Show();
                this.Hide();
            }
            else
            {  
                msgBoxFormError.mensaje = "Datos de acceso incorrectos";
                messageError.Show();
            }
        }
        public void CrearUsuarios()
        {
            Usuario usuario1 = new Usuario("admin", "admin", "Administrador");
            Usuario usuario2 = new Usuario("usuario2", "usuario2", "Vendedor");
            Usuario usuario3 = new Usuario("usuario3", "usuario3", "Auditor");
            usuarios.Add(usuario1);
            usuarios.Add(usuario2);
            usuarios.Add(usuario3);
        }
        public Boolean ValidarUsuario(string usuario, string contrasena)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.Usu_NombreUsuario == usuario && usu.Usu_Contrasena == contrasena)
                {
                    
                    return true;
                }
            }
            return false;
        }

        private void btnIniciarSesión_MouseHover(object sender, EventArgs e)
        {
            this.btnIniciarSesión.Font = new System.Drawing.Font("Century Gothic", 10.5F , System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        }

        private void btnIniciarSesión_MouseLeave(object sender, EventArgs e)
        {
            this.btnIniciarSesión.Font = new System.Drawing.Font("Century Gothic", 9.75F);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F);
        }
    }
}
