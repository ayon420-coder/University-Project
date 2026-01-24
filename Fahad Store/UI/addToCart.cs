using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Fahad_Store.Necessities;

namespace Fahad_Store.UI
{
    public partial class addToCart : Form
    {
        private DataAccess da;
        private shopping shop;
        private dashBoard db;

        public dashBoard Db
        {
            get { return db; }
            set { db = value; }
        }

        public shopping Shop
        {
            get { return shop; }
            set { shop = value; }
        }

        public addToCart(DataAccess da)
        {
            InitializeComponent();
            this.da = da;

            if (!Session.IsLoggedIn)
            {
                MessageBox.Show("Session expired. Please log in again.");
                new logIn().Show();
                this.Close();
                return;
            }

            LoadCustomerInfo();
        }

        public void setTotalPrice(int price)
        {
            totalPriceLbl.Text = "Tk." + price.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop.Show(this);
        }

        private void LoadCustomerInfo()
        {
            string sql = "SELECT customer_id, username FROM Customers WHERE customer_id = '" + Session.UserId + "'";
            var dt = da.ExecuteQueryTable(sql);
            if (dt.Rows.Count > 0)
            {
                customerID.Text = dt.Rows[0]["customer_id"].ToString();
                customerName.Text = dt.Rows[0]["username"].ToString();
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Session.Logout();
            MessageBox.Show("You have been logged out successfully.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            shop.Show(this);
            return;
        }

        private void addToCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Purchase confirmed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            db.Show(this);
        }
    }

}
