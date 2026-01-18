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
            searchButton = new Button();
            addEditButton = new Button();
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
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(847, 414);
            dataGridView1.TabIndex = 6;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(350, 132);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = " Search";
            searchBox.Size = new Size(508, 33);
            searchBox.TabIndex = 7;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.SaddleBrown;
            searchButton.Location = new Point(885, 132);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(79, 33);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // addEditButton
            // 
            addEditButton.Location = new Point(1096, 618);
            addEditButton.Name = "addEditButton";
            addEditButton.Size = new Size(101, 38);
            addEditButton.TabIndex = 9;
            addEditButton.Text = "Add / Edit";
            addEditButton.UseVisualStyleBackColor = true;
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(addEditButton);
            Controls.Add(searchButton);
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
        private Button searchButton;
        private Button addEditButton;
    }
}