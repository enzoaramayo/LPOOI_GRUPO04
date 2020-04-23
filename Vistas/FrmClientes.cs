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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm<frmAltaCliente>();
            nuevoClienteToolStripMenuItem.BackColor=Color.FromArgb(12, 62, 106); //activa el color de ventana activa
            verificarFormulariosAbiertosParaAgregar(); //verifica si las ventana estan activas-> pero para cumplir con la funcionalidad, la desactivamos momemtaneamente
        }
      
      
        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            AbrirForm <frmModificarCliente>();
            modificarClienteToolStripMenuItem.BackColor = Color.FromArgb(12, 62, 106);

        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm<frmEliminarCliente>();
            eliminarClienteToolStripMenuItem.BackColor = Color.FromArgb(12, 62, 106);
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm<frmBuscarCliente>();
            buscarClienteToolStripMenuItem.BackColor = Color.FromArgb(12, 62, 106);
        }

        /// <summary>
        /// Permite abrir un formulario en el pnlSecundario dentro del Form Clientes
        /// </summary>
     
        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlSecundario.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnlSecundario.Controls.Add(formulario);
                pnlSecundario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        
        public void CerrarForm(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmAltaCliente"] == null) //si formulario esta cerrado ->
            {
                nuevoClienteToolStripMenuItem.BackColor = Color.FromArgb(26, 20, 68);
            }
            if (Application.OpenForms["frmModificarCliente"] == null) //si formulario esta cerrado ->
            {
                nuevoClienteToolStripMenuItem.BackColor = Color.FromArgb(26, 20, 68);
            }
        }


        /// <summary>
        /// Metodo momentaneo para desactivar el color de pestaña activa en el form de clientes
        /// </summary>
        private void verificarFormulariosAbiertosParaAgregar()
        {
            if (Application.OpenForms["frmModificarCliente"] != null) //si formulario esta cerrado ->
            {
                modificarClienteToolStripMenuItem.BackColor = Color.FromArgb(26, 20, 68);
            }
            if (Application.OpenForms["frmEliminarCliente"] != null)
            {
                eliminarClienteToolStripMenuItem.BackColor = Color.FromArgb(26, 20, 68);
            }
            if (Application.OpenForms["frmBuscarCliente"] != null)
            {
                buscarClienteToolStripMenuItem.BackColor = Color.FromArgb(26, 20, 68);
            }
        }
    }

}
