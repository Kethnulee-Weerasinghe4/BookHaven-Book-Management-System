namespace BookHaven
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnrestock = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnsalestransactions = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btninventory = new System.Windows.Forms.Button();
            this.btnsuppliers = new System.Windows.Forms.Button();
            this.btncustomers = new System.Windows.Forms.Button();
            this.btnusers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnrestock);
            this.panel1.Controls.Add(this.btnreports);
            this.panel1.Controls.Add(this.btnsalestransactions);
            this.panel1.Controls.Add(this.btnorders);
            this.panel1.Controls.Add(this.btninventory);
            this.panel1.Controls.Add(this.btnsuppliers);
            this.panel1.Controls.Add(this.btncustomers);
            this.panel1.Controls.Add(this.btnusers);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 415);
            this.panel1.TabIndex = 0;
            // 
            // btnrestock
            // 
            this.btnrestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btnrestock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrestock.Location = new System.Drawing.Point(28, 302);
            this.btnrestock.Name = "btnrestock";
            this.btnrestock.Size = new System.Drawing.Size(149, 25);
            this.btnrestock.TabIndex = 14;
            this.btnrestock.Text = "Restock Management";
            this.btnrestock.UseVisualStyleBackColor = false;
            this.btnrestock.Click += new System.EventHandler(this.btnrestock_Click);
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreports.Location = new System.Drawing.Point(28, 343);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(149, 25);
            this.btnreports.TabIndex = 13;
            this.btnreports.Text = "Reports";
            this.btnreports.UseVisualStyleBackColor = false;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnsalestransactions
            // 
            this.btnsalestransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btnsalestransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalestransactions.Location = new System.Drawing.Point(28, 261);
            this.btnsalestransactions.Name = "btnsalestransactions";
            this.btnsalestransactions.Size = new System.Drawing.Size(149, 25);
            this.btnsalestransactions.TabIndex = 12;
            this.btnsalestransactions.Text = "Sales Transactions";
            this.btnsalestransactions.UseVisualStyleBackColor = false;
            this.btnsalestransactions.Click += new System.EventHandler(this.btnsalestransactions_Click);
            // 
            // btnorders
            // 
            this.btnorders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnorders.Location = new System.Drawing.Point(28, 219);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(149, 25);
            this.btnorders.TabIndex = 11;
            this.btnorders.Text = "Order Management";
            this.btnorders.UseVisualStyleBackColor = false;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
            // 
            // btninventory
            // 
            this.btninventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btninventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninventory.Location = new System.Drawing.Point(28, 178);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(149, 25);
            this.btninventory.TabIndex = 10;
            this.btninventory.Text = "Inventory Management";
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // btnsuppliers
            // 
            this.btnsuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btnsuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuppliers.Location = new System.Drawing.Point(28, 137);
            this.btnsuppliers.Name = "btnsuppliers";
            this.btnsuppliers.Size = new System.Drawing.Size(149, 25);
            this.btnsuppliers.TabIndex = 9;
            this.btnsuppliers.Text = "Supplier Management";
            this.btnsuppliers.UseVisualStyleBackColor = false;
            this.btnsuppliers.Click += new System.EventHandler(this.btnsuppliers_Click);
            // 
            // btncustomers
            // 
            this.btncustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btncustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncustomers.Location = new System.Drawing.Point(28, 96);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Size = new System.Drawing.Size(149, 25);
            this.btncustomers.TabIndex = 8;
            this.btncustomers.Text = "Customer Management";
            this.btncustomers.UseVisualStyleBackColor = false;
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // btnusers
            // 
            this.btnusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btnusers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnusers.Location = new System.Drawing.Point(28, 55);
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(149, 25);
            this.btnusers.TabIndex = 7;
            this.btnusers.Text = "User Management";
            this.btnusers.UseVisualStyleBackColor = false;
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalSales);
            this.panel2.Controls.Add(this.lblTotalOrders);
            this.panel2.Controls.Add(this.lblTotalCustomers);
            this.panel2.Controls.Add(this.lblTotalBooks);
            this.panel2.Location = new System.Drawing.Point(276, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 239);
            this.panel2.TabIndex = 1;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Location = new System.Drawing.Point(744, 374);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(78, 25);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBooks.Location = new System.Drawing.Point(21, 41);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(108, 24);
            this.lblTotalBooks.TabIndex = 0;
            this.lblTotalBooks.Text = "Total Books";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.Location = new System.Drawing.Point(248, 41);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(146, 24);
            this.lblTotalCustomers.TabIndex = 1;
            this.lblTotalCustomers.Text = "Total Customers";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(26, 117);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(114, 24);
            this.lblTotalOrders.TabIndex = 2;
            this.lblTotalOrders.Text = "Total Orders";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(248, 117);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(102, 24);
            this.lblTotalSales.TabIndex = 3;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btninventory;
        private System.Windows.Forms.Button btnsuppliers;
        private System.Windows.Forms.Button btncustomers;
        private System.Windows.Forms.Button btnusers;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnsalestransactions;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnrestock;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalOrders;
    }
}