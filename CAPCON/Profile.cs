using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CAPCON
{
    public partial class Profile : Form
    {
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
            lblFName.Text = user.Firstname;
            lblLName.Text = user.Lastname;
            lblRole.Text = user.UserType;
            tbxFirstName.Text = user.Firstname;
            tbxLastName.Text = user.Lastname;
            tbxEmail.Text = user.Email;
            //tbxContact.Text = user.Firstname;
        }
    }
}
