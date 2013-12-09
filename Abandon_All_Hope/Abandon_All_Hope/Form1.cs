using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Abandon_All_Hope
{
    public partial class Form1 : Form
    {
        List<string> files;
        int index = 0;
        int iScroll = 0;
        public string filename_view = "";

        //Constructor
        public Form1()
        {
            InitializeComponent();
        }

        public bool file_is_valid(string name)
        {
            string[] w = new string[4] { ".jpg", ".jpeg", ".gif", ".png" };
            int x;
            for (x = 0; x < w.Length; ++x)
            {
                if(name.ToLower().Contains(w[x]))
                    return true;
            }
            return false;
        }

        //######################Fix shit in here
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Picture Files (*.jpeg, *.jpg, *.png, )|*.jpeg;*.jpg;*.png;*.gif|All Files (*.*)|*.*|GIF Files (*.gif)|*.gif";
            ofd.ShowDialog();
            index = 0;

            try
            {
                picBox1.Image = Bitmap.FromFile(ofd.FileName);
                filename_view = ofd.FileName;

            }
            catch (System.OutOfMemoryException error)
            {
                picBox1.Image = null;
                index = -1;
                filename_view = "Invalid file: " + ofd.FileName;
            }
            catch (System.ArgumentException error)
            {
                picBox1.Image = null;
                index = -1;
                filename_view = "Invalid file: " + ofd.FileName;
            }

            string filePath = ofd.FileName;
            string directoryPath = Path.GetDirectoryName(filePath);
            files = new List<string>(Directory.EnumerateFiles(directoryPath));

            //this code is used to remove any files from our files list that are invalid
            int x = 0;
            for (x = 0; x < files.Count; ++x)
            {
                if (file_is_valid(files[x]))
                {
                    continue;
                }
                else
                {
                    files.RemoveAt(x);
                    x--;
                }
            }

            //now that we've gotten rid of our garbage files, figure out which index the file we opened uses
            for (x = 0; x < files.Count; ++x)
            {
                if (ofd.FileName == files[x])
                    index = x;
            }

            timerScroll.Start();
        }



        // Previous Image in Directory
        private void btnPrevImg_Click(object sender, EventArgs e)
        {
            --index;
            if (index < 0)
                index = files.Count - 1;
            picBox1.Image = Bitmap.FromFile(files[index]);
            timerScroll.Start();
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
            timerScroll.Start();
        }


        // Timer for Scrolling Directory Label
        private void timerScroll_Tick(object sender, EventArgs e)
        {
            iScroll++;
            int iLmt = filename_view.Length - iScroll;
            if (iLmt < 50)
                iScroll = 0;
            if (iScroll == 0)
                timerScroll.Stop();

            string str = filename_view.Substring(iScroll, 50);
            lblDir.Text = str;
        }



        /* Resize Thumbnail(s)
        private void resizeImage(string path, string originalFilename,
                     int canvasWidth, int canvasHeight,
                     int originalWidth, int originalHeight)
        {
            Image image = Image.FromFile(path + originalFilename);

            System.Drawing.Image thumbnail =
                new Bitmap(canvasWidth, canvasHeight); // changed parm names
            System.Drawing.Graphics graphic =
                            System.Drawing.Graphics.FromImage(thumbnail);

            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = CompositingQuality.HighQuality;

            // Figure out the ratio
            double ratioX = (double)canvasWidth / (double)originalWidth;
            double ratioY = (double)canvasHeight / (double)originalHeight;
            // use whichever multiplier is smaller
            double ratio = ratioX < ratioY ? ratioX : ratioY;

            // now we can get the new height and width
            int newHeight = Convert.ToInt32(originalHeight * ratio);
            int newWidth = Convert.ToInt32(originalWidth * ratio);

            // Now calculate the X,Y position of the upper-left corner 
            // (one of these will always be zero)
            int posX = Convert.ToInt32((canvasWidth - (originalWidth * ratio)) / 2);
            int posY = Convert.ToInt32((canvasHeight - (originalHeight * ratio)) / 2);

            graphic.Clear(Color.White); // white padding
            graphic.DrawImage(image, posX, posY, newWidth, newHeight);

            System.Drawing.Imaging.ImageCodecInfo[] info =
                                ImageCodecInfo.GetImageEncoders();
            EncoderParameters encoderParameters;
            encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality,
                                100L);
            thumbnail.Save(path + width + "." + originalFilename, info[1],
                                encoderParameters);
        }
        */
    }
}
