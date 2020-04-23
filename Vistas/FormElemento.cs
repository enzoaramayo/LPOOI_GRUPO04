using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{

    public partial class FormElemento : Form
    {
        private string valorElemento;
        public FormElemento()
        {
            InitializeComponent();
            valorElemento = "";
        }


        private void btnElemento_Click(object sender, EventArgs e)
        {
            valorElemento = txtElemento.Text;
            DialogResult boton = MessageBox.Show("Esta seguro de agregar '"+this.valorElemento+"'?",
                "Agregar", MessageBoxButtons.OKCancel);
            if (boton.Equals(DialogResult.OK) && valorElemento == "")
                MessageBox.Show("No se puede agregar cadena vacia", "Error cadena vacia"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        public string ValorElemento { get => valorElemento; set => valorElemento = value; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
