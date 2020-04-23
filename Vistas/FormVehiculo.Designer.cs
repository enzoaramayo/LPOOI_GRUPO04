namespace Vistas
{
    partial class FormVehiculo
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
            this.pnlNuevoVehiculo = new System.Windows.Forms.Panel();
            this.btnCancelarRegistroCliente = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTituloAddVehiculo = new System.Windows.Forms.Label();
            this.gBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregarClase = new System.Windows.Forms.Button();
            this.btnAgregarTipo = new System.Windows.Forms.Button();
            this.cmBoxClase = new System.Windows.Forms.ComboBox();
            this.cmBoxTipo = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gBoxEstetica = new System.Windows.Forms.GroupBox();
            this.btnAgregarColor = new System.Windows.Forms.Button();
            this.cmBoxColores = new System.Windows.Forms.ComboBox();
            this.gBoxGPS = new System.Windows.Forms.GroupBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.lblGPS = new System.Windows.Forms.Label();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.gBoxVehiculos = new System.Windows.Forms.GroupBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.txtLineaVehiculo = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.cmBoxMarcas = new System.Windows.Forms.ComboBox();
            this.pnlNuevoVehiculo.SuspendLayout();
            this.gBoxDatos.SuspendLayout();
            this.gBoxEstetica.SuspendLayout();
            this.gBoxGPS.SuspendLayout();
            this.gBoxVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNuevoVehiculo
            // 
            this.pnlNuevoVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnlNuevoVehiculo.Controls.Add(this.btnCancelarRegistroCliente);
            this.pnlNuevoVehiculo.Controls.Add(this.btnRegistrar);
            this.pnlNuevoVehiculo.Controls.Add(this.lblTituloAddVehiculo);
            this.pnlNuevoVehiculo.Controls.Add(this.gBoxDatos);
            this.pnlNuevoVehiculo.Controls.Add(this.gBoxEstetica);
            this.pnlNuevoVehiculo.Controls.Add(this.gBoxVehiculos);
            this.pnlNuevoVehiculo.Location = new System.Drawing.Point(12, 12);
            this.pnlNuevoVehiculo.Name = "pnlNuevoVehiculo";
            this.pnlNuevoVehiculo.Size = new System.Drawing.Size(440, 590);
            this.pnlNuevoVehiculo.TabIndex = 0;
            // 
            // btnCancelarRegistroCliente
            // 
            this.btnCancelarRegistroCliente.BackColor = System.Drawing.Color.Red;
            this.btnCancelarRegistroCliente.FlatAppearance.BorderSize = 0;
            this.btnCancelarRegistroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRegistroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRegistroCliente.ForeColor = System.Drawing.Color.White;
            this.btnCancelarRegistroCliente.Location = new System.Drawing.Point(167, 556);
            this.btnCancelarRegistroCliente.Name = "btnCancelarRegistroCliente";
            this.btnCancelarRegistroCliente.Size = new System.Drawing.Size(99, 26);
            this.btnCancelarRegistroCliente.TabIndex = 1;
            this.btnCancelarRegistroCliente.Text = "Cancelar";
            this.btnCancelarRegistroCliente.UseVisualStyleBackColor = false;
            this.btnCancelarRegistroCliente.Click += new System.EventHandler(this.btnCancelarRegistroCliente_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(120, 500);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(199, 38);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTituloAddVehiculo
            // 
            this.lblTituloAddVehiculo.AutoSize = true;
            this.lblTituloAddVehiculo.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAddVehiculo.ForeColor = System.Drawing.Color.White;
            this.lblTituloAddVehiculo.Location = new System.Drawing.Point(32, 8);
            this.lblTituloAddVehiculo.Name = "lblTituloAddVehiculo";
            this.lblTituloAddVehiculo.Size = new System.Drawing.Size(249, 56);
            this.lblTituloAddVehiculo.TabIndex = 3;
            this.lblTituloAddVehiculo.Text = "Nuevo Vehiculo";
            // 
            // gBoxDatos
            // 
            this.gBoxDatos.Controls.Add(this.btnAgregarClase);
            this.gBoxDatos.Controls.Add(this.btnAgregarTipo);
            this.gBoxDatos.Controls.Add(this.cmBoxClase);
            this.gBoxDatos.Controls.Add(this.cmBoxTipo);
            this.gBoxDatos.Controls.Add(this.txtPrecio);
            this.gBoxDatos.Controls.Add(this.lblPrecio);
            this.gBoxDatos.Controls.Add(this.lblClase);
            this.gBoxDatos.Controls.Add(this.lblTipo);
            this.gBoxDatos.ForeColor = System.Drawing.Color.White;
            this.gBoxDatos.Location = new System.Drawing.Point(37, 345);
            this.gBoxDatos.Name = "gBoxDatos";
            this.gBoxDatos.Size = new System.Drawing.Size(366, 122);
            this.gBoxDatos.TabIndex = 2;
            this.gBoxDatos.TabStop = false;
            this.gBoxDatos.Text = "Datos del vehiculo";
            // 
            // btnAgregarClase
            // 
            this.btnAgregarClase.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarClase.Location = new System.Drawing.Point(235, 48);
            this.btnAgregarClase.Name = "btnAgregarClase";
            this.btnAgregarClase.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarClase.TabIndex = 7;
            this.btnAgregarClase.Text = "Agregar nueva clase";
            this.btnAgregarClase.UseVisualStyleBackColor = true;
            this.btnAgregarClase.Click += new System.EventHandler(this.btnAgregarClase_Click);
            // 
            // btnAgregarTipo
            // 
            this.btnAgregarTipo.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarTipo.Location = new System.Drawing.Point(235, 17);
            this.btnAgregarTipo.Name = "btnAgregarTipo";
            this.btnAgregarTipo.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarTipo.TabIndex = 8;
            this.btnAgregarTipo.Text = "Agregar nuevo tipo";
            this.btnAgregarTipo.UseVisualStyleBackColor = true;
            this.btnAgregarTipo.Click += new System.EventHandler(this.btnAgregarTipo_Click);
            // 
            // cmBoxClase
            // 
            this.cmBoxClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmBoxClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxClase.ForeColor = System.Drawing.Color.White;
            this.cmBoxClase.FormattingEnabled = true;
            this.cmBoxClase.Items.AddRange(new object[] {
            "Pasajero",
            "Carga",
            "Deportivo",
            "Furgon",
            "Coupé",
            "Cisterna"});
            this.cmBoxClase.Location = new System.Drawing.Point(83, 50);
            this.cmBoxClase.Name = "cmBoxClase";
            this.cmBoxClase.Size = new System.Drawing.Size(146, 21);
            this.cmBoxClase.TabIndex = 1;
            // 
            // cmBoxTipo
            // 
            this.cmBoxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxTipo.ForeColor = System.Drawing.Color.White;
            this.cmBoxTipo.FormattingEnabled = true;
            this.cmBoxTipo.Items.AddRange(new object[] {
            "Automovil",
            "Utilitario",
            "Camioneta",
            "Monovolumen",
            "Motocicleta"});
            this.cmBoxTipo.Location = new System.Drawing.Point(83, 19);
            this.cmBoxTipo.Name = "cmBoxTipo";
            this.cmBoxTipo.Size = new System.Drawing.Size(146, 21);
            this.cmBoxTipo.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(83, 81);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(146, 25);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(17, 81);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(65, 27);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio $";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.ForeColor = System.Drawing.Color.White;
            this.lblClase.Location = new System.Drawing.Point(17, 51);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(47, 27);
            this.lblClase.TabIndex = 9;
            this.lblClase.Text = "Clase";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(19, 19);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(42, 27);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // gBoxEstetica
            // 
            this.gBoxEstetica.Controls.Add(this.btnAgregarColor);
            this.gBoxEstetica.Controls.Add(this.cmBoxColores);
            this.gBoxEstetica.Controls.Add(this.gBoxGPS);
            this.gBoxEstetica.Controls.Add(this.lblGPS);
            this.gBoxEstetica.Controls.Add(this.txtPuertas);
            this.gBoxEstetica.Controls.Add(this.label1);
            this.gBoxEstetica.Controls.Add(this.lblColor);
            this.gBoxEstetica.ForeColor = System.Drawing.Color.White;
            this.gBoxEstetica.Location = new System.Drawing.Point(37, 202);
            this.gBoxEstetica.Name = "gBoxEstetica";
            this.gBoxEstetica.Size = new System.Drawing.Size(366, 127);
            this.gBoxEstetica.TabIndex = 1;
            this.gBoxEstetica.TabStop = false;
            this.gBoxEstetica.Text = "Estetica";
            // 
            // btnAgregarColor
            // 
            this.btnAgregarColor.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarColor.Location = new System.Drawing.Point(235, 16);
            this.btnAgregarColor.Name = "btnAgregarColor";
            this.btnAgregarColor.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarColor.TabIndex = 7;
            this.btnAgregarColor.Text = "Agregar nuevo color";
            this.btnAgregarColor.UseVisualStyleBackColor = true;
            this.btnAgregarColor.Click += new System.EventHandler(this.btnAgregarColor_Click);
            // 
            // cmBoxColores
            // 
            this.cmBoxColores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmBoxColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxColores.ForeColor = System.Drawing.Color.White;
            this.cmBoxColores.FormattingEnabled = true;
            this.cmBoxColores.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Blanco",
            "Negro",
            "Verde",
            "Gris",
            "Morado"});
            this.cmBoxColores.Location = new System.Drawing.Point(83, 18);
            this.cmBoxColores.Name = "cmBoxColores";
            this.cmBoxColores.Size = new System.Drawing.Size(146, 21);
            this.cmBoxColores.TabIndex = 0;
            // 
            // gBoxGPS
            // 
            this.gBoxGPS.Controls.Add(this.optNo);
            this.gBoxGPS.Controls.Add(this.optSi);
            this.gBoxGPS.Location = new System.Drawing.Point(83, 81);
            this.gBoxGPS.Name = "gBoxGPS";
            this.gBoxGPS.Size = new System.Drawing.Size(146, 34);
            this.gBoxGPS.TabIndex = 2;
            this.gBoxGPS.TabStop = false;
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Location = new System.Drawing.Point(47, 11);
            this.optNo.Name = "optNo";
            this.optNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optNo.Size = new System.Drawing.Size(39, 17);
            this.optNo.TabIndex = 1;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Checked = true;
            this.optSi.Location = new System.Drawing.Point(7, 11);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(34, 17);
            this.optSi.TabIndex = 0;
            this.optSi.TabStop = true;
            this.optSi.Text = "Si";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // lblGPS
            // 
            this.lblGPS.AutoSize = true;
            this.lblGPS.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPS.ForeColor = System.Drawing.Color.White;
            this.lblGPS.Location = new System.Drawing.Point(28, 88);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(38, 27);
            this.lblGPS.TabIndex = 11;
            this.lblGPS.Text = "GPS";
            // 
            // txtPuertas
            // 
            this.txtPuertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPuertas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuertas.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuertas.ForeColor = System.Drawing.Color.White;
            this.txtPuertas.Location = new System.Drawing.Point(83, 50);
            this.txtPuertas.Multiline = true;
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(146, 25);
            this.txtPuertas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Puertas";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(21, 18);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(48, 27);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color";
            // 
            // gBoxVehiculos
            // 
            this.gBoxVehiculos.Controls.Add(this.txtModelo);
            this.gBoxVehiculos.Controls.Add(this.lblModelo);
            this.gBoxVehiculos.Controls.Add(this.lblLinea);
            this.gBoxVehiculos.Controls.Add(this.lblMarcas);
            this.gBoxVehiculos.Controls.Add(this.txtLineaVehiculo);
            this.gBoxVehiculos.Controls.Add(this.btnAgregarMarca);
            this.gBoxVehiculos.Controls.Add(this.cmBoxMarcas);
            this.gBoxVehiculos.ForeColor = System.Drawing.Color.White;
            this.gBoxVehiculos.Location = new System.Drawing.Point(37, 67);
            this.gBoxVehiculos.Name = "gBoxVehiculos";
            this.gBoxVehiculos.Size = new System.Drawing.Size(366, 129);
            this.gBoxVehiculos.TabIndex = 0;
            this.gBoxVehiculos.TabStop = false;
            this.gBoxVehiculos.Text = "Vehiculo";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelo.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.White;
            this.txtModelo.Location = new System.Drawing.Point(83, 90);
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(146, 25);
            this.txtModelo.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(17, 90);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(64, 27);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.ForeColor = System.Drawing.Color.White;
            this.lblLinea.Location = new System.Drawing.Point(19, 54);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(47, 27);
            this.lblLinea.TabIndex = 4;
            this.lblLinea.Text = "Linea";
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.Color.White;
            this.lblMarcas.Location = new System.Drawing.Point(17, 22);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(53, 27);
            this.lblMarcas.TabIndex = 3;
            this.lblMarcas.Text = "Marca";
            // 
            // txtLineaVehiculo
            // 
            this.txtLineaVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtLineaVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLineaVehiculo.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineaVehiculo.ForeColor = System.Drawing.Color.White;
            this.txtLineaVehiculo.Location = new System.Drawing.Point(83, 54);
            this.txtLineaVehiculo.Multiline = true;
            this.txtLineaVehiculo.Name = "txtLineaVehiculo";
            this.txtLineaVehiculo.Size = new System.Drawing.Size(146, 25);
            this.txtLineaVehiculo.TabIndex = 1;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarMarca.Location = new System.Drawing.Point(235, 19);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "Agregar nueva marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // cmBoxMarcas
            // 
            this.cmBoxMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmBoxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxMarcas.ForeColor = System.Drawing.Color.White;
            this.cmBoxMarcas.FormattingEnabled = true;
            this.cmBoxMarcas.Items.AddRange(new object[] {
            "Volkswagen",
            "Chevrolet",
            "Renault",
            "Ford",
            "Toyota",
            "FIAT",
            "Peugeot",
            "Citroën",
            "Honda",
            "Nissan"});
            this.cmBoxMarcas.Location = new System.Drawing.Point(83, 22);
            this.cmBoxMarcas.Name = "cmBoxMarcas";
            this.cmBoxMarcas.Size = new System.Drawing.Size(146, 21);
            this.cmBoxMarcas.TabIndex = 0;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlNuevoVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.pnlNuevoVehiculo.ResumeLayout(false);
            this.pnlNuevoVehiculo.PerformLayout();
            this.gBoxDatos.ResumeLayout(false);
            this.gBoxDatos.PerformLayout();
            this.gBoxEstetica.ResumeLayout(false);
            this.gBoxEstetica.PerformLayout();
            this.gBoxGPS.ResumeLayout(false);
            this.gBoxGPS.PerformLayout();
            this.gBoxVehiculos.ResumeLayout(false);
            this.gBoxVehiculos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNuevoVehiculo;
        private System.Windows.Forms.Label lblTituloAddVehiculo;
        private System.Windows.Forms.GroupBox gBoxDatos;
        private System.Windows.Forms.GroupBox gBoxEstetica;
        private System.Windows.Forms.GroupBox gBoxVehiculos;
        private System.Windows.Forms.ComboBox cmBoxMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.GroupBox gBoxGPS;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.TextBox txtLineaVehiculo;
        private System.Windows.Forms.ComboBox cmBoxColores;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelarRegistroCliente;
        private System.Windows.Forms.Button btnAgregarClase;
        private System.Windows.Forms.Button btnAgregarTipo;
        private System.Windows.Forms.ComboBox cmBoxClase;
        private System.Windows.Forms.ComboBox cmBoxTipo;
        private System.Windows.Forms.Button btnAgregarColor;
    }
}