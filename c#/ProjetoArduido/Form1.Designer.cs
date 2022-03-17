namespace ProjetoArduido
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
            this.components = new System.ComponentModel.Container();
            this.dgv_DadosBanco = new System.Windows.Forms.DataGridView();
            this.dadosArduinoDataSet = new ProjetoArduido.DadosArduinoDataSet();
            this.cadastrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastrosTableAdapter = new ProjetoArduido.DadosArduinoDataSetTableAdapters.CadastrosTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nºCrachaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_RF = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cracha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DadosBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosArduinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DadosBanco
            // 
            this.dgv_DadosBanco.AutoGenerateColumns = false;
            this.dgv_DadosBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DadosBanco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DadosBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DadosBanco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nºCrachaDataGridViewTextBoxColumn,
            this.rFIDDataGridViewTextBoxColumn});
            this.dgv_DadosBanco.DataSource = this.cadastrosBindingSource;
            this.dgv_DadosBanco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DadosBanco.Location = new System.Drawing.Point(403, 3);
            this.dgv_DadosBanco.Name = "dgv_DadosBanco";
            this.dgv_DadosBanco.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DadosBanco.Size = new System.Drawing.Size(395, 475);
            this.dgv_DadosBanco.TabIndex = 0;
            // 
            // dadosArduinoDataSet
            // 
            this.dadosArduinoDataSet.DataSetName = "DadosArduinoDataSet";
            this.dadosArduinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastrosBindingSource
            // 
            this.cadastrosBindingSource.DataMember = "Cadastros";
            this.cadastrosBindingSource.DataSource = this.dadosArduinoDataSet;
            // 
            // cadastrosTableAdapter
            // 
            this.cadastrosTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nºCrachaDataGridViewTextBoxColumn
            // 
            this.nºCrachaDataGridViewTextBoxColumn.DataPropertyName = "NºCracha";
            this.nºCrachaDataGridViewTextBoxColumn.HeaderText = "NºCracha";
            this.nºCrachaDataGridViewTextBoxColumn.Name = "nºCrachaDataGridViewTextBoxColumn";
            // 
            // rFIDDataGridViewTextBoxColumn
            // 
            this.rFIDDataGridViewTextBoxColumn.DataPropertyName = "RF-ID";
            this.rFIDDataGridViewTextBoxColumn.HeaderText = "RF-ID";
            this.rFIDDataGridViewTextBoxColumn.Name = "rFIDDataGridViewTextBoxColumn";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(10, 116);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(102, 116);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_RF
            // 
            this.btn_RF.Location = new System.Drawing.Point(293, 116);
            this.btn_RF.Name = "btn_RF";
            this.btn_RF.Size = new System.Drawing.Size(75, 23);
            this.btn_RF.TabIndex = 3;
            this.btn_RF.Text = "Gerar RF";
            this.btn_RF.UseVisualStyleBackColor = true;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(10, 55);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.txt_Nome.TabIndex = 4;
            // 
            // txt_Cracha
            // 
            this.txt_Cracha.Location = new System.Drawing.Point(154, 56);
            this.txt_Cracha.Name = "txt_Cracha";
            this.txt_Cracha.Size = new System.Drawing.Size(100, 20);
            this.txt_Cracha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "RF_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NºCracha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Cracha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Salvar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Excluir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_RF);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_DadosBanco, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 481);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Janela de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DadosBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosArduinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DadosBanco;
        private DadosArduinoDataSet dadosArduinoDataSet;
        private System.Windows.Forms.BindingSource cadastrosBindingSource;
        private DadosArduinoDataSetTableAdapters.CadastrosTableAdapter cadastrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nºCrachaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_RF;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Cracha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

