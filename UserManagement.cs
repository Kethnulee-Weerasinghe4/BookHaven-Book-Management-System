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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        void LoadUsers()
        {
            dgvusers.DataSource = DB.GetDataTable("SELECT * FROM Users");
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DB.Execute(
                  "INSERT INTO Users (username, password, fullname, email, role) " +
                  "VALUES (@un, @pw, @fn, @em, @rl)",
                   new SqlParameter("@un", txtusername.Text.Trim()),
                   new SqlParameter("@pw", txtpassword.Text.Trim()),
                   new SqlParameter("@fn", txtfullname.Text.Trim()),
                   new SqlParameter("@em", txtemail.Text.Trim()),
                   new SqlParameter("@rl", cmbrole.Text.Trim()));

            MessageBox.Show("User added");
            LoadUsers();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text == "")
            {
                MessageBox.Show("Select a user to update");
                return;
            }

            DB.Execute(
                "UPDATE Users SET username=@un, password=@pw, fullname=@fn, email=@em, role=@rl " +
                "WHERE userid=@id",
                new SqlParameter("@un", txtusername.Text.Trim()),
                new SqlParameter("@pw", txtpassword.Text.Trim()),
                new SqlParameter("@fn", txtfullname.Text.Trim()),
                new SqlParameter("@em", txtemail.Text.Trim()),
                new SqlParameter("@rl", cmbrole.Text.Trim()),
                new SqlParameter("@id", txtuserid.Text.Trim()));

            MessageBox.Show("User updated");
            LoadUsers();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text == "")
            {
                MessageBox.Show("Select a user to delete");
                return;
            }

            DialogResult d = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (d == DialogResult.No) return;

            DB.Execute(
                "DELETE FROM Users WHERE userid=@id",
                new SqlParameter("@id", txtuserid.Text.Trim())
            );

            MessageBox.Show("User deleted");
            LoadUsers();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuserid.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtfullname.Clear();
            txtemail.Clear();
            cmbrole.SelectedIndex = -1;
        }

        private void dgvusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtuserid.Text = dgvusers.Rows[e.RowIndex].Cells["userid"].Value.ToString();
                txtusername.Text = dgvusers.Rows[e.RowIndex].Cells["username"].Value.ToString();
                txtpassword.Text = dgvusers.Rows[e.RowIndex].Cells["password"].Value.ToString();
                txtfullname.Text = dgvusers.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                txtemail.Text = dgvusers.Rows[e.RowIndex].Cells["email"].Value.ToString();
                cmbrole.Text = dgvusers.Rows[e.RowIndex].Cells["role"].Value.ToString();
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }
    }
}
