namespace projetoMor
{
    partial class AdicionarItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarItem));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label itemLabel;
            System.Windows.Forms.Label descriçãoLabel;
            System.Windows.Forms.Label imagemLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.databaseDataSet = new projetoMor.DatabaseDataSet();
            this.baiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baiasTableAdapter = new projetoMor.DatabaseDataSetTableAdapters.BaiasTableAdapter();
            this.tableAdapterManager = new projetoMor.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.baiasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.baiasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.descriçãoTextBox = new System.Windows.Forms.TextBox();
            this.imagemPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            itemLabel = new System.Windows.Forms.Label();
            descriçãoLabel = new System.Windows.Forms.Label();
            imagemLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingNavigator)).BeginInit();
            this.baiasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idLabel1);
            this.groupBox1.Controls.Add(itemLabel);
            this.groupBox1.Controls.Add(this.itemTextBox);
            this.groupBox1.Controls.Add(descriçãoLabel);
            this.groupBox1.Controls.Add(this.descriçãoTextBox);
            this.groupBox1.Controls.Add(imagemLabel);
            this.groupBox1.Controls.Add(this.imagemPictureBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.tableAdapterManager.UpdateOrder = projetoMor.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.baiasBindingNavigator.Size = new System.Drawing.Size(627, 25);
            this.baiasBindingNavigator.TabIndex = 1;
            this.baiasBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // baiasBindingNavigatorSaveItem
            // 
            this.baiasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.baiasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("baiasBindingNavigatorSaveItem.Image")));
            this.baiasBindingNavigatorSaveItem.Name = "baiasBindingNavigatorSaveItem";
            this.baiasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.baiasBindingNavigatorSaveItem.Text = "Save Data";
            this.baiasBindingNavigatorSaveItem.Click += new System.EventHandler(this.baiasBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(24, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baiasBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(82, 53);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(135, 21);
            this.idLabel1.TabIndex = 1;
            this.idLabel1.Text = "label1";
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new System.Drawing.Point(12, 99);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(38, 20);
            itemLabel.TabIndex = 2;
            itemLabel.Text = "Item:";
            // 
            // itemTextBox
            // 
            this.itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baiasBindingSource, "Item", true));
            this.itemTextBox.Location = new System.Drawing.Point(86, 96);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(234, 26);
            this.itemTextBox.TabIndex = 3;
            // 
            // descriçãoLabel
            // 
            descriçãoLabel.AutoSize = true;
            descriçãoLabel.Location = new System.Drawing.Point(12, 141);
            descriçãoLabel.Name = "descriçãoLabel";
            descriçãoLabel.Size = new System.Drawing.Size(73, 20);
            descriçãoLabel.TabIndex = 4;
            descriçãoLabel.Text = "Descrição:";
            // 
            // descriçãoTextBox
            // 
            this.descriçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baiasBindingSource, "Descrição", true));
            this.descriçãoTextBox.Location = new System.Drawing.Point(86, 138);
            this.descriçãoTextBox.Name = "descriçãoTextBox";
            this.descriçãoTextBox.Size = new System.Drawing.Size(234, 26);
            this.descriçãoTextBox.TabIndex = 5;
            // 
            // imagemLabel
            // 
            imagemLabel.AutoSize = true;
            imagemLabel.Location = new System.Drawing.Point(259, 220);
            imagemLabel.Name = "imagemLabel";
            imagemLabel.Size = new System.Drawing.Size(61, 20);
            imagemLabel.TabIndex = 6;
            imagemLabel.Text = "Imagem:";
            // 
            // imagemPictureBox
            // 
            this.imagemPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.baiasBindingSource, "Imagem", true));
            this.imagemPictureBox.Location = new System.Drawing.Point(338, 30);
            this.imagemPictureBox.Name = "imagemPictureBox";
            this.imagemPictureBox.Size = new System.Drawing.Size(265, 210);
            this.imagemPictureBox.TabIndex = 7;
            this.imagemPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Carregar Imagem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdicionarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 294);
            this.Controls.Add(this.baiasBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdicionarItem";
            this.Text = "AdicionarItem";
            this.Load += new System.EventHandler(this.AdicionarItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiasBindingNavigator)).EndInit();
            this.baiasBindingNavigator.ResumeLayout(false);
            this.baiasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox descriçãoTextBox;
        private System.Windows.Forms.PictureBox imagemPictureBox;
    }
}