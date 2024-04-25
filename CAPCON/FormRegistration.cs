using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CAPCON
{
    public partial class FormRegistration : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Noah\\source\\database\\CaptureConnectDB.accdb";
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fname = tbxFirstName.Text;
            string lname = tbxLastName.Text;
            string email = tbxAddemail.Text;
            string password = tbxAddpass.Text;
            string cpass = tbxConpass.Text;
            string role = GetSelectedRole();

            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(cpass) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields and select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Users (FirstName, LastName, email, [password], [confirm_password], [user_type]) VALUES (@FName, @LName, @Email, @Password, @Conpass, @UserType)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FName", fname);
                        command.Parameters.AddWithValue("@LName", lname);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Conpass", cpass);
                        command.Parameters.AddWithValue("@UserType", role);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Get the UserID of the newly inserted user
                            query = "SELECT @@IDENTITY";
                            command.CommandText = query;
                            int userID = Convert.ToInt32(command.ExecuteScalar());

                            // Insert user into appropriate table based on role
                            if (role == "Client")
                            {
                                query = "INSERT INTO Clients (UserID, FirstName, LastName, email) VALUES (@UserID, @FName, @LName, @Email)";
                            }
                            else if (role == "Photographer")
                            {
                                query = "INSERT INTO Photographers (UserID, FirstName, LastName, email) VALUES (@UserID, @FName, @LName, @Email)";
                            }
                            command.CommandText = query;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@UserID", userID);
                            command.Parameters.AddWithValue("@FName", fname);
                            command.Parameters.AddWithValue("@LName", lname);
                            command.Parameters.AddWithValue("@Email", email);
                            command.ExecuteNonQuery();

                            MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear TextBoxes and RadioButtons after successful registration
                            tbxFirstName.Clear();
                            tbxLastName.Clear();
                            tbxAddemail.Clear();
                            tbxAddpass.Clear();
                            tbxConpass.Clear();
                            ClearRadioButtons();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private string GetSelectedRole()
        {
            if (rbtnClient.Checked)
                return "Client";
            else if (rbtnPhotographer.Checked)
                return "Photographer";
            else
                return "";
        }

        private void ClearRadioButtons()
        {
            rbtnClient.Checked = false;
            rbtnPhotographer.Checked = false;
        }
    }
}
