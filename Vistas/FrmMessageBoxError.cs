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
    public partial class msgBoxFormError : Form
    {
        public static string mensaje;
        public msgBoxFormError()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msgBoxFormError_Load(object sender, EventArgs e)
        {
            lblMessageBoxError.Text = mensaje;
        }
    }
}
