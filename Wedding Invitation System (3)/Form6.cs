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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxTable.SelectedItem == null)
            {
                MessageBox.Show("Please select a table.");
                return;
            }

            string selectedTable = cbxTable.SelectedItem.ToString();
            string clientWedID = lblWedID.Text;

            string tableID = "T" + selectedTable;
            string inviteePrefix = clientWedID + "-" + tableID;

            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                string query1 = "SELECT COUNT(*) FROM InviteeDB WHERE I_ID LIKE @inviteePrefix";
                SqlCommand countCmd = new SqlCommand(query1, conn);
                countCmd.Parameters.AddWithValue("@inviteePrefix", inviteePrefix + "%");

                int inviteeCount = (int)countCmd.ExecuteScalar();

                if (inviteeCount >= 10)
                {
                    MessageBox.Show("Table " + selectedTable + " is full. Please select other table.");
                    return;
                }

                string inviteeID = "";

                string query2 = "SELECT MAX(CAST(SUBSTRING(I_ID, LEN(@inviteePrefix) + 1, LEN(I_ID)) AS INT)) FROM InviteeDB WHERE I_ID LIKE @inviteePrefix";
                SqlCommand maxInviteeNumberCmd = new SqlCommand(query2, conn);
                maxInviteeNumberCmd.Parameters.AddWithValue("@inviteePrefix", inviteePrefix);

                object result = maxInviteeNumberCmd.ExecuteScalar();

                int nextInviteeNumber = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;

                while (true)
                {
                    inviteeID = inviteePrefix + nextInviteeNumber.ToString().PadLeft(2, '0');

                    string checkExistingIDQuery = "SELECT COUNT(*) FROM InviteeDB WHERE I_ID = @inviteeID";
                    SqlCommand checkExistingIDCmd = new SqlCommand(checkExistingIDQuery, conn);
                    checkExistingIDCmd.Parameters.AddWithValue("@inviteeID", inviteeID);

                    int existingCount = (int)checkExistingIDCmd.ExecuteScalar();

                    if (existingCount == 0)
                    {
                        break;
                    }
                    else
                    {
                        nextInviteeNumber++;
                    }
                }

                string query3 = "INSERT INTO [InviteeDB] VALUES (@I_ID, @I_Name, @I_Phone, @I_Relay)";
                SqlCommand cmd = new SqlCommand(query3, conn);

                cmd.Parameters.AddWithValue("@I_ID", inviteeID);
                cmd.Parameters.AddWithValue("@I_Name", txtGuestName.Text);
                cmd.Parameters.AddWithValue("@I_Phone", txtGuestPhone.Text);
                cmd.Parameters.AddWithValue("@I_Relay", cbxGuestRelay.Text);

                int rowAffect = cmd.ExecuteNonQuery();

                MessageBox.Show(rowAffect + " Invitee added to Table " + selectedTable);

                conn.Close();

                populateDGV(selectedTable);
                clearForm();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 adminMain = new Form4();
            adminMain.ShowDialog();
            this.Close();
        }

        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cbxTable.SelectedItem.ToString();
            populateDGV(selectedTable);
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

                dgvAddInvite.Rows.Clear();

                while(dr.Read())
                {
                    string inviteeID = dr["I_ID"].ToString();
                    string inviteeName = dr["I_Name"].ToString();
                    string phoneNum = dr["I_Phone"].ToString();
                    string relay = dr["I_Relay"].ToString();

                    dgvAddInvite.Rows.Add(inviteeID, inviteeName, phoneNum, relay);
                }

                conn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void styleDGV()
        {
            dgvAddInvite.Columns["c1"].Width = 90;
            dgvAddInvite.Columns["c2"].Width = 260;
            dgvAddInvite.Columns["c3"].Width = 101;
            dgvAddInvite.Columns["c4"].Width = 80;

            dgvAddInvite.BorderStyle = BorderStyle.None;
            dgvAddInvite.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvAddInvite.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvAddInvite.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvAddInvite.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAddInvite.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAddInvite.EnableHeadersVisualStyles = false;
            dgvAddInvite.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAddInvite.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvAddInvite.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10);
            dgvAddInvite.DefaultCellStyle.Font = new Font("Times New Roman", 10);
        }

        private void clearForm()
        {
            txtGuestName.Clear();
            txtGuestPhone.Clear();
            cbxGuestRelay.Text = " Select Relation";
        }
    }
}