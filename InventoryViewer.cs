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
    public partial class InventoryViewer : Form
    {
        public InventoryViewer()
        {
            InitializeComponent();
            ConfigureGrid();
            LoadInventory();
        }
        private void ConfigureGrid()
        {
            dgvbooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvbooks.ReadOnly = true;
            dgvbooks.AllowUserToAddRows = false;
            dgvbooks.AllowUserToDeleteRows = false;
            dgvbooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvbooks.MultiSelect = false;
            dgvbooks.RowHeadersVisible = false;
        }

        private void LoadInventory()
        {
            string query = "SELECT bookid, title, author, genre, isbn, stockquantity, price FROM Books";
            dgvbooks.DataSource = DB.GetDataTable(query);
        }
        private void InventoryViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
