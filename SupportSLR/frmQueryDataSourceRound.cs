using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportSLR
{
    public partial class frmQueryDataSourceRound : Form
    {
        public frmQueryDataSourceRound()
        {
            InitializeComponent();
        }

        private void queryDataSourceRoundBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.queryDataSourceRoundBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supportSLRDataSet);

        }

        private void frmQueryDataSourceRound_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supportSLRDataSet2.DataSource' table. You can move, or remove it, as needed.
            this.dataSourceTableAdapter1.Fill(this.supportSLRDataSet2.DataSource);
            // TODO: This line of code loads data into the 'supportSLRDataSet1.Round' table. You can move, or remove it, as needed.
            this.roundTableAdapter1.Fill(this.supportSLRDataSet1.Round);
            // TODO: This line of code loads data into the 'supportSLRDataSet.Round' table. You can move, or remove it, as needed.
            this.roundTableAdapter.Fill(this.supportSLRDataSet.Round);
            // TODO: This line of code loads data into the 'supportSLRDataSet.DataSource' table. You can move, or remove it, as needed.
            this.dataSourceTableAdapter.Fill(this.supportSLRDataSet.DataSource);
            // TODO: This line of code loads data into the 'supportSLRDataSet.QueryDataSourceRound' table. You can move, or remove it, as needed.
            this.queryDataSourceRoundTableAdapter.Fill(this.supportSLRDataSet.QueryDataSourceRound);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.roundTableAdapter.FillBy(this.supportSLRDataSet.Round);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
