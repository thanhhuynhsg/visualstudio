using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T145588_Test07_033016
{
    class MyFileReader
    {
        public static void FileViewer(String a)
        {
            string line;
            StreamReader file = new StreamReader(a);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            file.Close();
        }
    }
}
