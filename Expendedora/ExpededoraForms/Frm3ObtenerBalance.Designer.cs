namespace ExpededoraForms
{
    partial class Frm3ObtenerBalance
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalanceTtal = new System.Windows.Forms.TextBox();
            this.txtGanacias = new System.Windows.Forms.TextBox();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Balance Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tenencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Saldo Inicial";
            // 
            // txtBalanceTtal
            // 
            this.txtBalanceTtal.Location = new System.Drawing.Point(43, 206);
            this.txtBalanceTtal.Name = "txtBalanceTtal";
            this.txtBalanceTtal.ReadOnly = true;
            this.txtBalanceTtal.Size = new System.Drawing.Size(167, 20);
            this.txtBalanceTtal.TabIndex = 25;
            // 
            // txtGanacias
            // 
            this.txtGanacias.Location = new System.Drawing.Point(43, 128);
            this.txtGanacias.Name = "txtGanacias";
            this.txtGanacias.ReadOnly = true;
            this.txtGanacias.Size = new System.Drawing.Size(167, 20);
            this.txtGanacias.TabIndex = 24;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(43, 51);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.ReadOnly = true;
            this.txtSaldoInicial.Size = new System.Drawing.Size(167, 20);
            this.txtSaldoInicial.TabIndex = 23;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptar.Location = new System.Drawing.Point(43, 253);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(167, 37);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // Frm3ObtenerBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 304);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBalanceTtal);
            this.Controls.Add(this.txtGanacias);
            this.Controls.Add(this.txtSaldoInicial);
            this.Name = "Frm3ObtenerBalance";
            this.Text = "Balance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm3ObtenerBalance_FormClosing);
            this.Load += new System.EventHandler(this.FrmObtenerBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalanceTtal;
        private System.Windows.Forms.TextBox txtGanacias;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Button btnAceptar;
    }
}