using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace ALP_BeautyProductShopApp
{
    public partial class OrderDeleted : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        int selectedrowindex;
        string cellValue;

        DataTable dtDeletedData = new DataTable();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public OrderDeleted()
        {
            InitializeComponent();
            sqlQuery = "select * from `order` where status_del = '1';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDeletedData);
            dgvDeletedData.DataSource = dtDeletedData;
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

        private void dgvDeletedData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeletedData.SelectedCells.Count > 0)
            {
                selectedrowindex = dgvDeletedData.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvDeletedData.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["order_id"].Value);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"update `order` set status_del = '0' where order_id = '{cellValue}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                if (dgvDeletedData.Rows.Count > 0)
                {
                    dgvDeletedData.Rows.RemoveAt(selectedrowindex);
                    MessageBox.Show("Data restored !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }

        }
    }
}
