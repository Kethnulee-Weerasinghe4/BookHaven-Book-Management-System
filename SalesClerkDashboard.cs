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
    public partial class SalesClerkDashboard : Form
    {
        public SalesClerkDashboard()
        {
            InitializeComponent();
            LoadMetrics();

        }

        private void LoadMetrics()
        {
            try
            {
                lblTotalSales.Text = DB.GetDataTable("SELECT ISNULL(SUM(Total),0) AS Total FROM SalesTransactions").Rows[0]["Total"].ToString();
                lblTotalOrders.Text = DB.GetDataTable("SELECT COUNT(*) AS Count FROM Orders").Rows[0]["Count"].ToString();
                lblTotalCustomers.Text = DB.GetDataTable("SELECT COUNT(*) AS Count FROM Customers").Rows[0]["Count"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard metrics: " + ex.Message);
            }
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            new CustomerManagementSC().Show();
            this.Hide();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            new InventoryViewer().Show();
            this.Hide();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            new OrderManagementSC().Show();
            this.Hide();
        }

        private void btnsalestransactions_Click(object sender, EventArgs e)
        {
            new SalesTransactionsSC().Show();
            this.Hide();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            new ReportsSC().Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void SalesClerkDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
