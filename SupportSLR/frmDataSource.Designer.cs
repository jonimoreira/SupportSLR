namespace SupportSLR
{
    partial class frmDataSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataSource));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label baseURLforSearchLabel;
            this.supportSLRDataSet = new SupportSLR.SupportSLRDataSet();
            this.dataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSourceTableAdapter = new SupportSLR.SupportSLRDataSetTableAdapters.DataSourceTableAdapter();
            this.tableAdapterManager = new SupportSLR.SupportSLRDataSetTableAdapters.TableAdapterManager();
            this.dataSourceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataSourceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.baseURLforSearchTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            baseURLforSearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceBindingNavigator)).BeginInit();
            this.dataSourceBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // supportSLRDataSet
            // 
            this.supportSLRDataSet.DataSetName = "SupportSLRDataSet";
            this.supportSLRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSourceBindingSource
            // 
            this.dataSourceBindingSource.DataMember = "DataSource";
            this.dataSourceBindingSource.DataSource = this.supportSLRDataSet;
            // 
            // dataSourceTableAdapter
            // 
            this.dataSourceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataSourceTableAdapter = this.dataSourceTableAdapter;
            this.tableAdapterManager.KeywordTableAdapter = null;
            this.tableAdapterManager.QueryDataSourceRoundTableAdapter = null;
            this.tableAdapterManager.RoundTableAdapter = null;
            this.tableAdapterManager.SearchResultItemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SupportSLR.SupportSLRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataSourceBindingNavigator
            // 
            this.dataSourceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataSourceBindingNavigator.BindingSource = this.dataSourceBindingSource;
            this.dataSourceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataSourceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataSourceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dataSourceBindingNavigatorSaveItem});
            this.dataSourceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataSourceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataSourceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataSourceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataSourceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataSourceBindingNavigator.Name = "dataSourceBindingNavigator";
            this.dataSourceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataSourceBindingNavigator.Size = new System.Drawing.Size(537, 25);
            this.dataSourceBindingNavigator.TabIndex = 0;
            this.dataSourceBindingNavigator.Text = "bindingNavigator1";
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
            // dataSourceBindingNavigatorSaveItem
            // 
            this.dataSourceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataSourceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataSourceBindingNavigatorSaveItem.Image")));
            this.dataSourceBindingNavigatorSaveItem.Name = "dataSourceBindingNavigatorSaveItem";
            this.dataSourceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dataSourceBindingNavigatorSaveItem.Text = "Save Data";
            this.dataSourceBindingNavigatorSaveItem.Click += new System.EventHandler(this.dataSourceBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(107, 77);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSourceBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(220, 74);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(107, 103);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(34, 13);
            codeLabel.TabIndex = 3;
            codeLabel.Text = "code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSourceBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(220, 100);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(107, 129);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSourceBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(220, 126);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // baseURLforSearchLabel
            // 
            baseURLforSearchLabel.AutoSize = true;
            baseURLforSearchLabel.Location = new System.Drawing.Point(107, 155);
            baseURLforSearchLabel.Name = "baseURLforSearchLabel";
            baseURLforSearchLabel.Size = new System.Drawing.Size(107, 13);
            baseURLforSearchLabel.TabIndex = 7;
            baseURLforSearchLabel.Text = "base URLfor Search:";
            // 
            // baseURLforSearchTextBox
            // 
            this.baseURLforSearchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSourceBindingSource, "baseURLforSearch", true));
            this.baseURLforSearchTextBox.Location = new System.Drawing.Point(220, 152);
            this.baseURLforSearchTextBox.Name = "baseURLforSearchTextBox";
            this.baseURLforSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.baseURLforSearchTextBox.TabIndex = 8;
            // 
            // frmDataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 370);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(baseURLforSearchLabel);
            this.Controls.Add(this.baseURLforSearchTextBox);
            this.Controls.Add(this.dataSourceBindingNavigator);
            this.Name = "frmDataSource";
            this.Text = "frmDataSource";
            this.Load += new System.EventHandler(this.frmDataSource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceBindingNavigator)).EndInit();
            this.dataSourceBindingNavigator.ResumeLayout(false);
            this.dataSourceBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SupportSLRDataSet supportSLRDataSet;
        private System.Windows.Forms.BindingSource dataSourceBindingSource;
        private SupportSLRDataSetTableAdapters.DataSourceTableAdapter dataSourceTableAdapter;
        private SupportSLRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataSourceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dataSourceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox baseURLforSearchTextBox;
    }
}