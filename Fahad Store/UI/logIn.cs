using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahad_Store.UI
{
    public partial class logIn : Form
    {
        private dashBoard db;

        public dashBoard Db
        {
            get { return db; }
            set { db = value; }
        }

        private adminPanel ap;

        public adminPanel Ap
        {
            get { return ap; }
            set { ap = value; }
        }
        public logIn()
        {
            InitializeComponent();
        }

        public logIn(dashBoard db)
        {
            InitializeComponent();
            this.Db = db;
        }

        public logIn(adminPanel ap)
        {
            InitializeComponent();
            this.Ap = ap;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            OpenAdminPanel();
        }

        private void OpenAdminPanel()
        {
            var admin = new adminPanel(this);
            admin.Show();
            this.Hide();
        }

        private void createAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var create = new createAccount(this);
            create.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Db.Show();
        }

        private void logIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
