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
    public partial class TransactionDeleted : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        int selectedrowindex;
        string cellValue;

        DataTable dtDeletedData = new DataTable();

        public TransactionDeleted()
        {
            InitializeComponent();
            sqlQuery = "select * from transaction where status_del = '1';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDeletedData);
            dgvDeletedData.DataSource = dtDeletedData;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = $"update transaction set status_del = '0' where trans_id = '{cellValue}';";
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            dgvDeletedData.Rows.RemoveAt(selectedrowindex);
            MessageBox.Show("Data restored !");
        }

        private void dgvDeletedData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeletedData.SelectedCells.Count > 0)
            {
                selectedrowindex = dgvDeletedData.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvDeletedData.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["trans_id"].Value);
            }
        }
    }
}
