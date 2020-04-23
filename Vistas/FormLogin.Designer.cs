namespace Vistas
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.picBoxPassword = new System.Windows.Forms.PictureBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDatosIncorrectos = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblRegistrase = new System.Windows.Forms.Label();
            this.btnRegistarse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Gray;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUser.Location = new System.Drawing.Point(39, 78);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(165, 30);
            this.txtUser.TabIndex = 1;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Gray;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(39, 128);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(165, 30);
            this.txtPass.TabIndex = 2;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnVerificar.Location = new System.Drawing.Point(39, 198);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(165, 33);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Ingresar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            this.btnVerificar.MouseLeave += new System.EventHandler(this.btnVerificar_MouseLeave);
            this.btnVerificar.MouseHover += new System.EventHandler(this.btnVerificar_MouseHover);
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.picBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUser.Image")));
            this.picBoxUser.Location = new System.Drawing.Point(8, 78);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(30, 30);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUser.TabIndex = 5;
            this.picBoxUser.TabStop = false;
            // 
            // picBoxPassword
            // 
            this.picBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.picBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPassword.Image")));
            this.picBoxPassword.Location = new System.Drawing.Point(8, 128);
            this.picBoxPassword.Name = "picBoxPassword";
            this.picBoxPassword.Size = new System.Drawing.Size(30, 30);
            this.picBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPassword.TabIndex = 6;
            this.picBoxPassword.TabStop = false;
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(31, 4);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(174, 33);
            this.lblInicio.TabIndex = 7;
            this.lblInicio.Text = "Iniciar sesión";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(87, 202);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lblDatosIncorrectos);
            this.panel1.Controls.Add(this.btnVerificar);
            this.panel1.Controls.Add(this.picBoxUser);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.picBoxPassword);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Location = new System.Drawing.Point(56, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 248);
            this.panel1.TabIndex = 9;
            // 
            // lblDatosIncorrectos
            // 
            this.lblDatosIncorrectos.AutoSize = true;
            this.lblDatosIncorrectos.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosIncorrectos.ForeColor = System.Drawing.Color.White;
            this.lblDatosIncorrectos.Location = new System.Drawing.Point(39, 165);
            this.lblDatosIncorrectos.Name = "lblDatosIncorrectos";
            this.lblDatosIncorrectos.Size = new System.Drawing.Size(109, 20);
            this.lblDatosIncorrectos.TabIndex = 8;
            this.lblDatosIncorrectos.Text = "lblDatosIncorrectos";
            // 
            // lblRegistrase
            // 
            this.lblRegistrase.AutoSize = true;
            this.lblRegistrase.ForeColor = System.Drawing.Color.White;
            this.lblRegistrase.Location = new System.Drawing.Point(53, 412);
            this.lblRegistrase.Name = "lblRegistrase";
            this.lblRegistrase.Size = new System.Drawing.Size(121, 13);
            this.lblRegistrase.TabIndex = 11;
            this.lblRegistrase.Text = "¿No tienes cuenta aun?";
            // 
            // btnRegistarse
            // 
            this.btnRegistarse.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistarse.FlatAppearance.BorderSize = 0;
            this.btnRegistarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegistarse.Location = new System.Drawing.Point(171, 407);
            this.btnRegistarse.Name = "btnRegistarse";
            this.btnRegistarse.Size = new System.Drawing.Size(112, 23);
            this.btnRegistarse.TabIndex = 10;
            this.btnRegistarse.Text = "Registrate Aqui";
            this.btnRegistarse.UseVisualStyleBackColor = false;
            this.btnRegistarse.MouseLeave += new System.EventHandler(this.btnRegistarse_MouseLeave);
            this.btnRegistarse.MouseHover += new System.EventHandler(this.btnRegistarse_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 35);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(313, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(115, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(348, 457);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRegistarse);
            this.Controls.Add(this.lblRegistrase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.PictureBox picBoxPassword;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblRegistrase;
        private System.Windows.Forms.Button btnRegistarse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblDatosIncorrectos;
    }
}