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
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }
        void LoadOrders()
        {
            dgvorders.DataSource = DB.GetDataTable("SELECT * FROM Orders");
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DB.Execute(
                "INSERT INTO Orders (customerid, orderdate, status, totalamount, paymentstatus) " +
                "VALUES (@cid, @od, @st, @ta, @ps)",
                new SqlParameter("@cid", txtcustomerid.Text.Trim()),
                new SqlParameter("@od", dtporderdate.Value),
                new SqlParameter("@st", cmbstatus.Text.Trim()),
                new SqlParameter("@ta", txttotalamount.Text.Trim()),
                new SqlParameter("@ps", cmbpaymentstatus.Text.Trim())
            );

            MessageBox.Show("Order added");
            LoadOrders();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtorderid.Text == "")
            {
                MessageBox.Show("Select an order to update");
                return;
            }

            DB.Execute(
                "UPDATE Orders SET customerid=@cid, orderdate=@od, status=@st, totalamount=@ta, " +
                "paymentstatus=@ps WHERE orderid=@id",
                new SqlParameter("@cid", txtcustomerid.Text.Trim()),
                new SqlParameter("@od", dtporderdate.Value),
                new SqlParameter("@st", cmbstatus.Text.Trim()),
                new SqlParameter("@ta", txttotalamount.Text.Trim()),
                new SqlParameter("@ps", cmbpaymentstatus.Text.Trim()),
                new SqlParameter("@id", txtorderid.Text.Trim())
            );

            MessageBox.Show("Order updated");
            LoadOrders();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtorderid.Text == "")
            {
                MessageBox.Show("Select an order to delete");
                return;
            }

            DialogResult d = MessageBox.Show(
                "Delete this order?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (d == DialogResult.No) return;

            DB.Execute(
                "DELETE FROM Orders WHERE orderid=@id",
                new SqlParameter("@id", txtorderid.Text.Trim())
            );

            MessageBox.Show("Order deleted");
            LoadOrders();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtorderid.Clear();
            txtcustomerid.Clear();
            txttotalamount.Clear();
            cmbstatus.SelectedIndex = -1;
            cmbpaymentstatus.SelectedIndex = -1;
            dtporderdate.Value = DateTime.Now;
        }

        private void dgvorders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtorderid.Text = dgvorders.Rows[e.RowIndex].Cells["orderid"].Value.ToString();
                txtcustomerid.Text = dgvorders.Rows[e.RowIndex].Cells["customerid"].Value.ToString();
                dtporderdate.Value = Convert.ToDateTime(dgvorders.Rows[e.RowIndex].Cells["orderdate"].Value);
                cmbstatus.Text = dgvorders.Rows[e.RowIndex].Cells["status"].Value.ToString();
                txttotalamount.Text = dgvorders.Rows[e.RowIndex].Cells["totalamount"].Value.ToString();
                cmbpaymentstatus.Text = dgvorders.Rows[e.RowIndex].Cells["paymentstatus"].Value.ToString();
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }
    }
}
