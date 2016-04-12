using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic7
{
    class square
    {
        private int width, left, top;
        public square(int x, int y, int w)
        {
            left = x;
            top = y;
            width = w;
        }

        public int getPerimeter() 
        {
            return 4 * width;
        }

        public int getArea() 
        {
            return width + width;
        }

        public void setWidth(int w) 
        {
            width = w;
        }

        public void setLocation(int x, int y) 
        {
            left = x;
            top = y;
        }

        private void drawHorizonal(int x1,int x2,int y)
        {
            for( int i = x1; i<=x2; i++)
            {
                moveto(i, y);
                Console.Write('*');
            }
        }
        private void moveto(int x, int y) 
        {
            Console.SetCursorPosition(x, y);
        }

        private void drawStraigt(int y1, int y2, int x) 
        {
          
            for (int i = y1; i <= y2; i++) 
            {
                moveto(x, i);
                Console.Write('*');
            }
        }


        public void draw() 
        {
            drawHorizonal(left, left + width, top);
            drawHorizonal(left, width + left, top + width);
            drawStraigt(top, width + top, left);
            drawStraigt(top, width + top, left + width);
        }

    }
}
