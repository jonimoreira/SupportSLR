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
    public partial class frmSearchResultItem : Form
    {
        public frmSearchResultItem()
        {
            InitializeComponent();
        }

        private void searchResultItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.searchResultItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supportSLRDataSet);

        }

        private void frmSearchResultItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supportSLRDataSet.SearchResultItem' table. You can move, or remove it, as needed.
            this.searchResultItemTableAdapter.Fill(this.supportSLRDataSet.SearchResultItem);

        }
    }
}
