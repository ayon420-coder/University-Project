using Fahad_Store.Necessities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahad_Store.Necessities;

namespace Fahad_Store.UI
{
    public partial class shopping : Form
    {
        private dashBoard db;
        private logIn ln;
        private DataAccess da;
        private addToCart atd;
        private string customer_id = Session.UserId;
        protected int totalPrice = 0;

        public logIn Ln
        {
            get { return ln; }
            set { ln = value; }
        }

        public dashBoard Db
        {
            get { return db; }
            set { db = value; }
        }

        public addToCart Adt
        {
            get { return atd; }
            set { atd = value; }
        }

        public DataAccess Da
        {
            get { return da; }
            set { da = value; }
        }

        public shopping(string v)
        {
            InitializeComponent();
        }
        public shopping(dashBoard db)
        {
            InitializeComponent();
            this.Db = db;
            this.Da = new DataAccess();
        }
        public shopping(logIn ln)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Ln = ln;
        }

        public shopping(addToCart atd)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Adt = atd;
        }

        private void storeName_Click(object sender, EventArgs e)
        {
            var dashboard = new dashBoard();
            dashboard.Show();
            this.Hide();
        }

        private void productType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = productType.Items[e.Index].ToString();

            if (item == "Grocery")
            {
                foreach (Control control in groceryPanelLayout.Controls)
                {
                    if (control is Panel p)
                    {
                        p.Visible = false;
                        if (p.Tag?.ToString() == "grocery")
                        {
                            p.Visible = true;
                        }
                    }
                }
            }
            else if (item == "Food")
            {
                foreach (Control control in groceryPanelLayout.Controls)
                {
                    if (control is Panel p)
                    {
                        p.Visible = false;
                        if (p.Tag?.ToString() == "food")
                        {
                            p.Visible = true;
                        }
                    }
                }
            }
            else if (item == "Home and Kitchen")
            {
                foreach (Control control in groceryPanelLayout.Controls)
                {
                    if (control is Panel p)
                    {
                        p.Visible = false;
                        if (p.Tag?.ToString() == "home&kitchen")
                        {
                            p.Visible = true;
                        }
                    }
                }
            }
            else if (item == "Stationeries")
            {
                foreach (Control control in groceryPanelLayout.Controls)
                {
                    if (control is Panel p)
                    {
                        p.Visible = false;
                        if (p.Tag?.ToString() == "stationaries")
                        {
                            p.Visible = true;
                        }
                    }
                }
            }
            else
            {
                foreach (Control control in groceryPanelLayout.Controls)
                {
                    if (control is Panel p)
                    {
                        p.Visible = true;
                    }
                }
            }
        }

        private void chiniguraAdd_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'GCR-1000'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Chashi Chinigura Rice", "Tk. 145", "1");
                totalPrice += 145;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'GCR-1000'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void basmatiAdd_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'GBR-1000'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Fortune Basmati Rice", "Tk. 155", "1");
                totalPrice += 155;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'GBR-1000'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void moshurAdd_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'GMD-1000'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("ACI Pure Moshur Dal", "Tk. 130", "1");
                totalPrice += 130;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'GMD-1000'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void eggAdd_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'GE-12'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Loose Egg", "Tk. 115", "1");
                totalPrice += 115;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'GE-12'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'GPS-1000'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("ACI Pure Salt", "Tk. 45", "1");
                totalPrice += 45;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'GPS-1000'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'GRS-1000'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Fresh Refined Sugar", "Tk. 130", "1");
                totalPrice += 130;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'GRS-1000'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'FLB-12'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Danish Lexus Biscuit", "Tk. 130", "1");
                totalPrice += 130;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'FLB-12'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addMrNoodles_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'FMRN-4'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Mr Noodles", "Tk. 65", "1");
                totalPrice += 65;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'FMRN-4'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'FMN-4'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Maggie Noodles", "Tk. 60", "1");
                totalPrice += 60;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'FMN-4'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'SBN-3'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Bashundhara Notebook", "Tk. 75", "1");
                totalPrice += 75;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'SBN-3'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'HKK-1'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Kitchen Knife", "Tk. 175", "1");
                totalPrice += 175;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'HKK-1'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'HKBS-3'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Home Decor Bed Sheet", "Tk. 1200", "1");
                totalPrice += 1200;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'HKBS-3'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Session.UserId == null)
            {
                var r = MessageBox.Show("You are not logged in. Would like to log in?", "Not Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var loginForm = new logIn();
                    loginForm.Show();
                    this.Hide();
                }
                return;
            }
            var sql = @"Select * from Products where [Product Id] = 'HKSk-12'";
            var dt = Da.ExecuteQueryTable(sql);
            int stock = Convert.ToInt32(dt.Rows[0]["stock"]);
            if (stock == 0)
            {
                Da.Sqlcon.Close();
                MessageBox.Show("Out of Stock!", "Stock Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (atd == null || atd.IsDisposed)
                {
                    atd = new addToCart(Da);
                }
                Adt.createPanel("Spoon and Fork", "Tk. 300", "1");
                totalPrice += 300;
                Da.ExecuteQuery("UPDATE Products SET stock = stock - 1 WHERE [product id] = 'HKSK-12'  AND stock > 0;");
                MessageBox.Show("Added to Cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cartLogo_Click_1(object sender, EventArgs e)
        {
            Adt.setTotalPrice(totalPrice);
            EnsureAndShowCart();
        }

        // Ensure atd is a valid instance before showing it; fallback to a message if it's not constructible.
        private void EnsureAndShowCart()
        {
            if (atd != null)
            {
                this.Hide();
                atd.Show();
            }
            else
            {
                MessageBox.Show("Cart is unavailable.", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            db.Show(this);
        }

        private void cartLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            atd.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Session.Logout();
            MessageBox.Show("You have been logged out successfully.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void shopping_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
