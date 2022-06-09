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
    public partial class TransactionDetails : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtTransProduct;
        DataTable dtDetail;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public TransactionDetails(string transID)
        {
            InitializeComponent();
            dtTransProduct = new DataTable();
            sqlQuery = $"select trans_id, prod_id, qty_trans, concat('Rp.', format(price_trans, 'C', 'id-ID')) as price_trans, concat('Rp.', format((qty_trans * price_trans), 'C', 'id-ID')) as total_trans from transaction_product where trans_id = '{transID}' and status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTransProduct);
            dgvTransProduct.DataSource = dtTransProduct;

            dtDetail = new DataTable();
            sqlQuery = $"select t.trans_id, c.cust_name, s.staff_name, date_format(t.trans_date, '%y/%m/%d') as trans_date, format(t.trans_total, 'C', 'id-ID') as trans_total, format(t.trans_total, 'C', 'id-ID'), format((t.trans_total * t.discount / 100), 'C', 'id-ID') as discount_amount, format(((t.trans_total * (100 - t.discount) / 100) * t.tax / 100), 'C', 'id-ID') as tax_amount, t.discount, t.tax, format(t.net_total, 'C', 'id_ID') as 'net_total', ifnull(c.membership_id, '-') as membership_id from transaction t left join customer c on c.cust_id = t.cust_id left join staff s on s.staff_id = t.staff_id where t.trans_id = '{transID}' and t.status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetail);

            lblTransID.Text = "Transaction ID : " + dtDetail.Rows[0]["trans_id"].ToString();
            lblCustName.Text = ": " + dtDetail.Rows[0]["cust_name"].ToString();
            lblStaffName.Text = ": " + dtDetail.Rows[0]["staff_name"].ToString();
            lblDate.Text = ": " + dtDetail.Rows[0]["trans_date"].ToString();
            lblMember.Text = ": " + dtDetail.Rows[0]["membership_id"].ToString();
            lblTotal.Text = ": Rp." + dtDetail.Rows[0]["trans_total"].ToString();
            lblDiscount.Text = $": Rp.{dtDetail.Rows[0]["discount_amount"].ToString()} ({dtDetail.Rows[0]["discount"].ToString()}%)";
            lblTax.Text = $": Rp.{dtDetail.Rows[0]["tax_amount"].ToString()} ({dtDetail.Rows[0]["tax"].ToString()}%)";
            lblNetTotal.Text = ": Rp." + dtDetail.Rows[0]["net_total"].ToString();
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
    }
}
