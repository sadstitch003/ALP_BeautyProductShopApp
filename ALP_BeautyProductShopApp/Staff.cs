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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtStaff = new DataTable();
        DataTable dtPosition = new DataTable();

        public static string staffid;
        private void Staff_Load(object sender, EventArgs e)
        {
            
            dtStaff = new DataTable();
            sqlQuery = "select staff_id, staff_name, staff_password, staff_position, staff_phone, staff_dob from staff where status_del ='0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStaff);
            dgv_Staff.DataSource = dtStaff;

            sqlQuery = "select distinct staff_position from staff;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPosition);
            cBox_Position.DataSource = dtPosition;
            cBox_Position.DisplayMember = "staff_position";
           
            staffid = dtStaff.Rows[0][0].ToString();

        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            
            StaffSales sales = new StaffSales();
            sales.MdiParent = this.ParentForm;
            sales.Dock = DockStyle.Fill;
            sales.Show();
        }
        int staffke;
        private void dgv_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Staff_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tBox_StaffID.Text = dgv_Staff.CurrentRow.Cells[0].Value.ToString();
            tBox_StaffName.Text = dgv_Staff.CurrentRow.Cells[1].Value.ToString();
            tBox_Password.Text = dgv_Staff.CurrentRow.Cells[2].Value.ToString();
            cBox_Position.Text  = dgv_Staff.CurrentRow.Cells[3].Value.ToString();
            tBox_Phone.Text = dgv_Staff.CurrentRow.Cells[4].Value.ToString();
            dTP_dob.Text = dgv_Staff.CurrentRow.Cells[5].Value.ToString();
           
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            sqlQuery = " UPDATE staff SET staff_name = '" + tBox_StaffName.Text + "', staff_password = '"+ tBox_Password.Text + "', staff_position = '" + cBox_Position.Text + "', staff_phone = '" + tBox_Phone.Text + "', staff_dob = '" + dTP_dob.Value.ToString("yyyyMMdd") + "' WHERE staff_id = '" + tBox_StaffID.Text + "'; ";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            MessageBox.Show("Data telah terupdate");
            Staff_Load(sender, e);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            sqlQuery = "UPDATE staff SET status_del = '1'WHERE staff_id = '" + tBox_StaffID.Text + "';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data telah terhapus");
            Staff_Load(sender, e);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            sqlQuery = "insert into staff values ('" + tBox_StaffID.Text + "','" + tBox_StaffName.Text + "','"+tBox_Password.Text+"','"+ cBox_Position.Text + "','"+ tBox_Phone.Text + "','"+ dTP_dob.Value.ToString("yyyyMMdd") + "','0');";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data telah tersimpan");
            Staff_Load(sender, e);
        }

        private void dgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            staffke = dgv_Staff.CurrentCell.RowIndex;
            staffid = dtStaff.Rows[staffke][0].ToString();
           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tBox_StaffID.Clear();
            tBox_StaffName.Clear();
            tBox_Password.Clear();
            tBox_Phone.Clear();
            

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dtStaff = new DataTable();
            sqlQuery = "select staff_id, staff_name, staff_password, staff_position, staff_phone, staff_dob from staff where status_del ='0'and staff_name like '%" + tBox_Search.Text + "%';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStaff);
            sqlAdapter.Fill(dtPosition);
            dgv_Staff.DataSource = dtStaff;
            cBox_Position.DataSource = dtPosition;
            cBox_Position.DisplayMember = "staff_position";
            cBox_Position.ValueMember = "staff_id";
            staffid = dtStaff.Rows[0][0].ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtStaff = new DataTable();
            sqlQuery = "select staff_id, staff_name, staff_password, staff_position, staff_phone, staff_dob from staff where status_del ='0';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStaff);
            sqlAdapter.Fill(dtPosition);
            dgv_Staff.DataSource = dtStaff;
            cBox_Position.DataSource = dtPosition;
            cBox_Position.DisplayMember = "staff_position";
            cBox_Position.ValueMember = "staff_id";
            staffid = dtStaff.Rows[0][0].ToString();
        }
    }
}
