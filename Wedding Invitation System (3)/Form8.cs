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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedTable = cbxTable.SelectedItem.ToString();
            string clientwedID = lblWedID.Text;

            string tableID = "T" + selectedTable;
            string inviteePrefix = clientwedID + "-" + tableID;

            string inviteeID = inviteePrefix + txtGuestID.Text.PadLeft(2, '0');

            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            if(cbxNewTable.SelectedItem != cbxTable.SelectedItem)
            {
                string newSelectedTable = cbxNewTable.SelectedItem.ToString();
                string newTableID = "T" + newSelectedTable;

                string newInviteeID = clientwedID + "-" + newTableID + txtGuestID.Text.PadLeft(2, '0');

                string query1 = "UPDATE [InviteeDB] SET I_ID = @newID, I_Name = @I_Name, I_Phone = @I_Phone, I_Relay = @I_Relay WHERE I_ID = @oldID";

                SqlCommand cmd1 = new SqlCommand(query1, conn);

                cmd1.Parameters.AddWithValue("@newID", newInviteeID);
                cmd1.Parameters.AddWithValue("@oldID", inviteeID);
                cmd1.Parameters.AddWithValue("@I_Name", txtGuestName.Text);
                cmd1.Parameters.AddWithValue("@I_Phone", txtGuestPhone.Text);
                cmd1.Parameters.AddWithValue("@I_Relay", cbxGuestRelay.Text);

                try
                {
                    conn.Open();

                    int rowAffect = cmd1.ExecuteNonQuery();

                    if (rowAffect > 0)
                    {
                        MessageBox.Show("Invitee information updated successfully and moved to new table.");
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated.");
                    }

                    conn.Close();
                }

                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                populateDGV(selectedTable);
                clearForm();
            }

            else
            {
                string query2 = "UPDATE [InviteeDB] SET I_Name = @I_Name, I_Phone = @I_Phone, I_Relay = @I_Relay WHERE I_ID = @I_ID";

                SqlCommand cmd = new SqlCommand(query2, conn);

                cmd.Parameters.AddWithValue("@I_ID", inviteeID);
                cmd.Parameters.AddWithValue("@I_Name", txtGuestName.Text);
                cmd.Parameters.AddWithValue("@I_Phone", txtGuestPhone.Text);
                cmd.Parameters.AddWithValue("@I_Relay", cbxGuestRelay.Text);

                try
                {
                    conn.Open();

                    int rowAffect = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (rowAffect > 0)
                    {
                        MessageBox.Show("Invitee updated successfully.");
                    }

                    else
                    {
                        MessageBox.Show("No rows were updated.");
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                populateDGV(selectedTable);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string message = "This update form is for single update only.\nTo do multi-update, click on button 'Multiple Update' first.";
            string title = "Notice";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);

            dgvInvite.CellClick += dgvInvite_CellClick;

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

        private void dgvInvite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInvite.Rows[e.RowIndex];

                string inviteeID = row.Cells["c1"].Value.ToString();
                string digit = inviteeID.Substring(inviteeID.Length - 2);
                txtGuestID.Text = digit;

                txtGuestName.Text = row.Cells["c2"].Value.ToString();
                txtGuestPhone.Text = row.Cells["c3"].Value.ToString();
                cbxGuestRelay.Text = row.Cells["c4"].Value.ToString();
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 adminMain = new Form4();
            adminMain.ShowDialog();
            this.Close();
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

            //To update the cbxNewTable, number of table based on the selected Client IC
            string query3 = "SELECT C_MaxInvitee FROM ClientDB WHERE C_IC = @C_IC";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query3, conn);

                cmd.Parameters.AddWithValue("@C_IC", selectedClientIC);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int x = int.Parse(dr[0].ToString());

                    int y = x / 10;

                    for (int i = 1; i <= y; i++)
                    {
                        cbxNewTable.Items.Add(i.ToString());
                    }
                }
                else
                {
                    cbxNewTable.Text = "Data not found";
                }

                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error. Couldn't retrieve data from database.");
            }

            //To update wedID based on selected Client IC
            string query4 = "SELECT C_WedID FROM ClientDB WHERE C_IC = @C_IC";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query4, conn);

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

            cbxNewTable.SelectedItem = cbxTable.SelectedItem;
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

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 mulUpdate = new Form9();
            mulUpdate.ShowDialog();
            this.Close();
        }

        private void clearForm()
        {
            txtGuestID.Clear();
            txtGuestName.Clear();
            txtGuestPhone.Clear();
            cbxGuestRelay.Text = "Select Relay";
        }
    }
}
