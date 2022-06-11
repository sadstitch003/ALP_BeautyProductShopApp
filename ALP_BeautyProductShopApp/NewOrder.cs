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
    public partial class NewOrder : Form
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

        string orderNum;
        DataTable dtSupplierList = new DataTable();

        DataTable dtProductList = new DataTable();
        DataTable dtOrderProduct = new DataTable();

        public NewOrder(string StaffID)
        {
            InitializeComponent();
            sqlConnect.Open();
            sqlQuery = $"SELECT LPAD(COUNT(order_id) + 1, 2, '0') FROM `order`;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            orderNum = Convert.ToString(sqlCommand.ExecuteScalar());
            sqlConnect.Close();

            tbOrderID.Text = dtpOrderDate.Value.ToString("yyyyMMdd") + "-O" + orderNum;

            sqlQuery = "select * from supplier where status_del = '0' order by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtSupplierList);
            cbSupplierID.DataSource = dtSupplierList;
            cbSupplierID.DisplayMember = "supplier_name";
            cbSupplierID.ValueMember = "supplier_id";
            cbSupplierID.SelectedIndex = 0;

            tbStaffID.Text = StaffID;
            tbTaxPercentage.Text = "10";

            dtOrderProduct.Columns.Add("prod_id");
            dtOrderProduct.Columns.Add("prod_name");
            dtOrderProduct.Columns.Add("qty_order");
            dtOrderProduct.Columns.Add("price_order");
            dtOrderProduct.Columns.Add("price_total");

            sqlQuery = $"select prod_id from product where supplier_id = '{cbSupplierID.SelectedValue}' and status_del = '0' union select prod_name from product where supplier_id = '{cbSupplierID.SelectedValue.ToString()}' and status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);

            sqlConnect.Open();
            MySqlDataReader sdr = sqlCommand.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (sdr.Read()) autotext.Add(sdr.GetString(0));
            tbProductID.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbProductID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbProductID.AutoCompleteCustomSource = autotext;
            sqlConnect.Close();
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

        void calculateTotal()
        {
            try
            {
                if (tbDiscountPercentage.Text == "") tbDiscountAmount.Text = "0";
                else tbDiscountAmount.Text = Convert.ToString(Convert.ToInt32(tbTotal.Text) * Convert.ToInt32(tbDiscountPercentage.Text) / 100);
                tbTaxTotal.Text = Convert.ToString((Convert.ToInt32(tbTotal.Text) - Convert.ToInt32(tbDiscountAmount.Text)) * Convert.ToInt32(tbTaxPercentage.Text) / 100);
                tbNetTotal.Text = Convert.ToString(Convert.ToInt32(tbTotal.Text) - Convert.ToInt32(tbDiscountAmount.Text) + Convert.ToInt32(tbTaxTotal.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            tbOrderID.Text = dtpOrderDate.Value.ToString("yyyyMMdd") + "-O" + orderNum;
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void tbDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbProductID.Text = "";
            tbPrice.Text = "0";
            sqlQuery = $"select prod_id from product where supplier_id = '{cbSupplierID.SelectedValue}' and status_del = '0' union select prod_name from product where supplier_id = '{cbSupplierID.SelectedValue.ToString()}' and status_del = '0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);

            sqlConnect.Open();
            MySqlDataReader sdr = sqlCommand.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (sdr.Read()) autotext.Add(sdr.GetString(0));
            tbProductID.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbProductID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbProductID.AutoCompleteCustomSource = autotext;
            sqlConnect.Close();
        }

        private void dgvProductOrder_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductOrder.SelectedCells.Count > 0)
                {
                    selectedrowindex = dgvProductOrder.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvProductOrder.Rows[selectedrowindex];
                    cellValue = Convert.ToString(selectedRow.Cells["prod_id"].Value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductOrder.Rows.Count > 0)
                {
                    dgvProductOrder.Rows.RemoveAt(selectedrowindex);
                    dtProductList.Rows.RemoveAt(selectedrowindex);
                    MessageBox.Show("Data deleted !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dtProductList = new DataTable();
                sqlQuery = $"select * from product where status_del = '0' and prod_id = '{tbProductID.Text.ToUpper()}' or prod_name = '{tbProductID.Text.ToUpper()}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtProductList);

                if (tbProductID.Text == "" | dtProductList.Rows.Count < 1)
                {
                    MessageBox.Show("Product not found !");
                }
                else if (dtProductList.Rows[0]["supplier_id"].ToString() != cbSupplierID.SelectedValue.ToString())
                {
                    MessageBox.Show("Product is not from this supplier !");
                }
                else if (Convert.ToInt32(tbPrice.Text) > Convert.ToInt32(dtProductList.Rows[0]["prod_price"]))
                {
                    MessageBox.Show("Too Expensive !");
                }
                else if (tbPrice.Text == "" || tbPrice.Text == "0")
                {
                    MessageBox.Show("Enter product price !");
                }
                else
                {
                    dtOrderProduct.Rows.Add(new Object[]{
                        dtProductList.Rows[0]["prod_id"],
                        dtProductList.Rows[0]["prod_name"],
                        nudProdQty.Value,
                        tbPrice.Text,
                        (Convert.ToInt32(tbPrice.Text) * nudProdQty.Value)
                    });

                    dgvProductOrder.DataSource = dtOrderProduct;

                    tbTotal.Text = "0";
                    for (int i = 0; i < dtOrderProduct.Rows.Count; i++)
                        tbTotal.Text = Convert.ToString(Convert.ToInt32(tbTotal.Text) + Convert.ToInt32(dtOrderProduct.Rows[i]["price_total"]));
                }
                nudProdQty.Value = 1;
                tbProductID.Text = "";
                tbPrice.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTotal.Text == "0") MessageBox.Show("Order Kosong !");
                else
                {
                    sqlConnect.Open();
                    sqlQuery = $"insert into `order` (order_id, staff_id, supplier_id, order_date, tax, discount, order_total, net_total) values ('{tbOrderID.Text}', '{tbStaffID.Text}', '{cbSupplierID.SelectedValue}', '{dtpOrderDate.Value.ToString("yyyy-MM-dd")}', '{tbTaxPercentage.Text}', '{tbDiscountPercentage.Text}', '{tbTotal.Text}', '{tbNetTotal.Text}');";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();

                    for (int i = 0; i < dtOrderProduct.Rows.Count; i++)
                    {
                        sqlQuery = $"insert into order_product (order_id, prod_id, qty_order, price_order) values ('{tbOrderID.Text}', '{dtOrderProduct.Rows[i]["prod_id"].ToString()}', '{dtOrderProduct.Rows[i]["qty_order"].ToString()}', '{dtOrderProduct.Rows[i]["price_order"].ToString()}');";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlCommand.ExecuteNonQuery();

                        sqlQuery = $"UPDATE product SET prod_stock = prod_stock + {dtOrderProduct.Rows[i]["qty_order"].ToString()} WHERE prod_id = '{dtOrderProduct.Rows[i]["prod_id"].ToString()}';";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnect.Close();
                    MessageBox.Show("Order created !");
                    this.Close();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
        }


    }
}
