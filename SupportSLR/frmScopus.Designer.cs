namespace SupportSLR
{
    partial class frmScopus
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.queryDataSourceRoundTableAdapter = new SupportSLR.SupportSLRDataSetTableAdapters.QueryDataSourceRoundTableAdapter();
            this.supportSLRDataSet = new SupportSLR.SupportSLRDataSet();
            this.queryDataSourceRoundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataSourceRoundBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(438, 20);
            this.textBox4.TabIndex = 49;
            this.textBox4.Text = "TY  - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "String to locate result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "File path (Endnote):";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(630, 20);
            this.textBox3.TabIndex = 46;
            this.textBox3.Text = "\\\\ad.utwente.nl\\home\\LuizRebeloMoreiraJ\\Documents\\PhD\\SLR\\App\\SupportSLR\\scopus_r" +
    "ound2.ris";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 321);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 136);
            this.textBox1.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 45);
            this.button1.TabIndex = 42;
            this.button1.Text = "Search Scopus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // queryDataSourceRoundTableAdapter
            // 
            this.queryDataSourceRoundTableAdapter.ClearBeforeFill = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Query:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.queryDataSourceRoundBindingSource;
            this.comboBox1.DisplayMember = "query";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(453, 21);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.ValueMember = "id";
            // 
            // frmScopus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmScopus";
            this.Text = "frmScopus";
            ((System.ComponentModel.ISupportInitialize)(this.supportSLRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataSourceRoundBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private SupportSLRDataSetTableAdapters.QueryDataSourceRoundTableAdapter queryDataSourceRoundTableAdapter;
        private SupportSLRDataSet supportSLRDataSet;
        private System.Windows.Forms.BindingSource queryDataSourceRoundBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}