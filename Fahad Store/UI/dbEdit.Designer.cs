namespace Fahad_Store.UI
{
    partial class databaseEdit
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
            apPanel = new Panel();
            storeName = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            apPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // apPanel
            // 
            apPanel.BackColor = Color.SaddleBrown;
            apPanel.Controls.Add(storeName);
            apPanel.Controls.Add(pictureBox1);
            apPanel.Location = new Point(0, 12);
            apPanel.Name = "apPanel";
            apPanel.Size = new Size(1261, 83);
            apPanel.TabIndex = 2;
            // 
            // storeName
            // 
            storeName.AllowDrop = true;
            storeName.Anchor = AnchorStyles.None;
            storeName.BackColor = Color.Transparent;
            storeName.Font = new Font("Swis721 BlkCn BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeName.ForeColor = SystemColors.ButtonFace;
            storeName.Location = new Point(131, 0);
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
            // panel1
            // 
            panel1.Location = new Point(35, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 557);
            panel1.TabIndex = 3;
            // 
            // databaseEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(apPanel);
            Name = "databaseEdit";
            Text = "Database Edit";
            apPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel apPanel;
        private Label storeName;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}