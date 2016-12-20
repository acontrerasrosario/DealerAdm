namespace DealerADMProject
{
    partial class Inicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UserN = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 209);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(302, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 2;
            // 
            // UserN
            // 
            this.UserN.AutoSize = true;
            this.UserN.Location = new System.Drawing.Point(198, 70);
            this.UserN.Name = "UserN";
            this.UserN.Size = new System.Drawing.Size(98, 13);
            this.UserN.TabIndex = 3;
            this.UserN.Text = "Nombre de Usuario";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(231, 134);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(61, 13);
            this.Pass.TabIndex = 4;
            this.Pass.Text = "Contraseña";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(334, 225);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(91, 24);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(470, 225);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 24);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 261);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UserN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label UserN;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

