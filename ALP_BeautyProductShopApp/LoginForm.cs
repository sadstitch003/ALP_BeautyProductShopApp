﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_BeautyProductShopApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainMenu form = new FormMainMenu();
            form.Show();
        }
    }
}
