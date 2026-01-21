namespace Fahad_Store.UI
{
    partial class logIn
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logIn));
            logInPanel = new Panel();
            storeName = new Label();
            pictureBox1 = new PictureBox();
            username = new TextBox();
            passwordTb = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            logIn_btn = new Button();
            createAccLink = new LinkLabel();
            backButton = new Button();
            logInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logInPanel
            // 
            logInPanel.BackColor = Color.SaddleBrown;
            logInPanel.Controls.Add(storeName);
            logInPanel.Controls.Add(pictureBox1);
            logInPanel.Location = new Point(1, 1);
            logInPanel.Name = "logInPanel";
            logInPanel.Size = new Size(800, 100);
            logInPanel.TabIndex = 0;
            // 
            // storeName
            // 
            storeName.AutoSize = true;
            storeName.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeName.ForeColor = SystemColors.Control;
            storeName.Location = new Point(114, 20);
            storeName.Name = "storeName";
            storeName.Size = new Size(94, 58);
            storeName.TabIndex = 3;
            storeName.Text = "Fahad\r\nStore";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fresh_grocery_store_logo_vector_21609818;
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // username
            // 
            username.AcceptsReturn = true;
            username.Cursor = Cursors.IBeam;
            username.Location = new Point(299, 165);
            username.Multiline = true;
            username.Name = "username";
            username.PlaceholderText = " Username";
            username.Size = new Size(206, 30);
            username.TabIndex = 1;
            // 
            // passwordTb
            // 
            passwordTb.AcceptsReturn = true;
            passwordTb.Cursor = Cursors.IBeam;
            passwordTb.Location = new Point(299, 210);
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.PlaceholderText = " Password";
            passwordTb.Size = new Size(206, 23);
            passwordTb.TabIndex = 2;
            passwordTb.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(188, 168);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.RightToLeft = RightToLeft.No;
            usernameLabel.Size = new Size(96, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            passwordLabel.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(188, 213);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.RightToLeft = RightToLeft.No;
            passwordLabel.Size = new Size(96, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = " Password: ";
            // 
            // logIn_btn
            // 
            logIn_btn.BackColor = Color.SaddleBrown;
            logIn_btn.Cursor = Cursors.Hand;
            logIn_btn.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logIn_btn.ForeColor = Color.SeaShell;
            logIn_btn.Location = new Point(299, 292);
            logIn_btn.Name = "logIn_btn";
            logIn_btn.Size = new Size(95, 43);
            logIn_btn.TabIndex = 5;
            logIn_btn.Text = "Log In";
            logIn_btn.UseVisualStyleBackColor = false;
            logIn_btn.Click += logInButton_Click;
            // 
            // createAccLink
            // 
            createAccLink.AutoSize = true;
            createAccLink.Location = new Point(299, 359);
            createAccLink.Name = "createAccLink";
            createAccLink.Size = new Size(106, 15);
            createAccLink.TabIndex = 7;
            createAccLink.TabStop = true;
            createAccLink.Text = "Create an account.";
            createAccLink.LinkClicked += createAccLink_LinkClicked;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.SaddleBrown;
            backButton.Location = new Point(681, 395);
            backButton.Name = "backButton";
            backButton.Size = new Size(87, 43);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += btnback_Click;
            // 
            // logIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(createAccLink);
            Controls.Add(logIn_btn);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTb);
            Controls.Add(username);
            Controls.Add(logInPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "logIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "logIn";
            FormClosed += logIn_FormClosed;
            logInPanel.ResumeLayout(false);
            logInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel logInPanel;
        private TextBox username;
        private TextBox passwordTb;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button logIn_btn;
        private Label storeName;
        private PictureBox pictureBox1;
        private LinkLabel createAccLink;
        private Button backButton;
    }
}
