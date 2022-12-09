using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.GUI
{
    public partial class subreport : Form
    {
        public subreport()
        {
            InitializeComponent();
        }

        private void subreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'receiptData.receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.receiptData.receipt);

            this.reportViewer1.RefreshReport();
        }
    }
}
