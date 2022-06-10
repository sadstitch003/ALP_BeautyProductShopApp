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
    public partial class StaffSales : Form
    {
        public StaffSales()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtStaffSales = new DataTable();
        DataTable dtTotal = new DataTable();

        private void StaffSales_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.staff_id, s.staff_name, s.staff_position, s.staff_phone, t.net_total from `transaction` t, staff s where s.staff_id = t.staff_id and t.staff_id = '" + Staff.staffid + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStaffSales);
            dgv_StaffSales.DataSource = dtStaffSales;
            if (dgv_StaffSales.CurrentCell != null)
            {
                sqlQuery = "select t.staff_id, s.staff_name, s.staff_position, s.staff_phone, t.net_total from `transaction` t, staff s where s.staff_id = t.staff_id and t.staff_id = '" + Staff.staffid + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtStaffSales);
                dgv_StaffSales.DataSource = dtStaffSales;
                tBox_staffID.Text = dgv_StaffSales.CurrentRow.Cells[0].Value.ToString();
                tBox_Name.Text = dgv_StaffSales.CurrentRow.Cells[1].Value.ToString();
                tBox_Position.Text = dgv_StaffSales.CurrentRow.Cells[2].Value.ToString();
                tBox_Phone.Text = dgv_StaffSales.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Belum ada transaksi");
            }
            sqlQuery = "select t.staff_id, s.staff_name, s.staff_position, s.staff_phone, sum(t.net_total) from `transaction` t, staff s where s.staff_id = t.staff_id and t.staff_id = '" + Staff.staffid + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTotal);
            lbl_Total.Text = dtTotal.Rows[0][4].ToString();

        }

        private void dgv_StaffSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }
    }
}
