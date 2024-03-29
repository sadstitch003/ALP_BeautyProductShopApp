﻿namespace ALP_BeautyProductShopApp
{
    partial class NewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lCreateOrder = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lOrderID = new System.Windows.Forms.Label();
            this.lSupplierID = new System.Windows.Forms.Label();
            this.lOrderDate = new System.Windows.Forms.Label();
            this.lStaffID = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lNetTotal = new System.Windows.Forms.Label();
            this.lTax = new System.Windows.Forms.Label();
            this.lDiscount = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbDiscountPercentage = new System.Windows.Forms.TextBox();
            this.tbDiscountAmount = new System.Windows.Forms.TextBox();
            this.tbTaxPercentage = new System.Windows.Forms.TextBox();
            this.tbTaxTotal = new System.Windows.Forms.TextBox();
            this.tbNetTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lProdID = new System.Windows.Forms.Label();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.lQty = new System.Windows.Forms.Label();
            this.nudProdQty = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvProductOrder = new System.Windows.Forms.DataGridView();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.LightCoral;
            this.pnlBorder.Controls.Add(this.BtnExit);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlBorder.Size = new System.Drawing.Size(800, 35);
            this.pnlBorder.TabIndex = 47;
            this.pnlBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBorder_MouseMove);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(740, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(60, 30);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(795, 35);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel3.Size = new System.Drawing.Size(5, 524);
            this.panel3.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2.Size = new System.Drawing.Size(5, 524);
            this.panel2.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCoral;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 554);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel4.Size = new System.Drawing.Size(790, 5);
            this.panel4.TabIndex = 53;
            // 
            // lCreateOrder
            // 
            this.lCreateOrder.AutoSize = true;
            this.lCreateOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCreateOrder.Location = new System.Drawing.Point(24, 52);
            this.lCreateOrder.Name = "lCreateOrder";
            this.lCreateOrder.Size = new System.Drawing.Size(123, 21);
            this.lCreateOrder.TabIndex = 54;
            this.lCreateOrder.Text = "Create Order";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnCreateOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateOrder.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrder.Location = new System.Drawing.Point(647, 45);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(111, 25);
            this.btnCreateOrder.TabIndex = 67;
            this.btnCreateOrder.Text = "Create";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lOrderID
            // 
            this.lOrderID.AutoSize = true;
            this.lOrderID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrderID.Location = new System.Drawing.Point(24, 94);
            this.lOrderID.Name = "lOrderID";
            this.lOrderID.Size = new System.Drawing.Size(72, 20);
            this.lOrderID.TabIndex = 68;
            this.lOrderID.Text = "Order ID";
            // 
            // lSupplierID
            // 
            this.lSupplierID.AutoSize = true;
            this.lSupplierID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSupplierID.Location = new System.Drawing.Point(24, 129);
            this.lSupplierID.Name = "lSupplierID";
            this.lSupplierID.Size = new System.Drawing.Size(86, 20);
            this.lSupplierID.TabIndex = 69;
            this.lSupplierID.Text = "Supplier ID";
            // 
            // lOrderDate
            // 
            this.lOrderDate.AutoSize = true;
            this.lOrderDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrderDate.Location = new System.Drawing.Point(24, 203);
            this.lOrderDate.Name = "lOrderDate";
            this.lOrderDate.Size = new System.Drawing.Size(45, 20);
            this.lOrderDate.TabIndex = 70;
            this.lOrderDate.Text = "Date";
            // 
            // lStaffID
            // 
            this.lStaffID.AutoSize = true;
            this.lStaffID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStaffID.Location = new System.Drawing.Point(24, 167);
            this.lStaffID.Name = "lStaffID";
            this.lStaffID.Size = new System.Drawing.Size(61, 20);
            this.lStaffID.TabIndex = 71;
            this.lStaffID.Text = "Staff ID";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(425, 98);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(42, 20);
            this.lTotal.TabIndex = 72;
            this.lTotal.Text = "Total";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Enabled = false;
            this.tbOrderID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderID.Location = new System.Drawing.Point(164, 90);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(201, 28);
            this.tbOrderID.TabIndex = 73;
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(164, 129);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(201, 25);
            this.cbSupplierID.TabIndex = 80;
            this.cbSupplierID.SelectedIndexChanged += new System.EventHandler(this.cbSupplierID_SelectedIndexChanged);
            // 
            // tbStaffID
            // 
            this.tbStaffID.Enabled = false;
            this.tbStaffID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffID.Location = new System.Drawing.Point(164, 163);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.Size = new System.Drawing.Size(201, 28);
            this.tbStaffID.TabIndex = 81;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderDate.Location = new System.Drawing.Point(164, 203);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 23);
            this.dtpOrderDate.TabIndex = 82;
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // lNetTotal
            // 
            this.lNetTotal.AutoSize = true;
            this.lNetTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNetTotal.Location = new System.Drawing.Point(425, 203);
            this.lNetTotal.Name = "lNetTotal";
            this.lNetTotal.Size = new System.Drawing.Size(72, 20);
            this.lNetTotal.TabIndex = 83;
            this.lNetTotal.Text = "Net Total";
            // 
            // lTax
            // 
            this.lTax.AutoSize = true;
            this.lTax.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTax.Location = new System.Drawing.Point(425, 167);
            this.lTax.Name = "lTax";
            this.lTax.Size = new System.Drawing.Size(31, 20);
            this.lTax.TabIndex = 84;
            this.lTax.Text = "Tax";
            // 
            // lDiscount
            // 
            this.lDiscount.AutoSize = true;
            this.lDiscount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiscount.Location = new System.Drawing.Point(425, 129);
            this.lDiscount.Name = "lDiscount";
            this.lDiscount.Size = new System.Drawing.Size(72, 20);
            this.lDiscount.TabIndex = 85;
            this.lDiscount.Text = "Discount";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(549, 94);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTotal.Size = new System.Drawing.Size(201, 28);
            this.tbTotal.TabIndex = 86;
            this.tbTotal.Text = "0";
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // tbDiscountPercentage
            // 
            this.tbDiscountPercentage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscountPercentage.Location = new System.Drawing.Point(549, 129);
            this.tbDiscountPercentage.Name = "tbDiscountPercentage";
            this.tbDiscountPercentage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDiscountPercentage.Size = new System.Drawing.Size(69, 28);
            this.tbDiscountPercentage.TabIndex = 87;
            this.tbDiscountPercentage.Text = "0";
            this.tbDiscountPercentage.TextChanged += new System.EventHandler(this.tbDiscountPercentage_TextChanged);
            // 
            // tbDiscountAmount
            // 
            this.tbDiscountAmount.Enabled = false;
            this.tbDiscountAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscountAmount.Location = new System.Drawing.Point(624, 129);
            this.tbDiscountAmount.Name = "tbDiscountAmount";
            this.tbDiscountAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDiscountAmount.Size = new System.Drawing.Size(126, 28);
            this.tbDiscountAmount.TabIndex = 88;
            // 
            // tbTaxPercentage
            // 
            this.tbTaxPercentage.Enabled = false;
            this.tbTaxPercentage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxPercentage.Location = new System.Drawing.Point(549, 167);
            this.tbTaxPercentage.Name = "tbTaxPercentage";
            this.tbTaxPercentage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTaxPercentage.Size = new System.Drawing.Size(69, 28);
            this.tbTaxPercentage.TabIndex = 89;
            this.tbTaxPercentage.Text = "10";
            // 
            // tbTaxTotal
            // 
            this.tbTaxTotal.Enabled = false;
            this.tbTaxTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxTotal.Location = new System.Drawing.Point(624, 167);
            this.tbTaxTotal.Name = "tbTaxTotal";
            this.tbTaxTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTaxTotal.Size = new System.Drawing.Size(126, 28);
            this.tbTaxTotal.TabIndex = 90;
            // 
            // tbNetTotal
            // 
            this.tbNetTotal.Enabled = false;
            this.tbNetTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNetTotal.Location = new System.Drawing.Point(549, 199);
            this.tbNetTotal.Name = "tbNetTotal";
            this.tbNetTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbNetTotal.Size = new System.Drawing.Size(201, 28);
            this.tbNetTotal.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 92;
            this.label9.Text = "Product";
            // 
            // lProdID
            // 
            this.lProdID.AutoSize = true;
            this.lProdID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProdID.Location = new System.Drawing.Point(30, 288);
            this.lProdID.Name = "lProdID";
            this.lProdID.Size = new System.Drawing.Size(87, 20);
            this.lProdID.TabIndex = 93;
            this.lProdID.Text = "Product ID";
            // 
            // tbProductID
            // 
            this.tbProductID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductID.Location = new System.Drawing.Point(133, 284);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(170, 28);
            this.tbProductID.TabIndex = 94;
            // 
            // lQty
            // 
            this.lQty.AutoSize = true;
            this.lQty.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQty.Location = new System.Drawing.Point(330, 288);
            this.lQty.Name = "lQty";
            this.lQty.Size = new System.Drawing.Size(71, 20);
            this.lQty.TabIndex = 95;
            this.lQty.Text = "Quantity";
            // 
            // nudProdQty
            // 
            this.nudProdQty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProdQty.Location = new System.Drawing.Point(407, 285);
            this.nudProdQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProdQty.Name = "nudProdQty";
            this.nudProdQty.Size = new System.Drawing.Size(60, 28);
            this.nudProdQty.TabIndex = 96;
            this.nudProdQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(570, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 28);
            this.btnAdd.TabIndex = 97;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(672, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 28);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvProductOrder
            // 
            this.dgvProductOrder.AllowUserToAddRows = false;
            this.dgvProductOrder.AllowUserToDeleteRows = false;
            this.dgvProductOrder.AllowUserToResizeRows = false;
            this.dgvProductOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOrder.Location = new System.Drawing.Point(32, 368);
            this.dgvProductOrder.Name = "dgvProductOrder";
            this.dgvProductOrder.RowHeadersWidth = 51;
            this.dgvProductOrder.RowTemplate.Height = 24;
            this.dgvProductOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductOrder.Size = new System.Drawing.Size(744, 168);
            this.dgvProductOrder.TabIndex = 99;
            this.dgvProductOrder.SelectionChanged += new System.EventHandler(this.dgvProductOrder_SelectionChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(133, 318);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPrice.Size = new System.Drawing.Size(170, 28);
            this.tbPrice.TabIndex = 101;
            this.tbPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Price";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightCoral;
            this.panel5.Location = new System.Drawing.Point(28, 270);
            this.panel5.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 1);
            this.panel5.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(28, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 1);
            this.panel1.TabIndex = 102;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudProdQty);
            this.Controls.Add(this.lQty);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.lProdID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNetTotal);
            this.Controls.Add(this.tbTaxTotal);
            this.Controls.Add(this.tbTaxPercentage);
            this.Controls.Add(this.tbDiscountAmount);
            this.Controls.Add(this.tbDiscountPercentage);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lDiscount);
            this.Controls.Add(this.lTax);
            this.Controls.Add(this.lNetTotal);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.tbStaffID);
            this.Controls.Add(this.cbSupplierID);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lStaffID);
            this.Controls.Add(this.lOrderDate);
            this.Controls.Add(this.lSupplierID);
            this.Controls.Add(this.lOrderID);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.lCreateOrder);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewOrder";
            this.pnlBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudProdQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lCreateOrder;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label lOrderID;
        private System.Windows.Forms.Label lSupplierID;
        private System.Windows.Forms.Label lOrderDate;
        private System.Windows.Forms.Label lStaffID;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.ComboBox cbSupplierID;
        private System.Windows.Forms.TextBox tbStaffID;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lNetTotal;
        private System.Windows.Forms.Label lTax;
        private System.Windows.Forms.Label lDiscount;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbDiscountPercentage;
        private System.Windows.Forms.TextBox tbDiscountAmount;
        private System.Windows.Forms.TextBox tbTaxPercentage;
        private System.Windows.Forms.TextBox tbTaxTotal;
        private System.Windows.Forms.TextBox tbNetTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lProdID;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label lQty;
        private System.Windows.Forms.NumericUpDown nudProdQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProductOrder;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}