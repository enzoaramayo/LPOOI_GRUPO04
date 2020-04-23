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
    public partial class msgBoxForm : Form
    { public static string mensaje;
        public msgBoxForm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void messageBoxForm_Load(object sender, EventArgs e)
        {
            lblMessageBox.Text = "Bienvenido/a " + mensaje;
        }
    }
}
