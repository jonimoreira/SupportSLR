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
    public partial class frmRound : Form
    {
        public frmRound()
        {
            InitializeComponent();
        }

        private void roundBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roundBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.supportSLRDataSet);

        }

        private void frmRound_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supportSLRDataSet.Round' table. You can move, or remove it, as needed.
            this.roundTableAdapter.Fill(this.supportSLRDataSet.Round);

        }
    }
}
