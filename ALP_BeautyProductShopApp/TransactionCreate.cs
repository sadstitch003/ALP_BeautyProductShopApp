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
using System.Runtime.InteropServices;

namespace ALP_BeautyProductShopApp
{
    public partial class TransactionCreate : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        int selectedrowindex;
        string cellValue;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        DataTable dtCustList = new DataTable();
        string transactionNum;

        DataTable dtProductList = new DataTable();
        DataTable dtTransProduct = new DataTable();

        public TransactionCreate(string StaffID)
        {
            InitializeComponent();

            sqlConnect.Open();
            sqlQuery = $"SELECT LPAD(COUNT(trans_id), 2, '0') FROM transaction;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            transactionNum = Convert.ToString(Convert.ToInt32(sqlCommand.ExecuteScalar()) + 1);
            sqlConnect.Close();

            tbTransID.Text = dtpTransDate.Value.ToString("yyyyMMdd") + "-T" + transactionNum;

            sqlQuery = "select * from customer where status_del = '0' order by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustList);
            cbCustID.DataSource = dtCustList;
            cbCustID.DisplayMember = "cust_name";
            cbCustID.ValueMember = "cust_id";
            cbCustID.SelectedValue = "C000";

            tbStaffID.Text = StaffID;
            tbTaxPercentage.Text = "10";

            dtTransProduct.Columns.Add("prod_id");
            dtTransProduct.Columns.Add("prod_name");
            dtTransProduct.Columns.Add("qty_trans");
            dtTransProduct.Columns.Add("price_trans");
            dtTransProduct.Columns.Add("price_total");

            sqlQuery = "select prod_id from product where status_del = '0' order by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtProductList);
            
            sqlQuery = "select prod_name from product where status_del = '0' order by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtProductList);

            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cbCustID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtCustList.Rows[cbCustID.SelectedIndex]["membership_id"].ToString() == "SIL")
                tbDiscountPercentage.Text = "5";
            else if (dtCustList.Rows[cbCustID.SelectedIndex]["membership_id"].ToString() == "GLD")
                tbDiscountPercentage.Text = "10";
            else if (dtCustList.Rows[cbCustID.SelectedIndex]["membership_id"].ToString() == "DIA")
                tbDiscountPercentage.Text = "15";
            else tbDiscountPercentage.Text = "0";

            calculateTotal();
        }

        void calculateTotal()
        {
            tbDiscountAmount.Text = Convert.ToString(Convert.ToInt32(tbTotal.Text) * Convert.ToInt32(tbDiscountPercentage.Text) / 100);
            tbTaxAmount.Text = Convert.ToString((Convert.ToInt32(tbTotal.Text) - Convert.ToInt32(tbDiscountAmount.Text)) * Convert.ToInt32(tbTaxPercentage.Text) / 100);
            tbNetTotal.Text = Convert.ToString(Convert.ToInt32(tbTotal.Text) - Convert.ToInt32(tbDiscountAmount.Text) + Convert.ToInt32(tbTaxAmount.Text));
        }

        private void dtpTransDate_ValueChanged(object sender, EventArgs e)
        {
            tbTransID.Text = dtpTransDate.Value.ToString("yyyyMMdd") + "-T" + transactionNum;
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnCreate_click(object sender, EventArgs e)
        {
            if (tbTotal.Text == "0")
            {
                MessageBox.Show("Transaksi Kosong !");
            }


            // Kurangin jumlah
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtProductList = new DataTable();
            sqlQuery = $"select * from product where status_del = '0' and prod_id = '{tbProductID.Text.ToUpper()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtProductList);

            if (nudProdQty.Value > Convert.ToInt16(dtProductList.Rows[0]["prod_stock"]))
            {
                MessageBox.Show("Not enough stock !");
            }
            else
            {
                dtTransProduct.Rows.Add(new Object[]{
                    dtProductList.Rows[0]["prod_id"],
                    dtProductList.Rows[0]["prod_name"],
                    nudProdQty.Value,
                    dtProductList.Rows[0]["prod_price"],
                    (Convert.ToInt32(dtProductList.Rows[0]["prod_price"]) * nudProdQty.Value)
                });

                dgvProductTrans.DataSource = dtTransProduct;

                tbTotal.Text = "0";
                for (int i = 0; i < dtTransProduct.Rows.Count; i++)
                    tbTotal.Text = Convert.ToString(Convert.ToInt32(tbTotal.Text) + Convert.ToInt32(dtTransProduct.Rows[i]["price_total"]));
            }
        }

        private void dgvProductTrans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductTrans.SelectedCells.Count > 0)
            {
                selectedrowindex = dgvProductTrans.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvProductTrans.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["prod_id"].Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProductTrans.Rows.Count > 0)
            {
                dgvProductTrans.Rows.RemoveAt(selectedrowindex);
                dtProductList.Rows.RemoveAt(selectedrowindex);
                MessageBox.Show("Data deleted !");
            }
        }

        private void TransactionCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
