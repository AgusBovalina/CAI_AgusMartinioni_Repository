namespace ExpededoraForms
{
    partial class Frm3IngresarLata
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
            this.lstVariedad = new System.Windows.Forms.ListBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.lblListLabel = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngresarLata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVariedad
            // 
            this.lstVariedad.FormattingEnabled = true;
            this.lstVariedad.Location = new System.Drawing.Point(29, 52);
            this.lstVariedad.Name = "lstVariedad";
            this.lstVariedad.Size = new System.Drawing.Size(393, 368);
            this.lstVariedad.TabIndex = 0;
            this.lstVariedad.SelectedIndexChanged += new System.EventHandler(this.LstVariedad_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(505, 76);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(167, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(505, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtSabor
            // 
            this.txtSabor.Location = new System.Drawing.Point(505, 231);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.ReadOnly = true;
            this.txtSabor.Size = new System.Drawing.Size(167, 20);
            this.txtSabor.TabIndex = 3;
            // 
            // lblListLabel
            // 
            this.lblListLabel.AutoSize = true;
            this.lblListLabel.Location = new System.Drawing.Point(28, 21);
            this.lblListLabel.Name = "lblListLabel";
            this.lblListLabel.Size = new System.Drawing.Size(163, 13);
            this.lblListLabel.TabIndex = 4;
            this.lblListLabel.Text = "Elija qué variedad desea ingresar";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(505, 306);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(167, 20);
            this.txtVolumen.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(505, 378);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(167, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sabor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Volumen";
            // 
            // btnIngresarLata
            // 
            this.btnIngresarLata.Location = new System.Drawing.Point(505, 428);
            this.btnIngresarLata.Name = "btnIngresarLata";
            this.btnIngresarLata.Size = new System.Drawing.Size(167, 37);
            this.btnIngresarLata.TabIndex = 12;
            this.btnIngresarLata.Text = "Ingresar Lata";
            this.btnIngresarLata.UseVisualStyleBackColor = true;
            this.btnIngresarLata.Click += new System.EventHandler(this.BtnIngresarLata_Click);
            // 
            // Frm3IngresarLata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 477);
            this.Controls.Add(this.btnIngresarLata);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblListLabel);
            this.Controls.Add(this.txtSabor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lstVariedad);
            this.Name = "Frm3IngresarLata";
            this.Text = "Ingresar Lata";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm3IngresarLata_FormClosing);
            this.Load += new System.EventHandler(this.Frm3IngresarLata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVariedad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.Label lblListLabel;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresarLata;
    }
}