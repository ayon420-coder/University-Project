namespace Fahad_Store.UI
{
    partial class createAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createAccount));
            createAccountPanel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            addressLabel = new Label();
            genderLabel = new Label();
            passwordLabel = new Label();
            firstNameTb = new TextBox();
            lastNameTb = new TextBox();
            addressTb = new TextBox();
            comboBox1 = new ComboBox();
            passwordTb = new TextBox();
            crtAccBtn = new Button();
            dateOfBirthLabel = new Label();
            dateOfBirthPicker = new DateTimePicker();
            contactTb = new TextBox();
            contactLabel = new Label();
            backButton = new Button();
            createAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // createAccountPanel
            // 
            createAccountPanel.BackColor = Color.SaddleBrown;
            createAccountPanel.Controls.Add(label1);
            createAccountPanel.Controls.Add(pictureBox1);
            createAccountPanel.Location = new Point(0, 0);
            createAccountPanel.Name = "createAccountPanel";
            createAccountPanel.Size = new Size(800, 53);
            createAccountPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Swis721 Blk BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(63, 3);
            label1.Name = "label1";
            label1.Size = new Size(91, 47);
            label1.TabIndex = 4;
            label1.Text = "Fahad\r\nStore";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fresh_grocery_store_logo_vector_21609818;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(116, 95);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(89, 21);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(116, 128);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(87, 21);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLabel.Location = new Point(134, 230);
            addressLabel.Name = "addressLabel";
            addressLabel.RightToLeft = RightToLeft.No;
            addressLabel.Size = new Size(69, 21);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderLabel.Location = new Point(139, 161);
            genderLabel.Name = "genderLabel";
            genderLabel.RightToLeft = RightToLeft.No;
            genderLabel.Size = new Size(64, 21);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Gender:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(126, 301);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.RightToLeft = RightToLeft.No;
            passwordLabel.Size = new Size(79, 21);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // firstNameTb
            // 
            firstNameTb.Cursor = Cursors.IBeam;
            firstNameTb.Location = new Point(288, 95);
            firstNameTb.Name = "firstNameTb";
            firstNameTb.PlaceholderText = " First Name";
            firstNameTb.Size = new Size(261, 23);
            firstNameTb.TabIndex = 6;
            // 
            // lastNameTb
            // 
            lastNameTb.Cursor = Cursors.IBeam;
            lastNameTb.Location = new Point(288, 130);
            lastNameTb.Name = "lastNameTb";
            lastNameTb.PlaceholderText = " Last Name";
            lastNameTb.Size = new Size(261, 23);
            lastNameTb.TabIndex = 7;
            // 
            // addressTb
            // 
            addressTb.Location = new Point(288, 232);
            addressTb.Multiline = true;
            addressTb.Name = "addressTb";
            addressTb.PlaceholderText = " Address";
            addressTb.Size = new Size(261, 23);
            addressTb.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(288, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // passwordTb
            // 
            passwordTb.Location = new Point(288, 303);
            passwordTb.Name = "passwordTb";
            passwordTb.PlaceholderText = " Password";
            passwordTb.Size = new Size(261, 23);
            passwordTb.TabIndex = 10;
            // 
            // crtAccBtn
            // 
            crtAccBtn.BackColor = Color.SaddleBrown;
            crtAccBtn.ForeColor = SystemColors.ButtonFace;
            crtAccBtn.Location = new Point(318, 352);
            crtAccBtn.Name = "crtAccBtn";
            crtAccBtn.Size = new Size(128, 45);
            crtAccBtn.TabIndex = 11;
            crtAccBtn.Text = "Create Account";
            crtAccBtn.UseVisualStyleBackColor = false;
            crtAccBtn.Click += crtAccBtn_Click;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateOfBirthLabel.Location = new Point(101, 195);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(104, 21);
            dateOfBirthLabel.TabIndex = 12;
            dateOfBirthLabel.Text = "Date od Birth:";
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Cursor = Cursors.Hand;
            dateOfBirthPicker.Location = new Point(288, 195);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(200, 23);
            dateOfBirthPicker.TabIndex = 13;
            // 
            // contactTb
            // 
            contactTb.Location = new Point(288, 270);
            contactTb.Name = "contactTb";
            contactTb.PlaceholderText = " Contact";
            contactTb.Size = new Size(200, 23);
            contactTb.TabIndex = 14;
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactLabel.Location = new Point(139, 268);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(66, 21);
            contactLabel.TabIndex = 15;
            contactLabel.Text = "Contact:";
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.SaddleBrown;
            backButton.Location = new Point(701, 395);
            backButton.Name = "backButton";
            backButton.Size = new Size(87, 43);
            backButton.TabIndex = 16;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // createAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(contactLabel);
            Controls.Add(contactTb);
            Controls.Add(dateOfBirthPicker);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(crtAccBtn);
            Controls.Add(passwordTb);
            Controls.Add(comboBox1);
            Controls.Add(addressTb);
            Controls.Add(lastNameTb);
            Controls.Add(firstNameTb);
            Controls.Add(passwordLabel);
            Controls.Add(genderLabel);
            Controls.Add(addressLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(createAccountPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "createAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create an account";
            FormClosed += createAccount_FormClosed;
            createAccountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel createAccountPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label addressLabel;
        private Label genderLabel;
        private Label passwordLabel;
        private TextBox firstNameTb;
        private TextBox lastNameTb;
        private TextBox addressTb;
        private ComboBox comboBox1;
        private TextBox passwordTb;
        private Button crtAccBtn;
        private Label dateOfBirthLabel;
        private DateTimePicker dateOfBirthPicker;
        private TextBox contactTb;
        private Label contactLabel;
        private Button backButton;
    }
}