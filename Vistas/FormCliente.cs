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
    public partial class FormCliente : Form
    {
        /* se declara un objeto de tipo cliente para guardar los datos*/
        private Cliente cliente;

        public FormCliente()
        {
            InitializeComponent();
            
        }

        /*cuando se hace click en el boton registrar, se guardan los datos correspondiente y se limpian
         * los textbox*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();

            DialogResult boton = MessageBox.Show("Esta seguro de agregar el usuario?",
                "Agregar", MessageBoxButtons.OKCancel);
            if (boton.Equals(DialogResult.OK)){
                cliente.CLI_Dni = txtDni.Text;
                cliente.CLI_Nombre = txtNombre.Text;
                cliente.CLI_Apellido = txtApellido.Text;
                cliente.CLI_Telefono = txtTelefono.Text;
                cliente.CLI_Direccion = txtDireccion.Text;

                txtDni.Text = txtDireccion.Text = txtTelefono.Text = txtApellido.Text = txtNombre.Text = "";

                mostrarDatos();
            }
            
            
        }

        /*muestra los datos del cliente agregado*/
        private void mostrarDatos()
        {
            MessageBox.Show("DNI: " + cliente.CLI_Dni + "\nNombre: " + cliente.CLI_Nombre
                + "\nApellido: " + cliente.CLI_Apellido + "\nDireccion: " + cliente.CLI_Direccion
                + "\nTelefono: " + cliente.CLI_Telefono,"Cliente Ingresado",MessageBoxButtons.OK
                ,MessageBoxIcon.Information);
        }

        private void btnCancelarRegistroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}