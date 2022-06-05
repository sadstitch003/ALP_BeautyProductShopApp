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

namespace ALP_BeautyProductShopApp
{
    public partial class FormMainMenu : Form
    {

         
        public FormMainMenu(string staffID)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
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
    }
}

