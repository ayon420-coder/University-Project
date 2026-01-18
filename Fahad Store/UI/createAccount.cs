using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Fahad_Store.UI
{
    public partial class createAccount : Form
    {
        private dashBoard db;
        public dashBoard Db1
        {
            get { return db; }
            set { db = value; }
        }

        private logIn ln;

        private logIn Ln
        {
            get { return ln; }
            set { ln = value; }
        }
        public createAccount()
        {
            InitializeComponent();
        }

        

        public createAccount(logIn ln)
        {
            InitializeComponent();
            this.Ln = ln;
        }

        private void crtAccBtn_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ln.Show();
        }

        private void createAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
