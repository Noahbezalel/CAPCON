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
            dgvList.Columns[dgvList.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PopulateDataGridView()
        {
  
            dgvList.Columns.Clear();
            dgvList.AutoGenerateColumns = true;

            try
            {
                // Fetch data from the database
                List<User> photographers = User.GetPhotographers();

                // Check if any data is returned
                if (photographers != null && photographers.Count > 0)
                {
                   
                    dgvList.DataSource = photographers;

                    dgvList.AutoResizeColumns();
                }
                else
                {
                  
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as database connection errors
                MessageBox.Show($"An error occurred while fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
