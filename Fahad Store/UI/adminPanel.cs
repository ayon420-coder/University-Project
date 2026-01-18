using System;
using System.Windows.Forms;

namespace Fahad_Store.UI
{
    public partial class adminPanel : Form
    {
        public logIn ln { get; set; }


        public adminPanel()
        {
            InitializeComponent();
        }

        public adminPanel(logIn ln)
        {
            InitializeComponent();
            this.ln = ln;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ln.Show();
        }

        // Minimal safe InitializeComponent so adminPanel can be shown without throwing
    }
}
