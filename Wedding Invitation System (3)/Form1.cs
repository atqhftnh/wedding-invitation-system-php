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

namespace Wedding_Invitation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblGoAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 adminPage = new Form2();
            adminPage.ShowDialog();
            this.Close();
        }

        private void btnRLog_Click(object sender, EventArgs e)
        {
            string clientIC = txtIC.Text;
            string password = txtPass.Text;

            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            string query = "SELECT COUNT(*) FROM ClientDB WHERE C_IC = @ClientIC AND C_Pass = @Password";

            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@ClientIC", clientIC);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        DisplayClientInfo(clientIC);
                    }

                    else
                    {
                        MessageBox.Show("Invalid client IC and/or password. Please try again.");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void validate()
        {
            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            string query = "SELECT COUNT(*) FROM ClientDB WHERE C_IC = @C_IC AND C_Password = @C_Pass";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@C_IC", txtIC.Text);
                cmd.Parameters.AddWithValue("@C_Pass", txtPass.Text);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if(count > 0)
                    {
                        DisplayClientInfo(txtIC.Text);
                    }

                    else
                    {
                        MessageBox.Show("Invalid Client IC or Password");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DisplayClientInfo(string clientIC)
        {
            this.Hide();
            Form3 clientPage = new Form3(clientIC);
            clientPage.ShowDialog();
            this.Close();
        }

        private void lblGoAdmin_MouseHover(object sender, EventArgs e)
        {
            lblGoAdmin.ForeColor = Color.Red;
        }

        private void lblGoAdmin_MouseLeave(object sender, EventArgs e)
        {
            lblGoAdmin.ForeColor= Color.Blue;
        }
    }
}
