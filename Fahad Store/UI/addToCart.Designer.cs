namespace Fahad_Store.UI
{
    partial class addToCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addToCart));
            panel1 = new Panel();
            backButton = new Button();
            customerID = new Label();
            customerName = new Label();
            customerProfile = new PictureBox();
            panel2 = new Panel();
            logOutBtn = new PictureBox();
            cartLogo = new PictureBox();
            storeName = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblYourCart = new Label();
            lblTotal = new Label();
            totalPriceLbl = new Label();
            btnBuyNow = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerProfile).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logOutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(customerID);
            panel1.Controls.Add(customerName);
            panel1.Controls.Add(customerProfile);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 681);
            panel1.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.SaddleBrown;
            backButton.Location = new Point(89, 579);
            backButton.Name = "backButton";
            backButton.Size = new Size(87, 43);
            backButton.TabIndex = 9;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // customerID
            // 
            customerID.AutoSize = true;
            customerID.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerID.Location = new Point(45, 287);
            customerID.Name = "customerID";
            customerID.Size = new Size(94, 19);
            customerID.TabIndex = 1;
            customerID.Text = "customer ID";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Font = new Font("Swis721 Blk BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerName.ForeColor = Color.SaddleBrown;
            customerName.Location = new Point(45, 262);
            customerName.Name = "customerName";
            customerName.Size = new Size(131, 25);
            customerName.TabIndex = 1;
            customerName.Text = "Ayon Saha";
            // 
            // customerProfile
            // 
            customerProfile.BorderStyle = BorderStyle.Fixed3D;
            customerProfile.Location = new Point(45, 43);
            customerProfile.Name = "customerProfile";
            customerProfile.Size = new Size(180, 200);
            customerProfile.TabIndex = 1;
            customerProfile.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(logOutBtn);
            panel2.Controls.Add(cartLogo);
            panel2.Controls.Add(storeName);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(278, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 83);
            panel2.TabIndex = 6;
            // 
            // logOutBtn
            // 
            logOutBtn.Cursor = Cursors.Hand;
            logOutBtn.Image = Properties.Resources.logOut;
            logOutBtn.Location = new Point(898, 21);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(36, 36);
            logOutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            logOutBtn.TabIndex = 7;
            logOutBtn.TabStop = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // cartLogo
            // 
            cartLogo.Cursor = Cursors.Hand;
            cartLogo.Image = Properties.Resources.cart;
            cartLogo.Location = new Point(987, 12);
            cartLogo.Name = "cartLogo";
            cartLogo.Size = new Size(55, 55);
            cartLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            cartLogo.TabIndex = 5;
            cartLogo.TabStop = false;
            // 
            // storeName
            // 
            storeName.AllowDrop = true;
            storeName.Anchor = AnchorStyles.None;
            storeName.BackColor = Color.Transparent;
            storeName.Cursor = Cursors.Hand;
            storeName.Font = new Font("Swis721 BlkCn BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeName.ForeColor = SystemColors.ButtonFace;
            storeName.Location = new Point(142, 0);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(lblYourCart);
            flowLayoutPanel1.Controls.Add(lblTotal);
            flowLayoutPanel1.Controls.Add(totalPriceLbl);
            flowLayoutPanel1.Controls.Add(btnBuyNow);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(278, 83);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(986, 598);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // lblYourCart
            // 
            lblYourCart.AutoSize = true;
            lblYourCart.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYourCart.ForeColor = Color.SaddleBrown;
            lblYourCart.Location = new Point(50, 50);
            lblYourCart.Margin = new Padding(50, 50, 3, 0);
            lblYourCart.Name = "lblYourCart";
            lblYourCart.Size = new Size(95, 25);
            lblYourCart.TabIndex = 0;
            lblYourCart.Text = "Your Cart";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.SaddleBrown;
            lblTotal.Location = new Point(698, 50);
            lblTotal.Margin = new Padding(550, 50, 3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(68, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total: ";
            // 
            // totalPriceLbl
            // 
            totalPriceLbl.AutoSize = true;
            totalPriceLbl.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceLbl.ForeColor = Color.SaddleBrown;
            totalPriceLbl.Location = new Point(779, 50);
            totalPriceLbl.Margin = new Padding(10, 50, 3, 0);
            totalPriceLbl.Name = "totalPriceLbl";
            totalPriceLbl.Size = new Size(57, 25);
            totalPriceLbl.TabIndex = 5;
            totalPriceLbl.Text = "Price";
            // 
            // btnBuyNow
            // 
            btnBuyNow.BackColor = Color.SaddleBrown;
            btnBuyNow.Cursor = Cursors.Hand;
            btnBuyNow.Dock = DockStyle.Bottom;
            btnBuyNow.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuyNow.ForeColor = SystemColors.ControlLightLight;
            btnBuyNow.Location = new Point(400, 95);
            btnBuyNow.Margin = new Padding(400, 20, 3, 3);
            btnBuyNow.Name = "btnBuyNow";
            btnBuyNow.Size = new Size(128, 42);
            btnBuyNow.TabIndex = 7;
            btnBuyNow.Text = "Buy Now";
            btnBuyNow.UseVisualStyleBackColor = false;
            btnBuyNow.Click += btnBuyNow_Click;
            // 
            // addToCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addToCart";
            Text = "Cart";
            FormClosed += addToCart_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerProfile).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logOutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        public void createPanel(string pName, string pTag, string pQuan)
        {
            productPanel = new Panel();
            priceTag = new Label();
            lblQuantity = new Label();
            productName = new Label();
            // 
            // productPanel
            // 
            productPanel.BorderStyle = BorderStyle.Fixed3D;
            productPanel.Controls.Add(priceTag);
            productPanel.Controls.Add(lblQuantity);
            productPanel.Controls.Add(productName);
            productPanel.Location = new Point(50, 95);
            productPanel.Margin = new Padding(50, 20, 3, 3);
            productPanel.Name = "productPanel";
            productPanel.Size = new Size(840, 100);
            productPanel.TabIndex = 1;
            // 
            // priceTag
            // 
            priceTag.AutoSize = true;
            priceTag.Font = new Font("Swis721 BlkCn BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTag.ForeColor = Color.SaddleBrown;
            priceTag.Location = new Point(717, 36);
            priceTag.Name = "priceTag";
            priceTag.Size = new Size(88, 29);
            priceTag.TabIndex = 2;
            priceTag.Text = pTag;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(12, 63);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(108, 21);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = pQuan;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productName.ForeColor = Color.SaddleBrown;
            productName.Location = new Point(12, 12);
            productName.Name = "productName";
            productName.Size = new Size(134, 25);
            productName.TabIndex = 0;
            productName.Text = pName;

            flowLayoutPanel1.Controls.Add(productPanel);
        }

        #endregion

        private Panel panel1;
        private Label customerName;
        private PictureBox customerProfile;
        private Label customerID;
        private Panel panel2;
        private PictureBox cartLogo;
        private Label storeName;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblYourCart;
        private Panel productPanel;
        private Label priceTag;
        private Label lblQuantity;
        private Label productName;
        private Label lblTotal;
        private Label totalPriceLbl;
        private Button btnBuyNow;
        private Button backButton;
        private PictureBox logOutBtn;
    }
}