namespace Vistas
{
    partial class FormElemento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBoxElemento = new System.Windows.Forms.GroupBox();
            this.btnElemento = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblElemento = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gBoxElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxElemento
            // 
            this.gBoxElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gBoxElemento.Controls.Add(this.btnCancelar);
            this.gBoxElemento.Controls.Add(this.btnElemento);
            this.gBoxElemento.Controls.Add(this.txtElemento);
            this.gBoxElemento.Controls.Add(this.lblElemento);
            this.gBoxElemento.ForeColor = System.Drawing.Color.White;
            this.gBoxElemento.Location = new System.Drawing.Point(12, 12);
            this.gBoxElemento.Name = "gBoxElemento";
            this.gBoxElemento.Size = new System.Drawing.Size(252, 136);
            this.gBoxElemento.TabIndex = 0;
            this.gBoxElemento.TabStop = false;
            this.gBoxElemento.Text = "Nuevo Elemento";
            // 
            // btnElemento
            // 
            this.btnElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnElemento.FlatAppearance.BorderSize = 0;
            this.btnElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElemento.Location = new System.Drawing.Point(6, 90);
            this.btnElemento.Name = "btnElemento";
            this.btnElemento.Size = new System.Drawing.Size(87, 23);
            this.btnElemento.TabIndex = 2;
            this.btnElemento.Text = "Agregar";
            this.btnElemento.UseVisualStyleBackColor = false;
            this.btnElemento.Click += new System.EventHandler(this.btnElemento_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(6, 50);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(140, 20);
            this.txtElemento.TabIndex = 1;
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.ForeColor = System.Drawing.Color.White;
            this.lblElemento.Location = new System.Drawing.Point(7, 25);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(191, 13);
            this.lblElemento.TabIndex = 0;
            this.lblElemento.Text = "Ingrese el elemento que desea agregar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(157, 90);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(280, 166);
            this.Controls.Add(this.gBoxElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormElemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Elemento";
            this.gBoxElemento.ResumeLayout(false);
            this.gBoxElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxElemento;
        private System.Windows.Forms.Button btnElemento;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Button btnCancelar;
    }
}