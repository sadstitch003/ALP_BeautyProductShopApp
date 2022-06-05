using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_BeautyProductShopApp
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnViewTrans_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionHistory trans = new TransactionHistory();
            trans.MdiParent = this.ParentForm;
            trans.Dock = DockStyle.Fill;
            trans.Show();
        }
    }
}
