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
    public partial class Schedule : Form
    {
        private int userId;
        public User user;

        // Modify the constructor to accept the user object
        public Schedule(int userId, User user)
        {
            InitializeComponent();
            this.userId = userId;
            this.user = user; // Assign the passed user object to the user property
            PopulateDataGridView(userId);

            if (user.UserType == "Photographer")
            {
                // If the user is a photographer, show the pnlConsched panel
                pnlConsched.Visible = true;
                pnlConsched.BringToFront();
            }
            else
            {
                // If the user is not a photographer, hide the pnlConsched panel
                pnlConsched.Visible = false;
            }
        }

        private void PopulateDataGridView(int userId)
        {
            try
            {
                // Fetch bookings from the database using the GetUserBookings method of the User class
                List<Booking> bookings = user.GetUserBookings(userId); // Use the user object passed from the constructor

                // Check if any data is returned
                if (bookings != null && bookings.Count > 0)
                {
                    // Set the DataSource of the DataGridView to the list of bookings
                    dgvSchedule.DataSource = bookings;
                    dgvConfirmation.DataSource = bookings;


                    // Optionally, auto-resize columns to fit content
                    dgvSchedule.AutoResizeColumns();
                    dgvConfirmation.AutoResizeColumns();

                }
                else
                {
                    MessageBox.Show("No bookings found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection errors
                MessageBox.Show($"An error occurred while fetching bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected
            if (dgvSchedule.SelectedCells.Count > 0)
            {
                // Ask the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm Booking Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Get the booking ID from the selected row
                    int bookingID = Convert.ToInt32(dgvSchedule.SelectedCells[0].OwningRow.Cells["BookingID"].Value);

                    // Call the DeleteBooking method with the retrieved booking ID
                    bool success = user.DeleteBooking(bookingID);

                    // Check if the booking was successfully deleted
                    if (success)
                    {
                        // Inform the user and refresh the DataGridView
                        MessageBox.Show("Booking canceled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateDataGridView(userId);
                    }
                    else
                    {
                        // Inform the user if the deletion failed
                        MessageBox.Show("Failed to cancel booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Inform the user if no cell is selected
                MessageBox.Show("Please select a booking to cancel.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvSchedule_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedCells.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvSchedule.SelectedCells[0].OwningRow;

                // Get the booking date from the selected row
                DateTime bookingDate = Convert.ToDateTime(selectedRow.Cells["BookingDate"].Value);

                // Set the value of the DateTimePicker to the booking date
                dateTimePicker1.Value = bookingDate;

                // Set the value of the MonthCalendar to the booking date
                monthCalendar1.SetDate(bookingDate);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected
            if (dgvSchedule.SelectedCells.Count > 0)
            {
                // Ask the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to update this booking?", "Confirm Booking Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvSchedule.SelectedCells[0].OwningRow;

                    // Get the booking ID from the selected row
                    int bookingID = Convert.ToInt32(selectedRow.Cells["BookingID"].Value);

                    // Get the new booking date from the DateTimePicker
                    DateTime newBookingDate = dateTimePicker1.Value;

                    // Call the UpdateBooking method to update the booking
                    bool success = user.UpdateBooking(bookingID, newBookingDate);

                    // Check if the booking was successfully updated
                    if (success)
                    {
                        // Inform the user and refresh the DataGridView
                        MessageBox.Show("Booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateDataGridView(userId);
                    }
                    else
                    {
                        // Inform the user if the update failed
                        MessageBox.Show("Failed to update booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Inform the user if no cell is selected
                MessageBox.Show("Please select a booking to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbxID.Text = dgvSchedule.Rows[e.RowIndex].Cells["BookingID"].Value.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(dateTimePicker1.Value);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = monthCalendar1.SelectionStart;
        }

        private void pnlConsched_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected
            if (dgvConfirmation.SelectedCells.Count > 0)
            {
                // Ask the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to update this booking?", "Confirm Booking Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvConfirmation.SelectedCells[0].OwningRow;

                    // Get the booking ID from the selected row
                    int bookingID = Convert.ToInt32(selectedRow.Cells["BookingID"].Value);

                    // Call the ConfirmBooking method to confirm the booking
                    bool success = user.ConfirmBooking(bookingID);

                    // Check if the booking was successfully confirmed
                    if (success)
                    {
                        // Inform the user and refresh the DataGridView
                        MessageBox.Show("Booking confirmed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateDataGridView(userId);
                    }
                    else
                    {
                        // Inform the user if the confirmation failed
                        MessageBox.Show("Failed to confirm booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Inform the user if no cell is selected
                MessageBox.Show("Please select a booking to confirm.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }
    }
}
