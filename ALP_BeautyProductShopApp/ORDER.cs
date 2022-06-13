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
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtOrderList;

        string cellValue;
        int selectedrowindex;

        string staffID;


        public Order(string StaffID)
        {
            InitializeComponent();
            staffID = StaffID;
        }

        void resetTable()
        {
            dtOrderList = new DataTable();
            sqlQuery = "select order_id, supplier_id, staff_id, order_date, tax, discount, concat('Rp.', format(order_total, 'C', 'id_ID')) as trans_total, concat('Rp.', format(net_total, 'C', 'id-ID')) as net_total  from `order` where status_del = '0'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtOrderList);
            dgvOrderList.DataSource = dtOrderList;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            resetTable();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            NewOrder form = new NewOrder(staffID);
            form.ShowDialog();
            resetTable();
        }

        private void dgvTransList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderList.SelectedCells.Count > 0)
            {
                selectedrowindex = dgvOrderList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvOrderList.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["order_id"].Value);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            OrderDetails form = new OrderDetails(cellValue);
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = $"update `order` set status_del = '1' where order_id = '{cellValue}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            if (dgvOrderList.Rows.Count > 0)
            {
                dgvOrderList.Rows.RemoveAt(selectedrowindex);
                MessageBox.Show("Data deleted !");
            }
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            OrderDeleted form = new OrderDeleted();
            form.ShowDialog();
            resetTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                dtOrderList = new DataTable();
                sqlQuery = $"select order_id, staff_id, supplier_id, order_date, tax, discount, concat('Rp.', format(order_total, 'C', 'id_ID')) as order_total, concat('Rp.', format(net_total, 'C', 'id-ID')) as net_total from `order` where status_del = '0' and (order_id like '%{tbSearch.Text.ToUpper()}%' or staff_id like '%{tbSearch.Text.ToUpper()}%' or supplier_id like '%{tbSearch.Text.ToUpper()}%');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtOrderList);
                dgvOrderList.DataSource = dtOrderList;
                tbSearch.Text = "";
            }
            else resetTable();
        }
    }
}
