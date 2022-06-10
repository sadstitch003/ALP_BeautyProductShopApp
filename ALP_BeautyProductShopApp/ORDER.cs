using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ALP_BeautyProductShopApp
{
    public partial class Order : Form
    {
        public Order(string SupplierID)
        {
            InitializeComponent();
            supplierID = SupplierID;
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtOrderList;

        string supplierID;


        private void Order_Load(object sender, EventArgs e)
        {
            dtOrderList = new DataTable();
            sqlQuery = "select order_id, supplier_id, staff_id, order_date, tax, discount, concat('Rp.', format(order_total, 'C', 'id_ID')) as trans_total, concat('Rp.', format(net_total, 'C', 'id-ID')) as net_total  from `order` where status_del = '0'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtOrderList);
            dgvTransList.DataSource = dtOrderList;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            NewOrder form = new NewOrder(supplierID);
            form.Show();
        }
    }
}
