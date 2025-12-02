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
    public partial class SignIn : Form
    {
        SqlConnection con = new SqlConnection("Data Source = KETHNULEE; Initial Catalog = BookHavenDB; Integrated Security = True");


        public SignIn()
        {
            InitializeComponent();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter username and password");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT role FROM Users WHERE username=@username AND password=@password", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                object roleObj = cmd.ExecuteScalar();

                if (roleObj == null)
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }

                string role = roleObj.ToString().ToLower();

                this.Hide();

                if (role == "admin")
                {
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                }
                else if (role == "salesclerk")
                {
                    SalesClerkDashboard clerk = new SalesClerkDashboard();
                    clerk.Show();
                }
                else
                {
                    MessageBox.Show("unknown role");
                    this.Show();
                }
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
            new SignUp().Show();
            this.Hide();
        }
    }

}
  
