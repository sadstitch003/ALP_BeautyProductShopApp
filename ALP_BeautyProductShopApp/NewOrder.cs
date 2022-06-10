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
    public partial class NewOrder : Form
    {
        public NewOrder(string SupplierID)
        {

            InitializeComponent();
        }


        private void NewOrder_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
