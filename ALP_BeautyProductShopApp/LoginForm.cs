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
    public partial class LoginForm : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery; 

        public LoginForm()
        {
            InitializeComponent();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")] 
        public static extern bool ReleaseCapture();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();  
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = $"SELECT COUNT(staff_id) FROM staff WHERE staff_id = '{TbStaffID.Text}' AND staff_password = '{TbPassword.Text}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            bool loginSucceed = Convert.ToBoolean(sqlCommand.ExecuteScalar());
            sqlConnect.Close();
             
            if (loginSucceed)
            {
                this.Close();
                FormMainMenu form = new FormMainMenu(TbStaffID.Text);
                form.Show();
            }
            else
            {
                MessageBox.Show("ID atau Password anda salah !");
                TbStaffID.Focus();
            }
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
