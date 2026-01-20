using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Fahad_Store.UI
{
    public partial class createAccount : Form
    {
        private dashBoard db;
        private DataAccess da;

        public DataAccess Da
        {
            get { return da; }
            set { da = value; }
        }
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
            this.Da = new DataAccess();

        }

        public createAccount(logIn ln)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Ln = ln;
        }

        private void createAccount_Load(object sender, EventArgs e)
        {

        }
        public string generateID()
        {
            int currentID = 1001;
            try
            {
                string query = "SELECT MAX(CAST(SUBSTRING(CUSTOMER_ID, CHARINDEX('-', CUSTOMER_ID) + 1, LEN(customer_ID)) AS INT)) AS MaxCustID FROM Customers;";
                DataTable tb = new DataTable();
                tb = Da.ExecuteQueryTable(query);
                if (tb.Rows.Count > 0 && tb.Rows[0][0] != DBNull.Value)
                {
                    currentID = Convert.ToInt32(tb.Rows[0][0]) + 1;
                }
                Da.Sqlcon.Close();
                return Convert.ToString(currentID);

            }
            catch (Exception E)
            {
                return Convert.ToString(currentID);
            }
        }


        private void crtAccBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you really want to create an account?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                return;
            }
            try
            {
                string customerID = "C-" + generateID();
                string userName = firstNameTb.Text + " " + lastNameTb.Text;
                string query = "INSERT INTO Customers (customer_id, Username, gender, date_of_birth, address, contact, password) " +
                               "VALUES ('" + customerID + "', '" + userName + "', '" + genderBox.Text + "', '" +
                               dateOfBirthPicker.Value + "', '" + addressTb.Text + "', '" + contactTb.Text + "', '" + passwordTb.Text + "')";
                Da.ExecuteQuery(query);
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
