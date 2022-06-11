
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tBox_City = new System.Windows.Forms.TextBox();
            this.cBox_MemberID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_Search.Location = new System.Drawing.Point(761, 283);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(111, 29);
            this.btn_Search.TabIndex = 174;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tBox_Search
            // 
            this.tBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Search.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_Search.Location = new System.Drawing.Point(27, 286);
            this.tBox_Search.Name = "tBox_Search";
            this.tBox_Search.Size = new System.Drawing.Size(590, 23);
            this.tBox_Search.TabIndex = 173;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.AllowUserToAddRows = false;
            this.dgv_Customer.AllowUserToDeleteRows = false;
            this.dgv_Customer.AllowUserToResizeRows = false;
            this.dgv_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Location = new System.Drawing.Point(24, 324);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.RowHeadersWidth = 51;
            this.dgv_Customer.RowTemplate.Height = 24;
            this.dgv_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Customer.Size = new System.Drawing.Size(845, 264);
            this.dgv_Customer.TabIndex = 172;
            this.dgv_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_CellClick);
            this.dgv_Customer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_CellEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label6.Location = new System.Drawing.Point(29, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 196;
            this.label6.Text = "City";
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.LightCoral;
            this.btn_View.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_View.Location = new System.Drawing.Point(289, 251);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(111, 29);
            this.btn_View.TabIndex = 195;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btnViewTrans_Click);
            // 
            // dTP_dob
            // 
            this.dTP_dob.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.dTP_dob.Location = new System.Drawing.Point(530, 207);
            this.dTP_dob.Name = "dTP_dob";
            this.dTP_dob.Size = new System.Drawing.Size(211, 23);
            this.dTP_dob.TabIndex = 194;
            // 
            // tBox_Phone
            // 
            this.tBox_Phone.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_Phone.Location = new System.Drawing.Point(530, 157);
            this.tBox_Phone.Name = "tBox_Phone";
            this.tBox_Phone.Size = new System.Drawing.Size(211, 23);
            this.tBox_Phone.TabIndex = 192;
            // 
            // tBox_Address
            // 
            this.tBox_Address.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_Address.Location = new System.Drawing.Point(530, 115);
            this.tBox_Address.Name = "tBox_Address";
            this.tBox_Address.Size = new System.Drawing.Size(342, 23);
            this.tBox_Address.TabIndex = 191;
            // 
            // tBox_CustName
            // 
            this.tBox_CustName.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_CustName.Location = new System.Drawing.Point(155, 115);
            this.tBox_CustName.Name = "tBox_CustName";
            this.tBox_CustName.Size = new System.Drawing.Size(242, 23);
            this.tBox_CustName.TabIndex = 190;
            // 
            // dTP_memberjoin
            // 
            this.dTP_memberjoin.CustomFormat = " ";
            this.dTP_memberjoin.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.dTP_memberjoin.Location = new System.Drawing.Point(661, 68);
            this.dTP_memberjoin.Name = "dTP_memberjoin";
            this.dTP_memberjoin.Size = new System.Drawing.Size(211, 23);
            this.dTP_memberjoin.TabIndex = 189;
            this.dTP_memberjoin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dTP_memberjoin_KeyDown);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_Delete.Location = new System.Drawing.Point(418, 251);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(111, 29);
            this.btn_Delete.TabIndex = 188;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_Update.Location = new System.Drawing.Point(160, 251);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(111, 29);
            this.btn_Update.TabIndex = 187;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_Save.Location = new System.Drawing.Point(27, 251);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 29);
            this.btn_Save.TabIndex = 186;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tBox_CustID
            // 
            this.tBox_CustID.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_CustID.Location = new System.Drawing.Point(155, 68);
            this.tBox_CustID.Name = "tBox_CustID";
            this.tBox_CustID.Size = new System.Drawing.Size(89, 23);
            this.tBox_CustID.TabIndex = 184;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label9.Location = new System.Drawing.Point(425, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 182;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label8.Location = new System.Drawing.Point(425, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 181;
            this.label8.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label5.Location = new System.Drawing.Point(425, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 179;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 178;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label3.Location = new System.Drawing.Point(522, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 177;
            this.label3.Text = "Membership Join";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label2.Location = new System.Drawing.Point(266, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 176;
            this.label2.Text = "Membership ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 175;
            this.label1.Text = "Customer ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label7.Location = new System.Drawing.Point(29, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 180;
            this.label7.Text = "Email";
            // 
            // tBox_Email
            // 
            this.tBox_Email.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_Email.Location = new System.Drawing.Point(155, 201);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.Size = new System.Drawing.Size(242, 23);
            this.tBox_Email.TabIndex = 193;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(33, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 1);
            this.panel1.TabIndex = 199;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(29, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 23);
            this.lblTitle.TabIndex = 198;
            this.lblTitle.Text = "Customer List";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightCoral;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_clear.Location = new System.Drawing.Point(767, 207);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(111, 29);
            this.btn_clear.TabIndex = 200;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.LightCoral;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btn_refresh.Location = new System.Drawing.Point(630, 283);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(111, 29);
            this.btn_refresh.TabIndex = 201;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tBox_City
            // 
            this.tBox_City.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.tBox_City.Location = new System.Drawing.Point(155, 157);
            this.tBox_City.Name = "tBox_City";
            this.tBox_City.Size = new System.Drawing.Size(242, 23);
            this.tBox_City.TabIndex = 202;
            // 
            // cBox_MemberID
            // 
            this.cBox_MemberID.FormattingEnabled = true;
            this.cBox_MemberID.Location = new System.Drawing.Point(407, 68);
            this.cBox_MemberID.Name = "cBox_MemberID";
            this.cBox_MemberID.Size = new System.Drawing.Size(89, 24);
            this.cBox_MemberID.TabIndex = 203;
            this.cBox_MemberID.SelectedIndexChanged += new System.EventHandler(this.cBox_MemberID_SelectedIndexChanged);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.cBox_MemberID);
            this.Controls.Add(this.tBox_City);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
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
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tBox_Search;
        private System.Windows.Forms.DataGridView dgv_Customer;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox tBox_City;
        private System.Windows.Forms.ComboBox cBox_MemberID;
    }
}