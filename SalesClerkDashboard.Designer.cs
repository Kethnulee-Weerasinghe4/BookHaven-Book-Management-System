namespace BookHaven
{
    partial class SalesClerkDashboard
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnsalestransactions = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btninventory = new System.Windows.Forms.Button();
            this.btncustomers = new System.Windows.Forms.Button();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Location = new System.Drawing.Point(744, 374);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(78, 25);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalSales);
            this.panel2.Controls.Add(this.lblTotalOrders);
            this.panel2.Controls.Add(this.lblTotalCustomers);
            this.panel2.Location = new System.Drawing.Point(276, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 239);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnreports);
            this.panel1.Controls.Add(this.btnsalestransactions);
            this.panel1.Controls.Add(this.btnorders);
            this.panel1.Controls.Add(this.btninventory);
            this.panel1.Controls.Add(this.btncustomers);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 415);
            this.panel1.TabIndex = 10;
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreports.Location = new System.Drawing.Point(27, 277);
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
            this.btnsalestransactions.Location = new System.Drawing.Point(27, 236);
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
            this.btnorders.Location = new System.Drawing.Point(27, 194);
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
            this.btninventory.Location = new System.Drawing.Point(27, 153);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(149, 25);
            this.btninventory.TabIndex = 10;
            this.btninventory.Text = "Inventory Viewer";
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // btncustomers
            // 
            this.btncustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(57)))), ((int)(((byte)(138)))));
            this.btncustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncustomers.Location = new System.Drawing.Point(27, 112);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Size = new System.Drawing.Size(149, 25);
            this.btncustomers.TabIndex = 8;
            this.btncustomers.Text = "Customer Management";
            this.btncustomers.UseVisualStyleBackColor = false;
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(59, 68);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(102, 24);
            this.lblTotalSales.TabIndex = 7;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(175, 140);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(114, 24);
            this.lblTotalOrders.TabIndex = 6;
            this.lblTotalOrders.Text = "Total Orders";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.Location = new System.Drawing.Point(281, 68);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(146, 24);
            this.lblTotalCustomers.TabIndex = 5;
            this.lblTotalCustomers.Text = "Total Customers";
            // 
            // SalesClerkDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SalesClerkDashboard";
            this.Load += new System.EventHandler(this.SalesClerkDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnsalestransactions;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btninventory;
        private System.Windows.Forms.Button btncustomers;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalCustomers;
    }
}