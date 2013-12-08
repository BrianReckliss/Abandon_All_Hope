using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Abandon_All_Hope
{
    public partial class Form1 : Form
    {
        /*
        Load Image Directory / Current Image
        protected string[] pFileNames;
        protected int pCurrentImage = -1;
        */

        List<string> files;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //######################Fix shit in here
        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string dirPath = fbd.ToString();
            files = new List<string>(Directory.EnumerateFiles(dirPath));
            picBox1.Image = Bitmap.FromFile(files[index]);
            lblDir.Text = files[index];

            
            /* DEBUG 1######################
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;
            ofd.Title = "Select Image";
            ofd.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Create a new Bitmap object from the picture file on disk,
                // and assign that to the PictureBox.Image property
                try
                {
                    pFileNames = ofd.FileNames;
                    pCurrentImage = 0;
                    ShowCurrentImage();
                }
                catch (System.ArgumentException error)
                {
                    MessageBox.Show("File type not supported.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                lblDir.Text = ofd.FileName;
            }
            */
        }

        // Previous Image in Directory
        private void btnPrevImg_Click(object sender, EventArgs e)
        {
            --index;
            if (index < 0)
                index = files.Count - 1;

            picBox1.Image = Bitmap.FromFile(files[index]);
            lblDir.Text = files[index];
        }

        // Scale Image between CenterImage and Zoom(Fit)
        private void btnScale_Click(object sender, EventArgs e)
        {
            if (picBox1.SizeMode == PictureBoxSizeMode.CenterImage)
                picBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else
                picBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        // Next Image in Directory
        private void btnNextImg_Click(object sender, EventArgs e)
        {
            ++index;
            if (index >= files.Count)
                index = 0;
            picBox1.Image = Bitmap.FromFile(files[index]);
            lblDir.Text = files[index];
        }

    }
}
