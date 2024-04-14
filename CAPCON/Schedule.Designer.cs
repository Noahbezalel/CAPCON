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
            panel6 = new Panel();
            tbxID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(12, 12);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowTemplate.Height = 25;
            dgvSchedule.Size = new Size(412, 238);
            dgvSchedule.TabIndex = 0;
            dgvSchedule.CellClick += dgvSchedule_CellClick;
            dgvSchedule.CellContentClick += dgvSchedule_CellContentClick;
            dgvSchedule.SelectionChanged += dgvSchedule_SelectionChanged;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(256, 256);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 25);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(343, 256);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 25);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(25, 55);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 17;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(monthCalendar1);
            panel1.Location = new Point(430, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 238);
            panel1.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(tbxID);
            panel6.Location = new Point(282, 20);
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
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 581);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(dgvSchedule);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Schedule";
            Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
    }
}