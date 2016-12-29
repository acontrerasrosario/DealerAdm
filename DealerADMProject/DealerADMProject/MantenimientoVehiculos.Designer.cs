namespace DealerADMProject
{
    partial class MantenimientoVehiculos
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
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAño = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxKm = new System.Windows.Forms.TextBox();
            this.dtpAdqusicion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPrecioAdq = new System.Windows.Forms.TextBox();
            this.rtbxDetalles = new System.Windows.Forms.RichTextBox();
            this.dgvVeh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelChasis = new System.Windows.Forms.Label();
            this.tbxChasis = new System.Windows.Forms.TextBox();
            this.labelCilindros = new System.Windows.Forms.Label();
            this.labelPuertas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.tcVehiculos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.cmbCilindros = new System.Windows.Forms.ComboBox();
            this.cmbPuertas = new System.Windows.Forms.ComboBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxCampo = new System.Windows.Forms.TextBox();
            this.rbModelo = new System.Windows.Forms.RadioButton();
            this.rbMarca = new System.Windows.Forms.RadioButton();
            this.rbChasis = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tcVehiculos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbDatosVehiculo.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(93, 63);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(134, 21);
            this.cmbMarca.TabIndex = 0;
            this.cmbMarca.SelectedValueChanged += new System.EventHandler(this.cmbMarca_SelectedValueChanged);
            this.cmbMarca.Click += new System.EventHandler(this.cmbMarca_Click);
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(93, 97);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(134, 21);
            this.cmbModelo.TabIndex = 1;
            this.cmbModelo.Click += new System.EventHandler(this.cmbModelos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(219, 131);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(98, 20);
            this.tbxColor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // tbxAño
            // 
            this.tbxAño.Location = new System.Drawing.Point(93, 131);
            this.tbxAño.Name = "tbxAño";
            this.tbxAño.Size = new System.Drawing.Size(46, 20);
            this.tbxAño.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 56);
            this.panel1.TabIndex = 10;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(21, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(339, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "MANTENIMIENTO DE VEHICULOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kilometraje";
            // 
            // tbxKm
            // 
            this.tbxKm.Location = new System.Drawing.Point(93, 206);
            this.tbxKm.Name = "tbxKm";
            this.tbxKm.Size = new System.Drawing.Size(58, 20);
            this.tbxKm.TabIndex = 12;
            // 
            // dtpAdqusicion
            // 
            this.dtpAdqusicion.Location = new System.Drawing.Point(501, 30);
            this.dtpAdqusicion.Name = "dtpAdqusicion";
            this.dtpAdqusicion.Size = new System.Drawing.Size(236, 20);
            this.dtpAdqusicion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha de adquisicion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio de adquisicion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Detalles";
            // 
            // tbxPrecioAdq
            // 
            this.tbxPrecioAdq.Location = new System.Drawing.Point(501, 64);
            this.tbxPrecioAdq.Name = "tbxPrecioAdq";
            this.tbxPrecioAdq.Size = new System.Drawing.Size(150, 20);
            this.tbxPrecioAdq.TabIndex = 17;
            // 
            // rtbxDetalles
            // 
            this.rtbxDetalles.Location = new System.Drawing.Point(501, 134);
            this.rtbxDetalles.Name = "rtbxDetalles";
            this.rtbxDetalles.Size = new System.Drawing.Size(236, 98);
            this.rtbxDetalles.TabIndex = 18;
            this.rtbxDetalles.Text = "";
            // 
            // dgvVeh
            // 
            this.dgvVeh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeh.Location = new System.Drawing.Point(14, 32);
            this.dgvVeh.Name = "dgvVeh";
            this.dgvVeh.Size = new System.Drawing.Size(892, 221);
            this.dgvVeh.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvVeh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 276);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculos Registrados";
            // 
            // labelChasis
            // 
            this.labelChasis.AutoSize = true;
            this.labelChasis.Location = new System.Drawing.Point(29, 30);
            this.labelChasis.Name = "labelChasis";
            this.labelChasis.Size = new System.Drawing.Size(48, 13);
            this.labelChasis.TabIndex = 21;
            this.labelChasis.Text = "Chasis #";
            // 
            // tbxChasis
            // 
            this.tbxChasis.Location = new System.Drawing.Point(93, 30);
            this.tbxChasis.Name = "tbxChasis";
            this.tbxChasis.Size = new System.Drawing.Size(136, 20);
            this.tbxChasis.TabIndex = 22;
            // 
            // labelCilindros
            // 
            this.labelCilindros.AutoSize = true;
            this.labelCilindros.Location = new System.Drawing.Point(29, 164);
            this.labelCilindros.Name = "labelCilindros";
            this.labelCilindros.Size = new System.Drawing.Size(46, 13);
            this.labelCilindros.TabIndex = 23;
            this.labelCilindros.Text = "Cilindros";
            // 
            // labelPuertas
            // 
            this.labelPuertas.AutoSize = true;
            this.labelPuertas.Location = new System.Drawing.Point(170, 165);
            this.labelPuertas.Name = "labelPuertas";
            this.labelPuertas.Size = new System.Drawing.Size(43, 13);
            this.labelPuertas.TabIndex = 24;
            this.labelPuertas.Text = "Puertas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(501, 97);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 28;
            // 
            // tcVehiculos
            // 
            this.tcVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcVehiculos.Controls.Add(this.tabPage1);
            this.tcVehiculos.Controls.Add(this.tabPage2);
            this.tcVehiculos.Location = new System.Drawing.Point(0, 62);
            this.tcVehiculos.Name = "tcVehiculos";
            this.tcVehiculos.SelectedIndex = 0;
            this.tcVehiculos.Size = new System.Drawing.Size(929, 399);
            this.tcVehiculos.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbDatosVehiculo);
            this.tabPage1.Controls.Add(this.gbOpciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(921, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del Vehiculo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbDatosVehiculo
            // 
            this.gbDatosVehiculo.Controls.Add(this.cmbCilindros);
            this.gbDatosVehiculo.Controls.Add(this.cmbPuertas);
            this.gbDatosVehiculo.Controls.Add(this.labelChasis);
            this.gbDatosVehiculo.Controls.Add(this.label8);
            this.gbDatosVehiculo.Controls.Add(this.label7);
            this.gbDatosVehiculo.Controls.Add(this.cmbCategoria);
            this.gbDatosVehiculo.Controls.Add(this.tbxPrecioAdq);
            this.gbDatosVehiculo.Controls.Add(this.cmbMarca);
            this.gbDatosVehiculo.Controls.Add(this.label6);
            this.gbDatosVehiculo.Controls.Add(this.label9);
            this.gbDatosVehiculo.Controls.Add(this.dtpAdqusicion);
            this.gbDatosVehiculo.Controls.Add(this.cmbModelo);
            this.gbDatosVehiculo.Controls.Add(this.rtbxDetalles);
            this.gbDatosVehiculo.Controls.Add(this.tbxKm);
            this.gbDatosVehiculo.Controls.Add(this.label1);
            this.gbDatosVehiculo.Controls.Add(this.label5);
            this.gbDatosVehiculo.Controls.Add(this.label4);
            this.gbDatosVehiculo.Controls.Add(this.label2);
            this.gbDatosVehiculo.Controls.Add(this.tbxAño);
            this.gbDatosVehiculo.Controls.Add(this.labelPuertas);
            this.gbDatosVehiculo.Controls.Add(this.tbxChasis);
            this.gbDatosVehiculo.Controls.Add(this.tbxColor);
            this.gbDatosVehiculo.Controls.Add(this.label3);
            this.gbDatosVehiculo.Controls.Add(this.labelCilindros);
            this.gbDatosVehiculo.Location = new System.Drawing.Point(8, 16);
            this.gbDatosVehiculo.Name = "gbDatosVehiculo";
            this.gbDatosVehiculo.Size = new System.Drawing.Size(762, 264);
            this.gbDatosVehiculo.TabIndex = 30;
            this.gbDatosVehiculo.TabStop = false;
            this.gbDatosVehiculo.Text = "Datos";
            // 
            // cmbCilindros
            // 
            this.cmbCilindros.FormattingEnabled = true;
            this.cmbCilindros.Location = new System.Drawing.Point(93, 161);
            this.cmbCilindros.Name = "cmbCilindros";
            this.cmbCilindros.Size = new System.Drawing.Size(68, 21);
            this.cmbCilindros.TabIndex = 30;
            // 
            // cmbPuertas
            // 
            this.cmbPuertas.FormattingEnabled = true;
            this.cmbPuertas.Location = new System.Drawing.Point(219, 161);
            this.cmbPuertas.Name = "cmbPuertas";
            this.cmbPuertas.Size = new System.Drawing.Size(68, 21);
            this.cmbPuertas.TabIndex = 29;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnEliminar);
            this.gbOpciones.Controls.Add(this.btnCancel);
            this.gbOpciones.Controls.Add(this.btnGuardar);
            this.gbOpciones.Location = new System.Drawing.Point(787, 21);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(114, 172);
            this.gbOpciones.TabIndex = 29;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 59);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 25);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbRegistro);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(921, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehiculos Registrados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbRegistro
            // 
            this.gbRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegistro.Controls.Add(this.btnUpdate);
            this.gbRegistro.Controls.Add(this.tbxCampo);
            this.gbRegistro.Controls.Add(this.rbModelo);
            this.gbRegistro.Controls.Add(this.rbMarca);
            this.gbRegistro.Controls.Add(this.rbChasis);
            this.gbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.Location = new System.Drawing.Point(0, 6);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(915, 88);
            this.gbRegistro.TabIndex = 21;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Bucar por :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(616, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 20);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tbxCampo
            // 
            this.tbxCampo.Location = new System.Drawing.Point(21, 51);
            this.tbxCampo.Name = "tbxCampo";
            this.tbxCampo.Size = new System.Drawing.Size(550, 20);
            this.tbxCampo.TabIndex = 4;
            this.tbxCampo.TextChanged += new System.EventHandler(this.tbxCampo_TextChanged);
            // 
            // rbModelo
            // 
            this.rbModelo.AutoSize = true;
            this.rbModelo.Location = new System.Drawing.Point(312, 19);
            this.rbModelo.Name = "rbModelo";
            this.rbModelo.Size = new System.Drawing.Size(66, 17);
            this.rbModelo.TabIndex = 2;
            this.rbModelo.TabStop = true;
            this.rbModelo.Text = "Modelo";
            this.rbModelo.UseVisualStyleBackColor = true;
            // 
            // rbMarca
            // 
            this.rbMarca.AutoSize = true;
            this.rbMarca.Location = new System.Drawing.Point(161, 19);
            this.rbMarca.Name = "rbMarca";
            this.rbMarca.Size = new System.Drawing.Size(60, 17);
            this.rbMarca.TabIndex = 1;
            this.rbMarca.TabStop = true;
            this.rbMarca.Text = "Marca";
            this.rbMarca.UseVisualStyleBackColor = true;
            // 
            // rbChasis
            // 
            this.rbChasis.AutoSize = true;
            this.rbChasis.Location = new System.Drawing.Point(10, 19);
            this.rbChasis.Name = "rbChasis";
            this.rbChasis.Size = new System.Drawing.Size(62, 17);
            this.rbChasis.TabIndex = 0;
            this.rbChasis.TabStop = true;
            this.rbChasis.Text = "Chasis";
            this.rbChasis.UseVisualStyleBackColor = true;
            // 
            // MantenimientoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 473);
            this.Controls.Add(this.tcVehiculos);
            this.Controls.Add(this.panel1);
            this.Name = "MantenimientoVehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tcVehiculos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbDatosVehiculo.ResumeLayout(false);
            this.gbDatosVehiculo.PerformLayout();
            this.gbOpciones.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxKm;
        private System.Windows.Forms.DateTimePicker dtpAdqusicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPrecioAdq;
        private System.Windows.Forms.RichTextBox rtbxDetalles;
        private System.Windows.Forms.DataGridView dgvVeh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelChasis;
        private System.Windows.Forms.TextBox tbxChasis;
        private System.Windows.Forms.Label labelCilindros;
        private System.Windows.Forms.Label labelPuertas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TabControl tcVehiculos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbDatosVehiculo;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxCampo;
        private System.Windows.Forms.RadioButton rbModelo;
        private System.Windows.Forms.RadioButton rbMarca;
        private System.Windows.Forms.RadioButton rbChasis;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbPuertas;
        private System.Windows.Forms.ComboBox cmbCilindros;
    }
}