﻿namespace ExpededoraForms
{
    partial class Frm2MenuPrincipal
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
            this.btnExtraerLata = new System.Windows.Forms.Button();
            this.btnIngresarLata = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnMostrarStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExtraerLata
            // 
            this.btnExtraerLata.Location = new System.Drawing.Point(38, 85);
            this.btnExtraerLata.Name = "btnExtraerLata";
            this.btnExtraerLata.Size = new System.Drawing.Size(469, 54);
            this.btnExtraerLata.TabIndex = 0;
            this.btnExtraerLata.Text = "Extraer Lata";
            this.btnExtraerLata.UseVisualStyleBackColor = true;
            this.btnExtraerLata.Click += new System.EventHandler(this.btnExtraerLata_Click);
            // 
            // btnIngresarLata
            // 
            this.btnIngresarLata.Location = new System.Drawing.Point(38, 167);
            this.btnIngresarLata.Name = "btnIngresarLata";
            this.btnIngresarLata.Size = new System.Drawing.Size(469, 54);
            this.btnIngresarLata.TabIndex = 1;
            this.btnIngresarLata.Text = "Ingresar lata";
            this.btnIngresarLata.UseVisualStyleBackColor = true;
            this.btnIngresarLata.Click += new System.EventHandler(this.btnIngresarLata_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(38, 333);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(469, 54);
            this.btnBalance.TabIndex = 3;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnMostrarStock
            // 
            this.btnMostrarStock.Location = new System.Drawing.Point(38, 251);
            this.btnMostrarStock.Name = "btnMostrarStock";
            this.btnMostrarStock.Size = new System.Drawing.Size(469, 54);
            this.btnMostrarStock.TabIndex = 2;
            this.btnMostrarStock.Text = "Stock";
            this.btnMostrarStock.UseVisualStyleBackColor = true;
            this.btnMostrarStock.Click += new System.EventHandler(this.btnMostrarStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Frm2MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnMostrarStock);
            this.Controls.Add(this.btnIngresarLata);
            this.Controls.Add(this.btnExtraerLata);
            this.Name = "Frm2MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtraerLata;
        private System.Windows.Forms.Button btnIngresarLata;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnMostrarStock;
        private System.Windows.Forms.Label label1;
    }
}