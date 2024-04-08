using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPCON
{
    public partial class Main : Form
    {
        private string email;
        private string password;
        private string name;
        private string role;
        private int userID;

        public Main(string email, string password, int userID)
        {
            InitializeComponent();

            // Assign email, password, and userID
            this.email = email;
            this.password = password;
            this.userID = userID;

            // Retrieve user information
            GetUserInformation(userID);

            // Update labels with user information
            UpdateLabels();
        }

        private void GetUserInformation(int userID)
        {
            User user = User.GetUserById(userID);
            name = user.Firstname;
            role = user.UserType;
        }

        private void UpdateLabels()
        {
            // Display user's name in welcome label
            lblName.Text = name;

            // Display user's role in role label
            lblRole.Text = role;
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            // Ask the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked Yes
            if (result == DialogResult.Yes)
            {
                // Close the current form (Main form)
                this.Close();

                // Show the login form (Form1)
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(userID);
            profile.TopLevel = false;
            pnlContent.Controls.Add(profile);
            profile.BringToFront();
            profile.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.TopLevel = false;
            pnlContent.Controls.Add(home);
            home.BringToFront();
            home.Show();
        }
    }
}
