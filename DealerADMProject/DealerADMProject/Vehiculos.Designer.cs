namespace DealerADMProject
{
    partial class Vehiculos
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
            this.CBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxModelos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textKm = new System.Windows.Forms.TextBox();
            this.dateTimeAdq = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textPrecioAdq = new System.Windows.Forms.TextBox();
            this.richtextDetalles = new System.Windows.Forms.RichTextBox();
            this.dataGridViewVeh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelChasis = new System.Windows.Forms.Label();
            this.textBoxChasis = new System.Windows.Forms.TextBox();
            this.labelCilindros = new System.Windows.Forms.Label();
            this.labelPuertas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxCilindros = new System.Windows.Forms.ComboBox();
            this.comboBoxPuertas = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textPrecioVenta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBoxMarca
            // 
            this.CBoxMarca.FormattingEnabled = true;
            this.CBoxMarca.Location = new System.Drawing.Point(77, 104);
            this.CBoxMarca.Name = "CBoxMarca";
            this.CBoxMarca.Size = new System.Drawing.Size(134, 21);
            this.CBoxMarca.TabIndex = 0;
            this.CBoxMarca.SelectedIndexChanged += new System.EventHandler(this.CBoxMarca_SelectedIndexChanged);
            // 
            // comboBoxModelos
            // 
            this.comboBoxModelos.FormattingEnabled = true;
            this.comboBoxModelos.Location = new System.Drawing.Point(77, 138);
            this.comboBoxModelos.Name = "comboBoxModelos";
            this.comboBoxModelos.Size = new System.Drawing.Size(134, 21);
            this.comboBoxModelos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(560, 510);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(653, 510);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 56);
            this.panel1.TabIndex = 10;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(21, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(270, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "REGISTRO DE VEHICULOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kilometraje";
            // 
            // textKm
            // 
            this.textKm.Location = new System.Drawing.Point(485, 70);
            this.textKm.Name = "textKm";
            this.textKm.Size = new System.Drawing.Size(58, 20);
            this.textKm.TabIndex = 12;
            // 
            // dateTimeAdq
            // 
            this.dateTimeAdq.Location = new System.Drawing.Point(485, 96);
            this.dateTimeAdq.Name = "dateTimeAdq";
            this.dateTimeAdq.Size = new System.Drawing.Size(197, 20);
            this.dateTimeAdq.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha de adquisicion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio de adquisicion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Detalles";
            // 
            // textPrecioAdq
            // 
            this.textPrecioAdq.Location = new System.Drawing.Point(485, 127);
            this.textPrecioAdq.Name = "textPrecioAdq";
            this.textPrecioAdq.Size = new System.Drawing.Size(101, 20);
            this.textPrecioAdq.TabIndex = 17;
            // 
            // richtextDetalles
            // 
            this.richtextDetalles.Location = new System.Drawing.Point(485, 201);
            this.richtextDetalles.Name = "richtextDetalles";
            this.richtextDetalles.Size = new System.Drawing.Size(236, 74);
            this.richtextDetalles.TabIndex = 18;
            this.richtextDetalles.Text = "";
            // 
            // dataGridViewVeh
            // 
            this.dataGridViewVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeh.Location = new System.Drawing.Point(14, 32);
            this.dataGridViewVeh.Name = "dataGridViewVeh";
            this.dataGridViewVeh.Size = new System.Drawing.Size(717, 150);
            this.dataGridViewVeh.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewVeh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 198);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculos Registrados";
            // 
            // labelChasis
            // 
            this.labelChasis.AutoSize = true;
            this.labelChasis.Location = new System.Drawing.Point(8, 76);
            this.labelChasis.Name = "labelChasis";
            this.labelChasis.Size = new System.Drawing.Size(48, 13);
            this.labelChasis.TabIndex = 21;
            this.labelChasis.Text = "Chasis #";
            // 
            // textBoxChasis
            // 
            this.textBoxChasis.Location = new System.Drawing.Point(77, 73);
            this.textBoxChasis.Name = "textBoxChasis";
            this.textBoxChasis.Size = new System.Drawing.Size(136, 20);
            this.textBoxChasis.TabIndex = 22;
            // 
            // labelCilindros
            // 
            this.labelCilindros.AutoSize = true;
            this.labelCilindros.Location = new System.Drawing.Point(12, 236);
            this.labelCilindros.Name = "labelCilindros";
            this.labelCilindros.Size = new System.Drawing.Size(46, 13);
            this.labelCilindros.TabIndex = 23;
            this.labelCilindros.Text = "Cilindros";
            // 
            // labelPuertas
            // 
            this.labelPuertas.AutoSize = true;
            this.labelPuertas.Location = new System.Drawing.Point(150, 236);
            this.labelPuertas.Name = "labelPuertas";
            this.labelPuertas.Size = new System.Drawing.Size(43, 13);
            this.labelPuertas.TabIndex = 24;
            this.labelPuertas.Text = "Puertas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(77, 167);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(134, 21);
            this.cbCategoria.TabIndex = 28;
            // 
            // comboBoxCilindros
            // 
            this.comboBoxCilindros.FormattingEnabled = true;
            this.comboBoxCilindros.Items.AddRange(new object[] {
            "4",
            "6",
            "8"});
            this.comboBoxCilindros.Location = new System.Drawing.Point(76, 233);
            this.comboBoxCilindros.Name = "comboBoxCilindros";
            this.comboBoxCilindros.Size = new System.Drawing.Size(46, 21);
            this.comboBoxCilindros.TabIndex = 29;
            // 
            // comboBoxPuertas
            // 
            this.comboBoxPuertas.FormattingEnabled = true;
            this.comboBoxPuertas.Items.AddRange(new object[] {
            "3",
            "5"});
            this.comboBoxPuertas.Location = new System.Drawing.Point(202, 232);
            this.comboBoxPuertas.Name = "comboBoxPuertas";
            this.comboBoxPuertas.Size = new System.Drawing.Size(45, 21);
            this.comboBoxPuertas.TabIndex = 30;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(76, 201);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(46, 21);
            this.comboBoxYear.TabIndex = 31;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Bronce",
            "Crema",
            "Dorado",
            "Gris",
            "Gris metalico",
            "Mamey",
            "Marron",
            "Morado",
            "Negro",
            "Plateada",
            "Rojo",
            "Rojo vino",
            "Verde"});
            this.comboBoxColor.Location = new System.Drawing.Point(202, 203);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(88, 21);
            this.comboBoxColor.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Precio de venta";
            // 
            // textPrecioVenta
            // 
            this.textPrecioVenta.Location = new System.Drawing.Point(485, 161);
            this.textPrecioVenta.Name = "textPrecioVenta";
            this.textPrecioVenta.Size = new System.Drawing.Size(101, 20);
            this.textPrecioVenta.TabIndex = 34;
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 545);
            this.Controls.Add(this.textPrecioVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxPuertas);
            this.Controls.Add(this.comboBoxCilindros);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelPuertas);
            this.Controls.Add(this.labelCilindros);
            this.Controls.Add(this.textBoxChasis);
            this.Controls.Add(this.labelChasis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.richtextDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textPrecioAdq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeAdq);
            this.Controls.Add(this.textKm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxModelos);
            this.Controls.Add(this.CBoxMarca);
            this.Name = "Vehiculos";
            this.Text = "Vehiculos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textKm;
        private System.Windows.Forms.DateTimePicker dateTimeAdq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPrecioAdq;
        private System.Windows.Forms.RichTextBox richtextDetalles;
        private System.Windows.Forms.DataGridView dataGridViewVeh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelChasis;
        private System.Windows.Forms.TextBox textBoxChasis;
        private System.Windows.Forms.Label labelCilindros;
        private System.Windows.Forms.Label labelPuertas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox comboBoxCilindros;
        private System.Windows.Forms.ComboBox comboBoxPuertas;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPrecioVenta;
    }
}