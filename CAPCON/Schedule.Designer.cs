namespace CAPCON
{
    partial class Schedule
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
            dgvSchedule = new DataGridView();
            btnEdit = new Button();
            btnCancel = new Button();
            monthCalendar1 = new MonthCalendar();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            artanPanel1 = new ArtanComponent.ArtanPanel();
            artanPanel2 = new ArtanComponent.ArtanPanel();
            panel6 = new Panel();
            tbxID = new TextBox();
            dgvConfirmation = new DataGridView();
            pnlConsched = new Panel();
            btnDecline = new Button();
            btnAccept = new Button();
            artanPanel3 = new ArtanComponent.ArtanPanel();
            artanPanel4 = new ArtanComponent.ArtanPanel();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            panel1.SuspendLayout();
            artanPanel1.SuspendLayout();
            artanPanel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConfirmation).BeginInit();
            pnlConsched.SuspendLayout();
            artanPanel3.SuspendLayout();
            artanPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSchedule.BackgroundColor = Color.White;
            dgvSchedule.BorderStyle = BorderStyle.None;
            dgvSchedule.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(12, 12);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowTemplate.Height = 25;
            dgvSchedule.Size = new Size(1000, 143);
            dgvSchedule.TabIndex = 0;
            dgvSchedule.CellClick += dgvSchedule_CellClick;
            dgvSchedule.CellContentClick += dgvSchedule_CellContentClick;
            dgvSchedule.SelectionChanged += dgvSchedule_SelectionChanged;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(-15, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 25);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "UPDATE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(-34, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(239, 25);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(25, 38);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 17;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(artanPanel1);
            panel1.Controls.Add(artanPanel2);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(monthCalendar1);
            panel1.Location = new Point(12, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 207);
            panel1.TabIndex = 18;
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 30;
            artanPanel1.Controls.Add(btnCancel);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 90F;
            artanPanel1.GradientBottomColor = Color.CadetBlue;
            artanPanel1.GradientTopColor = Color.DodgerBlue;
            artanPanel1.Location = new Point(455, 170);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(174, 30);
            artanPanel1.TabIndex = 20;
            // 
            // artanPanel2
            // 
            artanPanel2.BackColor = Color.White;
            artanPanel2.BorderRadius = 30;
            artanPanel2.Controls.Add(btnEdit);
            artanPanel2.ForeColor = Color.Black;
            artanPanel2.GradientAngle = 90F;
            artanPanel2.GradientBottomColor = Color.CadetBlue;
            artanPanel2.GradientTopColor = Color.DodgerBlue;
            artanPanel2.Location = new Point(264, 170);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Size = new Size(174, 30);
            artanPanel2.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(tbxID);
            panel6.Location = new Point(264, 38);
            panel6.Name = "panel6";
            panel6.Size = new Size(227, 32);
            panel6.TabIndex = 18;
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
            // dgvConfirmation
            // 
            dgvConfirmation.BackgroundColor = Color.White;
            dgvConfirmation.BorderStyle = BorderStyle.None;
            dgvConfirmation.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvConfirmation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConfirmation.Location = new Point(12, 3);
            dgvConfirmation.Name = "dgvConfirmation";
            dgvConfirmation.RowTemplate.Height = 25;
            dgvConfirmation.Size = new Size(1000, 159);
            dgvConfirmation.TabIndex = 19;
            // 
            // pnlConsched
            // 
            pnlConsched.Controls.Add(artanPanel4);
            pnlConsched.Controls.Add(artanPanel3);
            pnlConsched.Controls.Add(dgvConfirmation);
            pnlConsched.Dock = DockStyle.Bottom;
            pnlConsched.Location = new Point(0, 382);
            pnlConsched.Name = "pnlConsched";
            pnlConsched.Size = new Size(1024, 199);
            pnlConsched.TabIndex = 20;
            pnlConsched.Paint += pnlConsched_Paint;
            // 
            // btnDecline
            // 
            btnDecline.BackColor = Color.Transparent;
            btnDecline.Cursor = Cursors.Hand;
            btnDecline.FlatAppearance.BorderSize = 0;
            btnDecline.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDecline.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDecline.FlatStyle = FlatStyle.Flat;
            btnDecline.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecline.ForeColor = Color.White;
            btnDecline.Location = new Point(-3, 0);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(147, 23);
            btnDecline.TabIndex = 21;
            btnDecline.Text = "Decline";
            btnDecline.UseVisualStyleBackColor = false;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Transparent;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAccept.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(-9, 1);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(160, 23);
            btnAccept.TabIndex = 20;
            btnAccept.Text = "ACCEPT";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // artanPanel3
            // 
            artanPanel3.BackColor = Color.White;
            artanPanel3.BorderRadius = 30;
            artanPanel3.Controls.Add(btnAccept);
            artanPanel3.ForeColor = Color.Black;
            artanPanel3.GradientAngle = 90F;
            artanPanel3.GradientBottomColor = Color.CadetBlue;
            artanPanel3.GradientTopColor = Color.DodgerBlue;
            artanPanel3.Location = new Point(724, 169);
            artanPanel3.Name = "artanPanel3";
            artanPanel3.Size = new Size(141, 23);
            artanPanel3.TabIndex = 22;
            // 
            // artanPanel4
            // 
            artanPanel4.BackColor = Color.White;
            artanPanel4.BorderRadius = 30;
            artanPanel4.Controls.Add(btnDecline);
            artanPanel4.ForeColor = Color.Black;
            artanPanel4.GradientAngle = 90F;
            artanPanel4.GradientBottomColor = Color.CadetBlue;
            artanPanel4.GradientTopColor = Color.DodgerBlue;
            artanPanel4.Location = new Point(871, 169);
            artanPanel4.Name = "artanPanel4";
            artanPanel4.Size = new Size(141, 23);
            artanPanel4.TabIndex = 23;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 581);
            Controls.Add(pnlConsched);
            Controls.Add(panel1);
            Controls.Add(dgvSchedule);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Schedule";
            Text = "Schedule";
            Load += Schedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            panel1.ResumeLayout(false);
            artanPanel1.ResumeLayout(false);
            artanPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConfirmation).EndInit();
            pnlConsched.ResumeLayout(false);
            artanPanel3.ResumeLayout(false);
            artanPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSchedule;
        private Button btnEdit;
        private Button btnCancel;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Panel panel6;
        private TextBox tbxID;
        private DataGridView dgvConfirmation;
        private Panel pnlConsched;
        private Button btnDecline;
        private Button btnAccept;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ArtanComponent.ArtanPanel artanPanel4;
        private ArtanComponent.ArtanPanel artanPanel3;
    }
}