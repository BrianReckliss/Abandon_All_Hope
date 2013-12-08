using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Abandon_All_Hope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "C:\\";
            ofd.Title = "Select Image";
            ofd.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Create a new Bitmap object from the picture file on disk,
                // and assign that to the PictureBox.Image property
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch (System.ArgumentException error)
                {
                    MessageBox.Show("File type not supported.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                lblDir.Text = ofd.FileName;
            }
            ofd.Dispose();
        }
    }
}
