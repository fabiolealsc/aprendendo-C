namespace Componentes
{
    partial class fMaskedTextBox
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
            this.mtbSenha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbMask = new System.Windows.Forms.MaskedTextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtbSenha
            // 
            this.mtbSenha.Location = new System.Drawing.Point(15, 37);
            this.mtbSenha.Name = "mtbSenha";
            this.mtbSenha.PasswordChar = '*';
            this.mtbSenha.Size = new System.Drawing.Size(196, 20);
            this.mtbSenha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha:";
            // 
            // mtbMask
            // 
            this.mtbMask.Location = new System.Drawing.Point(15, 113);
            this.mtbMask.Mask = "000.000.000-00";
            this.mtbMask.Name = "mtbMask";
            this.mtbMask.Size = new System.Drawing.Size(193, 20);
            this.mtbMask.TabIndex = 2;
            this.mtbMask.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(216, 113);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Mostrar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(15, 139);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(98, 17);
            this.cb1.TabIndex = 4;
            this.cb1.Text = "Somente Texto";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(16, 60);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(95, 17);
            this.cbMostrarSenha.TabIndex = 5;
            this.cbMostrarSenha.Text = "Mostrar Senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // fMaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 194);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.mtbMask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fMaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masked Text Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbMask;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
    }
}