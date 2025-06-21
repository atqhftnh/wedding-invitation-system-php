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
    public partial class Form11 : Form
    {
        SqlDataAdapter da;
        DataTable dt;

        public Form11()
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

        private void Form11_Load(object sender, EventArgs e)
        {
            populateDGV();

            styleDGV();
        }

        private void populateDGV()
        {
            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            string query = "SELECT I_ID AS 'ID', I_Name AS 'Guest Name' FROM InviteeDB";
            da = new SqlDataAdapter(query, conn);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                dt = new DataTable();
                dt.Load(dr);

                dt.Columns.Add("Client ID", typeof(string));
                dt.Columns.Add("Table", typeof(string));

                foreach(DataRow row in dt.Rows)
                {
                    string guestID = row["ID"].ToString();
                    string clientID = guestID.Substring(0, 5);
                    string table = guestID.Substring(guestID.Length - 3);
                    string table2 = table.Substring(0, 1);

                    row["Client ID"] = clientID;
                    row["Table"] = table2;
                }

                dt.Columns.Add("No.", typeof(int)).SetOrdinal(0);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["No."] = i + 1;
                }

                dgvView.DataSource = dt;

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error populating DataGridView: " + ex.Message);
            }
        }

        private void styleDGV()
        {
            dgvView.Columns["No."].Width = 40;
            dgvView.Columns["ID"].Width = 90;
            dgvView.Columns["Guest Name"].Width = 259;
            dgvView.Columns["Client ID"].Width = 80;
            dgvView.Columns["Table"].Width = 50;

            dgvView.Columns["Client ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvView.Columns["Table"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvView.BorderStyle = BorderStyle.None;
            dgvView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvView.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvView.EnableHeadersVisualStyles = false;
            dgvView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvView .ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvView.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10);
            dgvView.DefaultCellStyle.Font = new Font("Times New Roman", 10);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchItem = txtSearch.Text.Trim().ToLower();

            dt.DefaultView.RowFilter = $"[Guest Name] LIKE '%{searchItem}%'";

            dgvView.DataSource = dt.DefaultView.ToTable();
        }
    }
}