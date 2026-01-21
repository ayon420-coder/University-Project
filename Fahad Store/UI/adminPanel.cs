using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Fahad_Store.UI
{
    public partial class adminPanel: Form
    {
        public logIn ln { get; set; }
        public DataAccess Da { get; set; }
        public string Customer_id { get; set; }

        public adminPanel()
        {
            InitializeComponent();
        }

        public adminPanel(logIn ln)
        {
            InitializeComponent();
            this.ln = ln;
        }

        public adminPanel(logIn ln, string customer_id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ln = ln;
            this.Customer_id = customer_id;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ln.Show();
        }

        private void adminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM Admins";
            var dt = Da.ExecuteQueryTable(sql);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM Customers";
            var dt = Da.ExecuteQueryTable(sql);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM Products";
            var dt = Da.ExecuteQueryTable(sql);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Refresh();
        }

        // Minimal safe InitializeComponent so adminPanel can be shown without throwing
    }
}
