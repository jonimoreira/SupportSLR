namespace SupportSLR
{
    partial class frmQueryDataSourceRound
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label queryLabel;
            System.Windows.Forms.Label fk_DataSource_idLabel;
            System.Windows.Forms.Label fk_Round_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryDataSourceRound));
            this.supportSLRDataSet = new SupportSLR.SupportSLRDataSet();
            this.queryDataSourceRoundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryDataSourceRoundTableAdapter = new SupportSLR.SupportSLRDataSetTableAdapters.QueryDataSourceRoundTableAdapter();
            this.tableAdapterManager = new SupportSLR.SupportSLRDataSetTableAdapters.TableAdapterManager();
            this.dataSourceTableAdapter = new SupportSLR.SupportSLRDataSetTableAdapters.DataSourceTableAdapter();
            this.roundTableAdapter = new SupportSLR.SupportSLRDataSetTableAdapters.RoundTableAdapter();
            this.queryDataSourceRoundBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.queryDataSourceRoundBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.fk_DataSource_idComboBox = new System.Windows.Forms.ComboBox();
            this.dataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fk_Round_idComboBox = new System.Windows.Forms.ComboBox();
            this.roundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supportSLRDataSet1 = new SupportSLR.SupportSLRDataSet1();
            this.roundBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roundTableAdapter1 = new SupportSLR.SupportSLRDataSet1TableAdapters.RoundTableAdapter();
            this.supportSLRDataSet2 = new SupportSLR.SupportSLRDataSet2();
            this.dataSourceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSourceTableAdapter1 = new SupportSLR.SupportSLRDataSet2TableAdapters.DataSourceTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            queryLabel = new System.Windows.Forms.Label();
            fk_DataSource_idLabel = new System.Windows.Forms.Label();
            fk_Round_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataSourceRoundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataSourceRoundBindingNavigator)).BeginInit();
            this.queryDataSourceRoundBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(15, 40);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // queryLabel
            // 
            queryLabel.AutoSize = true;
            queryLabel.Location = new System.Drawing.Point(15, 66);
            queryLabel.Name = "queryLabel";
            queryLabel.Size = new System.Drawing.Size(36, 13);
            queryLabel.TabIndex = 3;
            queryLabel.Text = "query:";
            // 
            // fk_DataSource_idLabel
            // 
            fk_DataSource_idLabel.AutoSize = true;
            fk_DataSource_idLabel.Location = new System.Drawing.Point(15, 92);
            fk_DataSource_idLabel.Name = "fk_DataSource_idLabel";
            fk_DataSource_idLabel.Size = new System.Drawing.Size(70, 13);
            fk_DataSource_idLabel.TabIndex = 5;
            fk_DataSource_idLabel.Text = "Data Source:";
            // 
            // fk_Round_idLabel
            // 
            fk_Round_idLabel.AutoSize = true;
            fk_Round_idLabel.Location = new System.Drawing.Point(15, 119);
            fk_Round_idLabel.Name = "fk_Round_idLabel";
            fk_Round_idLabel.Size = new System.Drawing.Size(42, 13);
            fk_Round_idLabel.TabIndex = 7;
            fk_Round_idLabel.Text = "Round:";
            // 
            // supportSLRDataSet
            // 
            this.supportSLRDataSet.DataSetName = "SupportSLRDataSet";
            this.supportSLRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queryDataSourceRoundBindingSource
            // 
            this.queryDataSourceRoundBindingSource.DataMember = "QueryDataSourceRound";
            this.queryDataSourceRoundBindingSource.DataSource = this.supportSLRDataSet;
            // 
            // queryDataSourceRoundTableAdapter
            // 
            this.queryDataSourceRoundTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataSourceTableAdapter = this.dataSourceTableAdapter;
            this.tableAdapterManager.KeywordTableAdapter = null;
            this.tableAdapterManager.QueryDataSourceRoundTableAdapter = this.queryDataSourceRoundTableAdapter;
            this.tableAdapterManager.RoundTableAdapter = this.roundTableAdapter;
            this.tableAdapterManager.SearchResultItemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SupportSLR.SupportSLRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataSourceTableAdapter
            // 
            this.dataSourceTableAdapter.ClearBeforeFill = true;
            // 
            // roundTableAdapter
            // 
            this.roundTableAdapter.ClearBeforeFill = true;
            // 
            // queryDataSourceRoundBindingNavigator
            // 
            this.queryDataSourceRoundBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.queryDataSourceRoundBindingNavigator.BindingSource = this.queryDataSourceRoundBindingSource;
            this.queryDataSourceRoundBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.queryDataSourceRoundBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.queryDataSourceRoundBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.queryDataSourceRoundBindingNavigatorSaveItem});
            this.queryDataSourceRoundBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.queryDataSourceRoundBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.queryDataSourceRoundBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.queryDataSourceRoundBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.queryDataSourceRoundBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.queryDataSourceRoundBindingNavigator.Name = "queryDataSourceRoundBindingNavigator";
            this.queryDataSourceRoundBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.queryDataSourceRoundBindingNavigator.Size = new System.Drawing.Size(635, 25);
            this.queryDataSourceRoundBindingNavigator.TabIndex = 0;
            this.queryDataSourceRoundBindingNavigator.Text = "bindingNavigator1";
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
            // queryDataSourceRoundBindingNavigatorSaveItem
            // 
            this.queryDataSourceRoundBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.queryDataSourceRoundBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("queryDataSourceRoundBindingNavigatorSaveItem.Image")));
            this.queryDataSourceRoundBindingNavigatorSaveItem.Name = "queryDataSourceRoundBindingNavigatorSaveItem";
            this.queryDataSourceRoundBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.queryDataSourceRoundBindingNavigatorSaveItem.Text = "Save Data";
            this.queryDataSourceRoundBindingNavigatorSaveItem.Click += new System.EventHandler(this.queryDataSourceRoundBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queryDataSourceRoundBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(114, 37);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(501, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // queryTextBox
            // 
            this.queryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queryDataSourceRoundBindingSource, "query", true));
            this.queryTextBox.Location = new System.Drawing.Point(114, 63);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(501, 20);
            this.queryTextBox.TabIndex = 4;
            // 
            // fk_DataSource_idComboBox
            // 
            this.fk_DataSource_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queryDataSourceRoundBindingSource, "fk_DataSource_id", true));
            this.fk_DataSource_idComboBox.FormattingEnabled = true;
            this.fk_DataSource_idComboBox.Location = new System.Drawing.Point(114, 89);
            this.fk_DataSource_idComboBox.Name = "fk_DataSource_idComboBox";
            this.fk_DataSource_idComboBox.Size = new System.Drawing.Size(501, 21);
            this.fk_DataSource_idComboBox.TabIndex = 6;
            // 
            // dataSourceBindingSource
            // 
            this.dataSourceBindingSource.DataMember = "DataSource";
            this.dataSourceBindingSource.DataSource = this.supportSLRDataSet;
            // 
            // fk_Round_idComboBox
            // 
            this.fk_Round_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.queryDataSourceRoundBindingSource, "fk_Round_id", true));
            this.fk_Round_idComboBox.FormattingEnabled = true;
            this.fk_Round_idComboBox.Location = new System.Drawing.Point(114, 116);
            this.fk_Round_idComboBox.Name = "fk_Round_idComboBox";
            this.fk_Round_idComboBox.Size = new System.Drawing.Size(501, 21);
            this.fk_Round_idComboBox.TabIndex = 8;
            // 
            // roundBindingSource
            // 
            this.roundBindingSource.DataMember = "Round";
            this.roundBindingSource.DataSource = this.supportSLRDataSet;
            // 
            // supportSLRDataSet1
            // 
            this.supportSLRDataSet1.DataSetName = "SupportSLRDataSet1";
            this.supportSLRDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roundBindingSource1
            // 
            this.roundBindingSource1.DataMember = "Round";
            this.roundBindingSource1.DataSource = this.supportSLRDataSet1;
            // 
            // roundTableAdapter1
            // 
            this.roundTableAdapter1.ClearBeforeFill = true;
            // 
            // supportSLRDataSet2
            // 
            this.supportSLRDataSet2.DataSetName = "SupportSLRDataSet2";
            this.supportSLRDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSourceBindingSource1
            // 
            this.dataSourceBindingSource1.DataMember = "DataSource";
            this.dataSourceBindingSource1.DataSource = this.supportSLRDataSet2;
            // 
            // dataSourceTableAdapter1
            // 
            this.dataSourceTableAdapter1.ClearBeforeFill = true;
            // 
            // frmQueryDataSourceRound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 157);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(queryLabel);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(fk_DataSource_idLabel);
            this.Controls.Add(this.fk_DataSource_idComboBox);
            this.Controls.Add(fk_Round_idLabel);
            this.Controls.Add(this.fk_Round_idComboBox);
            this.Controls.Add(this.queryDataSourceRoundBindingNavigator);
            this.Name = "frmQueryDataSourceRound";
            this.Text = "frmQueryDataSourceRound";
            this.Load += new System.EventHandler(this.frmQueryDataSourceRound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataSourceRoundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataSourceRoundBindingNavigator)).EndInit();
            this.queryDataSourceRoundBindingNavigator.ResumeLayout(false);
            this.queryDataSourceRoundBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SupportSLRDataSet supportSLRDataSet;
        private System.Windows.Forms.BindingSource queryDataSourceRoundBindingSource;
        private SupportSLRDataSetTableAdapters.QueryDataSourceRoundTableAdapter queryDataSourceRoundTableAdapter;
        private SupportSLRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator queryDataSourceRoundBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton queryDataSourceRoundBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.ComboBox fk_DataSource_idComboBox;
        private System.Windows.Forms.ComboBox fk_Round_idComboBox;
        private SupportSLRDataSetTableAdapters.DataSourceTableAdapter dataSourceTableAdapter;
        private System.Windows.Forms.BindingSource dataSourceBindingSource;
        private SupportSLRDataSetTableAdapters.RoundTableAdapter roundTableAdapter;
        private System.Windows.Forms.BindingSource roundBindingSource;
        private SupportSLRDataSet1 supportSLRDataSet1;
        private System.Windows.Forms.BindingSource roundBindingSource1;
        private SupportSLRDataSet1TableAdapters.RoundTableAdapter roundTableAdapter1;
        private SupportSLRDataSet2 supportSLRDataSet2;
        private System.Windows.Forms.BindingSource dataSourceBindingSource1;
        private SupportSLRDataSet2TableAdapters.DataSourceTableAdapter dataSourceTableAdapter1;
    }
}