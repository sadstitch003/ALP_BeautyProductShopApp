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
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtCustTrans = new DataTable();
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            sqlQuery = "select c.cust_id, c.membership_id, c.cust_name, c.cust_phone, c.cust_email, sum(t.net_total) from customer c, transaction t where c.cust_id = t.cust_id and c.cust_id = '"+Customer.customerid + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustTrans);
            dgv_Transaction.DataSource = dtCustTrans;
            tBox_CustId.Text = dgv_Transaction.CurrentRow.Cells[0].Value.ToString();
            tBox_MemberID.Text = dgv_Transaction.CurrentRow.Cells[1].Value.ToString();
            tBox_Name.Text = dgv_Transaction.CurrentRow.Cells[2].Value.ToString();
            tBox_Phone.Text = dgv_Transaction.CurrentRow.Cells[3].Value.ToString();
            tBox_Email.Text = dgv_Transaction.CurrentRow.Cells[4].Value.ToString(); 
            
        }
    }
}
