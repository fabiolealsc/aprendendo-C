namespace System_Itens
{
    partial class EditarDataBase
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
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label itemLabel1;
            System.Windows.Forms.Label descriçãoLabel1;
            System.Windows.Forms.Label imagemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarDataBase));
            this.baiasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.baiasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.itemTextBox1 = new System.Windows.Forms.TextBox();
            this.descriçãoTextBox1 = new System.Windows.Forms.TextBox();
            this.imagemPictureBox = new System.Windows.Forms.PictureBox();
            this.baiasDataGridView = new System.Windows.Forms.DataGridView();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.baiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new System_Itens.DatabaseDataSet();
            this.baiasTableAdapter = new System_Itens.DatabaseDataSetTableAdapters.BaiasTableAdapter();
            this.tableAdapterManager = new System_Itens.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel1 = new System.Windows.Forms.Label();
            itemLabel1 = new System.Windows.Forms.Label();
            descriçãoLabel1 = new System.Windows.Forms.Label();
            imagemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingNavigator)).BeginInit();
            this.baiasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(8, 53);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 7;
            idLabel1.Text = "Id:";
            // 
            // itemLabel1
            // 
            itemLabel1.AutoSize = true;
            itemLabel1.Location = new System.Drawing.Point(8, 79);
            itemLabel1.Name = "itemLabel1";
            itemLabel1.Size = new System.Drawing.Size(30, 13);
            itemLabel1.TabIndex = 9;
            itemLabel1.Text = "Item:";
            // 
            // descriçãoLabel1
            // 
            descriçãoLabel1.AutoSize = true;
            descriçãoLabel1.Location = new System.Drawing.Point(8, 105);
            descriçãoLabel1.Name = "descriçãoLabel1";
            descriçãoLabel1.Size = new System.Drawing.Size(58, 13);
            descriçãoLabel1.TabIndex = 11;
            descriçãoLabel1.Text = "Descrição:";
            // 
            // imagemLabel
            // 
            imagemLabel.AutoSize = true;
            imagemLabel.Location = new System.Drawing.Point(8, 128);
            imagemLabel.Name = "imagemLabel";
            imagemLabel.Size = new System.Drawing.Size(47, 13);
            imagemLabel.TabIndex = 13;
            imagemLabel.Text = "Imagem:";
            // 
            // baiasBindingNavigator
            // 
            this.baiasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.baiasBindingNavigator.BindingSource = this.baiasBindingSource;
            this.baiasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.baiasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.baiasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.baiasBindingNavigatorSaveItem});
            this.baiasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.baiasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.baiasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.baiasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.baiasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.baiasBindingNavigator.Name = "baiasBindingNavigator";
            this.baiasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.baiasBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.baiasBindingNavigator.TabIndex = 0;
            this.baiasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // baiasBindingNavigatorSaveItem
            // 
            this.baiasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.baiasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("baiasBindingNavigatorSaveItem.Image")));
            this.baiasBindingNavigatorSaveItem.Name = "baiasBindingNavigatorSaveItem";
            this.baiasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.baiasBindingNavigatorSaveItem.Text = "Save Data";
            this.baiasBindingNavigatorSaveItem.Click += new System.EventHandler(this.baiasBindingNavigatorSaveItem_Click_1);
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baiasBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(72, 50);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(276, 20);
            this.idTextBox1.TabIndex = 8;
            // 
            // itemTextBox1
            // 
            this.itemTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baiasBindingSource, "Item", true));
            this.itemTextBox1.Location = new System.Drawing.Point(72, 76);
            this.itemTextBox1.Name = "itemTextBox1";
            this.itemTextBox1.Size = new System.Drawing.Size(276, 20);
            this.itemTextBox1.TabIndex = 10;
            // 
            // descriçãoTextBox1
            // 
            this.descriçãoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baiasBindingSource, "Descrição", true));
            this.descriçãoTextBox1.Location = new System.Drawing.Point(72, 102);
            this.descriçãoTextBox1.Name = "descriçãoTextBox1";
            this.descriçãoTextBox1.Size = new System.Drawing.Size(276, 20);
            this.descriçãoTextBox1.TabIndex = 12;
            // 
            // imagemPictureBox
            // 
            this.imagemPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.baiasBindingSource, "Imagem", true));
            this.imagemPictureBox.Location = new System.Drawing.Point(111, 128);
            this.imagemPictureBox.Name = "imagemPictureBox";
            this.imagemPictureBox.Size = new System.Drawing.Size(100, 50);
            this.imagemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemPictureBox.TabIndex = 14;
            this.imagemPictureBox.TabStop = false;
            // 
            // baiasDataGridView
            // 
            this.baiasDataGridView.AutoGenerateColumns = false;
            this.baiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baiasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1});
            this.baiasDataGridView.DataSource = this.baiasBindingSource;
            this.baiasDataGridView.Location = new System.Drawing.Point(249, 141);
            this.baiasDataGridView.Name = "baiasDataGridView";
            this.baiasDataGridView.Size = new System.Drawing.Size(502, 250);
            this.baiasDataGridView.TabIndex = 14;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(11, 155);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(75, 23);
            this.btnCarregarImagem.TabIndex = 15;
            this.btnCarregarImagem.Text = "Carregar";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // baiasBindingSource
            // 
            this.baiasBindingSource.DataMember = "Baias";
            this.baiasBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baiasTableAdapter
            // 
            this.baiasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaiasTableAdapter = this.baiasTableAdapter;
            this.tableAdapterManager.CarroRapidoTableAdapter = null;
            this.tableAdapterManager.ColomanTableAdapter = null;
            this.tableAdapterManager.CorteDeFitasTableAdapter = null;
            this.tableAdapterManager.DocasTableAdapter = null;
            this.tableAdapterManager.EntradaDePalletsTableAdapter = null;
            this.tableAdapterManager.GeralTableAdapter = null;
            this.tableAdapterManager.MezaninoTableAdapter = null;
            this.tableAdapterManager.MupiTableAdapter = null;
            this.tableAdapterManager.ProjepackTableAdapter = null;
            this.tableAdapterManager.SannetTableAdapter = null;
            this.tableAdapterManager.Sls_sTableAdapter = null;
            this.tableAdapterManager.SoldaPVCTableAdapter = null;
            this.tableAdapterManager.TesouraEletricaTableAdapter = null;
            this.tableAdapterManager.TrasloTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_Itens.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Imagem";
            this.dataGridViewImageColumn1.HeaderText = "Imagem";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descrição";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // EditarDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.baiasDataGridView);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(itemLabel1);
            this.Controls.Add(this.itemTextBox1);
            this.Controls.Add(descriçãoLabel1);
            this.Controls.Add(this.descriçãoTextBox1);
            this.Controls.Add(imagemLabel);
            this.Controls.Add(this.imagemPictureBox);
            this.Controls.Add(this.baiasBindingNavigator);
            this.Name = "EditarDataBase";
            this.Text = "EditarDataBase";
            this.Load += new System.EventHandler(this.EditarDataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingNavigator)).EndInit();
            this.baiasBindingNavigator.ResumeLayout(false);
            this.baiasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource baiasBindingSource;
        private DatabaseDataSetTableAdapters.BaiasTableAdapter baiasTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator baiasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton baiasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox itemTextBox1;
        private System.Windows.Forms.TextBox descriçãoTextBox1;
        private System.Windows.Forms.PictureBox imagemPictureBox;
        private System.Windows.Forms.DataGridView baiasDataGridView;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}