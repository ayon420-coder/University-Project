namespace Fahad_Store.UI
{
    partial class shopping
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
            panel1 = new Panel();
            storeName = new Label();
            pictureBox1 = new PictureBox();
            productType = new CheckedListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(storeName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 83);
            panel1.TabIndex = 2;
            // 
            // storeName
            // 
            storeName.AllowDrop = true;
            storeName.Anchor = AnchorStyles.None;
            storeName.BackColor = Color.Transparent;
            storeName.Font = new Font("Swis721 BlkCn BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeName.ForeColor = SystemColors.ButtonFace;
            storeName.Location = new Point(132, 3);
            storeName.Name = "storeName";
            storeName.Size = new Size(137, 79);
            storeName.TabIndex = 4;
            storeName.Text = "Fahad\r\nStore";
            storeName.TextAlign = ContentAlignment.MiddleLeft;
            storeName.UseMnemonic = false;
            storeName.Click += storeName_Click;
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
            // productType
            // 
            productType.Anchor = AnchorStyles.None;
            productType.Font = new Font("Swis721 Cn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productType.FormattingEnabled = true;
            productType.Items.AddRange(new object[] { "Grocery", "Food", "Home and Kitchen", "Stationaries" });
            productType.Location = new Point(3, 3);
            productType.Name = "productType";
            productType.Size = new Size(173, 179);
            productType.TabIndex = 4;
            productType.SelectedIndexChanged += productType_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(productType);
            flowLayoutPanel1.Location = new Point(12, 101);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(182, 568);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // shopping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "shopping";
            Text = "Shop";
            FormClosed += shopping_FormClosed;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label storeName;
        private PictureBox pictureBox1;
        private CheckedListBox productType;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}