using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Fahad_Store.UI
{
    public partial class adminPanel : Form
    {
        public logIn ln { get; set; }
        public DataAccess Da { get; set; }
        public string Customer_id { get; set; }
        private databaseEdit dbEdit;

        public databaseEdit DbEdit
        {
            get { return dbEdit; }
            set { dbEdit = value; }
        }

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
            var sql = "Select Customer_Id, Username, Gender, Date_of_Birth, Address, Contact from Customers";
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

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string columnName = dataGridView1.Columns[0].Name;

            try
            {
                if (columnName == "Customer_Id")
                {
                    var sql = "Select Customer_Id, Username, Gender, Date_of_Birth, Address, Contact from Customers where customer_id like '%" + searchBox.Text + "'";
                    var dt = Da.ExecuteQueryTable(sql);
                    dataGridView1.DataSource = dt;
                    this.dataGridView1.Refresh();
                }
                else if (columnName == "Product_ID")
                {
                    var sql = "SELECT * FROM Products where Product_ID like '%" + searchBox.Text + "'";
                    var dt = Da.ExecuteQueryTable(sql);
                    dataGridView1.DataSource = dt;
                    this.dataGridView1.Refresh();
                }
                else if (columnName == "admin_Id")
                {
                    var sql = "SELECT * FROM Admins where admin_ID like '%" + searchBox.Text + "'";
                    var dt = Da.ExecuteQueryTable(sql);
                    dataGridView1.DataSource = dt;
                    this.dataGridView1.Refresh();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dbEdit = new databaseEdit(this);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

            DataGridViewRow row = dataGridView1.CurrentRow;
            string columnName = dataGridView1.Columns[0].Name;
            
            if (columnName == "Customer_Id")
            {
                string id = row.Cells["customer_Id"].Value.ToString();
                new Edit(id).Show();

            }
            else if (columnName == "Product Id")
            {
                string id = row.Cells["product Id"].Value.ToString();
                new Edit(id).Show();
            }
            else if (columnName == "admin_Id")
            {
                string id = row.Cells["admin_Id"].Value.ToString();
                new Edit(id).Show();
            }
        }

        // Minimal safe InitializeComponent so adminPanel can be shown without throwing
    }
}
