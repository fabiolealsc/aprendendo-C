namespace PreparacaoDeDadosParaGravacao
{
    partial class FormGeracaoArquivoTexto
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
            this.btnCriarLinhas = new System.Windows.Forms.Button();
            this.btnCriarAquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtNrFuncionarios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarLinhas
            // 
            this.btnCriarLinhas.Location = new System.Drawing.Point(183, 4);
            this.btnCriarLinhas.Name = "btnCriarLinhas";
            this.btnCriarLinhas.Size = new System.Drawing.Size(219, 23);
            this.btnCriarLinhas.TabIndex = 0;
            this.btnCriarLinhas.Text = "Criar linhas para registro";
            this.btnCriarLinhas.UseVisualStyleBackColor = true;
            this.btnCriarLinhas.Click += new System.EventHandler(this.btnCriarLinhas_Click);
            // 
            // btnCriarAquivo
            // 
            this.btnCriarAquivo.Enabled = false;
            this.btnCriarAquivo.Location = new System.Drawing.Point(13, 239);
            this.btnCriarAquivo.Name = "btnCriarAquivo";
            this.btnCriarAquivo.Size = new System.Drawing.Size(208, 23);
            this.btnCriarAquivo.TabIndex = 0;
            this.btnCriarAquivo.Text = "Criar arquivo";
            this.btnCriarAquivo.UseVisualStyleBackColor = true;
            this.btnCriarAquivo.Click += new System.EventHandler(this.btnCriarAquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(228, 239);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(174, 23);
            this.btnReiniciar.TabIndex = 0;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-265, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtNrFuncionarios
            // 
            this.txtNrFuncionarios.Location = new System.Drawing.Point(118, 6);
            this.txtNrFuncionarios.Name = "txtNrFuncionarios";
            this.txtNrFuncionarios.Size = new System.Drawing.Size(59, 20);
            this.txtNrFuncionarios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nr. de Funcionários:";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(13, 38);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(389, 195);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = "Arquivos textos|*.txt";
            this.sfdGravarArquivo.Title = "Dados para geração de arquivos";
            // 
            // FormGeracaoArquivoTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 268);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNrFuncionarios);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarAquivo);
            this.Controls.Add(this.btnCriarLinhas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGeracaoArquivoTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geracao de arquivo de texto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarLinhas;
        private System.Windows.Forms.Button btnCriarAquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtNrFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
    }
}