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
    public partial class frmDataSource : Form
    {
        public frmDataSource()
        {
            InitializeComponent();
        }

        private void dataSourceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataSourceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supportSLRDataSet);

        }

        private void frmDataSource_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supportSLRDataSet.DataSource' table. You can move, or remove it, as needed.
            this.dataSourceTableAdapter.Fill(this.supportSLRDataSet.DataSource);

        }
    }
}
