namespace Componentes
{
    partial class fDateTimePicker
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnObterData = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnSetarData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(13, 13);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(314, 20);
            this.dtpData.TabIndex = 0;
            // 
            // btnObterData
            // 
            this.btnObterData.Location = new System.Drawing.Point(350, 10);
            this.btnObterData.Name = "btnObterData";
            this.btnObterData.Size = new System.Drawing.Size(203, 23);
            this.btnObterData.TabIndex = 1;
            this.btnObterData.Text = "Obter Data";
            this.btnObterData.UseVisualStyleBackColor = true;
            this.btnObterData.Click += new System.EventHandler(this.btnObterData_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(13, 40);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(314, 20);
            this.txtData.TabIndex = 2;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(13, 67);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(120, 67);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 4;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(227, 67);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 5;
            // 
            // btnSetarData
            // 
            this.btnSetarData.Location = new System.Drawing.Point(350, 67);
            this.btnSetarData.Name = "btnSetarData";
            this.btnSetarData.Size = new System.Drawing.Size(203, 23);
            this.btnSetarData.TabIndex = 9;
            this.btnSetarData.Text = "Setar Data";
            this.btnSetarData.UseVisualStyleBackColor = true;
            this.btnSetarData.Click += new System.EventHandler(this.btnSetarData_Click);
            // 
            // fDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 113);
            this.Controls.Add(this.btnSetarData);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnObterData);
            this.Controls.Add(this.dtpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fDateTimePicker";
            this.Text = "Date Time Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnObterData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnSetarData;
    }
}