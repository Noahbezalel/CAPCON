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
using System.Net.Http;



namespace CAPCON
{
    public class SessionManager
    {
        private static Dictionary<string, object> sessionData = new Dictionary<string, object>();

        public static void SetSessionValue(string key, object value)
        {
            if (sessionData.ContainsKey(key))
            {
                sessionData[key] = value;
            }
            else
            {
                sessionData.Add(key, value);
            }
        }

        public static object GetSessionValue(string key)
        {
            if (sessionData.ContainsKey(key))
            {
                return sessionData[key];
            }
            else
            {
                return null;
            }
        }

        public static int GetLoggedInUserID()
        {
            // Retrieve the UserID from session data
            if (GetSessionValue("UserID") != null)
            {
                // Cast the UserID from session to int and return it
                return (int)GetSessionValue("UserID");
            }
            else
            {
                // Return a default value or handle the absence of UserID in session based on your application's logic
                return -1; // or throw an exception, return null, etc.
            }
        }
    }
    public class Booking
    {
        public int BookingID { get; set; }
        public int ClientID { get; set; }
        public int PhotographerID { get; set; }
        public DateTime BookingDate { get; set; }
    }
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
        public int PhotographerID { get; set; }



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

                query = $"UPDATE Users SET FirstName = @FirstName, LastName = @LastName, email = @Email, contact_info = @Contact, UserImage = @UserImage WHERE UserID = {UserID}";

            }
            else
            {
                query = $"UPDATE Users SET FirstName = @FirstName, LastName = @LastName, email = @Email, contact_info = @Contact WHERE UserID = {UserID}";
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

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        command.Parameters.AddWithValue("@UserImage", UserImage);
                    }

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UploadPhotos(PictureBox pictureBox)
        {
            string query = $"INSERT INTO Users Set (PhotoData) VALUES (@PhotoData)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Convert PictureBox image to byte array
                    byte[] photoBytes = ImageToByteArray(pictureBox.Image);

                    // Add photoBytes as parameter
                    command.Parameters.AddWithValue("@PhotoData", photoBytes);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        private byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Change the format according to your requirement
                return ms.ToArray();
            }
        }

        public List<Image> GetImagesFromDatabase()
        {
            List<Image> images = new List<Image>();

            string query = "SELECT PhotoData FROM Photos"; // Replace YourTableName with the actual table name
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0)) // Check if the field is not null
                                {
                                    byte[] imageData = (byte[])reader["PhotoData"];
                                    Image image = ByteArrayToImage(imageData);
                                    if (image != null)
                                    {
                                        images.Add(image);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving images from database: " + ex.Message);
                    }
                }
            }

            return images;
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error converting byte array to image: " + ex.Message);
                return null;
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

        public static List<User> GetPhotographers()
        {
            List<User> photographers = new List<User>();

            // SQL query to select data from Users table and join with Photographers table
            string query = @"SELECT Users.UserID, Users.FirstName, Users.LastName, Users.email, Photographers.PhotographerID
                     FROM Users
                     INNER JOIN Photographers ON Users.UserID = Photographers.UserID";

            // Execute the query and retrieve data into a DataTable
            DataTable photographerData = new User().ExecuteQuery(query);

            // Iterate through the DataTable rows and populate the list of User objects
            foreach (DataRow row in photographerData.Rows)
            {
                User photographer = new User
                {
                    UserID = Convert.ToInt32(row["UserID"]),
                    Firstname = row["FirstName"].ToString(),
                    Lastname = row["LastName"].ToString(),
                    Email = row["email"].ToString(),
                    // Assuming PhotographerID is present in the result set
                    PhotographerID = Convert.ToInt32(row["PhotographerID"])
                };
                photographers.Add(photographer);
            }

            return photographers;
        }

        public bool CreateBooking(int clientId, int photographerId, DateTime bookingDate)
        {
            string query = "INSERT INTO Bookings (ClientID, PhotographerID, BookingDate) " +
                           "VALUES (@ClientID, @PhotographerID, @BookingDate)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", clientId);
                    command.Parameters.AddWithValue("@PhotographerID", photographerId);
                    command.Parameters.AddWithValue("@BookingDate", bookingDate);
   
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public List<Booking> GetUserBookings(int userId)
        {
            List<Booking> bookings = new List<Booking>();

            try
            {
                // SQL query to fetch bookings associated with the specified userID
                string query = "SELECT * FROM Bookings WHERE ClientID = @UserID OR PhotographerID = @UserID";

                // Execute the query and retrieve data into a DataTable
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);

                        DataTable bookingData = new DataTable();
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(bookingData);
                        }

                        // Iterate through the DataTable rows and populate the list of Booking objects
                        foreach (DataRow row in bookingData.Rows)
                        {
                            // Check if the booking is associated with the logged-in user
                            int clientID = Convert.ToInt32(row["ClientID"]);
                            int photographerID = Convert.ToInt32(row["PhotographerID"]);
                            if (clientID == userId || photographerID == userId)
                            {
                                Booking booking = new Booking
                                {
                                    BookingID = Convert.ToInt32(row["BookingID"]),
                                    ClientID = clientID,
                                    PhotographerID = photographerID,
                                    BookingDate = Convert.ToDateTime(row["BookingDate"])
                                };
                                bookings.Add(booking);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection errors
                Console.WriteLine($"An error occurred while fetching bookings: {ex.Message}");
            }

            return bookings;
        }

        public bool DeleteBooking(int bookingID)
        {
            // Construct the SQL query to delete the booking with the given booking ID
            string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";

            // Use a try-catch block to handle any potential exceptions
            try
            {
                // Open a connection to the database
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    // Create a command with parameters for the booking ID
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookingID", bookingID);
                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        // Check if any rows were affected (i.e., if the booking was successfully deleted)
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as database connection errors
                Console.WriteLine($"An error occurred while deleting the booking: {ex.Message}");
                return false; // Return false to indicate that the deletion failed
            }
        }

        public bool UpdateBooking(int bookingID, DateTime newBookingDate)
        {
            // Construct the SQL query to update the booking date
            string query = "UPDATE Bookings SET BookingDate = @BookingDate WHERE BookingID = @BookingID";

            // Use a try-catch block to handle any potential exceptions
            try
            {
                // Open a connection to the database
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    // Create a command with parameters for the new booking date and the booking ID
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookingDate", newBookingDate);
                        command.Parameters.AddWithValue("@BookingID", bookingID);
                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        // Check if any rows were affected (i.e., if the booking date was successfully updated)
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as database connection errors
                Console.WriteLine($"An error occurred while updating the booking: {ex.Message}");
                return false; // Return false to indicate that the update failed
            }
        }
    }
}
