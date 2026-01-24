namespace Fahad_Store.UI
{
    partial class adminPanel : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            apPanel = new Panel();
            storeName = new Label();
            pictureBox1 = new PictureBox();
            adminButton = new Button();
            customerButton = new Button();
            productButton = new Button();
            backButton = new Button();
            dataGridView1 = new DataGridView();
            searchBox = new TextBox();
            apPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // apPanel
            // 
            apPanel.BackColor = Color.SaddleBrown;
            apPanel.Controls.Add(storeName);
            apPanel.Controls.Add(pictureBox1);
            apPanel.Location = new Point(1, 12);
            apPanel.Name = "apPanel";
            apPanel.Size = new Size(1261, 83);
            apPanel.TabIndex = 1;
            // 
            // storeName
            // 
            storeName.AllowDrop = true;
            storeName.Anchor = AnchorStyles.None;
            storeName.BackColor = Color.Transparent;
            storeName.Font = new Font("Swis721 BlkCn BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeName.ForeColor = SystemColors.ButtonFace;
            storeName.Location = new Point(139, 3);
            storeName.Name = "storeName";
            storeName.Size = new Size(137, 79);
            storeName.TabIndex = 4;
            storeName.Text = "Fahad\r\nStore";
            storeName.TextAlign = ContentAlignment.MiddleLeft;
            storeName.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fresh_grocery_store_logo_vector_21609818;
            pictureBox1.Location = new Point(35, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // adminButton
            // 
            adminButton.BackColor = Color.SaddleBrown;
            adminButton.Cursor = Cursors.Hand;
            adminButton.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminButton.ForeColor = SystemColors.ControlLightLight;
            adminButton.Location = new Point(36, 167);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(241, 76);
            adminButton.TabIndex = 2;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += adminButton_Click;
            // 
            // customerButton
            // 
            customerButton.BackColor = Color.SaddleBrown;
            customerButton.Cursor = Cursors.Hand;
            customerButton.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerButton.ForeColor = SystemColors.ControlLightLight;
            customerButton.Location = new Point(36, 306);
            customerButton.Name = "customerButton";
            customerButton.Size = new Size(241, 76);
            customerButton.TabIndex = 3;
            customerButton.Text = "Customer";
            customerButton.UseVisualStyleBackColor = false;
            customerButton.Click += customerButton_Click;
            // 
            // productButton
            // 
            productButton.BackColor = Color.SaddleBrown;
            productButton.Cursor = Cursors.Hand;
            productButton.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productButton.ForeColor = SystemColors.ControlLightLight;
            productButton.Location = new Point(36, 442);
            productButton.Name = "productButton";
            productButton.Size = new Size(241, 76);
            productButton.TabIndex = 4;
            productButton.Text = "Product";
            productButton.UseVisualStyleBackColor = false;
            productButton.Click += productButton_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.SaddleBrown;
            backButton.Location = new Point(68, 574);
            backButton.Name = "backButton";
            backButton.Size = new Size(119, 56);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(847, 414);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(350, 132);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = " Search";
            searchBox.Size = new Size(847, 33);
            searchBox.TabIndex = 7;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(searchBox);
            Controls.Add(dataGridView1);
            Controls.Add(backButton);
            Controls.Add(productButton);
            Controls.Add(customerButton);
            Controls.Add(adminButton);
            Controls.Add(apPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "adminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            FormClosed += adminPanel_FormClosed;
            Load += adminPanel_Load;
            apPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel apPanel;
        private Label storeName;
        private PictureBox pictureBox1;
        private Button adminButton;
        private Button customerButton;
        private Button productButton;
        private Button backButton;
        private DataGridView dataGridView1;
        private TextBox searchBox;
    }
}
