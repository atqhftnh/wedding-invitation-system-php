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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblGoGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 guestPage = new Form1();
            guestPage.ShowDialog();
            this.Close();
        }

        private void lblGoGuest_MouseHover(object sender, EventArgs e)
        {
            lblGoGuest.ForeColor = Color.Red;
        }

        private void lblGoGuest_MouseLeave(object sender, EventArgs e)
        {
            lblGoGuest.ForeColor = Color.Blue;
        }

        private void btnALog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 adminMain = new Form4();
            adminMain.ShowDialog();
            this.Close();
        }
    }
}
