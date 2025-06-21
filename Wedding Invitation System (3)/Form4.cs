using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wedding_Invitation_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 adminPage = new Form2();
            adminPage.ShowDialog();
            this.Close();
        }

        private void lblLogOut_MouseHover(object sender, EventArgs e)
        {
            lblLogOut.ForeColor = Color.Red;
        }

        private void lblLogOut_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.ForeColor = Color.Blue;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 newClient = new Form5();
            newClient.ShowDialog();
            this.Close();
        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 viewClient = new Form7();
            viewClient.ShowDialog();
            this.Close();
        }

        private void btnAddInvite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 addInvitee = new Form6();
            addInvitee.ShowDialog();
            this.Close();
        }

        private void btnUpdateInvite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 updateInvitee = new Form8();
            updateInvitee.ShowDialog();
            this.Close();
        }

        private void btnViewInvite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 viewInvite = new Form11();
            viewInvite.ShowDialog();
            this.Close();
        }

        private void btnRemoveInvite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 deleteInvite = new Form10();
            deleteInvite.ShowDialog();
            this.Close();
        }
    }
}
