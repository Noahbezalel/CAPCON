using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CAPCON
{
    public partial class Form1 : Form
    {
        private string email;
        private string password;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Noah\\source\\database\\CaptureConnectDB.accdb";
        private bool rememberMeChecked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            email = tbxEmail.Text;
            password = tbxPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Count(*) FROM Users WHERE email = @email AND [password] = @password";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            if (rememberMeChecked) // Store credentials if "Remember Me" is checked
                            {
                                // You can save email and password securely here
                                // For demonstration, let's assume we're saving them in variables
                                Properties.Settings.Default.RememberedEmail = email;
                                Properties.Settings.Default.RememberedPassword = password;
                                Properties.Settings.Default.Save();
                            }

                            // Retrieve userID from database
                            int userID = GetUserIDFromDatabase(email);

                            // Set the UserID in the session
                            SessionManager.SetSessionValue("UserID", userID);

                            // Open the Main form
                            Main mainForm = new Main(email, password, userID);
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private int GetUserIDFromDatabase(string email)
        {
            // Initialize the userID variable to store the result
            int userID = -1; // Default value if the userID is not found or an error occurs

            // Connection string
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Noah\\source\\database\\CaptureConnectDB.accdb";

            // SQL query to retrieve userID based on email
            string query = "SELECT UserID FROM Users WHERE email = @Email";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    connection.Open();
                    // Execute the query to retrieve the userID
                    object result = command.ExecuteScalar();

                    // Check if the result is not null
                    if (result != null && result != DBNull.Value)
                    {
                        // Parse the result to integer and assign it to userID
                        userID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions (e.g., database connection error, query execution error)
                    MessageBox.Show("An error occurred while retrieving userID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Return the retrieved userID
            return userID;
        }

        private void cbxRemember_CheckedChanged(object sender, EventArgs e)
        {
            rememberMeChecked = cbxRemember.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberedEmail != string.Empty &&
                Properties.Settings.Default.RememberedPassword != string.Empty)
            {
                tbxEmail.Text = Properties.Settings.Default.RememberedEmail;
                tbxPassword.Text = Properties.Settings.Default.RememberedPassword;
                cbxRemember.Checked = true;
            }
        }
    }
}
