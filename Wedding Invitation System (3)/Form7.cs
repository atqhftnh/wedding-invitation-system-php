using System;
using System.Collections;
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
    public partial class Form7 : Form
    {
        SqlDataAdapter da;
        DataTable dt;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            populateDGV();

            styleDGV();
        }

        private void populateDGV()
        {
            string connString = "Data Source=ATQHFTNH\\SQLEXPRESS;Initial Catalog=\"Wedding Invitation System\";Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False";
            SqlConnection conn = new SqlConnection(connString);

            string query = "SELECT C_IC AS 'IC Number', C_Name AS 'Client Name', C_Pass AS 'Password', C_Date AS 'Wedding Date', C_MaxInvitee AS 'Max. Invitation', C_WedID AS 'Wedding ID' FROM ClientDB";
            da = new SqlDataAdapter(query, conn);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                dt = new DataTable();
                dt.Load(dr);

                dgvInvite.DataSource = dt;

                conn.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error populating DataGridView: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 adminMain = new Form4();
            adminMain.ShowDialog();
            this.Close();
        }

        private void styleDGV()
        {
            dgvInvite.Columns["IC Number"].Width = 100;
            dgvInvite.Columns["Client Name"].Width = 200;
            dgvInvite.Columns["Password"].Width = 80;
            dgvInvite.Columns["Wedding Date"].Width = 80;
            dgvInvite.Columns["Max. Invitation"].Width = 80;
            dgvInvite.Columns["Wedding ID"].Width = 90;
            dgvInvite.ColumnHeadersHeight = 35;

            dgvInvite.Columns["Wedding Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInvite.Columns["Wedding Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInvite.Columns["Max. Invitation"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInvite.Columns["Max. Invitation"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInvite.Columns["Wedding ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
