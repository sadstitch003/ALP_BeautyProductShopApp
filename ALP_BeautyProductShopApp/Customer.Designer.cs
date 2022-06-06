
namespace ALP_BeautyProductShopApp
{
    partial class Customer
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.tBox_Search = new System.Windows.Forms.TextBox();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.cBox_City = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.dTP_dob = new System.Windows.Forms.DateTimePicker();
            this.tBox_Phone = new System.Windows.Forms.TextBox();
            this.tBox_Address = new System.Windows.Forms.TextBox();
            this.tBox_CustName = new System.Windows.Forms.TextBox();
            this.dTP_memberjoin = new System.Windows.Forms.DateTimePicker();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tBox_memberID = new System.Windows.Forms.TextBox();
            this.tBox_CustID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBox_Email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_Search.Location = new System.Drawing.Point(542, 222);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(82, 26);
            this.btn_Search.TabIndex = 174;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // tBox_Search
            // 
            this.tBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tBox_Search.Location = new System.Drawing.Point(18, 222);
            this.tBox_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBox_Search.Name = "tBox_Search";
            this.tBox_Search.Size = new System.Drawing.Size(512, 23);
            this.tBox_Search.TabIndex = 173;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Location = new System.Drawing.Point(18, 263);
            this.dgv_Customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.RowHeadersWidth = 51;
            this.dgv_Customer.RowTemplate.Height = 24;
            this.dgv_Customer.Size = new System.Drawing.Size(607, 275);
            this.dgv_Customer.TabIndex = 172;
            // 
            // cBox_City
            // 
            this.cBox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_City.FormattingEnabled = true;
            this.cBox_City.Location = new System.Drawing.Point(101, 105);
            this.cBox_City.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBox_City.Name = "cBox_City";
            this.cBox_City.Size = new System.Drawing.Size(182, 23);
            this.cBox_City.TabIndex = 197;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 196;
            this.label6.Text = "City";
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_View.Location = new System.Drawing.Point(230, 181);
            this.btn_View.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(82, 25);
            this.btn_View.TabIndex = 195;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btnViewTrans_Click);
            // 
            // dTP_dob
            // 
            this.dTP_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_dob.Location = new System.Drawing.Point(382, 143);
            this.dTP_dob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_dob.Name = "dTP_dob";
            this.dTP_dob.Size = new System.Drawing.Size(159, 21);
            this.dTP_dob.TabIndex = 194;
            // 
            // tBox_Phone
            // 
            this.tBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Phone.Location = new System.Drawing.Point(382, 102);
            this.tBox_Phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBox_Phone.Name = "tBox_Phone";
            this.tBox_Phone.Size = new System.Drawing.Size(159, 21);
            this.tBox_Phone.TabIndex = 192;
            // 
            // tBox_Address
            // 
            this.tBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Address.Location = new System.Drawing.Point(382, 68);
            this.tBox_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBox_Address.Name = "tBox_Address";
            this.tBox_Address.Size = new System.Drawing.Size(258, 21);
            this.tBox_Address.TabIndex = 191;
            // 
            // tBox_CustName
            // 
            this.tBox_CustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_CustName.Location = new System.Drawing.Point(101, 68);
            this.tBox_CustName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBox_CustName.Name = "tBox_CustName";
            this.tBox_CustName.Size = new System.Drawing.Size(182, 21);
            this.tBox_CustName.TabIndex = 190;
            // 
            // dTP_memberjoin
            // 
            this.dTP_memberjoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_memberjoin.Location = new System.Drawing.Point(481, 30);
            this.dTP_memberjoin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_memberjoin.Name = "dTP_memberjoin";
            this.dTP_memberjoin.Size = new System.Drawing.Size(159, 21);
            this.dTP_memberjoin.TabIndex = 189;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Salmon;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(327, 181);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(82, 25);
            this.btn_Delete.TabIndex = 188;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_Update.Location = new System.Drawing.Point(134, 181);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(82, 25);
            this.btn_Update.TabIndex = 187;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_Save.Location = new System.Drawing.Point(34, 181);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 25);
            this.btn_Save.TabIndex = 186;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // tBox_memberID
            // 
            this.tBox_memberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_memberID.Location = new System.Drawing.Point(287, 30);
            this.tBox_memberID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBox_memberID.Name = "tBox_memberID";
            this.tBox_memberID.Size = new System.Drawing.Size(68, 21);
            this.tBox_memberID.TabIndex = 185;
            // 
            // tBox_CustID
            // 
            this.tBox_CustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_CustID.Location = new System.Drawing.Point(101, 30);
            this.tBox_CustID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBox_CustID.Name = "tBox_CustID";
            this.tBox_CustID.Size = new System.Drawing.Size(68, 21);
            this.tBox_CustID.TabIndex = 184;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(304, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 182;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 181;
            this.label8.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 179;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 178;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 177;
            this.label3.Text = "Membership Join";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 176;
            this.label2.Text = "Membership ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 175;
            this.label1.Text = "Customer ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 180;
            this.label7.Text = "Email";
            // 
            // tBox_Email
            // 
            this.tBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Email.Location = new System.Drawing.Point(101, 138);
            this.tBox_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.Size = new System.Drawing.Size(182, 21);
            this.tBox_Email.TabIndex = 193;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(648, 548);
            this.Controls.Add(this.cBox_City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.dTP_dob);
            this.Controls.Add(this.tBox_Email);
            this.Controls.Add(this.tBox_Phone);
            this.Controls.Add(this.tBox_Address);
            this.Controls.Add(this.tBox_CustName);
            this.Controls.Add(this.dTP_memberjoin);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tBox_memberID);
            this.Controls.Add(this.tBox_CustID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tBox_Search);
            this.Controls.Add(this.dgv_Customer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tBox_Search;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.ComboBox cBox_City;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.DateTimePicker dTP_dob;
        private System.Windows.Forms.TextBox tBox_Phone;
        private System.Windows.Forms.TextBox tBox_Address;
        private System.Windows.Forms.TextBox tBox_CustName;
        private System.Windows.Forms.DateTimePicker dTP_memberjoin;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tBox_memberID;
        private System.Windows.Forms.TextBox tBox_CustID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBox_Email;
    }
}