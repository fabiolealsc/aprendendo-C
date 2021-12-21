namespace Componentes
{
    partial class fLinkLabel
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
            this.txtGit = new System.Windows.Forms.TextBox();
            this.llblGit = new System.Windows.Forms.LinkLabel();
            this.llblCalculadora = new System.Windows.Forms.LinkLabel();
            this.llblMultiplosLink = new System.Windows.Forms.LinkLabel();
            this.llLikedin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite nome do Git:";
            // 
            // txtGit
            // 
            this.txtGit.Location = new System.Drawing.Point(16, 30);
            this.txtGit.Name = "txtGit";
            this.txtGit.Size = new System.Drawing.Size(209, 20);
            this.txtGit.TabIndex = 1;
            // 
            // llblGit
            // 
            this.llblGit.AutoSize = true;
            this.llblGit.Location = new System.Drawing.Point(13, 57);
            this.llblGit.Name = "llblGit";
            this.llblGit.Size = new System.Drawing.Size(38, 13);
            this.llblGit.TabIndex = 2;
            this.llblGit.TabStop = true;
            this.llblGit.Text = "Github";
            this.llblGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCanal_LinkClicked);
            // 
            // llblCalculadora
            // 
            this.llblCalculadora.AutoSize = true;
            this.llblCalculadora.Location = new System.Drawing.Point(162, 57);
            this.llblCalculadora.Name = "llblCalculadora";
            this.llblCalculadora.Size = new System.Drawing.Size(63, 13);
            this.llblCalculadora.TabIndex = 3;
            this.llblCalculadora.TabStop = true;
            this.llblCalculadora.Text = "Calculadora";
            this.llblCalculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCalculadora_LinkClicked);
            // 
            // llblMultiplosLink
            // 
            this.llblMultiplosLink.AutoSize = true;
            this.llblMultiplosLink.Location = new System.Drawing.Point(53, 98);
            this.llblMultiplosLink.Name = "llblMultiplosLink";
            this.llblMultiplosLink.Size = new System.Drawing.Size(130, 13);
            this.llblMultiplosLink.TabIndex = 4;
            this.llblMultiplosLink.TabStop = true;
            this.llblMultiplosLink.Text = "Google - Canal - YouTube";
            this.llblMultiplosLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMultiplosLink_LinkClicked);
            // 
            // llLikedin
            // 
            this.llLikedin.AutoSize = true;
            this.llLikedin.Location = new System.Drawing.Point(85, 57);
            this.llLikedin.Name = "llLikedin";
            this.llLikedin.Size = new System.Drawing.Size(47, 13);
            this.llLikedin.TabIndex = 5;
            this.llLikedin.TabStop = true;
            this.llLikedin.Text = "Linkedin";
            this.llLikedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLikedin_LinkClicked);
            // 
            // fLinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 140);
            this.Controls.Add(this.llLikedin);
            this.Controls.Add(this.llblMultiplosLink);
            this.Controls.Add(this.llblCalculadora);
            this.Controls.Add(this.llblGit);
            this.Controls.Add(this.txtGit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fLinkLabel";
            this.Text = "fLinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGit;
        private System.Windows.Forms.LinkLabel llblGit;
        private System.Windows.Forms.LinkLabel llblCalculadora;
        private System.Windows.Forms.LinkLabel llblMultiplosLink;
        private System.Windows.Forms.LinkLabel llLikedin;
    }
}