using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Media;


namespace DocSo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Number: 13");
            //Console.WriteLine("English: "+spell.SpellNumber(123));
            //Console.WriteLine("Vietnamese: " + spell.Numberv(10001001));

            //Console.WriteLine(docso.So_chu(1001));

            //String a = spell.SpellNumber(123);
            String a = "one two three four";
            string[] A = a.Split(' ');

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == "one")
                {
                    using (SoundPlayer player = new SoundPlayer(@"english\one.wav"))
                    {
                        player.PlaySync();
                    }
                }
                if (A[i] == "two")
                {
                    using (SoundPlayer player = new SoundPlayer(@"english\two.wav"))
                    {
                        player.PlaySync();
                    }
                }
                if (A[i] == "three")
                {
                    using (SoundPlayer player = new SoundPlayer(@"english\three.wav"))
                    {
                        player.PlaySync();
                    }
                }
                if (A[i] == "four")
                {
                    using (SoundPlayer player = new SoundPlayer(@"english\four.wav"))
                    {
                        player.PlaySync();
                    }
                }
                if (A[i] == "five")
                {
                    using (SoundPlayer player = new SoundPlayer(@"english\five.wav"))
                    {
                        player.PlaySync();
                    }
                }
                if (A[i] == "six")
                {
                    using (SoundPlayer player = new SoundPlayer(@"english\six.wav"))
                    {
                        player.PlaySync();
                    }
                }
                if (A[i] == "eight")
                {
                    using (SoundPlayer player = new SoundPlayer(@"english\eight.wav"))
                    {
                        player.PlaySync();
                    }
                }
                if (A[i] == "nine")
                {
                    using (SoundPlayer player = new SoundPlayer(@"english\nine.wav"))
                    {
                        player.PlaySync();
                    }
                }
                if (A[i] == "ten")
                {
                    using (SoundPlayer player = new SoundPlayer(@"english\ten.wav"))
                    {
                        player.PlaySync();
                    }
                }
               



            }



            //String[] never = new String[a.Length];
            //string[] catchuoi = a.Split(new char[] { ' ', ',', '.', ':', '-' });
          // foreach (string s1 in catchuoi)
          // {
          //    if (s1.Trim() != "")
          //    {
          //        this.checkedListBox.Items.Add(s1);
          //    }
          //}
          //}

            //string[] sCat = a.Split(new char[] { ' ' });
            //System.Collections.ArrayList arrList = new System.Collections.ArrayList();
            //arrList.AddRange(sCat);
            //Array arr = arrList.ToArray(typeof(string));

            //for(int i =0; i<arr.Length; i++)
            //{
                //Console.WriteLine(arr[1]);
            //}

        }
    }

    }