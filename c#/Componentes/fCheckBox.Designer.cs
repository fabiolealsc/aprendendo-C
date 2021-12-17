namespace Componentes
{
    partial class fCheckBox
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
            this.cbxCarro = new System.Windows.Forms.CheckBox();
            this.cbxAviao = new System.Windows.Forms.CheckBox();
            this.cbxNavio = new System.Windows.Forms.CheckBox();
            this.cbxMoto = new System.Windows.Forms.CheckBox();
            this.cbxCavalo = new System.Windows.Forms.CheckBox();
            this.btnTransportesMarcados = new System.Windows.Forms.Button();
            this.cbxPatinete = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCarro
            // 
            this.cbxCarro.AutoSize = true;
            this.cbxCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCarro.Location = new System.Drawing.Point(13, 13);
            this.cbxCarro.Name = "cbxCarro";
            this.cbxCarro.Size = new System.Drawing.Size(67, 24);
            this.cbxCarro.TabIndex = 0;
            this.cbxCarro.Text = "Carro";
            this.cbxCarro.UseVisualStyleBackColor = true;
            // 
            // cbxAviao
            // 
            this.cbxAviao.AutoSize = true;
            this.cbxAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAviao.Location = new System.Drawing.Point(13, 37);
            this.cbxAviao.Name = "cbxAviao";
            this.cbxAviao.Size = new System.Drawing.Size(67, 24);
            this.cbxAviao.TabIndex = 1;
            this.cbxAviao.Text = "Avião";
            this.cbxAviao.UseVisualStyleBackColor = true;
            // 
            // cbxNavio
            // 
            this.cbxNavio.AutoSize = true;
            this.cbxNavio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNavio.Location = new System.Drawing.Point(13, 61);
            this.cbxNavio.Name = "cbxNavio";
            this.cbxNavio.Size = new System.Drawing.Size(67, 24);
            this.cbxNavio.TabIndex = 2;
            this.cbxNavio.Text = "Navio";
            this.cbxNavio.UseVisualStyleBackColor = true;
            // 
            // cbxMoto
            // 
            this.cbxMoto.AutoSize = true;
            this.cbxMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMoto.Location = new System.Drawing.Point(13, 85);
            this.cbxMoto.Name = "cbxMoto";
            this.cbxMoto.Size = new System.Drawing.Size(64, 24);
            this.cbxMoto.TabIndex = 3;
            this.cbxMoto.Text = "Moto";
            this.cbxMoto.UseVisualStyleBackColor = true;
            // 
            // cbxCavalo
            // 
            this.cbxCavalo.AutoSize = true;
            this.cbxCavalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCavalo.Location = new System.Drawing.Point(13, 109);
            this.cbxCavalo.Name = "cbxCavalo";
            this.cbxCavalo.Size = new System.Drawing.Size(76, 24);
            this.cbxCavalo.TabIndex = 4;
            this.cbxCavalo.Text = "Cavalo";
            this.cbxCavalo.UseVisualStyleBackColor = true;
            // 
            // btnTransportesMarcados
            // 
            this.btnTransportesMarcados.Location = new System.Drawing.Point(112, 13);
            this.btnTransportesMarcados.Name = "btnTransportesMarcados";
            this.btnTransportesMarcados.Size = new System.Drawing.Size(226, 35);
            this.btnTransportesMarcados.TabIndex = 5;
            this.btnTransportesMarcados.Text = "Transportes Marcados";
            this.btnTransportesMarcados.UseVisualStyleBackColor = true;
            this.btnTransportesMarcados.Click += new System.EventHandler(this.btnTransportesMarcados_Click);
            // 
            // cbxPatinete
            // 
            this.cbxPatinete.AutoSize = true;
            this.cbxPatinete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPatinete.Location = new System.Drawing.Point(13, 133);
            this.cbxPatinete.Name = "cbxPatinete";
            this.cbxPatinete.Size = new System.Drawing.Size(87, 24);
            this.cbxPatinete.TabIndex = 6;
            this.cbxPatinete.Text = "Patinete";
            this.cbxPatinete.UseVisualStyleBackColor = true;
            this.cbxPatinete.CheckedChanged += new System.EventHandler(this.cbxPatinete_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Abrir Form Filho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 205);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxPatinete);
            this.Controls.Add(this.btnTransportesMarcados);
            this.Controls.Add(this.cbxCavalo);
            this.Controls.Add(this.cbxMoto);
            this.Controls.Add(this.cbxNavio);
            this.Controls.Add(this.cbxAviao);
            this.Controls.Add(this.cbxCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTransportesMarcados;
        public System.Windows.Forms.CheckBox cbxCarro;
        public System.Windows.Forms.CheckBox cbxAviao;
        public System.Windows.Forms.CheckBox cbxNavio;
        public System.Windows.Forms.CheckBox cbxMoto;
        public System.Windows.Forms.CheckBox cbxCavalo;
        public System.Windows.Forms.CheckBox cbxPatinete;
        private System.Windows.Forms.Button button1;
    }
}