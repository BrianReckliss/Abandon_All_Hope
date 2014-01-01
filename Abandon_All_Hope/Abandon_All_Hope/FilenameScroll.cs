using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abandon_All_Hope
{
    public class FilenameScroll
    {
        public int scrollIndex = 0;
        public int tickspeed = 100;
        public int freezespeed = 3000;
        public string fancypants;

        /*////////////////////////////////////////////////////////////////////////////////////////////////////*/
        /*//////// I want to use the width of panel1Tagging.Size to make an adjustable display length ////////*/
        /*////////////////////////////////////////////////////////////////////////////////////////////////////*/


        //characters in name
        public int displaylength = 50;
        public int lblLength;

        public FilenameScroll()
        {
            displaylength = 50;
            lblLength = 200;//default size of panel at regular resolution
            fancypants = "";
            int x = displaylength;
            while (x > 0)
            {
                fancypants += " ";
                --x;
            }
        }

        //if the filenamescroll is initialized with the viewerform creating it, you can get the form data without a nullref
        //doing this with pointers in c++ seems like it would be much safer
        public FilenameScroll(ViewerForm f)
        {
            displaylength = 50;
            lblLength = f.panel1Tagging.Size.Width;
            fancypants = "";
            int x = displaylength;
            while (x > 0)
            {
                fancypants += " ";
                --x;
            }
        }

        public void StartScroll()
        {
            scrollIndex = -1;
            Program.VForm.timerScroll.Interval = freezespeed;
            int length = Program.VForm.filename_view.Length;

            string str;

            if (length >= displaylength)
                str = (Program.VForm.filename_view + fancypants).Substring(0, displaylength);
            else
                str = Program.VForm.filename_view;

            Program.VForm.lblDir.Text = str;
            Program.VForm.timerScroll.Start();
        }

        public void scroll()
        {
            Program.VForm.timerScroll.Interval = tickspeed;

            int length = Program.VForm.filename_view.Length;
            int dif = (length-1) - scrollIndex;
            string str;

            if (length < displaylength)
            {
                scrollIndex = 0;
                str = Program.VForm.filename_view;
                Program.VForm.lblDir.Text = str;
                return;
            }
            else
                scrollIndex = (++scrollIndex) % length;

            if (dif - displaylength == 0)
                Program.VForm.timerScroll.Interval = freezespeed;

            if (dif - displaylength < 0)
                dif = displaylength - dif;
            else dif = 0;

            int dispsize = displaylength - dif;
            if (dispsize < 1)
            {
                str = (Program.VForm.filename_view+fancypants).Substring(0, displaylength);
                Program.VForm.timerScroll.Interval = freezespeed;
            }
            else
            str = (Program.VForm.filename_view+fancypants).Substring(scrollIndex, dispsize);

            Program.VForm.lblDir.Text = str;
        }
    }
}
