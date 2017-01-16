namespace DealerADMProject
{
    partial class MantenimientoCliente
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

        /// <summary>.
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mtbxTelfono = new System.Windows.Forms.MaskedTextBox();
            this.tbxCalle = new System.Windows.Forms.TextBox();
            this.tbxProvincia = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxCedula = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbObservaciones = new System.Windows.Forms.GroupBox();
            this.rtbComentario = new System.Windows.Forms.RichTextBox();
            this.tbcCliente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.tbxCampo = new System.Windows.Forms.TextBox();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbDireccion = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.pnClientes = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.gbDatosCliente.SuspendLayout();
            this.gbObservaciones.SuspendLayout();
            this.tbcCliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbRegistro.SuspendLayout();
            this.pnClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.cmbEstado);
            this.gbDatosCliente.Controls.Add(this.lblEstado);
            this.gbDatosCliente.Controls.Add(this.mtbxTelfono);
            this.gbDatosCliente.Controls.Add(this.tbxCalle);
            this.gbDatosCliente.Controls.Add(this.tbxProvincia);
            this.gbDatosCliente.Controls.Add(this.tbxEmail);
            this.gbDatosCliente.Controls.Add(this.tbxDireccion);
            this.gbDatosCliente.Controls.Add(this.tbxApellido);
            this.gbDatosCliente.Controls.Add(this.tbxNombre);
            this.gbDatosCliente.Controls.Add(this.tbxCedula);
            this.gbDatosCliente.Controls.Add(this.lblDir);
            this.gbDatosCliente.Controls.Add(this.lblProvincia);
            this.gbDatosCliente.Controls.Add(this.lblCalle);
            this.gbDatosCliente.Controls.Add(this.lblTelefono);
            this.gbDatosCliente.Controls.Add(this.lblMail);
            this.gbDatosCliente.Controls.Add(this.lblApellido);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Controls.Add(this.lblCedula);
            this.gbDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(8, 6);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(626, 230);
            this.gbDatosCliente.TabIndex = 0;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cmbEstado.Location = new System.Drawing.Point(80, 184);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 18;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 187);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado";
            // 
            // mtbxTelfono
            // 
            this.mtbxTelfono.Location = new System.Drawing.Point(391, 73);
            this.mtbxTelfono.Mask = "000-000-0000";
            this.mtbxTelfono.Name = "mtbxTelfono";
            this.mtbxTelfono.Size = new System.Drawing.Size(100, 20);
            this.mtbxTelfono.TabIndex = 16;
            this.mtbxTelfono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbxTelfono_KeyPress);
            // 
            // tbxCalle
            // 
            this.tbxCalle.Location = new System.Drawing.Point(391, 140);
            this.tbxCalle.Name = "tbxCalle";
            this.tbxCalle.Size = new System.Drawing.Size(153, 20);
            this.tbxCalle.TabIndex = 14;
            // 
            // tbxProvincia
            // 
            this.tbxProvincia.Location = new System.Drawing.Point(391, 108);
            this.tbxProvincia.Name = "tbxProvincia";
            this.tbxProvincia.Size = new System.Drawing.Size(153, 20);
            this.tbxProvincia.TabIndex = 13;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(391, 34);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(227, 20);
            this.tbxEmail.TabIndex = 12;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(80, 145);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(227, 20);
            this.tbxDireccion.TabIndex = 11;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(80, 106);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(153, 20);
            this.tbxApellido.TabIndex = 10;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(80, 73);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(153, 20);
            this.tbxNombre.TabIndex = 9;
            // 
            // tbxCedula
            // 
            this.tbxCedula.Location = new System.Drawing.Point(80, 38);
            this.tbxCedula.Name = "tbxCedula";
            this.tbxCedula.Size = new System.Drawing.Size(127, 20);
            this.tbxCedula.TabIndex = 8;
            this.tbxCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCedula_KeyPress);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(17, 147);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(61, 13);
            this.lblDir.TabIndex = 7;
            this.lblDir.Text = "Direccion";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(322, 108);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(60, 13);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(325, 143);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(35, 13);
            this.lblCalle.TabIndex = 5;
            this.lblCalle.Text = "Calle";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(325, 73);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(57, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(325, 37);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Email";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 109);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(17, 38);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(46, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cedula";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(133, 69);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 40);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(12, 69);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(115, 40);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(264, 69);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(133, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbObservaciones
            // 
            this.gbObservaciones.Controls.Add(this.rtbComentario);
            this.gbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbObservaciones.Location = new System.Drawing.Point(8, 247);
            this.gbObservaciones.Name = "gbObservaciones";
            this.gbObservaciones.Size = new System.Drawing.Size(568, 107);
            this.gbObservaciones.TabIndex = 2;
            this.gbObservaciones.TabStop = false;
            this.gbObservaciones.Text = "Observaciones";
            // 
            // rtbComentario
            // 
            this.rtbComentario.Location = new System.Drawing.Point(9, 19);
            this.rtbComentario.Name = "rtbComentario";
            this.rtbComentario.Size = new System.Drawing.Size(553, 82);
            this.rtbComentario.TabIndex = 0;
            this.rtbComentario.Text = "";
            // 
            // tbcCliente
            // 
            this.tbcCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcCliente.Controls.Add(this.tabPage1);
            this.tbcCliente.Controls.Add(this.tabPage2);
            this.tbcCliente.Location = new System.Drawing.Point(1, 115);
            this.tbcCliente.Name = "tbcCliente";
            this.tbcCliente.SelectedIndex = 0;
            this.tbcCliente.Size = new System.Drawing.Size(783, 387);
            this.tbcCliente.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbDatosCliente);
            this.tabPage1.Controls.Add(this.gbObservaciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbClientes);
            this.tabPage2.Controls.Add(this.gbRegistro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes Registrados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.dgvCliente);
            this.gbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientes.Location = new System.Drawing.Point(6, 94);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(760, 261);
            this.gbClientes.TabIndex = 1;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // dgvCliente
            // 
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(6, 19);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(748, 224);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // gbRegistro
            // 
            this.gbRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegistro.Controls.Add(this.tbxCampo);
            this.gbRegistro.Controls.Add(this.rbEmail);
            this.gbRegistro.Controls.Add(this.rbDireccion);
            this.gbRegistro.Controls.Add(this.rbApellido);
            this.gbRegistro.Controls.Add(this.rbCedula);
            this.gbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.Location = new System.Drawing.Point(2, 0);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(767, 88);
            this.gbRegistro.TabIndex = 0;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Bucar por :";
            // 
            // tbxCampo
            // 
            this.tbxCampo.Location = new System.Drawing.Point(103, 51);
            this.tbxCampo.Name = "tbxCampo";
            this.tbxCampo.Size = new System.Drawing.Size(550, 20);
            this.tbxCampo.TabIndex = 4;
            this.tbxCampo.TextChanged += new System.EventHandler(this.tbxCampo_TextChanged);
            this.tbxCampo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCampo_KeyPress);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(545, 19);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(55, 17);
            this.rbEmail.TabIndex = 3;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // rbDireccion
            // 
            this.rbDireccion.AutoSize = true;
            this.rbDireccion.Location = new System.Drawing.Point(394, 19);
            this.rbDireccion.Name = "rbDireccion";
            this.rbDireccion.Size = new System.Drawing.Size(79, 17);
            this.rbDireccion.TabIndex = 2;
            this.rbDireccion.TabStop = true;
            this.rbDireccion.Text = "Direccion";
            this.rbDireccion.UseVisualStyleBackColor = true;
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.Location = new System.Drawing.Point(243, 19);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(70, 17);
            this.rbApellido.TabIndex = 1;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Location = new System.Drawing.Point(92, 19);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(64, 17);
            this.rbCedula.TabIndex = 0;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula";
            this.rbCedula.UseVisualStyleBackColor = true;
            // 
            // pnClientes
            // 
            this.pnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnClientes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnClientes.Controls.Add(this.labelTitle);
            this.pnClientes.Location = new System.Drawing.Point(1, 0);
            this.pnClientes.Name = "pnClientes";
            this.pnClientes.Size = new System.Drawing.Size(786, 56);
            this.pnClientes.TabIndex = 18;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(7, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(322, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "MANTENIMIENTO DE CLIENTES";
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 501);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnClientes);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.tbcCliente);
            this.Name = "MantenimientoCliente";
            this.Text = "Consulta de clientes";
            this.Load += new System.EventHandler(this.MantenimientoCliente_Load);
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbObservaciones.ResumeLayout(false);
            this.tbcCliente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.pnClientes.ResumeLayout(false);
            this.pnClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox tbxCalle;
        private System.Windows.Forms.TextBox tbxProvincia;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxCedula;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbObservaciones;
        private System.Windows.Forms.RichTextBox rtbComentario;
        private System.Windows.Forms.MaskedTextBox mtbxTelfono;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TabControl tbcCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnClientes;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.TextBox tbxCampo;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbDireccion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}