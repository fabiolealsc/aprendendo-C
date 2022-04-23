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
            this.imagemItem = new System.Windows.Forms.PictureBox();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemItem)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
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
            this.dgvItens.Size = new System.Drawing.Size(448, 442);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellClick);
            // 
            // imagemItem
            // 
            this.imagemItem.BackColor = System.Drawing.Color.LightGray;
            this.imagemItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagemItem.Location = new System.Drawing.Point(457, 3);
            this.imagemItem.Name = "imagemItem";
            this.imagemItem.Size = new System.Drawing.Size(497, 442);
            this.imagemItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemItem.TabIndex = 1;
            this.imagemItem.TabStop = false;
            // 
            // btnBaia
            // 
            this.btnBaia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBaia.Location = new System.Drawing.Point(0, 0);
            this.btnBaia.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaia.Name = "btnBaia";
            this.btnBaia.Size = new System.Drawing.Size(156, 37);
            this.btnBaia.TabIndex = 2;
            this.btnBaia.Text = "Baias";
            this.btnBaia.UseVisualStyleBackColor = true;
            this.btnBaia.Click += new System.EventHandler(this.btnBaia_Click);
            // 
            // btnColoman
            // 
            this.btnColoman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColoman.Location = new System.Drawing.Point(0, 74);
            this.btnColoman.Margin = new System.Windows.Forms.Padding(0);
            this.btnColoman.Name = "btnColoman";
            this.btnColoman.Size = new System.Drawing.Size(156, 37);
            this.btnColoman.TabIndex = 3;
            this.btnColoman.Text = "Coloman";
            this.btnColoman.UseVisualStyleBackColor = true;
            this.btnColoman.Click += new System.EventHandler(this.btnColoman_Click);
            // 
            // btnCarroRapido
            // 
            this.btnCarroRapido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCarroRapido.Location = new System.Drawing.Point(0, 37);
            this.btnCarroRapido.Margin = new System.Windows.Forms.Padding(0);
            this.btnCarroRapido.Name = "btnCarroRapido";
            this.btnCarroRapido.Size = new System.Drawing.Size(156, 37);
            this.btnCarroRapido.TabIndex = 3;
            this.btnCarroRapido.Text = "Carro Rapido";
            this.btnCarroRapido.UseVisualStyleBackColor = true;
            this.btnCarroRapido.Click += new System.EventHandler(this.btnCarroRapido_Click);
            // 
            // btnCorteDeFita
            // 
            this.btnCorteDeFita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCorteDeFita.Location = new System.Drawing.Point(0, 111);
            this.btnCorteDeFita.Margin = new System.Windows.Forms.Padding(0);
            this.btnCorteDeFita.Name = "btnCorteDeFita";
            this.btnCorteDeFita.Size = new System.Drawing.Size(156, 37);
            this.btnCorteDeFita.TabIndex = 4;
            this.btnCorteDeFita.Text = "Corte de Fita";
            this.btnCorteDeFita.UseVisualStyleBackColor = true;
            this.btnCorteDeFita.Click += new System.EventHandler(this.btnCorteDeFita_Click);
            // 
            // btnDoca
            // 
            this.btnDoca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoca.Location = new System.Drawing.Point(0, 148);
            this.btnDoca.Margin = new System.Windows.Forms.Padding(0);
            this.btnDoca.Name = "btnDoca";
            this.btnDoca.Size = new System.Drawing.Size(156, 37);
            this.btnDoca.TabIndex = 5;
            this.btnDoca.Text = "Doca";
            this.btnDoca.UseVisualStyleBackColor = true;
            this.btnDoca.Click += new System.EventHandler(this.btnDoca_Click);
            // 
            // btnEntradaDePallet
            // 
            this.btnEntradaDePallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEntradaDePallet.Location = new System.Drawing.Point(0, 185);
            this.btnEntradaDePallet.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntradaDePallet.Name = "btnEntradaDePallet";
            this.btnEntradaDePallet.Size = new System.Drawing.Size(156, 37);
            this.btnEntradaDePallet.TabIndex = 6;
            this.btnEntradaDePallet.Text = "Entrada de Pallet";
            this.btnEntradaDePallet.UseVisualStyleBackColor = true;
            this.btnEntradaDePallet.Click += new System.EventHandler(this.btnEntradaDePallet_Click);
            // 
            // btnGeral
            // 
            this.btnGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGeral.Location = new System.Drawing.Point(0, 222);
            this.btnGeral.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeral.Name = "btnGeral";
            this.btnGeral.Size = new System.Drawing.Size(156, 37);
            this.btnGeral.TabIndex = 7;
            this.btnGeral.Text = "Geral";
            this.btnGeral.UseVisualStyleBackColor = true;
            this.btnGeral.Click += new System.EventHandler(this.btnGeral_Click);
            // 
            // btnMezanino
            // 
            this.btnMezanino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMezanino.Location = new System.Drawing.Point(0, 259);
            this.btnMezanino.Margin = new System.Windows.Forms.Padding(0);
            this.btnMezanino.Name = "btnMezanino";
            this.btnMezanino.Size = new System.Drawing.Size(156, 37);
            this.btnMezanino.TabIndex = 8;
            this.btnMezanino.Text = "Mezanino";
            this.btnMezanino.UseVisualStyleBackColor = true;
            this.btnMezanino.Click += new System.EventHandler(this.btnMezanino_Click);
            // 
            // btnMupi
            // 
            this.btnMupi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMupi.Location = new System.Drawing.Point(0, 296);
            this.btnMupi.Margin = new System.Windows.Forms.Padding(0);
            this.btnMupi.Name = "btnMupi";
            this.btnMupi.Size = new System.Drawing.Size(156, 37);
            this.btnMupi.TabIndex = 9;
            this.btnMupi.Text = "Mupi";
            this.btnMupi.UseVisualStyleBackColor = true;
            this.btnMupi.Click += new System.EventHandler(this.btnMupi_Click);
            // 
            // btnSls
            // 
            this.btnSls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSls.Location = new System.Drawing.Point(0, 333);
            this.btnSls.Margin = new System.Windows.Forms.Padding(0);
            this.btnSls.Name = "btnSls";
            this.btnSls.Size = new System.Drawing.Size(156, 37);
            this.btnSls.TabIndex = 10;
            this.btnSls.Text = "Sls";
            this.btnSls.UseVisualStyleBackColor = true;
            this.btnSls.Click += new System.EventHandler(this.btnSls_Click);
            // 
            // btnSoldaPVC
            // 
            this.btnSoldaPVC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSoldaPVC.Location = new System.Drawing.Point(0, 370);
            this.btnSoldaPVC.Margin = new System.Windows.Forms.Padding(0);
            this.btnSoldaPVC.Name = "btnSoldaPVC";
            this.btnSoldaPVC.Size = new System.Drawing.Size(156, 37);
            this.btnSoldaPVC.TabIndex = 11;
            this.btnSoldaPVC.Text = "Solda PVC";
            this.btnSoldaPVC.UseVisualStyleBackColor = true;
            this.btnSoldaPVC.Click += new System.EventHandler(this.btnSoldaPVC_Click);
            // 
            // btnTraslo
            // 
            this.btnTraslo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTraslo.Location = new System.Drawing.Point(0, 407);
            this.btnTraslo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTraslo.Name = "btnTraslo";
            this.btnTraslo.Size = new System.Drawing.Size(156, 47);
            this.btnTraslo.TabIndex = 12;
            this.btnTraslo.Text = "Traslo";
            this.btnTraslo.UseVisualStyleBackColor = true;
            this.btnTraslo.Click += new System.EventHandler(this.btnTraslo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.94102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.05898F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.10331F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.89668F));
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(159, 110);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(957, 448);
            this.tableLayoutPanel3.TabIndex = 2;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(156, 454);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SistemaMor.View.Properties.Resources.pexels_miguel_á_padriñán_3785935;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.05416F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.94584F));
            this.tableLayoutPanel4.Controls.Add(this.txtBuscar, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnEditarItem, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnExcluirItem, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnNovoItem, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(159, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.32323F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.34343F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(957, 101);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(3, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar:";
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarItem.Location = new System.Drawing.Point(833, 69);
            this.btnEditarItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(124, 32);
            this.btnEditarItem.TabIndex = 4;
            this.btnEditarItem.Text = "Editar Item";
            this.btnEditarItem.UseVisualStyleBackColor = true;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluirItem.Location = new System.Drawing.Point(833, 33);
            this.btnExcluirItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(124, 36);
            this.btnExcluirItem.TabIndex = 3;
            this.btnExcluirItem.Text = "Excluir Item";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovoItem.Location = new System.Drawing.Point(833, 0);
            this.btnNovoItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(124, 33);
            this.btnNovoItem.TabIndex = 2;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
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
            this.descricao.Width = 400;
            // 
            // imagem
            // 
            this.imagem.DataPropertyName = "imagem";
            this.imagem.HeaderText = "Imagem";
            this.imagem.Name = "imagem";
            this.imagem.ReadOnly = true;
            this.imagem.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormPrincipal_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemItem)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagem;
    }
}

