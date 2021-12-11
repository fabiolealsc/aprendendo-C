namespace Componentes
{
    partial class fVeiculos
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
            this.txtListaVeiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtListaVeiculos
            // 
            this.txtListaVeiculos.Location = new System.Drawing.Point(0, 0);
            this.txtListaVeiculos.Multiline = true;
            this.txtListaVeiculos.Name = "txtListaVeiculos";
            this.txtListaVeiculos.Size = new System.Drawing.Size(491, 222);
            this.txtListaVeiculos.TabIndex = 0;
            // 
            // fVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 222);
            this.Controls.Add(this.txtListaVeiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fVeiculos";
            this.Text = "Lista de Veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fVeiculos_FormClosed);
            this.Load += new System.EventHandler(this.fVeiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListaVeiculos;
    }
}