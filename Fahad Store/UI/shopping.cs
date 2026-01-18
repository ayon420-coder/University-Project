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
    public partial class shopping : Form
    {
        private dashBoard db;

        public dashBoard Db
        {
            get { return db; }
            set { db = value; }
        }
        public shopping(string v)
        {
            InitializeComponent();
        }
        public shopping(dashBoard db)
        {
            InitializeComponent();
            this.Db = db;
        }

        private void productType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void storeName_Click(object sender, EventArgs e)
        {
            var dashboard = new dashBoard();
            dashboard.Show();
            this.Hide();
        }

        private void shopping_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
