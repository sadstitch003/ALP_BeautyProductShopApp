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
    public partial class FormMainMenu : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_08_BEAUTYPRODUCTSHOP");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        public FormMainMenu(string staffID)
        {
            InitializeComponent();
            sqlConnect.Open();
            sqlQuery = $"SELECT staff_name FROM staff WHERE staff_id = '{staffID}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            lblUsername.Text = Convert.ToString(sqlCommand.ExecuteScalar());
            sqlConnect.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        int Mx;
        int My;
        int Sw;
        int Sh;

        bool mov;

        void SizerMouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        void SizerMouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        void SizerMouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        void resetWarna()
         {
            btnProduct.BackColor = Color.MistyRose;
            btnStaff.BackColor = Color.MistyRose;
            btnCustomer.BackColor = Color.MistyRose;
            btnTransaction.BackColor = Color.MistyRose;
            btnOrder.BackColor = Color.MistyRose;
            btnOrder.Enabled = true;
            btnTransaction.Enabled = true;
            btnCustomer.Enabled = true;
            btnStaff.Enabled = true;
            btnProduct.Enabled = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            resetWarna();
            btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnProduct.Enabled = false;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            resetWarna();
            btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnStaff.Enabled = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            resetWarna();
            btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnCustomer.Enabled = false;
        }
         
        private void btnTransaction_Click(object sender, EventArgs e) 
        {
            resetWarna();
            btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnTransaction.Enabled = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            resetWarna();
            btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnOrder.Enabled = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.BackgroundImage = global::ALP_BeautyProductShopApp.Properties.Resources.collapse;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.BackgroundImage = global::ALP_BeautyProductShopApp.Properties.Resources.maximize;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}

