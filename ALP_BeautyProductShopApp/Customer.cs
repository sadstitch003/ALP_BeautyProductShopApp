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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtCustomer = new DataTable();
        DataTable dtCity = new DataTable();
        public static string customerid;
        private void btnViewTrans_Click(object sender, EventArgs e)
        {
            
            TransactionHistory trans = new TransactionHistory();
            trans.MdiParent = this.ParentForm;
            trans.Dock = DockStyle.Fill;
            trans.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dtCustomer = new DataTable();
            sqlQuery = "select cust_id,membership_id,membership_joindate,cust_name,cust_address, cust_city, cust_phone, cust_email, cust_dob from customer where status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustomer);
            dgv_Customer.DataSource = dtCustomer;
            sqlQuery = "select distinct cust_city from customer;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCity);
            cBox_City.DataSource = dtCity;
            cBox_City.DisplayMember = "cust_city";
            customerid = dtCustomer.Rows[0][0].ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            sqlQuery = "update customer set membership_id = '"+tBox_memberID.Text+"',cust_name = '"+tBox_CustName.Text+"', cust_address = '"+tBox_Address+"', cust_city = '"+cBox_City+"', cust_phone = '"+tBox_Phone+"', cust_email = '"+tBox_Email+"'where cust_id = '"+ tBox_CustID.Text+"'; ";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            Customer_Load(sender, e);

            MessageBox.Show("Data telah terupdate");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            sqlQuery = "update customer set status_del = '1' where cust_id = '" + tBox_CustID.Text + "';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data telah terhapus");
            Customer_Load(sender, e);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            sqlQuery = "insert into customer values ('"+tBox_CustID.Text+"','"+tBox_memberID.Text+"','"+ dTP_memberjoin.Value.ToString("yyyyMMdd") + "','"+tBox_CustName.Text+"','"+tBox_Address.Text+"','"+cBox_City.Text+"','"+tBox_Phone.Text+"','"+tBox_Email.Text+"','"+ dTP_dob.Value.ToString("yyyyMMdd") + "','0');";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data telah tersimpan");
            Customer_Load(sender, e);
        }

        private void dgv_Customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tBox_CustID.Text = dgv_Customer.CurrentRow.Cells[0].Value.ToString();
            tBox_memberID.Text = dgv_Customer.CurrentRow.Cells[1].Value.ToString();
            dTP_memberjoin.Text = dgv_Customer.CurrentRow.Cells[2].Value.ToString();
            tBox_CustName.Text = dgv_Customer.CurrentRow.Cells[3].Value.ToString();
            tBox_Address.Text = dgv_Customer.CurrentRow.Cells[4].Value.ToString();
            cBox_City.Text = dgv_Customer.CurrentRow.Cells[5].Value.ToString();
            tBox_Phone.Text = dgv_Customer.CurrentRow.Cells[6].Value.ToString();
            tBox_Email.Text = dgv_Customer.CurrentRow.Cells[7].Value.ToString();
            dTP_dob.Text = dgv_Customer.CurrentRow.Cells[8].Value.ToString();
        }
        int customerke;
        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerke = dgv_Customer.CurrentCell.RowIndex;
            customerid = dtCustomer.Rows[customerke][0].ToString();
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tBox_Address.Clear();
            tBox_CustID.Clear();
            tBox_CustName.Clear();
            tBox_Email.Clear();
            tBox_memberID.Clear();
            tBox_Phone.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dtCustomer = new DataTable();
            sqlQuery = "select cust_id,membership_id,membership_joindate,cust_name,cust_address, cust_city, cust_phone, cust_email, cust_dob from customer where status_del = '0' and cust_name like  '%" + tBox_Search.Text + "%';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustomer);
            sqlAdapter.Fill(dtCity);
            dgv_Customer.DataSource = dtCustomer;
            cBox_City.DataSource = dtCity;
            cBox_City.DisplayMember = "cust_city";
            cBox_City.ValueMember = "cust_id";
            customerid = dtCustomer.Rows[0][0].ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtCustomer = new DataTable();
            sqlQuery = "select cust_id,membership_id,membership_joindate,cust_name,cust_address, cust_city, cust_phone, cust_email, cust_dob from customer where status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustomer);
            sqlAdapter.Fill(dtCity);
            dgv_Customer.DataSource = dtCustomer;
            cBox_City.DataSource = dtCity;
            cBox_City.DisplayMember = "cust_city";
            cBox_City.ValueMember = "cust_id";
            customerid = dtCustomer.Rows[0][0].ToString();
        }
    }
}
