using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wedding_Invitation_System
{
    public partial class Form12 : Form
    {
        SqlDataAdapter da;
        DataTable dt;

        public Form12()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string message = "Are you sure to uninvite this Guest?";
            string title = "Uninvite Guest";

            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult action = MessageBox.Show(message, title, button, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (action == DialogResult.Yes)
            {
                string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
                SqlConnection conn = new SqlConnection(connString);

                List<string> selectedItem = new List<string>();
                DataGridViewRow drow = new DataGridViewRow();

                for (int i = 0; i <= dgvInvite.Rows.Count - 1; i++)
                {
                    drow = dgvInvite.Rows[i];
                    if (Convert.ToBoolean(drow.Cells[4].Value) == true)
                    {
                        string id = drow.Cells[0].Value.ToString();
                        selectedItem.Add(id);
                    }
                }
                conn.Open();

                foreach (string s in selectedItem)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM InviteeDB WHERE I_ID = '" + s + "'", conn);
                    int result = cmd.ExecuteNonQuery();
                }
                conn.Close();

                dgvInvite.Rows.Clear();

                string selectedTable = cbxTable.SelectedItem?.ToString();
                populateDGV(selectedTable);
            }

            else
            {
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 adminMain = new Form4();
            adminMain.ShowDialog();
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            dgvInvite.ReadOnly = false;

            foreach (DataGridViewRow row in dgvInvite.Rows)
            {
                row.Cells["checkboxColumn"].Value = false;
            }

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
                MessageBox.Show("Error populating DataGridView: " + ex.Message);
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
            string selectedTable = cbxTable.SelectedItem?.ToString();

            populateDGV(selectedTable);
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
    }
}
