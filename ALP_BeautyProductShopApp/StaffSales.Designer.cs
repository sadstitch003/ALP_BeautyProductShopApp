﻿
namespace ALP_BeautyProductShopApp
{
    partial class StaffSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSales));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.dgv_StaffSales = new System.Windows.Forms.DataGridView();
            this.tBox_Position = new System.Windows.Forms.TextBox();
            this.tBox_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tBox_staffID = new System.Windows.Forms.TextBox();
            this.lbl_staffID = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(2, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(528, 74);
            this.lbl_Title.TabIndex = 119;
            this.lbl_Title.Text = "Staff Sales History";
            // 
            // dgv_StaffSales
            // 
            this.dgv_StaffSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_StaffSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StaffSales.Location = new System.Drawing.Point(12, 223);
            this.dgv_StaffSales.Name = "dgv_StaffSales";
            this.dgv_StaffSales.RowHeadersWidth = 51;
            this.dgv_StaffSales.RowTemplate.Height = 24;
            this.dgv_StaffSales.Size = new System.Drawing.Size(840, 440);
            this.dgv_StaffSales.TabIndex = 117;
            this.dgv_StaffSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StaffSales_CellContentClick);
            // 
            // tBox_Position
            // 
            this.tBox_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Position.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tBox_Position.Location = new System.Drawing.Point(582, 124);
            this.tBox_Position.Name = "tBox_Position";
            this.tBox_Position.Size = new System.Drawing.Size(270, 28);
            this.tBox_Position.TabIndex = 116;
            // 
            // tBox_Phone
            // 
            this.tBox_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Phone.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tBox_Phone.Location = new System.Drawing.Point(582, 170);
            this.tBox_Phone.Name = "tBox_Phone";
            this.tBox_Phone.Size = new System.Drawing.Size(270, 28);
            this.tBox_Phone.TabIndex = 115;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_Phone.Location = new System.Drawing.Point(481, 173);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(62, 21);
            this.lbl_Phone.TabIndex = 114;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Position
            // 
            this.lbl_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_Position.Location = new System.Drawing.Point(481, 127);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(72, 21);
            this.lbl_Position.TabIndex = 113;
            this.lbl_Position.Text = "Position";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tBox_Name.Location = new System.Drawing.Point(165, 170);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(292, 28);
            this.tBox_Name.TabIndex = 112;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_Name.Location = new System.Drawing.Point(27, 173);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 21);
            this.lbl_Name.TabIndex = 111;
            this.lbl_Name.Text = "Name";
            // 
            // tBox_staffID
            // 
            this.tBox_staffID.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tBox_staffID.Location = new System.Drawing.Point(165, 124);
            this.tBox_staffID.Name = "tBox_staffID";
            this.tBox_staffID.Size = new System.Drawing.Size(89, 28);
            this.tBox_staffID.TabIndex = 109;
            // 
            // lbl_staffID
            // 
            this.lbl_staffID.AutoSize = true;
            this.lbl_staffID.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lbl_staffID.Location = new System.Drawing.Point(23, 124);
            this.lbl_staffID.Name = "lbl_staffID";
            this.lbl_staffID.Size = new System.Drawing.Size(70, 21);
            this.lbl_staffID.TabIndex = 107;
            this.lbl_staffID.Text = "Staff ID";
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(792, 18);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(60, 40);
            this.BtnExit.TabIndex = 118;
            this.BtnExit.TabStop = false;
            this.BtnExit.UseVisualStyleBackColor = false;
            // 
            // StaffSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(864, 675);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.dgv_StaffSales);
            this.Controls.Add(this.tBox_Position);
            this.Controls.Add(this.tBox_Phone);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Position);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tBox_staffID);
            this.Controls.Add(this.lbl_staffID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffSales";
            this.Text = "StaffSales";
            this.Load += new System.EventHandler(this.StaffSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView dgv_StaffSales;
        private System.Windows.Forms.TextBox tBox_Position;
        private System.Windows.Forms.TextBox tBox_Phone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tBox_staffID;
        private System.Windows.Forms.Label lbl_staffID;
    }
}