
namespace ALP_BeautyProductShopApp
{
    partial class Staff
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
            this.btn_ViewSales = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tBox_Search = new System.Windows.Forms.TextBox();
            this.dgv_Staff = new System.Windows.Forms.DataGridView();
            this.cBox_Position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dTP_dob = new System.Windows.Forms.DateTimePicker();
            this.tBox_Phone = new System.Windows.Forms.TextBox();
            this.tBox_Password = new System.Windows.Forms.TextBox();
            this.tBox_StaffName = new System.Windows.Forms.TextBox();
            this.tBox_StaffID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ViewSales
            // 
            this.btn_ViewSales.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_ViewSales.Location = new System.Drawing.Point(319, 181);
            this.btn_ViewSales.Name = "btn_ViewSales";
            this.btn_ViewSales.Size = new System.Drawing.Size(110, 31);
            this.btn_ViewSales.TabIndex = 199;
            this.btn_ViewSales.Text = "View";
            this.btn_ViewSales.UseVisualStyleBackColor = true;
            this.btn_ViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_Delete.Location = new System.Drawing.Point(461, 181);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 31);
            this.btn_Delete.TabIndex = 198;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_Update.Location = new System.Drawing.Point(169, 181);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 31);
            this.btn_Update.TabIndex = 197;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_Save.Location = new System.Drawing.Point(18, 181);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 31);
            this.btn_Save.TabIndex = 196;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btn_Search.Location = new System.Drawing.Point(714, 240);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 32);
            this.btn_Search.TabIndex = 202;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // tBox_Search
            // 
            this.tBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Search.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tBox_Search.Location = new System.Drawing.Point(18, 240);
            this.tBox_Search.Name = "tBox_Search";
            this.tBox_Search.Size = new System.Drawing.Size(686, 28);
            this.tBox_Search.TabIndex = 201;
            // 
            // dgv_Staff
            // 
            this.dgv_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Staff.Location = new System.Drawing.Point(18, 293);
            this.dgv_Staff.Name = "dgv_Staff";
            this.dgv_Staff.RowHeadersWidth = 51;
            this.dgv_Staff.RowTemplate.Height = 24;
            this.dgv_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Staff.Size = new System.Drawing.Size(806, 311);
            this.dgv_Staff.TabIndex = 200;
            this.dgv_Staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Staff_CellContentClick);
            this.dgv_Staff.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Staff_CellEnter);
            // 
            // cBox_Position
            // 
            this.cBox_Position.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Position.FormattingEnabled = true;
            this.cBox_Position.Location = new System.Drawing.Point(493, 76);
            this.cBox_Position.Name = "cBox_Position";
            this.cBox_Position.Size = new System.Drawing.Size(211, 28);
            this.cBox_Position.TabIndex = 220;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 219;
            this.label6.Text = "Position";
            // 
            // dTP_dob
            // 
            this.dTP_dob.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_dob.Location = new System.Drawing.Point(493, 127);
            this.dTP_dob.Name = "dTP_dob";
            this.dTP_dob.Size = new System.Drawing.Size(211, 26);
            this.dTP_dob.TabIndex = 218;
            // 
            // tBox_Phone
            // 
            this.tBox_Phone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Phone.Location = new System.Drawing.Point(131, 127);
            this.tBox_Phone.Name = "tBox_Phone";
            this.tBox_Phone.Size = new System.Drawing.Size(211, 26);
            this.tBox_Phone.TabIndex = 216;
            // 
            // tBox_Password
            // 
            this.tBox_Password.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Password.Location = new System.Drawing.Point(131, 73);
            this.tBox_Password.Name = "tBox_Password";
            this.tBox_Password.Size = new System.Drawing.Size(211, 26);
            this.tBox_Password.TabIndex = 215;
            // 
            // tBox_StaffName
            // 
            this.tBox_StaffName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_StaffName.Location = new System.Drawing.Point(493, 24);
            this.tBox_StaffName.Name = "tBox_StaffName";
            this.tBox_StaffName.Size = new System.Drawing.Size(211, 26);
            this.tBox_StaffName.TabIndex = 214;
            // 
            // tBox_StaffID
            // 
            this.tBox_StaffID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_StaffID.Location = new System.Drawing.Point(131, 24);
            this.tBox_StaffID.Name = "tBox_StaffID";
            this.tBox_StaffID.Size = new System.Drawing.Size(211, 26);
            this.tBox_StaffID.TabIndex = 212;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 210;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(376, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 209;
            this.label8.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 207;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 206;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 204;
            this.label2.Text = "Staff ID";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(846, 628);
            this.Controls.Add(this.cBox_Position);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dTP_dob);
            this.Controls.Add(this.tBox_Phone);
            this.Controls.Add(this.tBox_Password);
            this.Controls.Add(this.tBox_StaffName);
            this.Controls.Add(this.tBox_StaffID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tBox_Search);
            this.Controls.Add(this.dgv_Staff);
            this.Controls.Add(this.btn_ViewSales);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ViewSales;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tBox_Search;
        private System.Windows.Forms.DataGridView dgv_Staff;
        private System.Windows.Forms.ComboBox cBox_Position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTP_dob;
        private System.Windows.Forms.TextBox tBox_Phone;
        private System.Windows.Forms.TextBox tBox_Password;
        private System.Windows.Forms.TextBox tBox_StaffName;
        private System.Windows.Forms.TextBox tBox_StaffID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}