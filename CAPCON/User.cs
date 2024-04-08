using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CAPCON
{
    public class User : BaseModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPass { get; set; }
        public string UserType { get; set;}

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

                // Print the assigned values to verify

            }
            else
            {
                Console.WriteLine("User not found.");
            }
            return user;
        }
    }
}
