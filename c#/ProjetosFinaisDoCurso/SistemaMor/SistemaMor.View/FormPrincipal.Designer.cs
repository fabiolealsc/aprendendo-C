namespace SistemaMor.View
{
    partial class FormPrincipal
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
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaia = new System.Windows.Forms.Button();
            this.btnColoman = new System.Windows.Forms.Button();
            this.btnCarroRapido = new System.Windows.Forms.Button();
            this.btnCorteDeFita = new System.Windows.Forms.Button();
            this.btnDoca = new System.Windows.Forms.Button();
            this.btnEntradaDePallet = new System.Windows.Forms.Button();
            this.btnGeral = new System.Windows.Forms.Button();
            this.btnMezanino = new System.Windows.Forms.Button();
            this.btnMupi = new System.Windows.Forms.Button();
            this.btnSls = new System.Windows.Forms.Button();
            this.btnSoldaPVC = new System.Windows.Forms.Button();
            this.btnTraslo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.imagemItem = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemItem)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(200)))));
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.item,
            this.descricao,
            this.imagem});
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(3, 3);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(417, 442);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // item
            // 
            this.item.DataPropertyName = "item";
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 390;
            // 
            // imagem
            // 
            this.imagem.DataPropertyName = "imagem";
            this.imagem.HeaderText = "Imagem";
            this.imagem.Name = "imagem";
            this.imagem.ReadOnly = true;
            this.imagem.Visible = false;
            // 
            // btnBaia
            // 
            this.btnBaia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(200)))));
            this.btnBaia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBaia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaia.ForeColor = System.Drawing.Color.White;
            this.btnBaia.Location = new System.Drawing.Point(0, 0);
            this.btnBaia.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaia.Name = "btnBaia";
            this.btnBaia.Size = new System.Drawing.Size(220, 37);
            this.btnBaia.TabIndex = 2;
            this.btnBaia.Text = "Baias";
            this.btnBaia.UseVisualStyleBackColor = false;
            this.btnBaia.Click += new System.EventHandler(this.btnBaia_Click);
            // 
            // btnColoman
            // 
            this.btnColoman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColoman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColoman.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnColoman.Location = new System.Drawing.Point(0, 74);
            this.btnColoman.Margin = new System.Windows.Forms.Padding(0);
            this.btnColoman.Name = "btnColoman";
            this.btnColoman.Size = new System.Drawing.Size(220, 37);
            this.btnColoman.TabIndex = 3;
            this.btnColoman.Text = "Coloman";
            this.btnColoman.UseVisualStyleBackColor = true;
            this.btnColoman.Click += new System.EventHandler(this.btnColoman_Click);
            // 
            // btnCarroRapido
            // 
            this.btnCarroRapido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCarroRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarroRapido.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCarroRapido.Location = new System.Drawing.Point(0, 37);
            this.btnCarroRapido.Margin = new System.Windows.Forms.Padding(0);
            this.btnCarroRapido.Name = "btnCarroRapido";
            this.btnCarroRapido.Size = new System.Drawing.Size(220, 37);
            this.btnCarroRapido.TabIndex = 3;
            this.btnCarroRapido.Text = "Carro Rapido";
            this.btnCarroRapido.UseVisualStyleBackColor = true;
            this.btnCarroRapido.Click += new System.EventHandler(this.btnCarroRapido_Click);
            // 
            // btnCorteDeFita
            // 
            this.btnCorteDeFita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCorteDeFita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorteDeFita.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCorteDeFita.Location = new System.Drawing.Point(0, 111);
            this.btnCorteDeFita.Margin = new System.Windows.Forms.Padding(0);
            this.btnCorteDeFita.Name = "btnCorteDeFita";
            this.btnCorteDeFita.Size = new System.Drawing.Size(220, 37);
            this.btnCorteDeFita.TabIndex = 4;
            this.btnCorteDeFita.Text = "Corte de Fita";
            this.btnCorteDeFita.UseVisualStyleBackColor = true;
            this.btnCorteDeFita.Click += new System.EventHandler(this.btnCorteDeFita_Click);
            // 
            // btnDoca
            // 
            this.btnDoca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoca.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoca.Location = new System.Drawing.Point(0, 148);
            this.btnDoca.Margin = new System.Windows.Forms.Padding(0);
            this.btnDoca.Name = "btnDoca";
            this.btnDoca.Size = new System.Drawing.Size(220, 37);
            this.btnDoca.TabIndex = 5;
            this.btnDoca.Text = "Doca";
            this.btnDoca.UseVisualStyleBackColor = true;
            this.btnDoca.Click += new System.EventHandler(this.btnDoca_Click);
            // 
            // btnEntradaDePallet
            // 
            this.btnEntradaDePallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEntradaDePallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaDePallet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntradaDePallet.Location = new System.Drawing.Point(0, 185);
            this.btnEntradaDePallet.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntradaDePallet.Name = "btnEntradaDePallet";
            this.btnEntradaDePallet.Size = new System.Drawing.Size(220, 37);
            this.btnEntradaDePallet.TabIndex = 6;
            this.btnEntradaDePallet.Text = "Entrada de Pallet";
            this.btnEntradaDePallet.UseVisualStyleBackColor = true;
            this.btnEntradaDePallet.Click += new System.EventHandler(this.btnEntradaDePallet_Click);
            // 
            // btnGeral
            // 
            this.btnGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeral.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGeral.Location = new System.Drawing.Point(0, 222);
            this.btnGeral.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeral.Name = "btnGeral";
            this.btnGeral.Size = new System.Drawing.Size(220, 37);
            this.btnGeral.TabIndex = 7;
            this.btnGeral.Text = "Geral";
            this.btnGeral.UseVisualStyleBackColor = true;
            this.btnGeral.Click += new System.EventHandler(this.btnGeral_Click);
            // 
            // btnMezanino
            // 
            this.btnMezanino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMezanino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMezanino.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMezanino.Location = new System.Drawing.Point(0, 259);
            this.btnMezanino.Margin = new System.Windows.Forms.Padding(0);
            this.btnMezanino.Name = "btnMezanino";
            this.btnMezanino.Size = new System.Drawing.Size(220, 37);
            this.btnMezanino.TabIndex = 8;
            this.btnMezanino.Text = "Mezanino";
            this.btnMezanino.UseVisualStyleBackColor = true;
            this.btnMezanino.Click += new System.EventHandler(this.btnMezanino_Click);
            // 
            // btnMupi
            // 
            this.btnMupi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMupi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMupi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMupi.Location = new System.Drawing.Point(0, 296);
            this.btnMupi.Margin = new System.Windows.Forms.Padding(0);
            this.btnMupi.Name = "btnMupi";
            this.btnMupi.Size = new System.Drawing.Size(220, 37);
            this.btnMupi.TabIndex = 9;
            this.btnMupi.Text = "Mupi";
            this.btnMupi.UseVisualStyleBackColor = true;
            this.btnMupi.Click += new System.EventHandler(this.btnMupi_Click);
            // 
            // btnSls
            // 
            this.btnSls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSls.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSls.Location = new System.Drawing.Point(0, 333);
            this.btnSls.Margin = new System.Windows.Forms.Padding(0);
            this.btnSls.Name = "btnSls";
            this.btnSls.Size = new System.Drawing.Size(220, 37);
            this.btnSls.TabIndex = 10;
            this.btnSls.Text = "Sls";
            this.btnSls.UseVisualStyleBackColor = true;
            this.btnSls.Click += new System.EventHandler(this.btnSls_Click);
            // 
            // btnSoldaPVC
            // 
            this.btnSoldaPVC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSoldaPVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoldaPVC.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSoldaPVC.Location = new System.Drawing.Point(0, 370);
            this.btnSoldaPVC.Margin = new System.Windows.Forms.Padding(0);
            this.btnSoldaPVC.Name = "btnSoldaPVC";
            this.btnSoldaPVC.Size = new System.Drawing.Size(220, 37);
            this.btnSoldaPVC.TabIndex = 11;
            this.btnSoldaPVC.Text = "Solda PVC";
            this.btnSoldaPVC.UseVisualStyleBackColor = true;
            this.btnSoldaPVC.Click += new System.EventHandler(this.btnSoldaPVC_Click);
            // 
            // btnTraslo
            // 
            this.btnTraslo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTraslo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraslo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTraslo.Location = new System.Drawing.Point(0, 407);
            this.btnTraslo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTraslo.Name = "btnTraslo";
            this.btnTraslo.Size = new System.Drawing.Size(220, 47);
            this.btnTraslo.TabIndex = 12;
            this.btnTraslo.Text = "Traslo";
            this.btnTraslo.UseVisualStyleBackColor = true;
            this.btnTraslo.Click += new System.EventHandler(this.btnTraslo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.10331F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.89669F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1119, 561);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.43991F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.56009F));
            this.tableLayoutPanel3.Controls.Add(this.dgvItens, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.imagemItem, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(223, 110);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 448F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(893, 448);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // imagemItem
            // 
            this.imagemItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(200)))));
            this.imagemItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagemItem.Location = new System.Drawing.Point(426, 3);
            this.imagemItem.Name = "imagemItem";
            this.imagemItem.Size = new System.Drawing.Size(464, 442);
            this.imagemItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemItem.TabIndex = 1;
            this.imagemItem.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnBaia, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTraslo, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.btnCarroRapido, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSoldaPVC, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.btnColoman, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSls, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnCorteDeFita, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnMupi, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnDoca, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnMezanino, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnEntradaDePallet, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnGeral, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 107);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 454);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SistemaMor.View.Properties.Resources.logoMor1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.14721F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.85279F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel4.Controls.Add(this.txtBuscar, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnEditarItem, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnExcluirItem, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnNovoItem, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTitulo, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSair, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(223, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.32323F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.34343F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(893, 101);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(3, 69);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar:";
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(200)))));
            this.btnEditarItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarItem.ForeColor = System.Drawing.Color.White;
            this.btnEditarItem.Location = new System.Drawing.Point(788, 66);
            this.btnEditarItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(105, 35);
            this.btnEditarItem.TabIndex = 4;
            this.btnEditarItem.Text = "Editar Item";
            this.btnEditarItem.UseVisualStyleBackColor = false;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(200)))));
            this.btnExcluirItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItem.ForeColor = System.Drawing.Color.White;
            this.btnExcluirItem.Location = new System.Drawing.Point(788, 32);
            this.btnExcluirItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(105, 34);
            this.btnExcluirItem.TabIndex = 3;
            this.btnExcluirItem.Text = "Excluir Item";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(200)))));
            this.btnNovoItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoItem.ForeColor = System.Drawing.Color.White;
            this.btnNovoItem.Location = new System.Drawing.Point(788, 0);
            this.btnNovoItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(105, 32);
            this.btnNovoItem.TabIndex = 2;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = false;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(343, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(93, 32);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Baias";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(200)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(0, 2);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 28);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormPrincipal_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagemItem)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.PictureBox imagemItem;
        private System.Windows.Forms.Button btnBaia;
        private System.Windows.Forms.Button btnColoman;
        private System.Windows.Forms.Button btnCarroRapido;
        private System.Windows.Forms.Button btnCorteDeFita;
        private System.Windows.Forms.Button btnDoca;
        private System.Windows.Forms.Button btnEntradaDePallet;
        private System.Windows.Forms.Button btnGeral;
        private System.Windows.Forms.Button btnMezanino;
        private System.Windows.Forms.Button btnMupi;
        private System.Windows.Forms.Button btnSls;
        private System.Windows.Forms.Button btnSoldaPVC;
        private System.Windows.Forms.Button btnTraslo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.Button btnSair;
    }
}

