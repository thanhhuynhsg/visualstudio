using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic5
{
    class stack
    {
        private int[] arr;
        private int top;

        public stack(int a) 
        {
            arr = new int[a]; // truyền tham số phần tử vào mảng
            top = 0;
        }

        public int count()
        {
            return top; 
        }

        public void Put(int item) //đặt item vào mảng ở vị trí top
        {
            arr[top] = item;
            top++;
        }

        public int pop() //trả về giá trị và làm mất giá trị đó
        {
            top--; //dịch chuyển nó vào vị trí kế bên về trước
            return arr[top];
        }

        public int peek() //lấy ra và vẫn giữ nguyên giá trị
        {
            return arr[top - 1];
        }

    }
}
