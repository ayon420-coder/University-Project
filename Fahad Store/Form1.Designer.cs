namespace Fahad_Store
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            storeName = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            searchBox = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            groceryToolStripMenuItem = new ToolStripMenuItem();
            foodToolStripMenuItem = new ToolStripMenuItem();
            homeAndKitchenToolStripMenuItem = new ToolStripMenuItem();
            stationToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            adsImage = new PictureBox();
            ads = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            listView2 = new ListView();
            pictureBox5 = new PictureBox();
            listView3 = new ListView();
            pictureBox6 = new PictureBox();
            listView5 = new ListView();
            pictureBox7 = new PictureBox();
            listView4 = new ListView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adsImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(storeName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(-8, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 60);
            panel1.TabIndex = 0;
            // 
            // storeName
            // 
            storeName.AllowDrop = true;
            storeName.Anchor = AnchorStyles.None;
            storeName.AutoSize = true;
            storeName.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeName.ForeColor = SystemColors.ButtonFace;
            storeName.Location = new Point(180, 20);
            storeName.Name = "storeName";
            storeName.Size = new Size(88, 19);
            storeName.TabIndex = 4;
            storeName.Text = "Fahad Store";
            storeName.TextAlign = ContentAlignment.MiddleCenter;
            storeName.UseMnemonic = false;
            storeName.Click += label1_Click;
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
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SaddleBrown;
            button2.Location = new Point(842, 13);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            searchBox.Cursor = Cursors.IBeam;
            searchBox.Location = new Point(283, 16);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search your product";
            searchBox.ShortcutsEnabled = false;
            searchBox.Size = new Size(541, 23);
            searchBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(1132, 16);
            button1.Name = "button1";
            button1.Size = new Size(106, 30);
            button1.TabIndex = 1;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(32, 16);
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
            // 
            // stationToolStripMenuItem
            // 
            stationToolStripMenuItem.ForeColor = Color.SaddleBrown;
            stationToolStripMenuItem.Name = "stationToolStripMenuItem";
            stationToolStripMenuItem.Size = new Size(198, 24);
            stationToolStripMenuItem.Text = "Stationeries";
            // 
            // listView1
            // 
            listView1.Location = new Point(45, 432);
            listView1.Name = "listView1";
            listView1.Size = new Size(187, 223);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // adsImage
            // 
            adsImage.Location = new Point(30, 88);
            adsImage.Name = "adsImage";
            adsImage.Size = new Size(1200, 300);
            adsImage.SizeMode = PictureBoxSizeMode.StretchImage;
            adsImage.TabIndex = 6;
            adsImage.TabStop = false;
            adsImage.Click += pictureBox2_Click;
            // 
            // ads
            // 
            ads.ColorDepth = ColorDepth.Depth32Bit;
            ads.ImageStream = (ImageListStreamer)resources.GetObject("ads.ImageStream");
            ads.TransparentColor = Color.Transparent;
            ads.Images.SetKeyName(0, "Banner-1200x300.jpg");
            ads.Images.SetKeyName(1, "banner-1200x300.png");
            ads.Images.SetKeyName(2, "images.jpg");
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(62, 450);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 150);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(307, 450);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 150);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(290, 432);
            listView2.Name = "listView2";
            listView2.Size = new Size(187, 223);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(552, 450);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 150);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(535, 432);
            listView3.Name = "listView3";
            listView3.Size = new Size(187, 223);
            listView3.TabIndex = 11;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(798, 450);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(150, 150);
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // listView5
            // 
            listView5.Location = new Point(781, 432);
            listView5.Name = "listView5";
            listView5.Size = new Size(187, 223);
            listView5.TabIndex = 13;
            listView5.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(1048, 450);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(150, 150);
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // listView4
            // 
            listView4.Location = new Point(1031, 432);
            listView4.Name = "listView4";
            listView4.Size = new Size(187, 223);
            listView4.TabIndex = 15;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox7);
            Controls.Add(listView4);
            Controls.Add(pictureBox6);
            Controls.Add(listView5);
            Controls.Add(pictureBox5);
            Controls.Add(listView3);
            Controls.Add(pictureBox4);
            Controls.Add(listView2);
            Controls.Add(pictureBox3);
            Controls.Add(adsImage);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Fahad Store";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adsImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem groceryToolStripMenuItem;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem homeAndKitchenToolStripMenuItem;
        private ToolStripMenuItem stationToolStripMenuItem;
        private Button button1;
        private TextBox searchBox;
        private Button button2;
        private PictureBox pictureBox1;
        private Label storeName;
        private ListView listView1;
        private System.Windows.Forms.Timer timer1;
        public PictureBox adsImage;
        public ImageList ads;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ListView listView2;
        private PictureBox pictureBox5;
        private ListView listView3;
        private PictureBox pictureBox6;
        private ListView listView5;
        private PictureBox pictureBox7;
        private ListView listView4;
    }
}
