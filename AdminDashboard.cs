using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadMetrics();
        }

        private void LoadMetrics()
        {
            try
            {
                lblTotalBooks.Text = DB.GetDataTable("SELECT COUNT(*) AS Count FROM Books").Rows[0]["Count"].ToString();

                lblTotalCustomers.Text = DB.GetDataTable("SELECT COUNT(*) AS Count FROM Customers").Rows[0]["Count"].ToString();

                lblTotalOrders.Text = DB.GetDataTable("SELECT COUNT(*) AS Count FROM Orders").Rows[0]["Count"].ToString();

                lblTotalSales.Text = DB.GetDataTable("SELECT ISNULL(SUM(Total),0) AS Total FROM SalesTransactions").Rows[0]["Total"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard metrics: " + ex.Message);
            }
        }
        private void btnusers_Click(object sender, EventArgs e)
        {
            new UserManagement().Show();
            this.Hide();
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            new CustomerManagement().Show();
            this.Hide();
        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            new SupplierManagement().Show();
            this.Hide();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            new InventoryManagement().Show();
            this.Hide();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            new OrderManagement().Show();
            this.Hide();
        }

        private void btnsalestransactions_Click(object sender, EventArgs e)
        {
            new SalesTransaction().Show();
            this.Hide();
        }

        private void btnrestock_Click(object sender, EventArgs e)
        {
            new RestockManagement().Show();
            this.Hide();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            new Reports().Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
