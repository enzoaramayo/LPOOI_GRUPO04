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
    public partial class msgBoxFormYesNo : Form
    {
        static msgBoxFormYesNo msgBox;
        static DialogResult dialogResult = DialogResult.No;

        public msgBoxFormYesNo()
        {
            InitializeComponent();
        }
       

        public static DialogResult Show(string text, string caption, string btnOk, string btnCancel)
        {
            msgBox = new msgBoxFormYesNo();
            msgBox.lblMessageBox.Text = text;
            msgBox.btnAceptar.Text = btnOk;
            msgBox.btnCancelar.Text = btnCancel;
            msgBox.Text = caption;
            msgBox.ShowDialog();
            return dialogResult;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult = DialogResult.Cancel;
        }

        private void FrmMessajeBoxYesNo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
