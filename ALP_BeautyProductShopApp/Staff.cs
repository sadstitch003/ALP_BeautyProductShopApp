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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffSales sales = new StaffSales();
            sales.MdiParent = this.ParentForm;
            sales.Dock = DockStyle.Fill;
            sales.Show();
        }
    }
}
