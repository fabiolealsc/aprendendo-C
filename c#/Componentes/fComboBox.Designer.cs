namespace Componentes
{
    partial class fComboBox
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
            this.cbTransportes = new System.Windows.Forms.ComboBox();
            this.btnMostrarSelecionado = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.btnAdicionarTransporte = new System.Windows.Forms.Button();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbTransportes
            // 
            this.cbTransportes.FormattingEnabled = true;
            this.cbTransportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus"});
            this.cbTransportes.Location = new System.Drawing.Point(13, 13);
            this.cbTransportes.Name = "cbTransportes";
            this.cbTransportes.Size = new System.Drawing.Size(216, 21);
            this.cbTransportes.TabIndex = 0;
            this.cbTransportes.SelectedIndexChanged += new System.EventHandler(this.cbTransportes_SelectedIndexChanged);
            // 
            // btnMostrarSelecionado
            // 
            this.btnMostrarSelecionado.Location = new System.Drawing.Point(249, 13);
            this.btnMostrarSelecionado.Name = "btnMostrarSelecionado";
            this.btnMostrarSelecionado.Size = new System.Drawing.Size(188, 30);
            this.btnMostrarSelecionado.TabIndex = 1;
            this.btnMostrarSelecionado.Text = "Mostrar Selecionado";
            this.btnMostrarSelecionado.UseVisualStyleBackColor = true;
            this.btnMostrarSelecionado.Click += new System.EventHandler(this.btnMostrarSelecionado_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(249, 43);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(188, 30);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar Elemento";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(249, 73);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(188, 30);
            this.btnResetar.TabIndex = 3;
            this.btnResetar.Text = "Resetar Elementos";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // btnAdicionarTransporte
            // 
            this.btnAdicionarTransporte.Location = new System.Drawing.Point(249, 151);
            this.btnAdicionarTransporte.Name = "btnAdicionarTransporte";
            this.btnAdicionarTransporte.Size = new System.Drawing.Size(188, 30);
            this.btnAdicionarTransporte.TabIndex = 4;
            this.btnAdicionarTransporte.Text = "Adcionar Novo Transporte";
            this.btnAdicionarTransporte.UseVisualStyleBackColor = true;
            this.btnAdicionarTransporte.Click += new System.EventHandler(this.btnAdicionarTransporte_Click);
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(249, 126);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(188, 20);
            this.txtTransporte.TabIndex = 5;
            // 
            // fComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 231);
            this.Controls.Add(this.txtTransporte);
            this.Controls.Add(this.btnAdicionarTransporte);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrarSelecionado);
            this.Controls.Add(this.cbTransportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fComboBox";
            this.Text = "Combo Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTransportes;
        private System.Windows.Forms.Button btnMostrarSelecionado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Button btnAdicionarTransporte;
        private System.Windows.Forms.TextBox txtTransporte;
    }
}