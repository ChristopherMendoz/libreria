namespace Practica
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npagins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtpag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.RegistroDatos2 = new System.Windows.Forms.DataGridView();
            this.NombreClien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUNi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCDispo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPAgo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cboTipoDpago = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantAlma = new System.Windows.Forms.TextBox();
            this.cboLibro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblpre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chBuscar = new System.Windows.Forms.CheckBox();
            this.btnLimpiarBusque = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPreciooo = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistroDatos2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(236, 66);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(73, 57);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Agregar Libro Nuevo";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.titulo,
            this.autor,
            this.CantidadAlmacen,
            this.Precio,
            this.npagins});
            this.dataGridView1.Location = new System.Drawing.Point(12, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 156);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            // 
            // CantidadAlmacen
            // 
            this.CantidadAlmacen.HeaderText = "Cantidad Almacenada";
            this.CantidadAlmacen.Name = "CantidadAlmacen";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // npagins
            // 
            this.npagins.HeaderText = "N_paginas";
            this.npagins.Name = "npagins";
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(53, 28);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(152, 20);
            this.txtisbn.TabIndex = 2;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(53, 59);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(152, 20);
            this.txtautor.TabIndex = 3;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(55, 139);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(152, 20);
            this.txttitulo.TabIndex = 4;
            // 
            // txtpag
            // 
            this.txtpag.Location = new System.Drawing.Point(78, 167);
            this.txtpag.Name = "txtpag";
            this.txtpag.Size = new System.Drawing.Size(105, 20);
            this.txtpag.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "N.paginas:";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(305, 396);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(73, 29);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(273, 198);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(106, 20);
            this.txtbuscar.TabIndex = 12;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(194, 198);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 20);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(736, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnFacturar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.RegistroDatos2);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPAgo);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.cboTipoDpago);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(390, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 412);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(353, 355);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(62, 23);
            this.btnFacturar.TabIndex = 60;
            this.btnFacturar.Text = "Factura";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(347, 313);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(68, 23);
            this.btnRegistrar.TabIndex = 59;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 58;
            this.label12.Text = "Fecha:";
            // 
            // RegistroDatos2
            // 
            this.RegistroDatos2.AllowUserToDeleteRows = false;
            this.RegistroDatos2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RegistroDatos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RegistroDatos2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RegistroDatos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistroDatos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreClien,
            this.Cedula,
            this.Produ,
            this.Cantid,
            this.TipoDpago,
            this.PAgo,
            this.PrecioUNi,
            this.Total,
            this.Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RegistroDatos2.DefaultCellStyle = dataGridViewCellStyle2;
            this.RegistroDatos2.Location = new System.Drawing.Point(9, 248);
            this.RegistroDatos2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegistroDatos2.Name = "RegistroDatos2";
            this.RegistroDatos2.ReadOnly = true;
            this.RegistroDatos2.Size = new System.Drawing.Size(338, 164);
            this.RegistroDatos2.TabIndex = 57;
            // 
            // NombreClien
            // 
            this.NombreClien.HeaderText = "Nombre Del Cliente";
            this.NombreClien.Name = "NombreClien";
            this.NombreClien.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Produ
            // 
            this.Produ.HeaderText = "Libro";
            this.Produ.Name = "Produ";
            this.Produ.ReadOnly = true;
            // 
            // Cantid
            // 
            this.Cantid.HeaderText = "Cantidad De Productos";
            this.Cantid.Name = "Cantid";
            this.Cantid.ReadOnly = true;
            // 
            // TipoDpago
            // 
            this.TipoDpago.HeaderText = "Tipo De Pago";
            this.TipoDpago.Name = "TipoDpago";
            this.TipoDpago.ReadOnly = true;
            // 
            // PAgo
            // 
            this.PAgo.HeaderText = "Pago";
            this.PAgo.Name = "PAgo";
            this.PAgo.ReadOnly = true;
            // 
            // PrecioUNi
            // 
            this.PrecioUNi.HeaderText = "Precio";
            this.PrecioUNi.Name = "PrecioUNi";
            this.PrecioUNi.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(71, 52);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 15);
            this.label21.TabIndex = 55;
            this.label21.Text = "Cedula:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.txtCDispo);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Location = new System.Drawing.Point(219, 60);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 45);
            this.panel6.TabIndex = 54;
            // 
            // txtCDispo
            // 
            this.txtCDispo.Location = new System.Drawing.Point(119, 14);
            this.txtCDispo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCDispo.Name = "txtCDispo";
            this.txtCDispo.Size = new System.Drawing.Size(64, 20);
            this.txtCDispo.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(4, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Cant.Disponible:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.lblPrecio);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(301, 127);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(104, 38);
            this.panel5.TabIndex = 53;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(60, 13);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(16, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "...";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(164, 114);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 52;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 15);
            this.label15.TabIndex = 51;
            this.label15.Text = "Cantidad a comprar:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(88, 82);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 49;
            this.label13.Text = "Producto:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(68, 198);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 13);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 47;
            this.label14.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "Pago:";
            // 
            // txtPAgo
            // 
            this.txtPAgo.Location = new System.Drawing.Point(70, 139);
            this.txtPAgo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPAgo.Name = "txtPAgo";
            this.txtPAgo.Size = new System.Drawing.Size(100, 20);
            this.txtPAgo.TabIndex = 43;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(149, 21);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 40;
            // 
            // cboTipoDpago
            // 
            this.cboTipoDpago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDpago.FormattingEnabled = true;
            this.cboTipoDpago.Items.AddRange(new object[] {
            "Efectivo",
            "Targeta"});
            this.cboTipoDpago.Location = new System.Drawing.Point(110, 167);
            this.cboTipoDpago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTipoDpago.Name = "cboTipoDpago";
            this.cboTipoDpago.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDpago.TabIndex = 38;
            this.cboTipoDpago.SelectedIndexChanged += new System.EventHandler(this.cboTipoDpago_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nombre Del Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tipo de pago:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 220);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad a Agregar:";
            // 
            // txtCantAlma
            // 
            this.txtCantAlma.Location = new System.Drawing.Point(119, 89);
            this.txtCantAlma.Name = "txtCantAlma";
            this.txtCantAlma.Size = new System.Drawing.Size(101, 20);
            this.txtCantAlma.TabIndex = 16;
            // 
            // cboLibro
            // 
            this.cboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLibro.Items.AddRange(new object[] {
            "Don Quijote de la Mancha",
            "Historias de dos Cuidades",
            "El Señor de los Anillos",
            " El Principito",
            "El Hobbit",
            "Sueño en el pabellon Rojo",
            "EL leon,la Bruja y el Armario"});
            this.cboLibro.Location = new System.Drawing.Point(109, 116);
            this.cboLibro.Name = "cboLibro";
            this.cboLibro.Size = new System.Drawing.Size(121, 21);
            this.cboLibro.TabIndex = 21;
            this.cboLibro.SelectedIndexChanged += new System.EventHandler(this.cboLibro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Libros Existentes:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblpre);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtpre);
            this.panel2.Location = new System.Drawing.Point(237, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 53);
            this.panel2.TabIndex = 19;
            // 
            // lblpre
            // 
            this.lblpre.AutoSize = true;
            this.lblpre.Location = new System.Drawing.Point(79, 33);
            this.lblpre.Name = "lblpre";
            this.lblpre.Size = new System.Drawing.Size(16, 13);
            this.lblpre.TabIndex = 3;
            this.lblpre.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Precio:";
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(61, 9);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(83, 20);
            this.txtpre.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 57);
            this.button1.TabIndex = 20;
            this.button1.Text = "Agregar Libro Existente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chBuscar
            // 
            this.chBuscar.AutoSize = true;
            this.chBuscar.Location = new System.Drawing.Point(298, 167);
            this.chBuscar.Name = "chBuscar";
            this.chBuscar.Size = new System.Drawing.Size(80, 17);
            this.chBuscar.TabIndex = 22;
            this.chBuscar.Text = "checkBox1";
            this.chBuscar.UseVisualStyleBackColor = true;
            this.chBuscar.CheckedChanged += new System.EventHandler(this.chBuscar_CheckedChanged);
            // 
            // btnLimpiarBusque
            // 
            this.btnLimpiarBusque.Location = new System.Drawing.Point(189, 169);
            this.btnLimpiarBusque.Name = "btnLimpiarBusque";
            this.btnLimpiarBusque.Size = new System.Drawing.Size(91, 24);
            this.btnLimpiarBusque.TabIndex = 23;
            this.btnLimpiarBusque.Text = "Limpiar Busque";
            this.btnLimpiarBusque.UseVisualStyleBackColor = true;
            this.btnLimpiarBusque.Click += new System.EventHandler(this.btnLimpiarBusque_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(184, 384);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Precio";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(117, 383);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Cantidad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 383);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Producto";
            // 
            // txtPreciooo
            // 
            this.txtPreciooo.Location = new System.Drawing.Point(187, 405);
            this.txtPreciooo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreciooo.Name = "txtPreciooo";
            this.txtPreciooo.Size = new System.Drawing.Size(66, 20);
            this.txtPreciooo.TabIndex = 26;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(117, 405);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(64, 20);
            this.txtC.TabIndex = 25;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(10, 405);
            this.txtP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(102, 20);
            this.txtP.TabIndex = 24;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(8, 446);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(324, 20);
            this.txtDetalle.TabIndex = 30;
            this.txtDetalle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Detalle:";
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(259, 402);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(47, 23);
            this.btnDetalle.TabIndex = 32;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 467);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPreciooo);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.btnLimpiarBusque);
            this.Controls.Add(this.chBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboLibro);
            this.Controls.Add(this.txtCantAlma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpag);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistroDatos2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtpag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView RegistroDatos2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCDispo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPAgo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cboTipoDpago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantAlma;
        private System.Windows.Forms.ComboBox cboLibro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblpre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn npagins;
        private System.Windows.Forms.CheckBox chBuscar;
        private System.Windows.Forms.Button btnLimpiarBusque;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPreciooo;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreClien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUNi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDetalle;
    }
}