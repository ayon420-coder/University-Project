namespace Fahad_Store.UI
{
    partial class logIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logIn));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            username = new TextBox();
            textBox1 = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            logIn_btn = new Button();
            createAccLink = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(114, 20);
            label1.Name = "label1";
            label1.Size = new Size(94, 58);
            label1.TabIndex = 3;
            label1.Text = "Fahad\r\nStore";
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
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(299, 210);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Password";
            textBox1.Size = new Size(206, 30);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(188, 168);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.RightToLeft = RightToLeft.No;
            usernameLabel.Size = new Size(96, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username: ";
            usernameLabel.Click += label1_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(218, 213);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.RightToLeft = RightToLeft.No;
            passwordLabel.Size = new Size(66, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = " Password: ";
            // 
            // logIn_btn
            // 
            logIn_btn.BackColor = Color.SaddleBrown;
            logIn_btn.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logIn_btn.ForeColor = Color.SeaShell;
            logIn_btn.Location = new Point(299, 292);
            logIn_btn.Name = "logIn_btn";
            logIn_btn.Size = new Size(95, 43);
            logIn_btn.TabIndex = 5;
            logIn_btn.Text = "Log In";
            logIn_btn.UseVisualStyleBackColor = false;
            logIn_btn.Click += button1_Click;
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
            // logIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createAccLink);
            Controls.Add(logIn_btn);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(textBox1);
            Controls.Add(username);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "logIn";
            Text = "logIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox username;
        private TextBox textBox1;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button logIn_btn;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel createAccLink;
    }
}
