namespace SupportSLR
{
    partial class frmSearchResultItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchResultItem));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label fk_QueryDataSourceRound_idLabel;
            System.Windows.Forms.Label urlLabel;
            System.Windows.Forms.Label page_contentLabel;
            System.Windows.Forms.Label endnote_urlLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label abstractLabel;
            System.Windows.Forms.Label date_publicationLabel;
            System.Windows.Forms.Label pagesLabel;
            System.Windows.Forms.Label typeLabel;
            this.supportSLRDataSet = new SupportSLR.SupportSLRDataSet();
            this.searchResultItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchResultItemTableAdapter = new SupportSLR.SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter();
            this.tableAdapterManager = new SupportSLR.SupportSLRDataSetTableAdapters.TableAdapterManager();
            this.searchResultItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.searchResultItemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fk_QueryDataSourceRound_idTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.page_contentTextBox = new System.Windows.Forms.TextBox();
            this.endnote_urlTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.abstractTextBox = new System.Windows.Forms.TextBox();
            this.date_publicationTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            fk_QueryDataSourceRound_idLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            page_contentLabel = new System.Windows.Forms.Label();
            endnote_urlLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            abstractLabel = new System.Windows.Forms.Label();
            date_publicationLabel = new System.Windows.Forms.Label();
            pagesLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultItemBindingNavigator)).BeginInit();
            this.searchResultItemBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // supportSLRDataSet
            // 
            this.supportSLRDataSet.DataSetName = "SupportSLRDataSet";
            this.supportSLRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchResultItemBindingSource
            // 
            this.searchResultItemBindingSource.DataMember = "SearchResultItem";
            this.searchResultItemBindingSource.DataSource = this.supportSLRDataSet;
            // 
            // searchResultItemTableAdapter
            // 
            this.searchResultItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataSourceTableAdapter = null;
            this.tableAdapterManager.KeywordTableAdapter = null;
            this.tableAdapterManager.QueryDataSourceRoundTableAdapter = null;
            this.tableAdapterManager.RoundTableAdapter = null;
            this.tableAdapterManager.SearchResultItemTableAdapter = this.searchResultItemTableAdapter;
            this.tableAdapterManager.UpdateOrder = SupportSLR.SupportSLRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // searchResultItemBindingNavigator
            // 
            this.searchResultItemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.searchResultItemBindingNavigator.BindingSource = this.searchResultItemBindingSource;
            this.searchResultItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.searchResultItemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.searchResultItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.searchResultItemBindingNavigatorSaveItem});
            this.searchResultItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.searchResultItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.searchResultItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.searchResultItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.searchResultItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.searchResultItemBindingNavigator.Name = "searchResultItemBindingNavigator";
            this.searchResultItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.searchResultItemBindingNavigator.Size = new System.Drawing.Size(621, 25);
            this.searchResultItemBindingNavigator.TabIndex = 0;
            this.searchResultItemBindingNavigator.Text = "bindingNavigator1";
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
            // searchResultItemBindingNavigatorSaveItem
            // 
            this.searchResultItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchResultItemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("searchResultItemBindingNavigatorSaveItem.Image")));
            this.searchResultItemBindingNavigatorSaveItem.Name = "searchResultItemBindingNavigatorSaveItem";
            this.searchResultItemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.searchResultItemBindingNavigatorSaveItem.Text = "Save Data";
            this.searchResultItemBindingNavigatorSaveItem.Click += new System.EventHandler(this.searchResultItemBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(47, 51);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(212, 48);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(364, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // fk_QueryDataSourceRound_idLabel
            // 
            fk_QueryDataSourceRound_idLabel.AutoSize = true;
            fk_QueryDataSourceRound_idLabel.Location = new System.Drawing.Point(47, 77);
            fk_QueryDataSourceRound_idLabel.Name = "fk_QueryDataSourceRound_idLabel";
            fk_QueryDataSourceRound_idLabel.Size = new System.Drawing.Size(159, 13);
            fk_QueryDataSourceRound_idLabel.TabIndex = 3;
            fk_QueryDataSourceRound_idLabel.Text = "fk Query Data Source Round id:";
            // 
            // fk_QueryDataSourceRound_idTextBox
            // 
            this.fk_QueryDataSourceRound_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "fk_QueryDataSourceRound_id", true));
            this.fk_QueryDataSourceRound_idTextBox.Location = new System.Drawing.Point(212, 74);
            this.fk_QueryDataSourceRound_idTextBox.Name = "fk_QueryDataSourceRound_idTextBox";
            this.fk_QueryDataSourceRound_idTextBox.Size = new System.Drawing.Size(364, 20);
            this.fk_QueryDataSourceRound_idTextBox.TabIndex = 4;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(47, 103);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(21, 13);
            urlLabel.TabIndex = 5;
            urlLabel.Text = "url:";
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "url", true));
            this.urlTextBox.Location = new System.Drawing.Point(212, 100);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(364, 20);
            this.urlTextBox.TabIndex = 6;
            // 
            // page_contentLabel
            // 
            page_contentLabel.AutoSize = true;
            page_contentLabel.Location = new System.Drawing.Point(47, 129);
            page_contentLabel.Name = "page_contentLabel";
            page_contentLabel.Size = new System.Drawing.Size(73, 13);
            page_contentLabel.TabIndex = 7;
            page_contentLabel.Text = "page content:";
            // 
            // page_contentTextBox
            // 
            this.page_contentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "page_content", true));
            this.page_contentTextBox.Location = new System.Drawing.Point(212, 126);
            this.page_contentTextBox.Name = "page_contentTextBox";
            this.page_contentTextBox.Size = new System.Drawing.Size(364, 20);
            this.page_contentTextBox.TabIndex = 8;
            // 
            // endnote_urlLabel
            // 
            endnote_urlLabel.AutoSize = true;
            endnote_urlLabel.Location = new System.Drawing.Point(47, 155);
            endnote_urlLabel.Name = "endnote_urlLabel";
            endnote_urlLabel.Size = new System.Drawing.Size(63, 13);
            endnote_urlLabel.TabIndex = 9;
            endnote_urlLabel.Text = "endnote url:";
            // 
            // endnote_urlTextBox
            // 
            this.endnote_urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "endnote_url", true));
            this.endnote_urlTextBox.Location = new System.Drawing.Point(212, 152);
            this.endnote_urlTextBox.Name = "endnote_urlTextBox";
            this.endnote_urlTextBox.Size = new System.Drawing.Size(364, 20);
            this.endnote_urlTextBox.TabIndex = 10;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(47, 181);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(26, 13);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(212, 178);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(364, 20);
            this.titleTextBox.TabIndex = 12;
            // 
            // abstractLabel
            // 
            abstractLabel.AutoSize = true;
            abstractLabel.Location = new System.Drawing.Point(47, 207);
            abstractLabel.Name = "abstractLabel";
            abstractLabel.Size = new System.Drawing.Size(48, 13);
            abstractLabel.TabIndex = 13;
            abstractLabel.Text = "abstract:";
            // 
            // abstractTextBox
            // 
            this.abstractTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "abstract", true));
            this.abstractTextBox.Location = new System.Drawing.Point(212, 204);
            this.abstractTextBox.Name = "abstractTextBox";
            this.abstractTextBox.Size = new System.Drawing.Size(364, 20);
            this.abstractTextBox.TabIndex = 14;
            // 
            // date_publicationLabel
            // 
            date_publicationLabel.AutoSize = true;
            date_publicationLabel.Location = new System.Drawing.Point(47, 233);
            date_publicationLabel.Name = "date_publicationLabel";
            date_publicationLabel.Size = new System.Drawing.Size(85, 13);
            date_publicationLabel.TabIndex = 15;
            date_publicationLabel.Text = "date publication:";
            // 
            // date_publicationTextBox
            // 
            this.date_publicationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "date_publication", true));
            this.date_publicationTextBox.Location = new System.Drawing.Point(212, 230);
            this.date_publicationTextBox.Name = "date_publicationTextBox";
            this.date_publicationTextBox.Size = new System.Drawing.Size(364, 20);
            this.date_publicationTextBox.TabIndex = 16;
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Location = new System.Drawing.Point(47, 259);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(39, 13);
            pagesLabel.TabIndex = 17;
            pagesLabel.Text = "pages:";
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "pages", true));
            this.pagesTextBox.Location = new System.Drawing.Point(212, 256);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(364, 20);
            this.pagesTextBox.TabIndex = 18;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(47, 285);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(30, 13);
            typeLabel.TabIndex = 19;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.searchResultItemBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(212, 282);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(364, 20);
            this.typeTextBox.TabIndex = 20;
            // 
            // frmSearchResultItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 347);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(fk_QueryDataSourceRound_idLabel);
            this.Controls.Add(this.fk_QueryDataSourceRound_idTextBox);
            this.Controls.Add(urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(page_contentLabel);
            this.Controls.Add(this.page_contentTextBox);
            this.Controls.Add(endnote_urlLabel);
            this.Controls.Add(this.endnote_urlTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(abstractLabel);
            this.Controls.Add(this.abstractTextBox);
            this.Controls.Add(date_publicationLabel);
            this.Controls.Add(this.date_publicationTextBox);
            this.Controls.Add(pagesLabel);
            this.Controls.Add(this.pagesTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.searchResultItemBindingNavigator);
            this.Name = "frmSearchResultItem";
            this.Text = "frmSearchResultItem";
            this.Load += new System.EventHandler(this.frmSearchResultItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultItemBindingNavigator)).EndInit();
            this.searchResultItemBindingNavigator.ResumeLayout(false);
            this.searchResultItemBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SupportSLRDataSet supportSLRDataSet;
        private System.Windows.Forms.BindingSource searchResultItemBindingSource;
        private SupportSLRDataSetTableAdapters.SearchResultItemTableAdapter searchResultItemTableAdapter;
        private SupportSLRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator searchResultItemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton searchResultItemBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox fk_QueryDataSourceRound_idTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox page_contentTextBox;
        private System.Windows.Forms.TextBox endnote_urlTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox abstractTextBox;
        private System.Windows.Forms.TextBox date_publicationTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
    }
}