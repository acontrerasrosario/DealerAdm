namespace DealerADMProject
{
    partial class Menu
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
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.btnDealer = new System.Windows.Forms.Button();
            this.TxtFactura = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(12, 62);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(129, 31);
            this.btnFactura.TabIndex = 0;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            this.btnFactura.MouseHover += new System.EventHandler(this.btnFactura_Hover);
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Location = new System.Drawing.Point(12, 126);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(129, 31);
            this.btnCotizacion.TabIndex = 1;
            this.btnCotizacion.Text = "Cotizacion";
            this.btnCotizacion.UseVisualStyleBackColor = true;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
            this.btnCotizacion.MouseHover += new System.EventHandler(this.btnCotizacion_Hover);
            // 
            // btnDealer
            // 
            this.btnDealer.Location = new System.Drawing.Point(12, 190);
            this.btnDealer.Name = "btnDealer";
            this.btnDealer.Size = new System.Drawing.Size(129, 31);
            this.btnDealer.TabIndex = 2;
            this.btnDealer.Text = "Dealer";
            this.btnDealer.UseVisualStyleBackColor = true;
            this.btnDealer.Click += new System.EventHandler(this.btnVehiculos_Click);
            this.btnDealer.MouseHover += new System.EventHandler(this.btnDealer_Hover);
            // 
            // TxtFactura
            // 
            this.TxtFactura.Location = new System.Drawing.Point(452, 62);
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.ReadOnly = true;
            this.TxtFactura.Size = new System.Drawing.Size(168, 167);
            this.TxtFactura.TabIndex = 3;
            this.TxtFactura.Text = "Facturacion de Vehiculos para venta";
            this.TxtFactura.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFactura);
            this.Controls.Add(this.btnDealer);
            this.Controls.Add(this.btnCotizacion);
            this.Controls.Add(this.btnFactura);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.Button btnDealer;
        private System.Windows.Forms.RichTextBox TxtFactura;
        private System.Windows.Forms.Label label1;
    }
}