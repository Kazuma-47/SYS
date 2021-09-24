using System;
using System.Collections.Generic;
using System.Text;

namespace Les_2
{
    class Rectangle
    {
        private int height;
        private int width;
        public int x;
        public int y;
        public bool isquare;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public Rectangle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.width = size;
            this.height = size;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int size)
        {
            this.width = size;
            this.height = size;
        }


        void MoveTo(int x , int y)
        {
            this.x = x;
            this.y = y;
        }

        bool IsSquare()
        {
           if(this.width == this.height)
            {
                Console.WriteLine("This is a quare");
                return true;
            }
           else
            {
                Console.WriteLine("This is not a quare");
                return false;
            }
            
        }
    }
}
