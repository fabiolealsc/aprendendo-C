namespace Componentes
{
    partial class fCheckedListBox
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
            this.clbTransportes = new System.Windows.Forms.CheckedListBox();
            this.btnMostrarSelecionado = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnResetar = new System.Windows.Forms.Button();
            this.txtNovoTransporte = new System.Windows.Forms.TextBox();
            this.btnNovoTransporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbTransportes
            // 
            this.clbTransportes.FormattingEnabled = true;
            this.clbTransportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem",
            "Motocicleta",
            "Cavalo"});
            this.clbTransportes.Location = new System.Drawing.Point(27, 13);
            this.clbTransportes.Name = "clbTransportes";
            this.clbTransportes.Size = new System.Drawing.Size(154, 319);
            this.clbTransportes.TabIndex = 0;
            // 
            // btnMostrarSelecionado
            // 
            this.btnMostrarSelecionado.Location = new System.Drawing.Point(187, 13);
            this.btnMostrarSelecionado.Name = "btnMostrarSelecionado";
            this.btnMostrarSelecionado.Size = new System.Drawing.Size(267, 29);
            this.btnMostrarSelecionado.TabIndex = 1;
            this.btnMostrarSelecionado.Text = "Mostrar Selecionados";
            this.btnMostrarSelecionado.UseVisualStyleBackColor = true;
            this.btnMostrarSelecionado.Click += new System.EventHandler(this.btnMostrarSelecionado_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(187, 48);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(267, 29);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(187, 83);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(267, 29);
            this.btnResetar.TabIndex = 3;
            this.btnResetar.Text = "Resetar Lista";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // txtNovoTransporte
            // 
            this.txtNovoTransporte.Location = new System.Drawing.Point(187, 274);
            this.txtNovoTransporte.Name = "txtNovoTransporte";
            this.txtNovoTransporte.Size = new System.Drawing.Size(267, 20);
            this.txtNovoTransporte.TabIndex = 4;
            // 
            // btnNovoTransporte
            // 
            this.btnNovoTransporte.Location = new System.Drawing.Point(187, 300);
            this.btnNovoTransporte.Name = "btnNovoTransporte";
            this.btnNovoTransporte.Size = new System.Drawing.Size(267, 32);
            this.btnNovoTransporte.TabIndex = 5;
            this.btnNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btnNovoTransporte.UseVisualStyleBackColor = true;
            this.btnNovoTransporte.Click += new System.EventHandler(this.btnNovoTransporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte:";
            // 
            // fCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovoTransporte);
            this.Controls.Add(this.txtNovoTransporte);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrarSelecionado);
            this.Controls.Add(this.clbTransportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fCheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbTransportes;
        private System.Windows.Forms.Button btnMostrarSelecionado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.TextBox txtNovoTransporte;
        private System.Windows.Forms.Button btnNovoTransporte;
        private System.Windows.Forms.Label label1;
    }
}