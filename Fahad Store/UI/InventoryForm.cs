public partial class InventoryForm : Form
{
    private DbHelper db = new DbHelper();
    private DataGridView grid = new DataGridView { Location = new System.Drawing.Point(10, 10), Width = 400, Height = 200 };

    public InventoryForm()
    {
        InitializeComponent();
        Controls.Add(grid);
        LoadProducts();

        // Add TextBoxes for Name, Price, Quantity; Button for Add.
        var txtName = new TextBox { Location = new System.Drawing.Point(10, 220) };
        var txtPrice = new TextBox { Location = new System.Drawing.Point(10, 250) };
        var txtQty = new TextBox { Location = new System.Drawing.Point(10, 280) };
        var btnAdd = new Button { Text = "Add Product", Location = new System.Drawing.Point(10, 310) };
        btnAdd.Click += (s, e) => {
            db.InsertProduct(txtName.Text, double.Parse(txtPrice.Text), int.Parse(txtQty.Text));
            LoadProducts();
        };
        Controls.Add(txtName); Controls.Add(txtPrice); Controls.Add(txtQty); Controls.Add(btnAdd);
        // Add similar for Update/Delete using selected row.
    }

    private void LoadProducts()
    {
        // Query DB and bind to grid
        using (var conn = new SQLiteConnection(db.connectionString))
        {
            conn.Open();
            var adapter = new SQLiteDataAdapter("SELECT * FROM Products", conn);
            var table = new DataTable();
            adapter.Fill(table);
            grid.DataSource = table;
        }
    }
}