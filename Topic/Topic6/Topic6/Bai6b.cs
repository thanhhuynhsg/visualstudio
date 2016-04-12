using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic6
{
    class Bai6b
    {
        private int H;
        private Char[,] arr;
        public Bai6b(int h) 
        {
            H = h;
            arr = new Char[h, h];
        }

        public void print() 
        {
            for (int j = 0; j < H; j++) 
            {
                for (int i = 0; i < H; i++) 
                {
                    Console.Write(arr[j, i]);
                }
                Console.WriteLine();
            }
        }

        public void draw1() 
        {
            for (int i = 0; i < H; i++) 
            {
                arr[0, i] = '-';
                arr[H - 1, i] = '-';
                arr[i, 0] = '|';
                arr[i, H - 1] = '|';
                arr[i, i] = 'x';
                
            }

            for (int i = H-1; i >1; i--)
            {
                arr[i, H - i] = 'x';
            }
            

            arr[0, 0] = '+';
            arr[0, H - 1] = '+';
            arr[H - 1, 0] = '+';
            arr[H - 1, H - 1] = '+';


        }


    }
}
