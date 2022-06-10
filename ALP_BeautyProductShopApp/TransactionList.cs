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
    public partial class TransactionList : Form
    {

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtTransList;

        string cellValue;
        int selectedrowindex;

        string staffID;
        public TransactionList(string StaffID)
        {
            InitializeComponent();
            staffID = StaffID;
        }

        private void TransactionList_Load(object sender, EventArgs e)
        {
            updateTable();
        }

        void updateTable()
        {
            dtTransList = new DataTable();
            sqlQuery = "select trans_id, staff_id, cust_id, trans_date, tax, discount, concat('Rp.', format(trans_total, 'C', 'id_ID')) as trans_total, concat('Rp.', format(net_total, 'C', 'id-ID')) as net_total from transaction where status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTransList);
            dgvTransList.DataSource = dtTransList;
        }

        private void dgvTransList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransList.SelectedCells.Count > 0)
            {
                selectedrowindex = dgvTransList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvTransList.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["trans_id"].Value);
            }
        }

        private void btnNewTrans_Click(object sender, EventArgs e)
        {
            TransactionCreate form = new TransactionCreate(staffID);
            form.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            TransactionDetails form = new TransactionDetails(cellValue);
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = $"update transaction set status_del = '1' where trans_id = '{cellValue}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            if (dgvTransList.Rows.Count > 0)
            {
                dgvTransList.Rows.RemoveAt(selectedrowindex);
                MessageBox.Show("Data deleted !");
            }
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            TransactionDeleted form = new TransactionDeleted();
            form.ShowDialog();
            updateTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                dtTransList = new DataTable();
                sqlQuery = $"select trans_id, staff_id, cust_id, trans_date, tax, discount, concat('Rp.', format(trans_total, 'C', 'id_ID')) as trans_total, concat('Rp.', format(net_total, 'C', 'id-ID')) as net_total from transaction where status_del = '0' and (trans_id like '%{tbSearch.Text.ToUpper()}%' or staff_id like '%{tbSearch.Text.ToUpper()}%' or cust_id like '%{tbSearch.Text.ToUpper()}%');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTransList);
                dgvTransList.DataSource = dtTransList;
                tbSearch.Text = "";
            }
            else updateTable();
        }
    }
}
