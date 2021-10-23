namespace OOPWindow1
{
    partial class Form1
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
            this.btnSoma = new System.Windows.Forms.Button();
            this.somaA = new System.Windows.Forms.TextBox();
            this.somaB = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(55, 95);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(87, 23);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // somaA
            // 
            this.somaA.Location = new System.Drawing.Point(55, 32);
            this.somaA.Name = "somaA";
            this.somaA.Size = new System.Drawing.Size(100, 20);
            this.somaA.TabIndex = 1;
            this.somaA.TextChanged += new System.EventHandler(this.somaA_TextChanged);
            // 
            // somaB
            // 
            this.somaB.Location = new System.Drawing.Point(55, 58);
            this.somaB.Name = "somaB";
            this.somaB.Size = new System.Drawing.Size(100, 20);
            this.somaB.TabIndex = 2;
            this.somaB.TextChanged += new System.EventHandler(this.somaB_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(177, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 290);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(55, 125);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(87, 23);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Subtração";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(55, 155);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(87, 23);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "Multiplicação";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(55, 185);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(87, 23);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "Divisão";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 345);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.somaB);
            this.Controls.Add(this.somaA);
            this.Controls.Add(this.btnSoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.TextBox somaA;
        private System.Windows.Forms.TextBox somaB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
    }
}

