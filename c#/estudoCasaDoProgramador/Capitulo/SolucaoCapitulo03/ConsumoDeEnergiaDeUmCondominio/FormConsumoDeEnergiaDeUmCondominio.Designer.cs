namespace ConsumoDeEnergiaDeUmCondominio
{
    partial class frmConsumoDeEnergiaDeUmCondominio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalDeConsumo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnProsessarDados = new System.Windows.Forms.Button();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.dgvConsumoDeEnergia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumoDeEnergia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. Casa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consumo:";
            // 
            // lblTotalDeConsumo
            // 
            this.lblTotalDeConsumo.AutoSize = true;
            this.lblTotalDeConsumo.Location = new System.Drawing.Point(178, 233);
            this.lblTotalDeConsumo.Name = "lblTotalDeConsumo";
            this.lblTotalDeConsumo.Size = new System.Drawing.Size(188, 13);
            this.lblTotalDeConsumo.TabIndex = 0;
            this.lblTotalDeConsumo.Text = "Total de consumo sem desconto: ###";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(291, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnProsessarDados
            // 
            this.btnProsessarDados.Location = new System.Drawing.Point(21, 228);
            this.btnProsessarDados.Name = "btnProsessarDados";
            this.btnProsessarDados.Size = new System.Drawing.Size(111, 23);
            this.btnProsessarDados.TabIndex = 3;
            this.btnProsessarDados.Text = "Processar dados";
            this.btnProsessarDados.UseVisualStyleBackColor = true;
            this.btnProsessarDados.Click += new System.EventHandler(this.btnProsessarDados_Click);
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(207, 6);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(78, 20);
            this.txtConsumo.TabIndex = 1;
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(76, 6);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(56, 20);
            this.txtNumeroCasa.TabIndex = 0;
            // 
            // dgvConsumoDeEnergia
            // 
            this.dgvConsumoDeEnergia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumoDeEnergia.Location = new System.Drawing.Point(21, 33);
            this.dgvConsumoDeEnergia.Name = "dgvConsumoDeEnergia";
            this.dgvConsumoDeEnergia.Size = new System.Drawing.Size(345, 189);
            this.dgvConsumoDeEnergia.TabIndex = 4;
            // 
            // frmConsumoDeEnergiaDeUmCondominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.dgvConsumoDeEnergia);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.btnProsessarDados);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblTotalDeConsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsumoDeEnergiaDeUmCondominio";
            this.Text = "Consumo de energia de um condomínio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumoDeEnergia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalDeConsumo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnProsessarDados;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.DataGridView dgvConsumoDeEnergia;
    }
}