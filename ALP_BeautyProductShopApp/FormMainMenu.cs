﻿using System;
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


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

         void resetWarna()
         {
            pnlNavProduct.BackColor = Color.MistyRose;
            pnlNavStaff.BackColor = Color.MistyRose;
            pnlNavCustomer.BackColor = Color.MistyRose;
            pnlNavTransaction.BackColor = Color.MistyRose;
            pnlNavOrder.BackColor = Color.MistyRose;
         }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            resetWarna();
            pnlNavProduct.BackColor = Color.LightCoral;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            resetWarna();
            pnlNavStaff.BackColor = Color.LightCoral;
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            resetWarna();
            pnlNavCustomer.BackColor = Color.LightCoral;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            resetWarna();
            pnlNavTransaction.BackColor = Color.LightCoral;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            resetWarna();
            pnlNavOrder.BackColor = Color.LightCoral;
        }

        private void pnlBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            } 
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

