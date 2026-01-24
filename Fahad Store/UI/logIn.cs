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
using System.Xml.Linq;

namespace Fahad_Store.UI
{
    public partial class logIn: Form
    {
        private dashboard db;
        private DataAccess da;

        public DataAccess Da
        {
            get { return da; } 
            set { da = value; }
        }
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
            this.Da = new DataAccess();
        }

        public logIn(dashBoard db)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.Db = db;
        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(passwordTb.Text)) 
            {
                MessageBox.Show("Please enter the username and password!", "Input required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            try
            {
                if (username.Text[0] == 'C')
                {
                    var query = "Select * from Customers Where Customer_Id = '" + username.Text + "' and Password = '" + passwordTb.Text + "'";
                    DataTable dt = new DataTable();
                    dt = Da.ExecuteQueryTable(query);

                    if (dt.Rows.Count != 1)
                    {
                        MessageBox.Show("Invalid username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    string custId = dt.Rows[0]["customer_id"].ToString();
                    MessageBox.Show("Log In Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new shopping(this, custId).Show();
                }
                else if(username.Text[0] == 'A')
                {
                    var query = "Select * from Admins Where Admin_Id = '" + username.Text + "' and Password = '" + passwordTb.Text + "'";
                    DataTable dt = new DataTable();
                    dt = Da.ExecuteQueryTable(query);
                    if (dt.Rows.Count != 1)
                    {
                        MessageBox.Show("Invalid username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string custId = dt.Rows[0]["admin_id"].ToString();
                    MessageBox.Show("Log In Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new adminPanel(this, custId).Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Log In error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
 

