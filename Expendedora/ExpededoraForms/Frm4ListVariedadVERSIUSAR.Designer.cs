namespace ExpededoraForms
{
    partial class Frm4ListVariedadVERSIUSAR
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
            this.lblEncabezadoList = new System.Windows.Forms.Label();
            this.lstVariedad = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEncabezadoList
            // 
            this.lblEncabezadoList.AutoSize = true;
            this.lblEncabezadoList.Location = new System.Drawing.Point(28, 24);
            this.lblEncabezadoList.Name = "lblEncabezadoList";
            this.lblEncabezadoList.Size = new System.Drawing.Size(35, 13);
            this.lblEncabezadoList.TabIndex = 0;
            this.lblEncabezadoList.Text = "label1";
            // 
            // lstVariedad
            // 
            this.lstVariedad.FormattingEnabled = true;
            this.lstVariedad.Location = new System.Drawing.Point(31, 49);
            this.lstVariedad.Name = "lstVariedad";
            this.lstVariedad.Size = new System.Drawing.Size(430, 368);
            this.lstVariedad.TabIndex = 1;
            // 
            // Frm4ListVariedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 449);
            this.Controls.Add(this.lstVariedad);
            this.Controls.Add(this.lblEncabezadoList);
            this.Name = "Frm4ListVariedad";
            this.Text = "Frm4ListVariedad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezadoList;
        private System.Windows.Forms.ListBox lstVariedad;
    }
}