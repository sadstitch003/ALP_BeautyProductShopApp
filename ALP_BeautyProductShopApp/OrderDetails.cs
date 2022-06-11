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
    public partial class OrderDetails : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtOrderProduct;
        DataTable dtDetail;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public OrderDetails(string orderID)
        {
            InitializeComponent();
            dtOrderProduct = new DataTable();
            sqlQuery = $"select order_id, prod_id, qty_order, concat('Rp.', format(price_order, 'C', 'id-ID')) as price_order, concat('Rp.', format((qty_order * price_order), 'C', 'id-ID')) as total_order from order_product where order_id = '{orderID}' and status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtOrderProduct);
            dgvTransProduct.DataSource = dtOrderProduct;

            dtDetail = new DataTable();
            sqlQuery = $"select o.order_id, s.supplier_name, sf.staff_name, date_format(o.order_date, '%y/%m/%d') as order_date, format(o.order_total, 'C', 'id-ID') as order_total, format(o.order_total, 'C', 'id-ID'), format((o.order_total * o.discount / 100), 'C', 'id-ID') as discount_amount, format(((o.order_total * (100 - o.discount) / 100) * o.tax / 100), 'C', 'id-ID') as tax_amount, o.discount, o.tax, format(o.net_total, 'C', 'id_ID') as net_total from `order` o left join supplier s on s.supplier_id = o.supplier_id left join staff sf on sf.staff_id = o.staff_id where o.order_id = '{orderID}' and o.status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetail);

            lblTransID.Text = "Order ID : " + dtDetail.Rows[0]["order_id"].ToString();
            lblCustName.Text = ": " + dtDetail.Rows[0]["supplier_name"].ToString();
            lblStaffName.Text = ": " + dtDetail.Rows[0]["staff_name"].ToString();
            lblDate.Text = ": " + dtDetail.Rows[0]["order_date"].ToString();
            lblTotal.Text = ": Rp." + dtDetail.Rows[0]["order_total"].ToString();
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
