namespace Componentes
{
    partial class fFilhoCheckBox
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
            this.cbxPatinete = new System.Windows.Forms.CheckBox();
            this.cbxCavalo = new System.Windows.Forms.CheckBox();
            this.cbxMoto = new System.Windows.Forms.CheckBox();
            this.cbxNavio = new System.Windows.Forms.CheckBox();
            this.cbxAviao = new System.Windows.Forms.CheckBox();
            this.cbxCarro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbxPatinete
            // 
            this.cbxPatinete.AutoSize = true;
            this.cbxPatinete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPatinete.Location = new System.Drawing.Point(12, 139);
            this.cbxPatinete.Name = "cbxPatinete";
            this.cbxPatinete.Size = new System.Drawing.Size(87, 24);
            this.cbxPatinete.TabIndex = 12;
            this.cbxPatinete.Text = "Patinete";
            this.cbxPatinete.UseVisualStyleBackColor = true;
            this.cbxPatinete.CheckedChanged += new System.EventHandler(this.cbxPatinete_CheckedChanged);
            // 
            // cbxCavalo
            // 
            this.cbxCavalo.AutoSize = true;
            this.cbxCavalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCavalo.Location = new System.Drawing.Point(12, 115);
            this.cbxCavalo.Name = "cbxCavalo";
            this.cbxCavalo.Size = new System.Drawing.Size(76, 24);
            this.cbxCavalo.TabIndex = 11;
            this.cbxCavalo.Text = "Cavalo";
            this.cbxCavalo.UseVisualStyleBackColor = true;
            this.cbxCavalo.CheckedChanged += new System.EventHandler(this.cbxCavalo_CheckedChanged);
            // 
            // cbxMoto
            // 
            this.cbxMoto.AutoSize = true;
            this.cbxMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMoto.Location = new System.Drawing.Point(12, 91);
            this.cbxMoto.Name = "cbxMoto";
            this.cbxMoto.Size = new System.Drawing.Size(64, 24);
            this.cbxMoto.TabIndex = 10;
            this.cbxMoto.Text = "Moto";
            this.cbxMoto.UseVisualStyleBackColor = true;
            this.cbxMoto.CheckedChanged += new System.EventHandler(this.cbxMoto_CheckedChanged);
            // 
            // cbxNavio
            // 
            this.cbxNavio.AutoSize = true;
            this.cbxNavio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNavio.Location = new System.Drawing.Point(12, 67);
            this.cbxNavio.Name = "cbxNavio";
            this.cbxNavio.Size = new System.Drawing.Size(67, 24);
            this.cbxNavio.TabIndex = 9;
            this.cbxNavio.Text = "Navio";
            this.cbxNavio.UseVisualStyleBackColor = true;
            this.cbxNavio.CheckedChanged += new System.EventHandler(this.cbxNavio_CheckedChanged);
            // 
            // cbxAviao
            // 
            this.cbxAviao.AutoSize = true;
            this.cbxAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAviao.Location = new System.Drawing.Point(12, 43);
            this.cbxAviao.Name = "cbxAviao";
            this.cbxAviao.Size = new System.Drawing.Size(67, 24);
            this.cbxAviao.TabIndex = 8;
            this.cbxAviao.Text = "Avião";
            this.cbxAviao.UseVisualStyleBackColor = true;
            this.cbxAviao.CheckedChanged += new System.EventHandler(this.cbxAviao_CheckedChanged);
            // 
            // cbxCarro
            // 
            this.cbxCarro.AutoSize = true;
            this.cbxCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCarro.Location = new System.Drawing.Point(12, 19);
            this.cbxCarro.Name = "cbxCarro";
            this.cbxCarro.Size = new System.Drawing.Size(67, 24);
            this.cbxCarro.TabIndex = 7;
            this.cbxCarro.Text = "Carro";
            this.cbxCarro.UseVisualStyleBackColor = true;
            this.cbxCarro.CheckedChanged += new System.EventHandler(this.cbxCarro_CheckedChanged);
            // 
            // fFilhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 203);
            this.Controls.Add(this.cbxPatinete);
            this.Controls.Add(this.cbxCavalo);
            this.Controls.Add(this.cbxMoto);
            this.Controls.Add(this.cbxNavio);
            this.Controls.Add(this.cbxAviao);
            this.Controls.Add(this.cbxCarro);
            this.Name = "fFilhoCheckBox";
            this.Text = "fFilhoCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cbxPatinete;
        public System.Windows.Forms.CheckBox cbxCavalo;
        public System.Windows.Forms.CheckBox cbxMoto;
        public System.Windows.Forms.CheckBox cbxNavio;
        public System.Windows.Forms.CheckBox cbxAviao;
        public System.Windows.Forms.CheckBox cbxCarro;
    }
}