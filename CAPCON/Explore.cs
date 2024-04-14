using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPCON
{
    public partial class Explore : Form
    {


        public Explore()
        {
            InitializeComponent();
            PopulateDataGridView();
            dgvList.Columns[dgvList.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbxID.Text = dgvList.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                tbxFirstName.Text = dgvList.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
                tbxLastName.Text = dgvList.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();
            }
        }
        private void PopulateDataGridView()
        {
            try
            {
                // Fetch data from the database
                List<User> photographers = User.GetPhotographers();

                // Check if any data is returned
                if (photographers != null && photographers.Count > 0)
                {
                    // Set the DataSource of the DataGridView to the list of photographers
                    dgvList.DataSource = photographers;

                    // Optionally, auto-resize columns to fit content
                    dgvList.AutoResizeColumns();
                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection errors
                MessageBox.Show($"An error occurred while fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            // Retrieve the UserID of the logged-in user
            int userId = SessionManager.GetLoggedInUserID();

            // Check if the UserID is valid
            if (userId != -1)
            {
                // Parse the photographerID from lblID.Text
                if (int.TryParse(tbxID.Text, out int photographerId))
                {
                    // Get the booking date from wherever it's determined
                    DateTime bookingDate = dateTimePicker1.Value;

                    // Create a new instance of the User class and call the CreateBooking method
                    User user = new User();
                    bool bookingSuccess = user.CreateBooking(userId, photographerId, bookingDate); // Assuming userId can be used as clientId

                    // Optionally, display a message to indicate whether the booking was successful
                    if (bookingSuccess)
                    {
                        MessageBox.Show("Booking created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to create booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid photographer ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(dateTimePicker1.Value);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = monthCalendar1.SelectionStart;
        }

        private void Explore_Load(object sender, EventArgs e)
        {

        }
    }
}
