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
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAltaVehículo());
        }
        public void AbrirForm(object form)
        {
            if (this.subPnlContenedor.Controls.Count > 0)
            {
                this.subPnlContenedor.Controls.RemoveAt(0);

            }
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.subPnlContenedor.Controls.Add(frm);
            this.subPnlContenedor.Tag = frm;
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(CerrarForm); //se vincula el evento FormClosed con el delegado form closed event handler para que llame a cerrar form cada vez que el evento se lleva a cabo

        }
        public void CerrarForm(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmAltaVehiculos"] == null) //si formulario esta cerrado ->
            {
                nuevoClienteToolStripMenuItem.BackColor = Color.FromArgb(26, 20, 68);
            }
        }
    }
}
