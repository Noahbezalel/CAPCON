using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;
using System.IO;


namespace CAPCON
{
    public class User : BaseModel
    {
        public int UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPass { get; set; }
        public string UserType { get; set;}
        public string Contact { get; set; }
        public string UserImage { get; set; }


        public static User GetUserById(int userID)
        {
            User user = new User();
            string query = $"SELECT * FROM Users WHERE UserID = {userID}";
            DataTable userProfile = user.ExecuteQuery(query);

            // Check if any rows are returned
            if (userProfile.Rows.Count > 0)
            {
                // Assuming there's only one row for the user
                DataRow row = userProfile.Rows[0];

                // Assign values from DataTable to User object properties
                user.Firstname = row["FirstName"].ToString();
                user.Lastname = row["LastName"].ToString();
                user.Email = row["email"].ToString();
                user.UserType = row["user_type"].ToString();
                user.Contact = row["contact_info"].ToString();
                user.UserID = Convert.ToInt32(row["UserID"]);
                user.UserImage = row["UserImage"].ToString();

                // Proper conversion of UserImage
              //  if (row["UserImage"] != DBNull.Value)
             //   {
                    // Convert byte array to string (if UserImage is actually stored as byte array in the database)
             //   }
            }
            else
            {
                //Console.WriteLine("User not found.");
            }
            return user;
        }

        static string ImageToBase64(string imagePath)
        {
            byte[] imageBytes;

            // Read the image file into a byte array
            using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                imageBytes = new byte[fileStream.Length];
                fileStream.Read(imageBytes, 0, (int)fileStream.Length);
            }

            // Convert the byte array to a Base64 string
            string base64String = Convert.ToBase64String(imageBytes);

            return base64String;
        }

        public static Image Base64ToImage(string base64String)
        {
            // Convert the Base64 string back to a byte array
            Console.WriteLine(base64String);
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Create a MemoryStream from the byte array
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                // Create an Image from the MemoryStream
                Image image = Image.FromStream(ms);

                return image;
            }
        }

        public bool UpdateUser(string imagePath)

        {
            string query;
            if (!string.IsNullOrEmpty(imagePath))
            {
                UserImage = ImageToBase64(imagePath);
           
                query = $"UPDATE Users SET FirstName = '{Firstname}', LastName = '{Lastname}', email = '{Email}', contact_info = '{Contact}', UserImage = '{UserImage}' WHERE UserID = {UserID}";

            }
            else
            {
                query = $"UPDATE Users SET FirstName = '{Firstname}', LastName = '{Lastname}', email = '{Email}', contact_info = '{Contact}' WHERE UserID = {UserID}";
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Add parameters for other fields
                    command.Parameters.AddWithValue("@FirstName", Firstname);
                    command.Parameters.AddWithValue("@LastName", Lastname);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Contact", Contact);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }



        public bool DeleteUser()
        {
            // Delete related records in the 'Clients' table
            string clientDeleteQuery = $"DELETE FROM Clients WHERE UserID = {UserID}";
            int clientsDeleted = ExecuteNonQuery(clientDeleteQuery);

            // Delete related records in the 'Photographers' table
            string photographerDeleteQuery = $"DELETE FROM Photographers WHERE UserID = {UserID}";
            int photographersDeleted = ExecuteNonQuery(photographerDeleteQuery);

            // Proceed with deleting the user record if related records in both 'Clients' and 'Photographers' tables are deleted
            if (clientsDeleted >= 0 && photographersDeleted >= 0)
            {
                // Delete the user record from the 'Users' table
                string userDeleteQuery = $"DELETE FROM Users WHERE UserID = {UserID}";
                int rowsAffected = ExecuteNonQuery(userDeleteQuery);
                return rowsAffected > 0;
            }
            else
            {
                // If there was an error or related records were not deleted, return false
                return false;
            }
        }



    }
}
