namespace ALP_BeautyProductShopApp
{
    partial class TransactionList
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvTransList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewTrans = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Transaction List";
            // 
            // dgvTransList
            // 
            this.dgvTransList.AllowUserToAddRows = false;
            this.dgvTransList.AllowUserToDeleteRows = false;
            this.dgvTransList.AllowUserToResizeRows = false;
            this.dgvTransList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransList.Location = new System.Drawing.Point(28, 194);
            this.dgvTransList.Name = "dgvTransList";
            this.dgvTransList.RowHeadersWidth = 51;
            this.dgvTransList.RowTemplate.Height = 24;
            this.dgvTransList.Size = new System.Drawing.Size(845, 386);
            this.dgvTransList.TabIndex = 8;
            this.dgvTransList.SelectionChanged += new System.EventHandler(this.dgvTransList_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(28, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 1);
            this.panel1.TabIndex = 6;
            // 
            // btnNewTrans
            // 
            this.btnNewTrans.BackColor = System.Drawing.Color.LightCoral;
            this.btnNewTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTrans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewTrans.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTrans.ForeColor = System.Drawing.Color.White;
            this.btnNewTrans.Location = new System.Drawing.Point(28, 71);
            this.btnNewTrans.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewTrans.Name = "btnNewTrans";
            this.btnNewTrans.Size = new System.Drawing.Size(141, 29);
            this.btnNewTrans.TabIndex = 0;
            this.btnNewTrans.Text = "New Transaction";
            this.btnNewTrans.UseVisualStyleBackColor = false;
            this.btnNewTrans.Click += new System.EventHandler(this.btnNewTrans_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(334, 71);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.LightCoral;
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetails.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(181, 71);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(6);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(141, 29);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "View Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightCoral;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(309, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 28);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnTrash
            // 
            this.btnTrash.BackColor = System.Drawing.Color.LightCoral;
            this.btnTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrash.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrash.ForeColor = System.Drawing.Color.White;
            this.btnTrash.Location = new System.Drawing.Point(487, 72);
            this.btnTrash.Margin = new System.Windows.Forms.Padding(6);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(141, 28);
            this.btnTrash.TabIndex = 4;
            this.btnTrash.Text = "Trash";
            this.btnTrash.UseVisualStyleBackColor = false;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(28, 151);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(275, 28);
            this.tbSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(24, 131);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(37, 17);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Filter";
            // 
            // TransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnTrash);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvTransList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnNewTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionList";
            this.Text = "TransactionList";
            this.Load += new System.EventHandler(this.TransactionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewTrans;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvTransList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}