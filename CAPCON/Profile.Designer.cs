namespace CAPCON
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            pictureBox = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            lblRole = new Label();
            btnImage = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            lblFName = new Label();
            lblLName = new Label();
            label7 = new Label();
            panel3 = new Panel();
            tbxFirstName = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            tbxLastName = new TextBox();
            label9 = new Label();
            panel2 = new Panel();
            tbxEmail = new TextBox();
            label10 = new Label();
            panel4 = new Panel();
            tbxContact = new TextBox();
            label11 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImage = (Image)resources.GetObject("pictureBox.BackgroundImage");
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.Location = new Point(66, 140);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(131, 160);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 122);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "PROFILE IMAGE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 122);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 5;
            label4.Text = "ACCOUNT TYPE";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.Location = new Point(222, 137);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 21);
            lblRole.TabIndex = 6;
            lblRole.Text = "Client";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(66, 306);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(131, 23);
            btnImage.TabIndex = 7;
            btnImage.Text = "Change profile Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 196);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 8;
            label6.Text = "ACCOUNT DETAILS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 55);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFName.Location = new Point(66, 21);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(83, 21);
            lblFName.TabIndex = 1;
            lblFName.Text = "firstname";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLName.Location = new Point(147, 21);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(80, 21);
            lblLName.TabIndex = 2;
            lblLName.Text = "lastname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(-5, 70);
            label7.Name = "label7";
            label7.Size = new Size(1192, 15);
            label7.TabIndex = 9;
            label7.Text = resources.GetString("label7.Text");
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(tbxFirstName);
            panel3.Location = new Point(224, 235);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 32);
            panel3.TabIndex = 11;
            // 
            // tbxFirstName
            // 
            tbxFirstName.BackColor = SystemColors.Control;
            tbxFirstName.BorderStyle = BorderStyle.None;
            tbxFirstName.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxFirstName.ForeColor = Color.Black;
            tbxFirstName.Location = new Point(3, 7);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(206, 18);
            tbxFirstName.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(222, 215);
            label8.Name = "label8";
            label8.Size = new Size(75, 17);
            label8.TabIndex = 10;
            label8.Text = "First Name";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tbxLastName);
            panel1.Location = new Point(226, 297);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 32);
            panel1.TabIndex = 13;
            // 
            // tbxLastName
            // 
            tbxLastName.BackColor = SystemColors.Control;
            tbxLastName.BorderStyle = BorderStyle.None;
            tbxLastName.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxLastName.ForeColor = Color.Black;
            tbxLastName.Location = new Point(3, 7);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(206, 18);
            tbxLastName.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(224, 277);
            label9.Name = "label9";
            label9.Size = new Size(73, 17);
            label9.TabIndex = 12;
            label9.Text = "Last Name";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(tbxEmail);
            panel2.Location = new Point(490, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 32);
            panel2.TabIndex = 15;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = SystemColors.Control;
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.ForeColor = Color.Black;
            tbxEmail.Location = new Point(3, 7);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(206, 18);
            tbxEmail.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(488, 215);
            label10.Name = "label10";
            label10.Size = new Size(95, 17);
            label10.TabIndex = 14;
            label10.Text = "Email Address";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(tbxContact);
            panel4.Location = new Point(492, 296);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 32);
            panel4.TabIndex = 17;
            // 
            // tbxContact
            // 
            tbxContact.BackColor = SystemColors.Control;
            tbxContact.BorderStyle = BorderStyle.None;
            tbxContact.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxContact.ForeColor = Color.Black;
            tbxContact.Location = new Point(3, 7);
            tbxContact.Name = "tbxContact";
            tbxContact.Size = new Size(206, 18);
            tbxContact.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(490, 276);
            label11.Name = "label11";
            label11.Size = new Size(81, 17);
            label11.TabIndex = 16;
            label11.Text = "Contact No.";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(41, 537);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(210, 32);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(276, 537);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(210, 32);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 581);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(panel4);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnImage);
            Controls.Add(lblRole);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox;
        private Label label3;
        private Label label4;
        private Label lblRole;
        private Button btnImage;
        private Label label6;
        private PictureBox pictureBox1;
        private Label lblFName;
        private Label lblLName;
        private Label label7;
        private Panel panel3;
        private TextBox tbxFirstName;
        private Label label8;
        private Panel panel1;
        private TextBox tbxLastName;
        private Label label9;
        private Panel panel2;
        private TextBox tbxEmail;
        private Label label10;
        private Panel panel4;
        private TextBox tbxContact;
        private Label label11;
        private Button btnSave;
        private Button btnDelete;
    }
}