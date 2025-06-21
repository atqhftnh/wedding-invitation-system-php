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
    public partial class Form9 : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";


        public Form9()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Create an empty DataTable with the same schema as the database table
                    DataTable changes = dt.GetChanges();

                    if (changes != null)
                    {
                        foreach (DataRow row in changes.Rows)
                        {
                            if (row.RowState == DataRowState.Modified)
                            {
                                // Update command
                                string updateQuery = "UPDATE InviteeDB SET I_Name = @Name, I_Phone = @Phone, I_Relay = @Relay WHERE I_ID = @ID";

                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
                                {
                                    updateCommand.Parameters.AddWithValue("@Name", row["Guest Name"]);
                                    updateCommand.Parameters.AddWithValue("@Phone", row["Phone Number"]);
                                    updateCommand.Parameters.AddWithValue("@Relay", row["Relationship"]);
                                    updateCommand.Parameters.AddWithValue("@ID", row["Guest ID"]);

                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                        }

                        // Accept changes in the DataTable to clear the 'modified' flag
                        changes.AcceptChanges();
                    }

                    MessageBox.Show("Information Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating information: " + ex.Message);
            }

            styleDGV();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 singleUpdate = new Form8();
            singleUpdate.ShowDialog();
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string message = "To change table of any invitee, please do in Single Update.";
            string title = "Notice";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);

            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            string query = "SELECT C_IC FROM ClientDB";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbxClientList.Items.Add(dr[0].ToString());
                }

                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in putting data into ComboBox.");
            }

            styleDGV();
        }

        private void populateDGV(string selectedTable)
        {
            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            string query = "SELECT I_ID AS 'Guest ID', I_Name AS 'Guest Name', I_Phone AS 'Phone Number', I_Relay AS 'Relationship' FROM InviteeDB WHERE I_ID LIKE @inviteePrefix";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                string clientWedID = lblWedID.Text;

                string tableID = "T" + selectedTable;
                string inviteePrefix = clientWedID + "-" + tableID;

                cmd.Parameters.AddWithValue("@inviteePrefix", inviteePrefix + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                dt = new DataTable();
                dt.Load(dr);

                dgvInvite.DataSource = dt;

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error populating DataGridView: " + ex.Message);
            }

            styleDGV();
        }


        private void cbxClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClientIC = cbxClientList.SelectedItem.ToString();

            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            //To update name based on selected cbxClientList
            string query1 = "SELECT C_Name FROM ClientDB WHERE C_IC = @C_IC";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query1, conn);

                cmd.Parameters.AddWithValue("@C_IC", selectedClientIC);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblClientName.Text = dr[0].ToString();
                }
                else
                {
                    lblClientName.Text = "Client not found";
                }

                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error. Couldn't retrieve data from database.");
            }

            //To update the cbxTable, number of table based on the selected Client IC
            string query2 = "SELECT C_MaxInvitee FROM ClientDB WHERE C_IC = @C_IC";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query2, conn);

                cmd.Parameters.AddWithValue("@C_IC", selectedClientIC);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int x = int.Parse(dr[0].ToString());

                    int y = x / 10;

                    for (int i = 1; i <= y; i++)
                    {
                        cbxTable.Items.Add(i.ToString());
                    }
                }
                else
                {
                    cbxTable.Text = "Data not found";
                }

                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error. Couldn't retrieve data from database.");
            }

            //To update wedID based on selected Client IC
            string query3 = "SELECT C_WedID FROM ClientDB WHERE C_IC = @C_IC";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query3, conn);

                cmd.Parameters.AddWithValue("@C_IC", selectedClientIC);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblWedID.Text = dr[0].ToString();
                }
                else
                {
                    lblWedID.Text = "Client not found";
                }

                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error. Couldn't retrieve data from database.");
            }
        }

        private void styleDGV()
        {
            dgvInvite.BorderStyle = BorderStyle.None;
            dgvInvite.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvInvite.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvInvite.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvInvite.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvInvite.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInvite.EnableHeadersVisualStyles = false;
            dgvInvite.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvInvite.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvInvite.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10);
            dgvInvite.DefaultCellStyle.Font = new Font("Times New Roman", 10);
        }

        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cbxTable.SelectedItem?.ToString();

            populateDGV(selectedTable);
        }
    }
}
