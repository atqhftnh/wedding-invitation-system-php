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
    public partial class Form5 : Form
    {
        private bool fixedID = false;

        public Form5()
        {
            InitializeComponent();
            cbxTable.SelectedIndexChanged += cbxTable_SelectedIndexChanged;
            txtName.TextChanged += txtName_TextChanged;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string password = txtPass.Text;

            if (!checkPassword(password)) 
            {
                return;
            }

            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            string query = "INSERT INTO [ClientDB] VALUES (@C_IC, @C_Name, @C_Pass, @C_Date, @C_MaxInvitee, @C_WedID)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@C_IC", txtIC.Text);
                cmd.Parameters.AddWithValue("@C_Name", txtName.Text);
                cmd.Parameters.AddWithValue("@C_Pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@C_Date", SqlDbType.Date).Value = dtpWedding.Value.Date;
                cmd.Parameters.AddWithValue("@C_MaxInvitee", lblMax.Text);
                cmd.Parameters.AddWithValue("@C_WedID", lblWedID.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("New Client Added Successfully");

                clearForm();
            }

            catch(SqlException ex)
            {
                MessageBox.Show("Input Error. Failed Adding New Client.");
            }
        }

        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMaxTotalLabel();
        }

        private void UpdateMaxTotalLabel()
        {
            if(cbxTable.SelectedIndex >= 0)
            {
                int x = int.Parse(cbxTable.SelectedItem.ToString());
                int maxTotal = x * 10;
                lblMax.Text = maxTotal.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 adminMain = new Form4();
            adminMain.ShowDialog();
            this.Close();
        }

        private bool checkPassword(string password)
        {
            if(password.Length < 8)
            {
                MessageBox.Show("Your password must be at least 8 characters long.");
                txtPass.Focus();
                txtPass.SelectAll();
                return false;
            }

            if(!password.Any(char.IsUpper))
            {
                MessageBox.Show("Your password must have at least 1 uppercase.");
                txtPass.Focus();
                txtPass.SelectAll();
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Your password must have at least 1 lowercase.");
                txtPass.Focus();
                txtPass.SelectAll();
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Your password must have at least 1 digit number.");
                txtPass.Focus();
                txtPass.SelectAll();
                return false;
            }

            return true;
        }

        private void clearForm()
        {
            txtName.Clear();
            txtPass.Clear();
            txtIC.Clear();
            lblMax.Text = "";
            dtpWedding.ResetText();
            cbxTable.Text = "Select Here";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (name.Length >= 2)
            {
                string wedPrefix = name.Substring(0, 2).ToUpper();

                if (!fixedID)
                {
                    lblWedID.Text = wedPrefix + generateRandomID();
                    fixedID = true;
                }
                else
                {
                    lblWedID.Text = wedPrefix + lblWedID.Text.Substring(2);
                }
            }

            else
            {
                fixedID = false;
            }
        }

        private string generateRandomID()
        {
            Random rdm = new Random();
            int digit = rdm.Next(100, 999);

            return digit.ToString();
        }
    }
}