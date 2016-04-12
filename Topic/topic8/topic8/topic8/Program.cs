using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace topic8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MonteCarlo.monte(100000000));

            //StreamReader reader;
            //reader = new StreamReader("D:\\T145588\\topic8\\topic8\\1.txt");
            //String bai = reader.ReadLine();
            //if (reader.EndOfStream == true)
            //{
            //    reader.Close();
            //}
            //bai.Split(' ');

            //Console.WriteLine(bai);

            //int counter = 0;
            //string line;

            // Read the file and display it line by line.
            //StreamReader file = new StreamReader(@"F:\Git\Visual Studio\topic8\topic8\topic8\1.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //    counter++;
            //}

            //file.Close();

            //Suspend the screen.
            //Console.ReadLine();

            FileViewer s = new FileViewer("1.txt");
            s.ReadWholeFile();


            //directory.read(@"C:\");
            

        }
    }
}
