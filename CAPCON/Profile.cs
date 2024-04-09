using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CAPCON
{
    public partial class Profile : Form
    {
        private string imageFilePath;
        private Bitmap originalImage;
        private int userID;
        public User user;

        public Profile(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            user = User.GetUserById(userID);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblRole.Text = user.UserType;
            tbxFirstName.Text = user.Firstname;
            tbxLastName.Text = user.Lastname;
            tbxEmail.Text = user.Email;
            tbxContact.Text = user.Contact;

            // Check if a user image file path is available
            if (!string.IsNullOrEmpty(user.UserImage))
            {
                // Load the image from the Base64 string
                Image loadedImage = User.Base64ToImage(user.UserImage);
                pictureBox.Image = loadedImage;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }





        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update user object with new information
            user.Firstname = tbxFirstName.Text;
            user.Lastname = tbxLastName.Text;
            user.Email = tbxEmail.Text;
            user.Contact = tbxContact.Text;

            // Save changes to the database, passing the image file path
            bool success = user.UpdateUser(imageFilePath);
            if (success)
            {
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Attempt to delete the user
                bool success = user.DeleteUser();
                if (success)
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, you can close the form or perform any other action after successful deletion
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Failed to delete user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(imageFilePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}


