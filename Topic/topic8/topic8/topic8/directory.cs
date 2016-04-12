using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace topic8
{
    class directory
    {
        public static void read(string a)
        {
            String[] path = Directory.GetFiles(a);
            String[] folder = Directory.GetDirectories(a);
            for (int i = 0; i < path.Length; i++)
            {
                Console.WriteLine("File:" + path[i]);
            }
            for (int i = 0; i < folder.Length; i++)
            {
                Console.WriteLine("Folder: " + folder[i]);
            }
        }
    }
}
