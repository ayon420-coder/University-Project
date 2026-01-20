using Fahad_Store.UI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Fahad_Store
{
    public partial class dashBoard : Form
    {

        public dashBoard()
        {
            InitializeComponent();
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
            var login = new logIn(this);
            login.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var shopping = new shopping(this);
            shopping.Show();
            this.Hide();
        }

        private void groceryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new shopping("Grocery").Show();
            this.Hide();
        }


        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new shopping("Food").Show();
            this.Hide();
        }

        private void homeAndKitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new shopping("Home & Kitchen").Show();
            this.Hide();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            var shopping = new shopping(this);
            shopping.Show();
            this.Hide();
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
