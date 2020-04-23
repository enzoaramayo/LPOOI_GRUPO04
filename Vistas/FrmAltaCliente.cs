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
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = msgBoxFormYesNo.Show("Deseas agregar un nuevo cliente?", "", "Aceptar", "Cancelar");

            if (dialogResult == DialogResult.Yes)
            {
                if (ValidarCampos())//pendiente
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Cli_Nombre = txtNombre.Text;
                    oCliente.Cli_Apellido = txtApellido.Text;
                    oCliente.Cli_Dni = txtDni.Text;
                    oCliente.Cli_Telefono = txtTelefono.Text;
                    oCliente.Cli_Direccion = txtDireccion.Text;

                    //persistir usuario
                    GuardarCliente(oCliente);

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDni.Text = "";
                    txtTelefono.Text = "";
                    txtDireccion.Text = "";
                    this.Close();

                }
                else
                {   
                    MessageBox.Show("Debe completar todos los campos");

                }
            }
        }

        private bool ValidarCampos()
        {
            return true;
        }

        private void GuardarCliente(Cliente oCliente)
        {
            try
            {
                //persistir usuario
                MessageBox.Show("Nombre:" + oCliente.Cli_Nombre.ToString() + "\nApellido:" + oCliente.Cli_Apellido.ToString() + "\nDni:" + oCliente.Cli_Dni.ToString() + "\nDirreción:" + oCliente.Cli_Direccion.ToString() + "\nTelefono:" + oCliente.Cli_Telefono.ToString(), "Datos Cliente Nuevo");
            }
            catch (Exception ex)
            {   //momentameamente queda asi
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {  
            this.Close();
        }
    }
}
