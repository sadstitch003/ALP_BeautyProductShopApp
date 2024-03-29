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
        static string staffID;
        string staffPosition;

        Customer customer = new Customer();
        Product product = new Product();
        Staff staff = new Staff();
        
        TransactionList trans = new TransactionList(staffID);
        Order order = new Order(staffID);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        int Mx;
        int My;
        int Sw;
        int Sh;
        bool mov;

        public FormMainMenu(string StaffID)
        {
            InitializeComponent();
            sqlConnect.Open();
            sqlQuery = $"SELECT staff_name FROM staff WHERE staff_id = '{StaffID}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            lblUsername.Text = Convert.ToString(sqlCommand.ExecuteScalar());

            sqlQuery = $"SELECT staff_position FROM staff WHERE staff_id = '{StaffID}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            staffPosition = Convert.ToString(sqlCommand.ExecuteScalar());

            if (staffPosition == "Manager")
            {
                btnProduct.Enabled = true;
                btnStaff.Enabled = true;
                btnCustomer.Enabled = true;
                btnTransaction.Enabled = true;
                btnOrder.Enabled = true;
            }
            else if (staffPosition == "HRD")
            {
                btnStaff.Enabled = true;
            }
            else if (staffPosition == "Order Staff")
            {
                btnProduct.Enabled = true;
                btnOrder.Enabled = true;
            }
            else if (staffPosition == "Cashier")
            {
                btnCustomer.Enabled = true;
                btnTransaction.Enabled = true;
                btnProduct.Enabled = true;
            }

            sqlConnect.Close();
            staffID = StaffID;;
        }

        private void pnlBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

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
            pnlNavOrder.BackColor = Color.MistyRose;
            pnlNavTrans.BackColor = Color.MistyRose;    
            pnlNavCust.BackColor = Color.MistyRose;
            pnlNavStaff.BackColor = Color.MistyRose;
            pnlNavProd.BackColor = Color.MistyRose;

            if (staffPosition == "Manager")
            {
                btnProduct.Enabled = true;
                btnStaff.Enabled = true;
                btnCustomer.Enabled = true;
                btnTransaction.Enabled = true;
                btnOrder.Enabled = true;
            }
            else if (staffPosition == "HRD")
            {
                btnStaff.Enabled = true;
            }
            else if (staffPosition == "Order Staff")
            {
                btnProduct.Enabled = true;
                btnOrder.Enabled = true;
            }
            else if (staffPosition == "Cashier")
            {
                btnCustomer.Enabled = true;
                btnTransaction.Enabled = true;
                btnProduct.Enabled = true;
            }
        }

        void closeForm()
        {
            product.Close();
            staff.Close();
            customer.Close();
            trans.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            resetWarna();
            pnlNavProd.BackColor = Color.HotPink;
            closeForm();
            btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnProduct.Enabled = false;
            product = new Product();
            product.MdiParent = this;
            product.Dock = DockStyle.Fill;
            product.Show();

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            resetWarna();
            pnlNavStaff.BackColor = Color.HotPink;
            closeForm();
            btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnStaff.Enabled = false;
            staff = new Staff();
            staff.MdiParent = this;
            staff.Dock = DockStyle.Fill; 
            staff.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            
            resetWarna();
            pnlNavCust.BackColor = Color.HotPink;
            closeForm();
            btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnCustomer.Enabled = false;
            customer = new Customer();
            customer.MdiParent = this;
            customer.Dock = DockStyle.Fill;
            customer.Show();
        }
         
        private void btnTransaction_Click(object sender, EventArgs e) 
        {
             
            resetWarna();
            pnlNavTrans.BackColor = Color.HotPink;
            closeForm();
            btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnTransaction.Enabled = false;
            trans = new TransactionList(staffID);
            trans.MdiParent = this;
            trans.Dock = DockStyle.Fill;
            trans.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            resetWarna();
            pnlNavOrder.BackColor = Color.HotPink;
            closeForm();
            btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            btnOrder.Enabled = false;
            order = new Order(staffID);
            order.MdiParent = this;
            order.Dock = DockStyle.Fill;
            order.Show();
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

