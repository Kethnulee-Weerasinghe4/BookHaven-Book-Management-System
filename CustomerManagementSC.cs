using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class CustomerManagementSC : Form
    {
        public CustomerManagementSC()
        {
            InitializeComponent();
        }
        void LoadCustomers()
        {
            dgvcustomers.DataSource = DB.GetDataTable("SELECT * FROM Customers");
        }
        private void CustomerManagementSC_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DB.Execute(
              "INSERT INTO Customers (fullname, email, contactno, address) VALUES (@fn, @em, @cn, @ad)",
               new SqlParameter("@fn", txtfullname.Text.Trim()),
               new SqlParameter("@em", txtemail.Text.Trim()),
               new SqlParameter("@cn", txtcontactno.Text.Trim()),
               new SqlParameter("@ad", txtaddress.Text.Trim()));

            MessageBox.Show("Customer added");
            LoadCustomers();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtcustomerid.Text == "")
            {
                MessageBox.Show("Select a customer to update");
                return;
            }

            DB.Execute(
                "UPDATE Customers SET fullname=@fn, email=@em, contactno=@cn, address=@ad WHERE customerid=@id",
                new SqlParameter("@fn", txtfullname.Text.Trim()),
                new SqlParameter("@em", txtemail.Text.Trim()),
                new SqlParameter("@cn", txtcontactno.Text.Trim()),
                new SqlParameter("@ad", txtaddress.Text.Trim()),
                new SqlParameter("@id", txtcustomerid.Text.Trim())
            );

            MessageBox.Show("Customer updated");
            LoadCustomers();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcustomerid.Clear();
            txtfullname.Clear();
            txtemail.Clear();
            txtcontactno.Clear();
            txtaddress.Clear();
        }

        private void dgvcustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtcustomerid.Text = dgvcustomers.Rows[e.RowIndex].Cells["customerid"].Value.ToString();
                txtfullname.Text = dgvcustomers.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                txtemail.Text = dgvcustomers.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtcontactno.Text = dgvcustomers.Rows[e.RowIndex].Cells["contactno"].Value.ToString();
                txtaddress.Text = dgvcustomers.Rows[e.RowIndex].Cells["address"].Value.ToString();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new SalesClerkDashboard().Show();
            this.Hide();
        }
    }
}
