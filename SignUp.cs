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
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection("Data Source=KETHNULEE;Initial Catalog=BookHavenDB;Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            string fullname = txtfullname.Text.Trim();
            string email = txtemail.Text.Trim();
            string role = cmbrole.Text.Trim().ToLower();

            if (username == "" || password == "" || fullname == "" || email == "" || role == "")
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            try
            {
                con.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE username=@username", con);
                checkCmd.Parameters.AddWithValue("@username", username);
                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists");
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Users (username, password, fullname, email, role) VALUES (@username, @password, @fullname, @email, @role)",
                    con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@fullname", fullname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@role", role);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User created successfully");

                txtusername.Text = "";
                txtpassword.Text = "";
                txtfullname.Text = "";
                txtemail.Text = "";
                cmbrole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }
    }
}

