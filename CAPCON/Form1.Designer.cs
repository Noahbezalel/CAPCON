namespace CAPCON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            cbxRemember = new CheckBox();
            btnLogin = new Button();
            panel4 = new Panel();
            tbxPassword = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            tbxEmail = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(113, 199, 212);
            panel1.Controls.Add(cbxRemember);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 461);
            panel1.TabIndex = 0;
            // 
            // cbxRemember
            // 
            cbxRemember.AutoSize = true;
            cbxRemember.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxRemember.Location = new Point(51, 352);
            cbxRemember.Name = "cbxRemember";
            cbxRemember.Size = new Size(104, 19);
            cbxRemember.TabIndex = 9;
            cbxRemember.Text = "Remember me";
            cbxRemember.UseVisualStyleBackColor = true;
            cbxRemember.CheckedChanged += cbxRemember_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(35, 146, 192);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(51, 381);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(301, 32);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(tbxPassword);
            panel4.Location = new Point(51, 314);
            panel4.Name = "panel4";
            panel4.Size = new Size(301, 32);
            panel4.TabIndex = 7;
            // 
            // tbxPassword
            // 
            tbxPassword.BorderStyle = BorderStyle.None;
            tbxPassword.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPassword.ForeColor = Color.DimGray;
            tbxPassword.Location = new Point(3, 7);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '•';
            tbxPassword.Size = new Size(295, 18);
            tbxPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(49, 294);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tbxEmail);
            panel3.Location = new Point(51, 253);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 32);
            panel3.TabIndex = 5;
            // 
            // tbxEmail
            // 
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEmail.ForeColor = Color.DimGray;
            tbxEmail.Location = new Point(3, 7);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(295, 18);
            tbxEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 233);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 3;
            label3.Text = "Email Address";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(136, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 101);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 70);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(155, 89);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "_____________";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(392, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 461);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(134, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(253, 281);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 146, 192);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(26, 140);
            button2.Name = "button2";
            button2.Size = new Size(93, 32);
            button2.TabIndex = 9;
            button2.Text = "REGISTER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(25, 108);
            label8.Name = "label8";
            label8.Size = new Size(102, 17);
            label8.TabIndex = 4;
            label8.Text = "Click to Register";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 89);
            label7.Name = "label7";
            label7.Size = new Size(215, 17);
            label7.TabIndex = 3;
            label7.Text = "Login to access all of apps features\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 70);
            label6.Name = "label6";
            label6.Size = new Size(93, 17);
            label6.TabIndex = 2;
            label6.Text = "Welcome back";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 25);
            label5.Name = "label5";
            label5.Size = new Size(109, 45);
            label5.TabIndex = 1;
            label5.Text = "Hello,";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capture Connect";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox tbxEmail;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private TextBox tbxPassword;
        private Label label4;
        private Button btnLogin;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label8;
        private Label label7;
        private CheckBox cbxRemember;
    }
}