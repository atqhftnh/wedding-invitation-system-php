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
    public partial class Form3 : Form
    {
        private string selectedClientIC;
        private string selectedTableNumber;

        public Form3(string clientIC)
        {
            InitializeComponent();
            this.selectedClientIC = clientIC;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 guestPage = new Form1();
            guestPage.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblClientIC.Text = this.selectedClientIC;

            displayClientInfo();

            populateTable();

            styleDGV();
        }

        private void displayClientInfo()
        {
            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            string query = "SELECT C_Name, C_WedID FROM ClientDB WHERE C_IC = @C_IC";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@C_IC", selectedClientIC);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblClientName.Text = reader["C_Name"].ToString();
                    lblWedID.Text = reader["C_WedID"].ToString();
                }
                else
                {
                    lblClientName.Text = "Client not found";
                    lblWedID.Text = "Client not found";
                }
            }

            catch(SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void populateTable()
        {
            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            string query = "SELECT C_MaxInvitee FROM ClientDB WHERE C_IC = @C_IC";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@C_IC", selectedClientIC);

                int maxInvitee = (int)cmd.ExecuteScalar();
                int tableCount = maxInvitee / 10;

                for (int i = 1; i <= tableCount; i++)
                {
                    cbxTable.Items.Add(i.ToString());
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void populateInvitee(string selectedTable)
        {
            string clientWedID = lblWedID.Text;

            string tableID = "T" + selectedTable;
            string inviteePrefix = clientWedID + "-" + tableID;

            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            string query = "SELECT * FROM InviteeDB WHERE I_ID LIKE @inviteePrefix";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@inviteePrefix", inviteePrefix + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                dgvList.Rows.Clear();

                while (dr.Read())
                {
                    string inviteeID = dr["I_ID"].ToString();
                    string inviteeName = dr["I_Name"].ToString();
                    string phoneNum = dr["I_Phone"].ToString();
                    string relay = dr["I_Relay"].ToString();

                    dgvList.Rows.Add(inviteeID, inviteeName, phoneNum, relay);
                }

                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cbxTable.SelectedItem.ToString();
            populateInvitee(selectedTable);
        }

        private void styleDGV()
        {
            /*dgvList.Columns["No."].Width = 40;
            dgvList.Columns["ID"].Width = 80;
            dgvList.Columns["Guest Name"].Width = 200;*/

            dgvList.BorderStyle = BorderStyle.None;
            dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvList.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvList.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvList.EnableHeadersVisualStyles = false;
            dgvList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvList.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvList.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10);
            dgvList.DefaultCellStyle.Font = new Font("Times New Roman", 10);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchItem = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchItem))
            {
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    if (row.Cells["c2"].Value != null && row.Cells["c2"].Value.ToString().ToLower().Contains(searchItem.ToLower()))
                    {
                        row.Visible = true;
                    }

                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            else
            {
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}
