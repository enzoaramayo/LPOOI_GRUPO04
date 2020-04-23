using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Supuestamente esto nos permitiria mover el MAIN manteniendo presionado la barra superior
        /// DO
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wNsg, int wParam, int lParam);

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaCliente frmAltaCliente = new frmAltaCliente();
            frmAltaCliente.Show();
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmClientes());
        }


        /* metodo para abrir formularios dentro del pnlPrincipal dentro de  FrmMain*/
        public void AbrirForm(object form)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
            {
                this.pnlPrincipal.Controls.RemoveAt(0);
            }
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(frm);
            this.pnlPrincipal.Tag = frm;
            frm.Show();
        }
        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVehiculos());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;


        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }
    }
}
