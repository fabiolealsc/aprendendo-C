namespace projetoMor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSelecao2 = new System.Windows.Forms.Panel();
            this.panelSelecao1 = new System.Windows.Forms.Panel();
            this.btnSlss = new System.Windows.Forms.Button();
            this.btnTesouraEletrica = new System.Windows.Forms.Button();
            this.btnSoldaPVC = new System.Windows.Forms.Button();
            this.btnTraslo = new System.Windows.Forms.Button();
            this.btnSannet = new System.Windows.Forms.Button();
            this.btnMupi = new System.Windows.Forms.Button();
            this.btnMezanino = new System.Windows.Forms.Button();
            this.btnGeral = new System.Windows.Forms.Button();
            this.btnEntradaDePallets = new System.Windows.Forms.Button();
            this.btnDocas = new System.Windows.Forms.Button();
            this.btnCorteDeFitas = new System.Windows.Forms.Button();
            this.btnColoman = new System.Windows.Forms.Button();
            this.btnCarroRapido = new System.Windows.Forms.Button();
            this.btnBaias = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new projetoMor.DatabaseDataSet();
            this.baiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baiasTableAdapter = new projetoMor.DatabaseDataSetTableAdapters.BaiasTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxImagemItem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 115);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(203, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(523, 73);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(141, 29);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panelSelecao2);
            this.panel2.Controls.Add(this.panelSelecao1);
            this.panel2.Controls.Add(this.btnSlss);
            this.panel2.Controls.Add(this.btnTesouraEletrica);
            this.panel2.Controls.Add(this.btnSoldaPVC);
            this.panel2.Controls.Add(this.btnTraslo);
            this.panel2.Controls.Add(this.btnSannet);
            this.panel2.Controls.Add(this.btnMupi);
            this.panel2.Controls.Add(this.btnMezanino);
            this.panel2.Controls.Add(this.btnGeral);
            this.panel2.Controls.Add(this.btnEntradaDePallets);
            this.panel2.Controls.Add(this.btnDocas);
            this.panel2.Controls.Add(this.btnCorteDeFitas);
            this.panel2.Controls.Add(this.btnColoman);
            this.panel2.Controls.Add(this.btnCarroRapido);
            this.panel2.Controls.Add(this.btnBaias);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 360);
            this.panel2.TabIndex = 1;
            // 
            // panelSelecao2
            // 
            this.panelSelecao2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelSelecao2.Location = new System.Drawing.Point(182, 19);
            this.panelSelecao2.Name = "panelSelecao2";
            this.panelSelecao2.Size = new System.Drawing.Size(15, 24);
            this.panelSelecao2.TabIndex = 14;
            // 
            // panelSelecao1
            // 
            this.panelSelecao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelSelecao1.Location = new System.Drawing.Point(4, 19);
            this.panelSelecao1.Name = "panelSelecao1";
            this.panelSelecao1.Size = new System.Drawing.Size(17, 24);
            this.panelSelecao1.TabIndex = 13;
            // 
            // btnSlss
            // 
            this.btnSlss.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSlss.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlss.Location = new System.Drawing.Point(24, 259);
            this.btnSlss.Margin = new System.Windows.Forms.Padding(0);
            this.btnSlss.Name = "btnSlss";
            this.btnSlss.Size = new System.Drawing.Size(155, 24);
            this.btnSlss.TabIndex = 12;
            this.btnSlss.Text = "Sls\'s";
            this.btnSlss.UseVisualStyleBackColor = true;
            this.btnSlss.Click += new System.EventHandler(this.btnSlss_Click);
            // 
            // btnTesouraEletrica
            // 
            this.btnTesouraEletrica.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTesouraEletrica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesouraEletrica.Location = new System.Drawing.Point(24, 307);
            this.btnTesouraEletrica.Margin = new System.Windows.Forms.Padding(0);
            this.btnTesouraEletrica.Name = "btnTesouraEletrica";
            this.btnTesouraEletrica.Size = new System.Drawing.Size(155, 24);
            this.btnTesouraEletrica.TabIndex = 11;
            this.btnTesouraEletrica.Text = "Tesoura Eletrica";
            this.btnTesouraEletrica.UseVisualStyleBackColor = true;
            this.btnTesouraEletrica.Click += new System.EventHandler(this.btnTesouraEletrica_Click);
            // 
            // btnSoldaPVC
            // 
            this.btnSoldaPVC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSoldaPVC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoldaPVC.Location = new System.Drawing.Point(24, 283);
            this.btnSoldaPVC.Margin = new System.Windows.Forms.Padding(0);
            this.btnSoldaPVC.Name = "btnSoldaPVC";
            this.btnSoldaPVC.Size = new System.Drawing.Size(155, 24);
            this.btnSoldaPVC.TabIndex = 10;
            this.btnSoldaPVC.Text = "Solda PVC";
            this.btnSoldaPVC.UseVisualStyleBackColor = true;
            this.btnSoldaPVC.Click += new System.EventHandler(this.btnSoldaPVC_Click);
            // 
            // btnTraslo
            // 
            this.btnTraslo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTraslo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraslo.Location = new System.Drawing.Point(24, 331);
            this.btnTraslo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTraslo.Name = "btnTraslo";
            this.btnTraslo.Size = new System.Drawing.Size(155, 24);
            this.btnTraslo.TabIndex = 9;
            this.btnTraslo.Text = "Traslo";
            this.btnTraslo.UseVisualStyleBackColor = true;
            this.btnTraslo.Click += new System.EventHandler(this.btnTraslo_Click);
            // 
            // btnSannet
            // 
            this.btnSannet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSannet.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSannet.Location = new System.Drawing.Point(24, 235);
            this.btnSannet.Margin = new System.Windows.Forms.Padding(0);
            this.btnSannet.Name = "btnSannet";
            this.btnSannet.Size = new System.Drawing.Size(155, 24);
            this.btnSannet.TabIndex = 8;
            this.btnSannet.Text = "Sannet";
            this.btnSannet.UseVisualStyleBackColor = true;
            this.btnSannet.Click += new System.EventHandler(this.btnSannet_Click);
            // 
            // btnMupi
            // 
            this.btnMupi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMupi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMupi.Location = new System.Drawing.Point(24, 211);
            this.btnMupi.Margin = new System.Windows.Forms.Padding(0);
            this.btnMupi.Name = "btnMupi";
            this.btnMupi.Size = new System.Drawing.Size(155, 24);
            this.btnMupi.TabIndex = 7;
            this.btnMupi.Text = "Mupi";
            this.btnMupi.UseVisualStyleBackColor = true;
            this.btnMupi.Click += new System.EventHandler(this.btnMupi_Click);
            // 
            // btnMezanino
            // 
            this.btnMezanino.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMezanino.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMezanino.Location = new System.Drawing.Point(24, 187);
            this.btnMezanino.Margin = new System.Windows.Forms.Padding(0);
            this.btnMezanino.Name = "btnMezanino";
            this.btnMezanino.Size = new System.Drawing.Size(155, 24);
            this.btnMezanino.TabIndex = 3;
            this.btnMezanino.Text = "Mezanino";
            this.btnMezanino.UseVisualStyleBackColor = true;
            this.btnMezanino.Click += new System.EventHandler(this.btnMezanino_Click);
            // 
            // btnGeral
            // 
            this.btnGeral.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGeral.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeral.Location = new System.Drawing.Point(24, 163);
            this.btnGeral.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeral.Name = "btnGeral";
            this.btnGeral.Size = new System.Drawing.Size(155, 24);
            this.btnGeral.TabIndex = 6;
            this.btnGeral.Text = "Geral";
            this.btnGeral.UseVisualStyleBackColor = true;
            this.btnGeral.Click += new System.EventHandler(this.btnGeral_Click);
            // 
            // btnEntradaDePallets
            // 
            this.btnEntradaDePallets.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEntradaDePallets.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaDePallets.Location = new System.Drawing.Point(24, 139);
            this.btnEntradaDePallets.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntradaDePallets.Name = "btnEntradaDePallets";
            this.btnEntradaDePallets.Size = new System.Drawing.Size(155, 24);
            this.btnEntradaDePallets.TabIndex = 5;
            this.btnEntradaDePallets.Text = "Entrada De Pallets";
            this.btnEntradaDePallets.UseVisualStyleBackColor = true;
            this.btnEntradaDePallets.Click += new System.EventHandler(this.btnEntradaDePallets_Click);
            // 
            // btnDocas
            // 
            this.btnDocas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDocas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocas.Location = new System.Drawing.Point(24, 115);
            this.btnDocas.Margin = new System.Windows.Forms.Padding(0);
            this.btnDocas.Name = "btnDocas";
            this.btnDocas.Size = new System.Drawing.Size(155, 24);
            this.btnDocas.TabIndex = 4;
            this.btnDocas.Text = "Docas";
            this.btnDocas.UseVisualStyleBackColor = true;
            this.btnDocas.Click += new System.EventHandler(this.btnDocas_Click);
            // 
            // btnCorteDeFitas
            // 
            this.btnCorteDeFitas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCorteDeFitas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorteDeFitas.Location = new System.Drawing.Point(24, 91);
            this.btnCorteDeFitas.Margin = new System.Windows.Forms.Padding(0);
            this.btnCorteDeFitas.Name = "btnCorteDeFitas";
            this.btnCorteDeFitas.Size = new System.Drawing.Size(155, 24);
            this.btnCorteDeFitas.TabIndex = 3;
            this.btnCorteDeFitas.Text = "Corte De Fitas";
            this.btnCorteDeFitas.UseVisualStyleBackColor = true;
            this.btnCorteDeFitas.Click += new System.EventHandler(this.btnCorteDeFitas_Click);
            // 
            // btnColoman
            // 
            this.btnColoman.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnColoman.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColoman.Location = new System.Drawing.Point(24, 67);
            this.btnColoman.Margin = new System.Windows.Forms.Padding(0);
            this.btnColoman.Name = "btnColoman";
            this.btnColoman.Size = new System.Drawing.Size(155, 24);
            this.btnColoman.TabIndex = 2;
            this.btnColoman.Text = "Coloman";
            this.btnColoman.UseVisualStyleBackColor = true;
            this.btnColoman.Click += new System.EventHandler(this.btnColoman_Click);
            // 
            // btnCarroRapido
            // 
            this.btnCarroRapido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCarroRapido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarroRapido.Location = new System.Drawing.Point(24, 43);
            this.btnCarroRapido.Margin = new System.Windows.Forms.Padding(0);
            this.btnCarroRapido.Name = "btnCarroRapido";
            this.btnCarroRapido.Size = new System.Drawing.Size(155, 24);
            this.btnCarroRapido.TabIndex = 1;
            this.btnCarroRapido.Text = "Carro Rápido";
            this.btnCarroRapido.UseVisualStyleBackColor = true;
            this.btnCarroRapido.Click += new System.EventHandler(this.btnCarroRapido_Click);
            // 
            // btnBaias
            // 
            this.btnBaias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBaias.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaias.Location = new System.Drawing.Point(24, 19);
            this.btnBaias.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaias.Name = "btnBaias";
            this.btnBaias.Size = new System.Drawing.Size(155, 24);
            this.btnBaias.TabIndex = 0;
            this.btnBaias.Text = "Baias";
            this.btnBaias.UseVisualStyleBackColor = true;
            this.btnBaias.Click += new System.EventHandler(this.btnBaias_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.pictureBoxImagemItem);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 360);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.descriçãoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.baiasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baiasBindingSource
            // 
            this.baiasBindingSource.DataMember = "Baias";
            this.baiasBindingSource.DataSource = this.databaseDataSet;
            // 
            // baiasTableAdapter
            // 
            this.baiasTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoItemToolStripMenuItem,
            this.editarItemToolStripMenuItem,
            this.deletarItemToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoItemToolStripMenuItem
            // 
            this.novoItemToolStripMenuItem.Name = "novoItemToolStripMenuItem";
            this.novoItemToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.novoItemToolStripMenuItem.Text = "Novo Item";
            // 
            // editarItemToolStripMenuItem
            // 
            this.editarItemToolStripMenuItem.Name = "editarItemToolStripMenuItem";
            this.editarItemToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.editarItemToolStripMenuItem.Text = "Editar Item";
            // 
            // deletarItemToolStripMenuItem
            // 
            this.deletarItemToolStripMenuItem.Name = "deletarItemToolStripMenuItem";
            this.deletarItemToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deletarItemToolStripMenuItem.Text = "Deletar Item";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            // 
            // pictureBoxImagemItem
            // 
            this.pictureBoxImagemItem.BackColor = System.Drawing.Color.White;
            this.pictureBoxImagemItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImagemItem.Location = new System.Drawing.Point(433, 0);
            this.pictureBoxImagemItem.Name = "pictureBoxImagemItem";
            this.pictureBoxImagemItem.Size = new System.Drawing.Size(366, 360);
            this.pictureBoxImagemItem.TabIndex = 1;
            this.pictureBoxImagemItem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::projetoMor.Properties.Resources.iconMOr;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 499);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSlss;
        private System.Windows.Forms.Button btnTesouraEletrica;
        private System.Windows.Forms.Button btnSoldaPVC;
        private System.Windows.Forms.Button btnTraslo;
        private System.Windows.Forms.Button btnSannet;
        private System.Windows.Forms.Button btnMupi;
        private System.Windows.Forms.Button btnMezanino;
        private System.Windows.Forms.Button btnGeral;
        private System.Windows.Forms.Button btnEntradaDePallets;
        private System.Windows.Forms.Button btnDocas;
        private System.Windows.Forms.Button btnCorteDeFitas;
        private System.Windows.Forms.Button btnColoman;
        private System.Windows.Forms.Button btnCarroRapido;
        private System.Windows.Forms.Button btnBaias;
        private System.Windows.Forms.PictureBox pictureBoxImagemItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panelSelecao2;
        private System.Windows.Forms.Panel panelSelecao1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource baiasBindingSource;
        private DatabaseDataSetTableAdapters.BaiasTableAdapter baiasTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
    }
}

