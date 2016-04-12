using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace topic8
{
    class FileViewer
    {

        //đọc 1 file và in ra mà hình
             //sử dụng constructor
        private string s1;
        public FileViewer(String path) 
        {
            s1 = path;
        }

        public string ReadWholeFile() 
        {
            StreamReader reader = new StreamReader(s1);
            String s2 = reader.ReadToEnd();
            if (reader.EndOfStream == true) 
            {
                reader.Close();
            }
            return s2;
        }
    }
}
