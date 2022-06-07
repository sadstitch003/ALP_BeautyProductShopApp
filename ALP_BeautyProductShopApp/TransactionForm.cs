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
    public partial class TransactionForm : Form
    {
        public TransactionForm(string transID)
        {
            InitializeComponent();

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
