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
    public partial class RestockManagement : Form
    {
        public RestockManagement()
        {
            InitializeComponent();
        }

        void LoadRestocks()
        {
            dgv.DataSource = DB.GetDataTable("SELECT * FROM Restocks");
        }
        private void RestockManagement_Load(object sender, EventArgs e)
        {
            LoadRestocks();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DB.Execute(
                "INSERT INTO Restocks (bookid, quantity, costprice, supplierid, restockdate) " +
                "VALUES (@bid, @qt, @cp, @sid, @dt)",
                new SqlParameter("@bid", txtbookid.Text.Trim()),
                new SqlParameter("@qt", txtquantity.Text.Trim()),
                new SqlParameter("@cp", txtcostprice.Text.Trim()),
                new SqlParameter("@sid", txtsupplierid.Text.Trim()),
                new SqlParameter("@dt", dtp.Value)
            );

            MessageBox.Show("Restock entry added");
            LoadRestocks();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtrestockid.Text == "")
            {
                MessageBox.Show("Select a restock record to update");
                return;
            }

            DB.Execute(
                "UPDATE Restocks SET bookid=@bid, quantity=@qt, costprice=@cp, " +
                "supplierid=@sid, restockdate=@dt WHERE restockid=@id",
                new SqlParameter("@bid", txtbookid.Text.Trim()),
                new SqlParameter("@qt", txtquantity.Text.Trim()),
                new SqlParameter("@cp", txtcostprice.Text.Trim()),
                new SqlParameter("@sid", txtsupplierid.Text.Trim()),
                new SqlParameter("@dt", dtp.Value),
                new SqlParameter("@id", txtrestockid.Text.Trim())
            );

            MessageBox.Show("Restock entry updated");
            LoadRestocks();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtrestockid.Text == "")
            {
                MessageBox.Show("Select a restock entry to delete");
                return;
            }

            if (MessageBox.Show("Delete this restock record?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No) return;

            DB.Execute(
                "DELETE FROM Restocks WHERE restockid=@id",
                new SqlParameter("@id", txtrestockid.Text.Trim())
            );

            MessageBox.Show("Restock entry deleted");
            LoadRestocks();
            btnclear.PerformClick();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtrestockid.Clear();
            txtbookid.Clear();
            txtquantity.Clear();
            txtcostprice.Clear();
            txtsupplierid.Clear();
            dtp.Value = DateTime.Now;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtrestockid.Text = dgv.Rows[e.RowIndex].Cells["restockid"].Value.ToString();
                txtbookid.Text = dgv.Rows[e.RowIndex].Cells["bookid"].Value.ToString();
                txtquantity.Text = dgv.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
                txtcostprice.Text = dgv.Rows[e.RowIndex].Cells["costprice"].Value.ToString();
                txtsupplierid.Text = dgv.Rows[e.RowIndex].Cells["supplierid"].Value.ToString();
                dtp.Value = Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["restockdate"].Value);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }
    }
}
