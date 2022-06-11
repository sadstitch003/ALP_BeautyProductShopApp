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
      
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtCustomer = new DataTable();
        DataTable dtMembership = new DataTable();
        public Customer()
        {
            InitializeComponent();
            sqlQuery = "select distinct membership_id from membership;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMembership);
            dtMembership.Rows.Add(new Object[] { "-" });
            cBox_MemberID.DataSource = dtMembership;
            cBox_MemberID.DisplayMember = "membership_id";
            cBox_MemberID.ValueMember = "membership_id";
        }
        public static string customerid;
        int customerke;

        private void Customer_Load(object sender, EventArgs e)
        {
            dtCustomer = new DataTable();
            sqlQuery = "select cust_id,membership_id,membership_joindate,cust_name,cust_address, cust_city, cust_phone, cust_email, cust_dob from customer where status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustomer);
            dgv_Customer.DataSource = dtCustomer;

            
            
            customerid = dtCustomer.Rows[0][0].ToString();
            dTP_memberjoin.Enabled = false;
        }
        private void dgv_Customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tBox_CustID.Text = dgv_Customer.CurrentRow.Cells[0].Value.ToString();
                cBox_MemberID.Text = dgv_Customer.CurrentRow.Cells[1].Value.ToString();
                if (cBox_MemberID.Text == "" || cBox_MemberID.Text == "-")
                {
                    dTP_memberjoin.Enabled = false;
                }
                else
                {
                    dTP_memberjoin.Enabled = true;
                }

                tBox_CustName.Text = dgv_Customer.CurrentRow.Cells[3].Value.ToString();
                tBox_Address.Text = dgv_Customer.CurrentRow.Cells[4].Value.ToString();
                tBox_City.Text = dgv_Customer.CurrentRow.Cells[5].Value.ToString();
                tBox_Phone.Text = dgv_Customer.CurrentRow.Cells[6].Value.ToString();
                tBox_Email.Text = dgv_Customer.CurrentRow.Cells[7].Value.ToString();
                dTP_dob.Text = dgv_Customer.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(dgv_Customer.CurrentRow.Cells[2].Value.ToString());
            }

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            dtMembership = new DataTable();
            if (cBox_MemberID.Text == "" || cBox_MemberID.Text == "-")
            {
                sqlQuery = "select count(cust_id) from customer where cust_id = '" + tBox_CustID.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                int temp = Convert.ToInt32(sqlCommand.ExecuteScalar().ToString());
                if (temp > 0)
                {
                    MessageBox.Show("data sudah ada");
                    tBox_CustID.Text = null;
                }
                else
                {
                    sqlQuery = "insert into customer(cust_id, cust_name, cust_address, cust_city, cust_phone, cust_email, cust_dob, status_del) values ('" + tBox_CustID.Text + "','" + tBox_CustName.Text + "','" + tBox_Address.Text + "','" + tBox_City.Text + "','" + tBox_Phone.Text + "','" + tBox_Email.Text + "','" + dTP_dob.Value.ToString("yyyyMMdd") + "','0');";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Data telah tersimpan");
                    Customer_Load(sender, e);
                }
                sqlConnect.Close();
            }
            else
            {
                sqlQuery = "select count(cust_id) from customer where cust_id = '" + tBox_CustID.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                int temp = Convert.ToInt32(sqlCommand.ExecuteScalar().ToString());
                if (temp > 0)
                {
                    MessageBox.Show("data sudah ada");
                    tBox_CustID.Text = null;
                }
                else
                {
                    sqlQuery = "insert into customer values ('" + tBox_CustID.Text + "','" + cBox_MemberID.Text + "','" + dTP_memberjoin.Value.ToString("yyyyMMdd") + "','" + tBox_CustName.Text + "','" + tBox_Address.Text + "','" + tBox_City.Text + "','" + tBox_Phone.Text + "','" + tBox_Email.Text + "','" + dTP_dob.Value.ToString("yyyyMMdd") + "','0');";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Data telah tersimpan");
                    Customer_Load(sender, e);

                }
                sqlConnect.Close();
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                dtMembership = new DataTable();
                if (cBox_MemberID.Text == "" || cBox_MemberID.Text == "-")
                {
                    sqlQuery = "update customer set membership_id = '',cust_name = '" + tBox_CustName.Text + "', cust_address = '" + tBox_Address.Text + "', cust_city = '" + tBox_City.Text + "', cust_phone = '" + tBox_Phone.Text + "', cust_email = '" + tBox_Email.Text + "',  membership_id = null, membership_joindate = null where cust_id = '" + tBox_CustID.Text + "'; ";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    Customer_Load(sender, e);
                    MessageBox.Show("Data telah terupdate");
                }
                else
                {
                    sqlQuery = "update customer set membership_id = '" + cBox_MemberID.Text + "',cust_name = '" + tBox_CustName.Text + "', cust_address = '" + tBox_Address.Text + "', cust_city = '" + tBox_City.Text + "', cust_phone = '" + tBox_Phone.Text + "', cust_email = '" + tBox_Email.Text + "', membership_joindate = '"+ dTP_memberjoin.Value.ToString("yyyyMMdd") + "'where cust_id = '" + tBox_CustID.Text + "'; ";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    Customer_Load(sender, e);
                    MessageBox.Show("Data telah terupdate");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Masukkan data!");
            }


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dtMembership = new DataTable();
            sqlQuery = "update customer set status_del = '1' where cust_id = '" + tBox_CustID.Text + "';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data telah terhapus");
            Customer_Load(sender, e);
        }

        private void btnViewTrans_Click(object sender, EventArgs e)
        {

            TransactionHistory trans = new TransactionHistory();
            trans.MdiParent = this.ParentForm;
            trans.Dock = DockStyle.Fill;
            trans.Show();
        }
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
            tBox_City.Clear();
            tBox_Email.Clear();
            tBox_Phone.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dtCustomer = new DataTable();
            sqlQuery = "select cust_id,membership_id,membership_joindate,cust_name,cust_address, cust_city, cust_phone, cust_email, cust_dob from customer where status_del = '0' and (cust_name like  '%" + tBox_Search.Text + "%' or cust_id like '%" + tBox_Search.Text + "%' or membership_id like '%" + tBox_Search.Text + "%' or cust_city like '%"+ tBox_Search.Text + "%' or cust_phone like'%" + tBox_Search.Text + "%') ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustomer);
            dgv_Customer.DataSource = dtCustomer;
            if (dgv_Customer.Rows.Count > 0)
            {
                customerid = dtCustomer.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("ulangi");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtMembership = new DataTable();
            Customer_Load(sender, e);
            tBox_Search.Text = "";
        }

        private void cBox_MemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_MemberID.Text == "" || cBox_MemberID.Text == "-")
            {
                dTP_memberjoin.Enabled = false;
            }
            else
            {
                dTP_memberjoin.Enabled = true;
            }
        }
    }
}
