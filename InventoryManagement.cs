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
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }

        void LoadBooks()
        {
            dgvbooks.DataSource = DB.GetDataTable("SELECT * FROM Books");
        }
        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DB.Execute(
                   "INSERT INTO Books (title, author, genre, isbn, stockquantity, price) " +
                   "VALUES (@tt, @au, @gn, @is, @sq, @pr)",
                   new SqlParameter("@tt", txttitle.Text.Trim()),
                   new SqlParameter("@au", txtauthor.Text.Trim()),
                   new SqlParameter("@gn", txtgenre.Text.Trim()),
                   new SqlParameter("@is", txtisbn.Text.Trim()),
                   new SqlParameter("@sq", txtstockquantity.Text.Trim()),
                   new SqlParameter("@pr", txtprice.Text.Trim()) );

            MessageBox.Show("Book added");
            LoadBooks();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (txtbookid.Text == "")
            {
                MessageBox.Show("Select a book to update");
                return;
            }

            DB.Execute(
                "UPDATE Books SET title=@tt, author=@au, genre=@gn, isbn=@is, " +
                "stockquantity=@sq, price=@pr WHERE bookid=@id",
                new SqlParameter("@tt", txttitle.Text.Trim()),
                new SqlParameter("@au", txtauthor.Text.Trim()),
                new SqlParameter("@gn", txtgenre.Text.Trim()),
                new SqlParameter("@is", txtisbn.Text.Trim()),
                new SqlParameter("@sq", txtstockquantity.Text.Trim()),
                new SqlParameter("@pr", txtprice.Text.Trim()),
                new SqlParameter("@id", txtbookid.Text.Trim())
            );

            MessageBox.Show("Book updated");
            LoadBooks();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtbookid.Text == "")
            {
                MessageBox.Show("Select a book to delete");
                return;
            }

            DialogResult d = MessageBox.Show(
                "Delete this book?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (d == DialogResult.No) return;

            DB.Execute(
                "DELETE FROM Books WHERE bookid=@id",
                new SqlParameter("@id", txtbookid.Text.Trim())
            );

            MessageBox.Show("Book deleted");
            LoadBooks();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbookid.Clear();
            txttitle.Clear();
            txtauthor.Clear();
            txtgenre.Clear();
            txtisbn.Clear();
            txtstockquantity.Clear();
            txtprice.Clear();
        }

        private void dgvbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtbookid.Text = dgvbooks.Rows[e.RowIndex].Cells["bookid"].Value.ToString();
                txttitle.Text = dgvbooks.Rows[e.RowIndex].Cells["title"].Value.ToString();
                txtauthor.Text = dgvbooks.Rows[e.RowIndex].Cells["author"].Value.ToString();
                txtgenre.Text = dgvbooks.Rows[e.RowIndex].Cells["genre"].Value.ToString();
                txtisbn.Text = dgvbooks.Rows[e.RowIndex].Cells["isbn"].Value.ToString();
                txtstockquantity.Text = dgvbooks.Rows[e.RowIndex].Cells["stockquantity"].Value.ToString();
                txtprice.Text = dgvbooks.Rows[e.RowIndex].Cells["price"].Value.ToString();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }
    }
}
