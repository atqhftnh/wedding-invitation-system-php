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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 adminMain = new Form4();
            adminMain.ShowDialog();
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string message = "To uninvite any guest, simply click on the guest's cell";
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

                dr.Close();
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

                dgvInvite.Rows.Clear();

                while (dr.Read())
                {
                    string inviteeID = dr["I_ID"].ToString();
                    string inviteeName = dr["I_Name"].ToString();
                    string phoneNum = dr["I_Phone"].ToString();
                    string relay = dr["I_Relay"].ToString();

                    dgvInvite.Rows.Add(inviteeID, inviteeName, phoneNum, relay);
                }

                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
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

        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cbxTable.SelectedItem.ToString();
            populateDGV(selectedTable);
        }

        private void styleDGV()
        {
            dgvInvite.Columns["c1"].Width = 90;
            dgvInvite.Columns["c2"].Width = 260;
            dgvInvite.Columns["c3"].Width = 101;
            dgvInvite.Columns["c4"].Width = 80;

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchItem = txtSearch.Text.Trim();

            if(!string.IsNullOrEmpty(searchItem) )
            {
                foreach(DataGridViewRow row in dgvInvite.Rows)
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
                foreach (DataGridViewRow row in dgvInvite.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void deleteInvitee(string inviteeID)
        {
            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            string query = "DELETE FROM InviteeDB WHERE I_ID = @InviteeID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@InviteeID", inviteeID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Invitee deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete invitee.");
                    }

                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvInvite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string message = "Are you sure to uninvite this Guest?";
                string title = "Uninvite Guest";

                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvInvite.Rows[e.RowIndex];

                    string inviteeID = row.Cells["c1"].Value.ToString();

                    deleteInvitee(inviteeID);

                    string selectedTable = cbxTable.SelectedItem.ToString();
                    populateDGV(selectedTable);

                }

                else
                {
                    return;
                }                
            }

            else
            {
                MessageBox.Show("Please select a Guest to uninvite.");
            }
        }

        private void btnMRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 mulDelete = new Form12();
            mulDelete.ShowDialog();
            this.Close();
        }
    }
}
