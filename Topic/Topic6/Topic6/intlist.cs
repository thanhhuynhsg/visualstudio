using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic6
{
    class intlist
    {
        private int[] arr;
        private int count;

        public intlist(int capacity) 
        {
            arr = new int[capacity];
            count = 0;
        }
        public int Get() 
        {
            return count;
        }

        public int Getcapacity() 
        {
            return arr.Length;
        }

        public void clear() 
        {
            count = 0;
        }

        public void print() 
        {
            for (int i = 0; i < count; i++) 
            {
                Console.Write(arr[i]);
            }
        }


        public bool contains(int items) 
        {
            bool ok = false;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == items) 
                {
                   ok = true;
                }
            }
            return ok;
        }

        public void append(int n) 
        {
            arr[arr.Length] = n;
            count++;
        }

        public void appendArray(int[] n) 
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = n[i];
                count++;
            }
        }

        public void insert(int index, int value) 
        {
            for (int i = count; i > index; i--) 
            {
                arr[i] = arr[i-1];
            }
            arr[index] = value;
            count++;
        }

        public void insertArray(int index, int[] value) //Important
        {
            for (int j = 0; j < value.Length; j++) 
            {
                for (int i = count; i > index; i--) 
                {
                    arr[i] = value[j];
                }
                arr[index] = value[j];
                index++;
                count++;
            }
        }


    }
}
