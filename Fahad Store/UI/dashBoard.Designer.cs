namespace Fahad_Store
{
    partial class dashBoard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashBoard));
            panel1 = new Panel();
            storeName = new Label();
            pictureBox1 = new PictureBox();
            searchButton = new Button();
            searchBox = new TextBox();
            logInbtn = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            groceryToolStripMenuItem = new ToolStripMenuItem();
            foodToolStripMenuItem = new ToolStripMenuItem();
            homeAndKitchenToolStripMenuItem = new ToolStripMenuItem();
            stationToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutDashboardPanel = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            product1 = new Panel();
            product1Price = new Label();
            product1Name = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            shopButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            flowLayoutDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            product1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(storeName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(logInbtn);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 60);
            panel1.TabIndex = 0;
            // 
            // storeName
            // 
            storeName.AllowDrop = true;
            storeName.Anchor = AnchorStyles.None;
            storeName.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeName.ForeColor = SystemColors.ButtonFace;
            storeName.Location = new Point(173, 7);
            storeName.Name = "storeName";
            storeName.Size = new Size(88, 50);
            storeName.TabIndex = 4;
            storeName.Text = "Fahad\r\nStore";
            storeName.TextAlign = ContentAlignment.MiddleLeft;
            storeName.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fresh_grocery_store_logo_vector_21609818;
            pictureBox1.Location = new Point(117, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // searchButton
            // 
            searchButton.Cursor = Cursors.Hand;
            searchButton.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.SaddleBrown;
            searchButton.Location = new Point(842, 13);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(80, 30);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchBox
            // 
            searchBox.Cursor = Cursors.IBeam;
            searchBox.Location = new Point(283, 16);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = " Search your product";
            searchBox.ShortcutsEnabled = false;
            searchBox.Size = new Size(541, 23);
            searchBox.TabIndex = 2;
            // 
            // logInbtn
            // 
            logInbtn.Cursor = Cursors.Hand;
            logInbtn.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logInbtn.ForeColor = Color.SaddleBrown;
            logInbtn.Location = new Point(1132, 16);
            logInbtn.Name = "logInbtn";
            logInbtn.Size = new Size(106, 30);
            logInbtn.TabIndex = 1;
            logInbtn.Text = "Log In";
            logInbtn.UseVisualStyleBackColor = true;
            logInbtn.Click += logInbtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(25, 16);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(66, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { groceryToolStripMenuItem, foodToolStripMenuItem, homeAndKitchenToolStripMenuItem, stationToolStripMenuItem });
            menuToolStripMenuItem.ForeColor = Color.SaddleBrown;
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(58, 23);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // groceryToolStripMenuItem
            // 
            groceryToolStripMenuItem.ForeColor = Color.SaddleBrown;
            groceryToolStripMenuItem.Name = "groceryToolStripMenuItem";
            groceryToolStripMenuItem.Size = new Size(198, 24);
            groceryToolStripMenuItem.Text = "Grocery";
            groceryToolStripMenuItem.Click += groceryToolStripMenuItem_Click;
            // 
            // foodToolStripMenuItem
            // 
            foodToolStripMenuItem.ForeColor = Color.SaddleBrown;
            foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            foodToolStripMenuItem.Size = new Size(198, 24);
            foodToolStripMenuItem.Text = "Food";
            // 
            // homeAndKitchenToolStripMenuItem
            // 
            homeAndKitchenToolStripMenuItem.ForeColor = Color.SaddleBrown;
            homeAndKitchenToolStripMenuItem.Name = "homeAndKitchenToolStripMenuItem";
            homeAndKitchenToolStripMenuItem.Size = new Size(198, 24);
            homeAndKitchenToolStripMenuItem.Text = "Home and Kitchen";
            homeAndKitchenToolStripMenuItem.Click += homeAndKitchenToolStripMenuItem_Click;
            // 
            // stationToolStripMenuItem
            // 
            stationToolStripMenuItem.ForeColor = Color.SaddleBrown;
            stationToolStripMenuItem.Name = "stationToolStripMenuItem";
            stationToolStripMenuItem.Size = new Size(198, 24);
            stationToolStripMenuItem.Text = "Stationeries";
            // 
            // flowLayoutDashboardPanel
            // 
            flowLayoutDashboardPanel.AutoScroll = true;
            flowLayoutDashboardPanel.AutoScrollMargin = new Size(50, 300);
            flowLayoutDashboardPanel.Controls.Add(pictureBox2);
            flowLayoutDashboardPanel.Controls.Add(product1);
            flowLayoutDashboardPanel.Controls.Add(panel2);
            flowLayoutDashboardPanel.Controls.Add(panel3);
            flowLayoutDashboardPanel.Controls.Add(panel4);
            flowLayoutDashboardPanel.Controls.Add(panel5);
            flowLayoutDashboardPanel.Controls.Add(shopButton);
            flowLayoutDashboardPanel.Location = new Point(12, 66);
            flowLayoutDashboardPanel.Name = "flowLayoutDashboardPanel";
            flowLayoutDashboardPanel.Size = new Size(1240, 603);
            flowLayoutDashboardPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._687f5fb9f7767f9184972de1_LIMITED_DEALS_BANNER_DESTOP_1552;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1234, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // product1
            // 
            product1.BorderStyle = BorderStyle.Fixed3D;
            product1.Controls.Add(product1Price);
            product1.Controls.Add(product1Name);
            product1.Controls.Add(pictureBox3);
            product1.Cursor = Cursors.Hand;
            product1.Location = new Point(10, 256);
            product1.Margin = new Padding(10, 50, 0, 0);
            product1.Name = "product1";
            product1.Size = new Size(200, 250);
            product1.TabIndex = 1;
            // 
            // product1Price
            // 
            product1Price.AutoSize = true;
            product1Price.Font = new Font("Swis721 BlkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            product1Price.ForeColor = Color.SaddleBrown;
            product1Price.Location = new Point(74, 223);
            product1Price.Name = "product1Price";
            product1Price.Size = new Size(43, 16);
            product1Price.TabIndex = 0;
            product1Price.Text = "Tk. !45";
            // 
            // product1Name
            // 
            product1Name.AutoSize = true;
            product1Name.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            product1Name.Location = new Point(21, 194);
            product1Name.Name = "product1Name";
            product1Name.Size = new Size(155, 19);
            product1Name.TabIndex = 0;
            product1Name.Text = "Chashi Chinigura Rice";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.GCR_2000;
            pictureBox3.Location = new Point(12, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(173, 166);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox4);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(265, 256);
            panel2.Margin = new Padding(55, 50, 0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 250);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(74, 223);
            label1.Name = "label1";
            label1.Size = new Size(43, 16);
            label1.TabIndex = 0;
            label1.Text = "Tk. !55";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 194);
            label2.Name = "label2";
            label2.Size = new Size(151, 19);
            label2.TabIndex = 0;
            label2.Text = "Fortune Basmati RIce";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.GBR_1000;
            pictureBox4.Location = new Point(12, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(173, 166);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox5);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(520, 256);
            panel3.Margin = new Padding(55, 50, 0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 250);
            panel3.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BlkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(74, 223);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 0;
            label3.Text = "Tk. !30";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 194);
            label4.Name = "label4";
            label4.Size = new Size(112, 19);
            label4.TabIndex = 0;
            label4.Text = "ACI Moshur Dal";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.GMD_1000;
            pictureBox5.Location = new Point(12, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(173, 166);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox6);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(765, 256);
            panel4.Margin = new Padding(45, 50, 0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 250);
            panel4.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 BlkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(74, 223);
            label5.Name = "label5";
            label5.Size = new Size(43, 16);
            label5.TabIndex = 0;
            label5.Text = "Tk. !15";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 194);
            label6.Name = "label6";
            label6.Size = new Size(143, 19);
            label6.TabIndex = 0;
            label6.Text = "Loose Egg (1 Dogon)";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.GE_12;
            pictureBox6.Location = new Point(12, 14);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(173, 166);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox7);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(1020, 256);
            panel5.Margin = new Padding(55, 50, 0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 250);
            panel5.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Swis721 BlkCn BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Location = new Point(74, 223);
            label7.Name = "label7";
            label7.Size = new Size(43, 16);
            label7.TabIndex = 0;
            label7.Text = "Tk. !45";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 194);
            label8.Name = "label8";
            label8.Size = new Size(155, 19);
            label8.TabIndex = 0;
            label8.Text = "Chashi Chinigura Rice";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.GCR_2000;
            pictureBox7.Location = new Point(12, 14);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(173, 166);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // shopButton
            // 
            shopButton.BackColor = Color.SaddleBrown;
            shopButton.Cursor = Cursors.Hand;
            shopButton.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shopButton.ForeColor = SystemColors.ButtonFace;
            shopButton.Location = new Point(600, 536);
            shopButton.Margin = new Padding(600, 30, 3, 3);
            shopButton.Name = "shopButton";
            shopButton.Size = new Size(100, 40);
            shopButton.TabIndex = 13;
            shopButton.Text = "Shop More";
            shopButton.UseVisualStyleBackColor = false;
            // 
            // dashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1264, 681);
            Controls.Add(flowLayoutDashboardPanel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fahad Store";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutDashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            product1.ResumeLayout(false);
            product1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Button logInbtn;
        private TextBox searchBox;
        private Button searchButton;
        private PictureBox pictureBox1;
        private Label storeName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem groceryToolStripMenuItem;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem homeAndKitchenToolStripMenuItem;
        private ToolStripMenuItem stationToolStripMenuItem;
        private FlowLayoutPanel flowLayoutDashboardPanel;
        private PictureBox pictureBox2;
        private Panel product1;
        private Label product1Name;
        private PictureBox pictureBox3;
        private Label product1Price;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox5;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox6;
        private Panel panel5;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox7;
        private Button shopButton;
    }
}
