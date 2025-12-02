using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class ReportsSC : Form
    {
        public ReportsSC()
        {
            InitializeComponent();
            ConfigureGrid();
        }

        private void ReportsSC_Load(object sender, EventArgs e)
        {
            cmbreporttype.Items.Add("Sales Transactions");
            cmbreporttype.Items.Add("Orders");
            cmbreporttype.Items.Add("Customers");
            cmbreporttype.Items.Add("Inventory");
            cmbreporttype.Items.Add("Restock Logs");
        }

        private void LoadReport()
        {
            string query = "";   
            string selected = cmbreporttype.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selected))
            {
                dgv.DataSource = null;
                return;
            }

            switch (selected)
            {
                case "Sales":
                    query = "SELECT transactionid, userid, bookid, unitprice, discount, total, date FROM Transactions";
                    break;

                case "Inventory":
                    query = "SELECT bookid, title, author, genre, isbn, price, stockquantity FROM Books";
                    break;

                case "Customers":
                    query = "SELECT customerid, fullname, email, contactno FROM Customers";
                    break;

                case "Orders":
                    query = "SELECT orderid, customerid, orderdate, status, totalamount, paymentstatus FROM Orders";
                    break;

                case "Restock":
                    query = "SELECT restockid, bookid, supplierid, quantity, costprice, date FROM Restock";
                    break;

                case "Users":
                    query = "SELECT userid, username, fullname, email, role FROM Users";
                    break;

                default:
                    dgv.DataSource = null;
                    return;
            }

            dgv.DataSource = DB.GetDataTable(query);  
        }



        PrintDocument printDoc = new PrintDocument();
        int rowIndex = 0;
        private void btnprint_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No data to print.");
                return;
            }

            rowIndex = 0;
            printDoc.PrintPage += PrintDoc_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.ShowDialog();
        }


            private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font f = new Font("Arial", 10);
            int y = 20;

            e.Graphics.DrawString("Report: " + cmbreporttype.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 20, y);
            y += 40;

            int colX = 20;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, f, Brushes.Black, colX, y);
                colX += 150;
            }

            y += 25;
            colX = 20;

            while (rowIndex < dgv.Rows.Count)
            {
                DataGridViewRow row = dgv.Rows[rowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value?.ToString(), f, Brushes.Black, colX, y);
                    colX += 150;
                }

                y += 25;
                colX = 20;

                rowIndex++;

                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        void ConfigureGrid()
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new SalesClerkDashboard().Show();
            this.Hide();
        }

        private void cmbreporttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();

        }
    }
}
