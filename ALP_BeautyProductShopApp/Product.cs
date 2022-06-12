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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtProduct = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtSupplier = new DataTable();

        private void Product_Load(object sender, EventArgs e)
        {
            dtProduct = new DataTable();
            sqlQuery = "select prod_id,	category_id, supplier_id, prod_name, prod_stock, prod_price, prod_inputdate, prod_expdate from product  where status_del ='0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtProduct);

            sqlQuery = "select * from category where status_del ='0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCategory);

            sqlQuery = "select * from supplier where status_del ='0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtSupplier);

            cBox_CategoryID.DataSource = dtCategory;
            cBox_CategoryID.DisplayMember = "category_id";
            cBox_CategoryID.ValueMember = "category_id";

            cBox_SupplierID.DataSource = dtSupplier;
            cBox_SupplierID.DisplayMember = "supplier_id";
            dgv_Product.DataSource = dtProduct;
           
        }

        private void dgv_Product_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tBox_ProdID.Text = dgv_Product.CurrentRow.Cells[0].Value.ToString();
            cBox_CategoryID.Text = dgv_Product.CurrentRow.Cells[1].Value.ToString();
            cBox_SupplierID.Text = dgv_Product.CurrentRow.Cells[2].Value.ToString();
            tBox_ProdName.Text = dgv_Product.CurrentRow.Cells[3].Value.ToString();
            tBox_Stock.Text = dgv_Product.CurrentRow.Cells[4].Value.ToString();
            tBox_Price.Text = dgv_Product.CurrentRow.Cells[5].Value.ToString();
            dTP_Input.Text = dgv_Product.CurrentRow.Cells[6].Value.ToString();
            dTP_Expire.Text = dgv_Product.CurrentRow.Cells[7].Value.ToString();

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {

            dtCategory = new DataTable();
            dtSupplier = new DataTable();
            sqlConnect.Open();
            try
            {
                sqlQuery = "select count(prod_id) from product where prod_id = '" + tBox_ProdID.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                
                int cek = Convert.ToInt32(sqlCommand.ExecuteScalar().ToString());
                if (cek > 0)
                {
                    MessageBox.Show("data sudah ada");
                    tBox_ProdID.Text = null;
                }
                else
                {

                    sqlQuery = "insert into product values ('" + tBox_ProdID.Text + "','" + cBox_CategoryID.Text + "','" + cBox_SupplierID.Text + "','" + tBox_ProdName.Text + "','" + tBox_Stock.Text + "','" + tBox_Price.Text + "'," + dTP_Input.Value.ToString("yyyyMMdd") + "," + dTP_Expire.Value.ToString("yyyyMMdd") + ",'0');";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Data telah tersimpan");
                    Product_Load(sender, e);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("masukkan data");
            }
            sqlConnect.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            dtCategory = new DataTable();
            dtSupplier = new DataTable();
            sqlConnect.Open();
            try
            {
                
                sqlQuery = "update product set prod_stock = '" + tBox_Stock.Text + "', prod_price = '" + tBox_Price.Text + "', prod_inputdate = '" + dTP_Input.Value.ToString("yyyyMMdd") + "', prod_expdate = '" + dTP_Expire.Value.ToString("yyyyMMdd") + "'where prod_id = '" + tBox_ProdID.Text + "'; ";
                
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                
                MessageBox.Show("Data telah terupdate");
                Product_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Masukkan data!");
            }
            sqlConnect.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dtCategory = new DataTable();
            dtSupplier = new DataTable();
            sqlQuery = "UPDATE product SET status_del = '1' WHERE prod_id = '" + tBox_ProdID.Text + "';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data telah terhapus");
            Product_Load(sender, e);
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tBox_Price.Clear();
            tBox_ProdID.Clear();
            tBox_ProdName.Clear();
            tBox_Stock.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dtProduct = new DataTable();
            dtCategory = new DataTable();
            dtSupplier = new DataTable();
            sqlQuery = "select prod_id,	category_id, supplier_id, prod_name, prod_stock, prod_price, prod_inputdate, prod_expdate from product where status_del ='0' and (prod_name like  '%"+tBox_Search.Text+"%' or prod_id like '%"+tBox_Search.Text+ "%' or category_id like '%" + tBox_Search.Text +"%' or supplier_id like '%" + tBox_Search.Text +"%');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtProduct);
            sqlAdapter.Fill(dtCategory);
            sqlAdapter.Fill(dtSupplier);
            cBox_CategoryID.DataSource = dtCategory;
            cBox_CategoryID.DisplayMember = "category_name";
            cBox_CategoryID.ValueMember = "category_id";
            cBox_SupplierID.DataSource = dtSupplier;
            cBox_SupplierID.DisplayMember = "supplier_name";
            cBox_SupplierID.DisplayMember = "supplier_id";
            dgv_Product.DataSource = dtProduct;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtCategory = new DataTable();
            dtSupplier = new DataTable();
            Product_Load(sender,e);
            tBox_Search.Text = "";
        }
    }
}
