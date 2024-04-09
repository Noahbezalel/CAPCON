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
    public partial class Explore : Form
    {
        public Explore()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PopulateDataGridView()
        {
            // Call the GetPhotographers() method to retrieve photographers
            List<User> photographers = User.GetPhotographers();

            // Clear existing columns
            dgvList.Columns.Clear();

            // Add columns manually based on selected properties
            dgvList.Columns.Add("UserID", "User ID");
            dgvList.Columns.Add("Firstname", "First Name");
            dgvList.Columns.Add("Lastname", "Last Name");
            dgvList.Columns.Add("Email", "Email");
            dgvList.Columns.Add("Contact", "Contact");
            // You may add more columns as needed...

            // Bind the list of photographers to the DataGridView
            dgvList.DataSource = photographers;
        }

    }
}
