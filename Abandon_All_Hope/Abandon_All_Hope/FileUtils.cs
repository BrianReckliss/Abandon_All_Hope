using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abandon_All_Hope
{
    public class FileUtils
    {
        //Checks File Validity
        public static bool file_is_valid(string name)
        {
            string[] w = new string[4] { ".jpg", ".jpeg", ".gif", ".png" };
            int x;
            for (x = 0; x < w.Length; ++x)
            {
                if (name.ToLower().Contains(w[x]))
                    return true;
            }
            return false;
        }
    }
}
