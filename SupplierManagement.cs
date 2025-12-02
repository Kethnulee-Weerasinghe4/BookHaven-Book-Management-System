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
    public partial class SupplierManagement : Form
    {
        public SupplierManagement()
        {
            InitializeComponent();
        }

        void LoadSuppliers()
        {
            dgvsuppliers.DataSource = DB.GetDataTable("SELECT * FROM Suppliers");
        }
        private void SupplierManagement_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DB.Execute(
             "INSERT INTO Suppliers (fullname, email, contactno, address) VALUES (@fn, @em, @cn, @ad)",
              new SqlParameter("@fn", txtfullname.Text.Trim()),
              new SqlParameter("@em", txtemail.Text.Trim()),
              new SqlParameter("@cn", txtcontactno.Text.Trim()),
              new SqlParameter("@ad", txtaddress.Text.Trim()));

            MessageBox.Show("Supplier added");
            LoadSuppliers();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtsupplierid.Text == "")
            {
                MessageBox.Show("Select a supplier to update");
                return;
            }

            DB.Execute(
                "UPDATE Suppliers SET fullname=@fn, email=@em, contactno=@cn, address=@ad WHERE supplierid=@id",
                new SqlParameter("@fn", txtfullname.Text.Trim()),
                new SqlParameter("@em", txtemail.Text.Trim()),
                new SqlParameter("@cn", txtcontactno.Text.Trim()),
                new SqlParameter("@ad", txtaddress.Text.Trim()),
                new SqlParameter("@id", txtsupplierid.Text.Trim())
            );

            MessageBox.Show("Supplier updated");
            LoadSuppliers();
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtsupplierid.Text == "")
            {
                MessageBox.Show("Select a supplier to delete");
                return;
            }

            if (MessageBox.Show("Delete this supplier?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DB.Execute(
                "DELETE FROM Suppliers WHERE supplierid=@id",
                new SqlParameter("@id", txtsupplierid.Text.Trim())
            );

            MessageBox.Show("Supplier deleted");
            LoadSuppliers();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsupplierid.Clear();
            txtfullname.Clear();
            txtemail.Clear();
            txtcontactno.Clear();
            txtaddress.Clear();
        }

        private void dgvsuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtsupplierid .Text = dgvsuppliers.Rows[e.RowIndex].Cells["supplierid"].Value.ToString();
                txtfullname.Text = dgvsuppliers.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                txtemail.Text = dgvsuppliers.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtcontactno.Text = dgvsuppliers.Rows[e.RowIndex].Cells["contactno"].Value.ToString();
                txtaddress.Text = dgvsuppliers.Rows[e.RowIndex].Cells["address"].Value.ToString();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }
    }
}
