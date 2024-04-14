namespace CAPCON
{
    partial class Explore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explore));
            dgvList = new DataGridView();
            btnView = new Button();
            btnBook = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            tbxID = new TextBox();
            monthCalendar1 = new MonthCalendar();
            panel5 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel4 = new Panel();
            tbxLastName = new TextBox();
            panel3 = new Panel();
            tbxFirstName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(12, 12);
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.Size = new Size(430, 103);
            dgvList.TabIndex = 0;
            dgvList.CellClick += dgvList_CellContentClick;
            dgvList.CellContentClick += dgvList_CellContentClick;
            // 
            // btnView
            // 
            btnView.Location = new Point(454, 92);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 23);
            btnView.TabIndex = 1;
            btnView.Text = "VIEW";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(209, 413);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(75, 23);
            btnBook.TabIndex = 2;
            btnBook.Text = "BOOK";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(12, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 448);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(monthCalendar1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnBook);
            panel2.Location = new Point(535, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 448);
            panel2.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(tbxID);
            panel6.Location = new Point(131, 46);
            panel6.Name = "panel6";
            panel6.Size = new Size(227, 32);
            panel6.TabIndex = 13;
            // 
            // tbxID
            // 
            tbxID.BackColor = SystemColors.Control;
            tbxID.BorderStyle = BorderStyle.None;
            tbxID.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxID.ForeColor = Color.Black;
            tbxID.Location = new Point(3, 7);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(221, 18);
            tbxID.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(131, 239);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 15;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(dateTimePicker1);
            panel5.Location = new Point(131, 192);
            panel5.Name = "panel5";
            panel5.Size = new Size(227, 35);
            panel5.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(14, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(tbxLastName);
            panel4.Location = new Point(131, 140);
            panel4.Name = "panel4";
            panel4.Size = new Size(227, 32);
            panel4.TabIndex = 13;
            // 
            // tbxLastName
            // 
            tbxLastName.BackColor = SystemColors.Control;
            tbxLastName.BorderStyle = BorderStyle.None;
            tbxLastName.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxLastName.ForeColor = Color.Black;
            tbxLastName.Location = new Point(3, 7);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(221, 18);
            tbxLastName.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(tbxFirstName);
            panel3.Location = new Point(131, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 32);
            panel3.TabIndex = 12;
            // 
            // tbxFirstName
            // 
            tbxFirstName.BackColor = SystemColors.Control;
            tbxFirstName.BorderStyle = BorderStyle.None;
            tbxFirstName.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbxFirstName.ForeColor = Color.Black;
            tbxFirstName.Location = new Point(3, 7);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(221, 18);
            tbxFirstName.TabIndex = 4;
            // 
            // Explore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 581);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnView);
            Controls.Add(dgvList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Explore";
            Text = "Explore";
            Load += Explore_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvList;
        private Button btnView;
        private Button btnBook;
        private Panel panel1;
        private Panel panel2;
        private MonthCalendar monthCalendar1;
        private Panel panel5;
        private DateTimePicker dateTimePicker1;
        private Panel panel4;
        private TextBox tbxLastName;
        private Panel panel3;
        private TextBox tbxFirstName;
        private Panel panel6;
        private TextBox textBox2;
        private TextBox tbxID;
    }
}