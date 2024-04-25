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
    public partial class Home : Form
    {
        private int userId;
        public User user;

        public Home(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // Initialize the user object using the GetUserById method
            user = User.GetUserById(userId);

            // Check if the user object is not null before loading confirmed bookings
            if (user != null)
            {
                LoadConfirmedBookings();
                LoadFinishedBookings();
            }
            else
            {
                MessageBox.Show("User object is null");
            }
        }

        private void LoadConfirmedBookings()
        {
            if (user != null)
            {
                // Call the method to get confirmed bookings
                List<Booking> confirmedBookings = user.GetConfirmedBookings(userId);

                // Bind the list of bookings to the DataGridView
                dgvConsched.DataSource = confirmedBookings;

                // You can also format the date column to display dates in a specific format
                dgvConsched.Columns["BookingDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else
            {
                MessageBox.Show("User object is null");
            }
        }

        private void LoadFinishedBookings()
        {
            if (user != null)
            {
                // Call the method to get finished bookings
                List<Booking> finishedBookings = user.GetFinishedBookings(userId);

                // Bind the list of finished bookings to the DataGridView dgvPastsched
                dgvPastsched.DataSource = finishedBookings;

                // You can also format the date column to display dates in a specific format
                dgvPastsched.Columns["BookingDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else
            {
                MessageBox.Show("User object is null");
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void dgvConsched_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsched_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvConsched.SelectedCells.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvConsched.SelectedCells[0].OwningRow;

                // Get the booking date from the selected row
                DateTime bookingDate = Convert.ToDateTime(selectedRow.Cells["BookingDate"].Value);

                // Set the value of the DateTimePicker to the booking date
                dateTimePicker1.Value = bookingDate;

                // Set the value of the MonthCalendar to the booking date
                monthCalendar1.SetDate(bookingDate);
            }
        }


    }
}
