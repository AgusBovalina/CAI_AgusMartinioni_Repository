namespace ExpendedoraForms
{
    partial class Frm3ExtraerLata
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
            this.btnMostrarStock = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblListlabel = new System.Windows.Forms.Label();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lstVariedad = new System.Windows.Forms.ListBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtIngreseDinero = new System.Windows.Forms.TextBox();
            this.btnExtraerLata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarStock
            // 
            this.btnMostrarStock.Location = new System.Drawing.Point(41, 287);
            this.btnMostrarStock.Name = "btnMostrarStock";
            this.btnMostrarStock.Size = new System.Drawing.Size(174, 37);
            this.btnMostrarStock.TabIndex = 25;
            this.btnMostrarStock.Text = "Mostrar Stock";
            this.btnMostrarStock.UseVisualStyleBackColor = true;
            this.btnMostrarStock.Click += new System.EventHandler(this.BtnMostrarStock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sabor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Código";
            // 
            // lblListlabel
            // 
            this.lblListlabel.AutoSize = true;
            this.lblListlabel.Location = new System.Drawing.Point(286, 22);
            this.lblListlabel.Name = "lblListlabel";
            this.lblListlabel.Size = new System.Drawing.Size(77, 13);
            this.lblListlabel.TabIndex = 17;
            this.lblListlabel.Text = "Elegir variedad";
            // 
            // txtSabor
            // 
            this.txtSabor.Location = new System.Drawing.Point(48, 233);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(167, 20);
            this.txtSabor.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(48, 155);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(48, 78);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(167, 20);
            this.txtCodigo.TabIndex = 14;
            // 
            // lstVariedad
            // 
            this.lstVariedad.FormattingEnabled = true;
            this.lstVariedad.Location = new System.Drawing.Point(287, 53);
            this.lstVariedad.Name = "lstVariedad";
            this.lstVariedad.Size = new System.Drawing.Size(393, 342);
            this.lstVariedad.TabIndex = 13;
            this.lstVariedad.SelectedIndexChanged += new System.EventHandler(this.LstVariedad_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(38, 430);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 29;
            this.lblPrecio.Text = "Precio";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(38, 354);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(48, 13);
            this.lblVolumen.TabIndex = 28;
            this.lblVolumen.Text = "Volumen";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(48, 456);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(167, 20);
            this.txtPrecio.TabIndex = 27;
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(48, 379);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(167, 20);
            this.txtVolumen.TabIndex = 26;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(289, 430);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(74, 13);
            this.lblPago.TabIndex = 31;
            this.lblPago.Text = "Ingrese dinero";
            // 
            // txtIngreseDinero
            // 
            this.txtIngreseDinero.Location = new System.Drawing.Point(299, 456);
            this.txtIngreseDinero.Name = "txtIngreseDinero";
            this.txtIngreseDinero.Size = new System.Drawing.Size(167, 20);
            this.txtIngreseDinero.TabIndex = 30;
            // 
            // btnExtraerLata
            // 
            this.btnExtraerLata.Location = new System.Drawing.Point(506, 439);
            this.btnExtraerLata.Name = "btnExtraerLata";
            this.btnExtraerLata.Size = new System.Drawing.Size(174, 37);
            this.btnExtraerLata.TabIndex = 32;
            this.btnExtraerLata.Text = "Extraer Lata";
            this.btnExtraerLata.UseVisualStyleBackColor = true;
            this.btnExtraerLata.Click += new System.EventHandler(this.BtnExtraerLata_Click);
            // 
            // Frm3ExtraerLata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 510);
            this.Controls.Add(this.btnExtraerLata);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.txtIngreseDinero);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.btnMostrarStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblListlabel);
            this.Controls.Add(this.txtSabor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lstVariedad);
            this.Name = "Frm3ExtraerLata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extraer Lata";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm3ExtraerLata_FormClosing);
            this.Load += new System.EventHandler(this.Frm3ExtraerLata_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm3ExtraerLata_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblListlabel;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ListBox lstVariedad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtIngreseDinero;
        private System.Windows.Forms.Button btnExtraerLata;
        private System.Windows.Forms.TextBox txtVolumen;
    }
}