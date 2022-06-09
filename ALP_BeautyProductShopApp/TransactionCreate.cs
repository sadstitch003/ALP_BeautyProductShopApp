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

        public TransactionCreate(string StaffID)
        {
            InitializeComponent();

            sqlConnect.Open();
            sqlQuery = $"SELECT LPAD(COUNT(trans_id), 2, '0') FROM transaction;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            transactionNum = Convert.ToString(sqlCommand.ExecuteScalar());
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
            tbTotal.Text = "0";
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
        }

        void calculateTotal()
        {
            tbDiscountAmount.Text = Convert.ToString(Convert.ToInt16(tbTotal.Text) * (100 - Convert.ToInt16(tbDiscountPercentage.Text)) / 100);
            tbTaxTotal.Text = Convert.ToString((Convert.ToInt16(tbTotal.Text) - Convert.ToInt16(tbDiscountAmount.Text)) * (100 + Convert.ToInt16(tbTaxPercentage.Text)) / 100);
            tbNetTotal.Text = Convert.ToString(Convert.ToInt16(tbTotal.Text) - Convert.ToInt16(tbDiscountAmount.Text) + Convert.ToInt16(tbTaxTotal.Text));
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
        }
    }
}
