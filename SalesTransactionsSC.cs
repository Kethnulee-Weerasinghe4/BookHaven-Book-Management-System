using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class SalesTransactionsSC : Form
    {
        private PrintDocument printDoc = new PrintDocument();

        public SalesTransactionsSC()
        {
            InitializeComponent();
            LoadTransactions();
        }
        private void LoadTransactions()
        {
            string query = "SELECT * FROM Transactions";
            dgvtransactions.DataSource = DB.GetDataTable(query);
        }

        private void SalesTransactionsSC_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal unitPrice = decimal.Parse(txtunitprice.Text);
                decimal discount = decimal.Parse(txtdiscount.Text);
                decimal total = unitPrice - discount;
                txttotal.Text = total.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Invalid numeric input.");
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Transactions 
                (TransactionId, UserId, BookId, UnitPrice, Discount, Total)
                VALUES (@tid, @uid, @bid, @price, @discount, @total)";

            SqlParameter[] p =
            {
                new SqlParameter("@tid", txttransactionid.Text),
                new SqlParameter("@uid", txtuserid.Text),
                new SqlParameter("@bid", txtbookid.Text),
                new SqlParameter("@price", txtunitprice.Text),
                new SqlParameter("@discount", txtdiscount.Text),
                new SqlParameter("@total", txttotal.Text)
            };

            DB.Execute(query, p);
            LoadTransactions();
            MessageBox.Show("Transaction recorded.");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttransactionid.Text))
            {
                MessageBox.Show("Select a transaction to delete.");
                return;
            }

            string query = "DELETE FROM Transactions WHERE TransactionId=@tid";
            SqlParameter p = new SqlParameter("@tid", txttransactionid.Text);

            DB.Execute(query, new SqlParameter[] { p });
            LoadTransactions();
            MessageBox.Show("Transaction deleted.");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txttransactionid.Clear();
            txtuserid.Clear();
            txtbookid.Clear();
            txtunitprice.Clear();
            txtdiscount.Clear();
            txttotal.Clear();
        }


        private void btnprint_Click(object sender, EventArgs e)
        {

            printDoc.PrintPage += PrintDoc_PrintPage;
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {

            float y = 20;
            Font f = new Font("Arial", 12);

            e.Graphics.DrawString("=== SALES RECEIPT ===", f, Brushes.Black, 20, y); y += 30;
            e.Graphics.DrawString("Transaction ID: " + txttransactionid.Text, f, Brushes.Black, 20, y); y += 20;
            e.Graphics.DrawString("User ID: " + txtuserid.Text, f, Brushes.Black, 20, y); y += 20;
            e.Graphics.DrawString("Book ID: " + txtbookid.Text, f, Brushes.Black, 20, y); y += 20;
            e.Graphics.DrawString("Unit Price: " + txtunitprice.Text, f, Brushes.Black, 20, y); y += 20;
            e.Graphics.DrawString("Discount: " + txtdiscount.Text, f, Brushes.Black, 20, y); y += 20;
            e.Graphics.DrawString("Total: " + txttotal.Text, f, Brushes.Black, 20, y); y += 30;
            e.Graphics.DrawString("Thank you for your purchase!", f, Brushes.Black, 20, y);
        }
        private void dgvtransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txttransactionid.Text = dgvtransactions.Rows[e.RowIndex].Cells["TransactionId"].Value.ToString();
                txtuserid.Text = dgvtransactions.Rows[e.RowIndex].Cells["UserId"].Value.ToString();
                txtbookid.Text = dgvtransactions.Rows[e.RowIndex].Cells["BookId"].Value.ToString();
                txtunitprice.Text = dgvtransactions.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                txtdiscount.Text = dgvtransactions.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
                txttotal.Text = dgvtransactions.Rows[e.RowIndex].Cells["Total"].Value.ToString();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new SalesClerkDashboard().Show();
            this.Hide();
        }
    }
}
