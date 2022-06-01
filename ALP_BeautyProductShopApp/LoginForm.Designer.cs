namespace ALP_BeautyProductShopApp
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbStaffID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ALP_BeautyProductShopApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // TbStaffID
            // 
            this.TbStaffID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbStaffID.Location = new System.Drawing.Point(158, 359);
            this.TbStaffID.Name = "TbStaffID";
            this.TbStaffID.Size = new System.Drawing.Size(202, 28);
            this.TbStaffID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // TbPassword
            // 
            this.TbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TbPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(158, 394);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(202, 28);
            this.TbPassword.TabIndex = 6;
            // 
            // BtnLogin
            // 
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(285, 433);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 35);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(180)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbStaffID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbStaffID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnLogin;
    }
}

