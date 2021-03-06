﻿namespace DealerADMProject
{
    partial class Factura
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDir = new System.Windows.Forms.TextBox();
            this.mtbTelf = new System.Windows.Forms.MaskedTextBox();
            this.lblDirc = new System.Windows.Forms.Label();
            this.lblTelf = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.tbClienteName = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.tbxCat = new System.Windows.Forms.TextBox();
            this.tbxAño = new System.Windows.Forms.TextBox();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxChasis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblChasis = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxDetalleVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRNC = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetFactura = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChasisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCrearFactura = new System.Windows.Forms.TabPage();
            this.tabFacturasCreadas = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxCampo = new System.Windows.Forms.TextBox();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbMarca = new System.Windows.Forms.RadioButton();
            this.rbModelo = new System.Windows.Forms.RadioButton();
            this.rbChasis = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvFacturasReg = new System.Windows.Forms.DataGridView();
            this.panelHead.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetFactura)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCrearFactura.SuspendLayout();
            this.tabFacturasCreadas.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasReg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHead.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(822, 79);
            this.panelHead.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturacion de vehiculos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbDir);
            this.groupBox1.Controls.Add(this.mtbTelf);
            this.groupBox1.Controls.Add(this.lblDirc);
            this.groupBox1.Controls.Add(this.lblTelf);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Controls.Add(this.tbClienteName);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbCedula);
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // txbDir
            // 
            this.txbDir.BackColor = System.Drawing.Color.Silver;
            this.txbDir.Location = new System.Drawing.Point(65, 144);
            this.txbDir.Name = "txbDir";
            this.txbDir.ReadOnly = true;
            this.txbDir.Size = new System.Drawing.Size(257, 20);
            this.txbDir.TabIndex = 9;
            // 
            // mtbTelf
            // 
            this.mtbTelf.BackColor = System.Drawing.Color.Silver;
            this.mtbTelf.Location = new System.Drawing.Point(65, 107);
            this.mtbTelf.Mask = "000-000-0000";
            this.mtbTelf.Name = "mtbTelf";
            this.mtbTelf.ReadOnly = true;
            this.mtbTelf.Size = new System.Drawing.Size(100, 20);
            this.mtbTelf.TabIndex = 8;
            // 
            // lblDirc
            // 
            this.lblDirc.AutoSize = true;
            this.lblDirc.Location = new System.Drawing.Point(6, 144);
            this.lblDirc.Name = "lblDirc";
            this.lblDirc.Size = new System.Drawing.Size(61, 13);
            this.lblDirc.TabIndex = 7;
            this.lblDirc.Text = "Direccion";
            // 
            // lblTelf
            // 
            this.lblTelf.AutoSize = true;
            this.lblTelf.Location = new System.Drawing.Point(6, 107);
            this.lblTelf.Name = "lblTelf";
            this.lblTelf.Size = new System.Drawing.Size(57, 13);
            this.lblTelf.TabIndex = 6;
            this.lblTelf.Text = "Telefono";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(257, 34);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 5;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // tbClienteName
            // 
            this.tbClienteName.BackColor = System.Drawing.Color.Silver;
            this.tbClienteName.Location = new System.Drawing.Point(65, 70);
            this.tbClienteName.Name = "tbClienteName";
            this.tbClienteName.ReadOnly = true;
            this.tbClienteName.Size = new System.Drawing.Size(175, 20);
            this.tbClienteName.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 70);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(171, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(65, 37);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(100, 20);
            this.tbCedula.TabIndex = 1;
            this.tbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCedula_KeyPress);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(6, 36);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(46, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cedula";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxPrecio);
            this.groupBox2.Controls.Add(this.tbxColor);
            this.groupBox2.Controls.Add(this.tbxCat);
            this.groupBox2.Controls.Add(this.tbxAño);
            this.groupBox2.Controls.Add(this.tbxModelo);
            this.groupBox2.Controls.Add(this.tbxMarca);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.tbxChasis);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Controls.Add(this.lblCategoria);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblModelo);
            this.groupBox2.Controls.Add(this.lblMarca);
            this.groupBox2.Controls.Add(this.lblChasis);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(364, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Vehiculo";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.BackColor = System.Drawing.Color.Silver;
            this.tbxPrecio.Location = new System.Drawing.Point(262, 144);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.ReadOnly = true;
            this.tbxPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbxPrecio.TabIndex = 15;
            // 
            // tbxColor
            // 
            this.tbxColor.BackColor = System.Drawing.Color.Silver;
            this.tbxColor.Location = new System.Drawing.Point(262, 107);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.ReadOnly = true;
            this.tbxColor.Size = new System.Drawing.Size(100, 20);
            this.tbxColor.TabIndex = 14;
            // 
            // tbxCat
            // 
            this.tbxCat.BackColor = System.Drawing.Color.Silver;
            this.tbxCat.Location = new System.Drawing.Point(262, 70);
            this.tbxCat.Name = "tbxCat";
            this.tbxCat.ReadOnly = true;
            this.tbxCat.Size = new System.Drawing.Size(100, 20);
            this.tbxCat.TabIndex = 13;
            // 
            // tbxAño
            // 
            this.tbxAño.BackColor = System.Drawing.Color.Silver;
            this.tbxAño.Location = new System.Drawing.Point(57, 144);
            this.tbxAño.Name = "tbxAño";
            this.tbxAño.ReadOnly = true;
            this.tbxAño.Size = new System.Drawing.Size(48, 20);
            this.tbxAño.TabIndex = 12;
            // 
            // tbxModelo
            // 
            this.tbxModelo.BackColor = System.Drawing.Color.Silver;
            this.tbxModelo.Location = new System.Drawing.Point(57, 107);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.ReadOnly = true;
            this.tbxModelo.Size = new System.Drawing.Size(80, 20);
            this.tbxModelo.TabIndex = 11;
            // 
            // tbxMarca
            // 
            this.tbxMarca.BackColor = System.Drawing.Color.Silver;
            this.tbxMarca.Location = new System.Drawing.Point(57, 70);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.ReadOnly = true;
            this.tbxMarca.Size = new System.Drawing.Size(80, 20);
            this.tbxMarca.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxChasis
            // 
            this.tbxChasis.Location = new System.Drawing.Point(57, 37);
            this.tbxChasis.Name = "tbxChasis";
            this.tbxChasis.Size = new System.Drawing.Size(159, 20);
            this.tbxChasis.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Precio";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(191, 110);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(191, 73);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Año";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(7, 107);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(7, 73);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblChasis
            // 
            this.lblChasis.AutoSize = true;
            this.lblChasis.Location = new System.Drawing.Point(7, 36);
            this.lblChasis.Name = "lblChasis";
            this.lblChasis.Size = new System.Drawing.Size(44, 13);
            this.lblChasis.TabIndex = 0;
            this.lblChasis.Text = "Chasis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxDetalleVenta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.FechaVencimiento);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbxRNC);
            this.groupBox3.Controls.Add(this.tbxTotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Factura";
            // 
            // tbxDetalleVenta
            // 
            this.tbxDetalleVenta.Location = new System.Drawing.Point(225, 32);
            this.tbxDetalleVenta.Multiline = true;
            this.tbxDetalleVenta.Name = "tbxDetalleVenta";
            this.tbxDetalleVenta.Size = new System.Drawing.Size(383, 93);
            this.tbxDetalleVenta.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Observaciones";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.FechaVencimiento.Enabled = false;
            this.FechaVencimiento.Location = new System.Drawing.Point(5, 75);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(211, 20);
            this.FechaVencimiento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // tbxRNC
            // 
            this.tbxRNC.Location = new System.Drawing.Point(80, 28);
            this.tbxRNC.Name = "tbxRNC";
            this.tbxRNC.Size = new System.Drawing.Size(126, 20);
            this.tbxRNC.TabIndex = 3;
            this.tbxRNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRNC_KeyPress);
            // 
            // tbxTotal
            // 
            this.tbxTotal.BackColor = System.Drawing.Color.Silver;
            this.tbxTotal.Location = new System.Drawing.Point(47, 107);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(100, 20);
            this.tbxTotal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "RNC";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(128, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(7, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetFactura
            // 
            this.dgvDetFactura.AllowUserToAddRows = false;
            this.dgvDetFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.DetalleColumn,
            this.ChasisColumn,
            this.PrecioColumn,
            this.DescColumn,
            this.TotalColumn});
            this.dgvDetFactura.Location = new System.Drawing.Point(9, 19);
            this.dgvDetFactura.Name = "dgvDetFactura";
            this.dgvDetFactura.Size = new System.Drawing.Size(774, 185);
            this.dgvDetFactura.TabIndex = 5;
            this.dgvDetFactura.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDetFactura_CellValidating);
            this.dgvDetFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetFactura_CellValueChanged);
            this.dgvDetFactura.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetFactura_RowsAdded);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID ITEM";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // DetalleColumn
            // 
            this.DetalleColumn.HeaderText = "DETALLE";
            this.DetalleColumn.Name = "DetalleColumn";
            this.DetalleColumn.ReadOnly = true;
            this.DetalleColumn.Width = 230;
            // 
            // ChasisColumn
            // 
            this.ChasisColumn.HeaderText = "CHASIS";
            this.ChasisColumn.Name = "ChasisColumn";
            this.ChasisColumn.ReadOnly = true;
            // 
            // PrecioColumn
            // 
            this.PrecioColumn.HeaderText = "PRECIO";
            this.PrecioColumn.Name = "PrecioColumn";
            // 
            // DescColumn
            // 
            this.DescColumn.HeaderText = "DESCUENTO";
            this.DescColumn.Name = "DescColumn";
            // 
            // TotalColumn
            // 
            this.TotalColumn.HeaderText = "TOTAL";
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDetFactura);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 368);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(793, 216);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalle de Factura";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCrearFactura);
            this.tabControl1.Controls.Add(this.tabFacturasCreadas);
            this.tabControl1.Location = new System.Drawing.Point(1, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 615);
            this.tabControl1.TabIndex = 4;
            // 
            // tabCrearFactura
            // 
            this.tabCrearFactura.Controls.Add(this.groupBox2);
            this.tabCrearFactura.Controls.Add(this.groupBox1);
            this.tabCrearFactura.Controls.Add(this.groupBox5);
            this.tabCrearFactura.Controls.Add(this.groupBox3);
            this.tabCrearFactura.Location = new System.Drawing.Point(4, 22);
            this.tabCrearFactura.Name = "tabCrearFactura";
            this.tabCrearFactura.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrearFactura.Size = new System.Drawing.Size(813, 589);
            this.tabCrearFactura.TabIndex = 0;
            this.tabCrearFactura.Text = "Creacion de Facturas";
            this.tabCrearFactura.UseVisualStyleBackColor = true;
            // 
            // tabFacturasCreadas
            // 
            this.tabFacturasCreadas.Controls.Add(this.groupBox6);
            this.tabFacturasCreadas.Controls.Add(this.groupBox4);
            this.tabFacturasCreadas.Location = new System.Drawing.Point(4, 22);
            this.tabFacturasCreadas.Name = "tabFacturasCreadas";
            this.tabFacturasCreadas.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacturasCreadas.Size = new System.Drawing.Size(813, 589);
            this.tabFacturasCreadas.TabIndex = 1;
            this.tabFacturasCreadas.Text = "Facturas Registradas";
            this.tabFacturasCreadas.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbChasis);
            this.groupBox4.Controls.Add(this.rbModelo);
            this.groupBox4.Controls.Add(this.rbMarca);
            this.groupBox4.Controls.Add(this.rbApellido);
            this.groupBox4.Controls.Add(this.rbCedula);
            this.groupBox4.Controls.Add(this.tbxCampo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(19, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(732, 82);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por:";
            // 
            // tbxCampo
            // 
            this.tbxCampo.Location = new System.Drawing.Point(53, 49);
            this.tbxCampo.Name = "tbxCampo";
            this.tbxCampo.Size = new System.Drawing.Size(595, 20);
            this.tbxCampo.TabIndex = 0;
            this.tbxCampo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Location = new System.Drawing.Point(77, 29);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(64, 17);
            this.rbCedula.TabIndex = 1;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula";
            this.rbCedula.UseVisualStyleBackColor = true;
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.Location = new System.Drawing.Point(200, 29);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(70, 17);
            this.rbApellido.TabIndex = 2;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            // 
            // rbMarca
            // 
            this.rbMarca.AutoSize = true;
            this.rbMarca.Location = new System.Drawing.Point(330, 29);
            this.rbMarca.Name = "rbMarca";
            this.rbMarca.Size = new System.Drawing.Size(60, 17);
            this.rbMarca.TabIndex = 3;
            this.rbMarca.TabStop = true;
            this.rbMarca.Text = "Marca";
            this.rbMarca.UseVisualStyleBackColor = true;
            // 
            // rbModelo
            // 
            this.rbModelo.AutoSize = true;
            this.rbModelo.Location = new System.Drawing.Point(452, 29);
            this.rbModelo.Name = "rbModelo";
            this.rbModelo.Size = new System.Drawing.Size(66, 17);
            this.rbModelo.TabIndex = 4;
            this.rbModelo.TabStop = true;
            this.rbModelo.Text = "Modelo";
            this.rbModelo.UseVisualStyleBackColor = true;
            // 
            // rbChasis
            // 
            this.rbChasis.AutoSize = true;
            this.rbChasis.Location = new System.Drawing.Point(568, 29);
            this.rbChasis.Name = "rbChasis";
            this.rbChasis.Size = new System.Drawing.Size(62, 17);
            this.rbChasis.TabIndex = 5;
            this.rbChasis.TabStop = true;
            this.rbChasis.Text = "Chasis";
            this.rbChasis.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvFacturasReg);
            this.groupBox6.Location = new System.Drawing.Point(19, 146);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(767, 412);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datos Clientes";
            // 
            // dgvFacturasReg
            // 
            this.dgvFacturasReg.AllowUserToAddRows = false;
            this.dgvFacturasReg.AllowUserToDeleteRows = false;
            this.dgvFacturasReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturasReg.Location = new System.Drawing.Point(17, 20);
            this.dgvFacturasReg.Name = "dgvFacturasReg";
            this.dgvFacturasReg.ReadOnly = true;
            this.dgvFacturasReg.Size = new System.Drawing.Size(729, 368);
            this.dgvFacturasReg.TabIndex = 0;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(823, 745);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelHead);
            this.Name = "Factura";
            this.Text = "Facturacion de vehiculos";
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetFactura)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCrearFactura.ResumeLayout(false);
            this.tabFacturasCreadas.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbDir;
        private System.Windows.Forms.MaskedTextBox mtbTelf;
        private System.Windows.Forms.Label lblDirc;
        private System.Windows.Forms.Label lblTelf;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox tbClienteName;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxChasis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblChasis;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxAño;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.TextBox tbxCat;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker FechaVencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxRNC;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDetalleVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetFactura;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChasisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCrearFactura;
        private System.Windows.Forms.TabPage tabFacturasCreadas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxCampo;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvFacturasReg;
        private System.Windows.Forms.RadioButton rbChasis;
        private System.Windows.Forms.RadioButton rbModelo;
        private System.Windows.Forms.RadioButton rbMarca;
    }
}