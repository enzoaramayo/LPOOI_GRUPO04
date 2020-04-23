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
    public partial class FormVehiculo : Form
    {
        private Vehiculo vehiculoAgregar;
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vehiculoAgregar = new Vehiculo();
            DialogResult boton = MessageBox.Show("Esta seguro de agregar el usuario?",
                "Agregar", MessageBoxButtons.OKCancel);
            if (boton.Equals(DialogResult.OK))
            {
                try
                {
                    vehiculoAgregar.VEH_Matricula = "ABC 111";
                    vehiculoAgregar.VEH_Marca = cmBoxMarcas.Text;
                    vehiculoAgregar.VEH_Linea = txtLineaVehiculo.Text;
                    vehiculoAgregar.VEH_Modelo = Convert.ToInt32(txtModelo.Text);
                    vehiculoAgregar.VEH_Color = cmBoxColores.Text;
                    vehiculoAgregar.VEH_Puertas = Convert.ToInt32(txtPuertas.Text);
                    vehiculoAgregar.VEH_Gps = optSi.Checked;
                    vehiculoAgregar.VEH_TipoVehiculo = cmBoxTipo.Text;
                    vehiculoAgregar.VEH_ClaseVehiculo = cmBoxClase.Text;
                    vehiculoAgregar.VEH_Precio = Convert.ToDecimal(txtPrecio.Text);

                    txtLineaVehiculo.Text = txtModelo.Text = txtPuertas.Text = txtPrecio.Text = "";

                    mostrarDatos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Complete los campos correctamente", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
        }

        private void mostrarDatos()
        {
            MessageBox.Show(
                "Matricula: " + vehiculoAgregar.VEH_Matricula
                + "\nMarca: " + vehiculoAgregar.VEH_Marca
                + "\nLinea: " + vehiculoAgregar.VEH_Linea
                + "\nModelo: " + vehiculoAgregar.VEH_Modelo
                + "\nColor: " + vehiculoAgregar.VEH_Color
                + "\nPuertas: " + vehiculoAgregar.VEH_Puertas
                + "\nGPS: " + vehiculoAgregar.VEH_Gps
                + "\nTipo: " + vehiculoAgregar.VEH_TipoVehiculo
                + "\nClase: " + vehiculoAgregar.VEH_ClaseVehiculo
                + "\nPrecio: " + vehiculoAgregar.VEH_Precio
                ,"Vehiculo Registrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCancelarRegistroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            String valor = agregarElemento();
            if (valor != "")
                cmBoxMarcas.Items.Add(valor);
        }

        private void btnAgregarTipo_Click(object sender, EventArgs e)
        {
            String valor = agregarElemento();
            if (valor != "")
                cmBoxTipo.Items.Add(valor);
        }

        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
            String valor = agregarElemento();
            if(valor != "")
            cmBoxClase.Items.Add(valor);
        }

        private void btnAgregarColor_Click(object sender, EventArgs e)
        {
            String valor = agregarElemento();
            if (valor != "")
                cmBoxColores.Items.Add(valor);
        }

        private string agregarElemento()
        {
            FormElemento formulario = new FormElemento();
            formulario.ShowDialog();
            return formulario.ValorElemento;
        }

       
        
    }
}
