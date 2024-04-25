namespace CAPCON
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            artanPanel5 = new ArtanComponent.ArtanPanel();
            label1 = new Label();
            artanPanel4 = new ArtanComponent.ArtanPanel();
            label2 = new Label();
            artanPanel3 = new ArtanComponent.ArtanPanel();
            monthCalendar1 = new MonthCalendar();
            dateTimePicker1 = new DateTimePicker();
            artanPanel2 = new ArtanComponent.ArtanPanel();
            dgvPastsched = new DataGridView();
            artanPanel1 = new ArtanComponent.ArtanPanel();
            dgvConsched = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            artanPanel5.SuspendLayout();
            artanPanel4.SuspendLayout();
            artanPanel3.SuspendLayout();
            artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPastsched).BeginInit();
            artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsched).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(artanPanel5);
            panel2.Controls.Add(artanPanel4);
            panel2.Controls.Add(artanPanel3);
            panel2.Controls.Add(artanPanel2);
            panel2.Controls.Add(artanPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1024, 581);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 216);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // artanPanel5
            // 
            artanPanel5.BackColor = Color.White;
            artanPanel5.BorderRadius = 30;
            artanPanel5.Controls.Add(label1);
            artanPanel5.ForeColor = Color.Black;
            artanPanel5.GradientAngle = 90F;
            artanPanel5.GradientBottomColor = Color.FromArgb(244, 244, 245);
            artanPanel5.GradientTopColor = Color.FromArgb(244, 244, 245);
            artanPanel5.Location = new Point(12, 402);
            artanPanel5.Name = "artanPanel5";
            artanPanel5.Size = new Size(1000, 39);
            artanPanel5.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 23);
            label1.TabIndex = 5;
            label1.Text = "Previous Bookings";
            // 
            // artanPanel4
            // 
            artanPanel4.BackColor = Color.White;
            artanPanel4.BorderRadius = 30;
            artanPanel4.Controls.Add(label2);
            artanPanel4.ForeColor = Color.Black;
            artanPanel4.GradientAngle = 90F;
            artanPanel4.GradientBottomColor = Color.FromArgb(244, 244, 245);
            artanPanel4.GradientTopColor = Color.FromArgb(244, 244, 245);
            artanPanel4.Location = new Point(12, 234);
            artanPanel4.Name = "artanPanel4";
            artanPanel4.Size = new Size(1000, 39);
            artanPanel4.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(101, 9);
            label2.Name = "label2";
            label2.Size = new Size(174, 23);
            label2.TabIndex = 5;
            label2.Text = "Upcoming Bookings";
            // 
            // artanPanel3
            // 
            artanPanel3.BackColor = Color.White;
            artanPanel3.BorderRadius = 30;
            artanPanel3.Controls.Add(monthCalendar1);
            artanPanel3.Controls.Add(dateTimePicker1);
            artanPanel3.ForeColor = Color.Black;
            artanPanel3.GradientAngle = 90F;
            artanPanel3.GradientBottomColor = Color.CadetBlue;
            artanPanel3.GradientTopColor = Color.DodgerBlue;
            artanPanel3.Location = new Point(754, 12);
            artanPanel3.Name = "artanPanel3";
            artanPanel3.Size = new Size(255, 210);
            artanPanel3.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(16, 13);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(31, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // artanPanel2
            // 
            artanPanel2.BackColor = Color.White;
            artanPanel2.BorderRadius = 30;
            artanPanel2.Controls.Add(dgvPastsched);
            artanPanel2.ForeColor = Color.Black;
            artanPanel2.GradientAngle = 90F;
            artanPanel2.GradientBottomColor = Color.FromArgb(162, 250, 163);
            artanPanel2.GradientTopColor = Color.FromArgb(146, 201, 177);
            artanPanel2.Location = new Point(12, 441);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Size = new Size(1000, 128);
            artanPanel2.TabIndex = 9;
            // 
            // dgvPastsched
            // 
            dgvPastsched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPastsched.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPastsched.BackgroundColor = Color.White;
            dgvPastsched.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPastsched.Location = new Point(97, 14);
            dgvPastsched.Name = "dgvPastsched";
            dgvPastsched.RowTemplate.Height = 25;
            dgvPastsched.Size = new Size(820, 100);
            dgvPastsched.TabIndex = 6;
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 30;
            artanPanel1.Controls.Add(dgvConsched);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 90F;
            artanPanel1.GradientBottomColor = Color.CadetBlue;
            artanPanel1.GradientTopColor = Color.DodgerBlue;
            artanPanel1.Location = new Point(12, 273);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(1000, 128);
            artanPanel1.TabIndex = 8;
            // 
            // dgvConsched
            // 
            dgvConsched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvConsched.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConsched.BackgroundColor = Color.White;
            dgvConsched.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(244, 244, 245);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConsched.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsched.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConsched.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConsched.Location = new Point(97, 15);
            dgvConsched.Name = "dgvConsched";
            dgvConsched.RowTemplate.Height = 25;
            dgvConsched.Size = new Size(820, 100);
            dgvConsched.TabIndex = 4;
            dgvConsched.CellContentClick += dgvConsched_CellContentClick;
            dgvConsched.SelectionChanged += dgvConsched_SelectionChanged;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 581);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            artanPanel5.ResumeLayout(false);
            artanPanel5.PerformLayout();
            artanPanel4.ResumeLayout(false);
            artanPanel4.PerformLayout();
            artanPanel3.ResumeLayout(false);
            artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPastsched).EndInit();
            artanPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConsched).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private MonthCalendar monthCalendar1;
        private DataGridView dgvPastsched;
        private Label label2;
        private DataGridView dgvConsched;
        private ArtanComponent.ArtanPanel artanPanel1;
        private DateTimePicker dateTimePicker1;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ArtanComponent.ArtanPanel artanPanel3;
        private ArtanComponent.ArtanPanel artanPanel5;
        private Label label1;
        private ArtanComponent.ArtanPanel artanPanel4;
        private PictureBox pictureBox1;
    }
}