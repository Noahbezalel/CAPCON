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
    public partial class Gallery : Form
    {
        private string imageFilePath;
        public Gallery()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(imageFilePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox2.Image = Image.FromFile(imageFilePath);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox3.Image = Image.FromFile(imageFilePath);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox4.Image = Image.FromFile(imageFilePath);
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox5.Image = Image.FromFile(imageFilePath);
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox6.Image = Image.FromFile(imageFilePath);
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox7.Image = Image.FromFile(imageFilePath);
                    pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox8.Image = Image.FromFile(imageFilePath);
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox9.Image = Image.FromFile(imageFilePath);
                    pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFilePath = openFileDialog.FileName;
                    pictureBox10.Image = Image.FromFile(imageFilePath);
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UploadPhoto(pictureBox1);
            UploadPhoto(pictureBox2);
            UploadPhoto(pictureBox3);
            UploadPhoto(pictureBox9);
            UploadPhoto(pictureBox6);
            UploadPhoto(pictureBox7);
            UploadPhoto(pictureBox4);
            UploadPhoto(pictureBox5);
            UploadPhoto(pictureBox10);
            UploadPhoto(pictureBox8);
        }

        private bool UploadPhoto(PictureBox pictureBox)
        {
            // Check if the PictureBox has an image
            if (pictureBox.Image != null)
            {
                User user = new User();
                // Call the UploadPhotos method and return its result
                return user.UploadPhotos(pictureBox);
            }
            else
            {
                MessageBox.Show("Please select an image for PictureBox " + pictureBox.Name);
                return false;
            }
        }

        private void LoadImagesFromDatabase()
        {
            // Create an instance of the User class
            User user = new User();

            // Call the GetImagesFromDatabase method to retrieve images
            List<Image> images = user.GetImagesFromDatabase();

            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox9, pictureBox6, pictureBox7, pictureBox4, pictureBox5, pictureBox10, pictureBox8 };

            // Load images into PictureBoxes
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                if (i < images.Count)
                {
                    try
                    {
                        pictureBoxes[i].Image = images[i];
                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            LoadImagesFromDatabase();
        }
    }
}
