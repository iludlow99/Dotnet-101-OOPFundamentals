using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_2
{
    public class Room
    {
        private int _height;
        public int Height
        {
            get { return _height; }
            private set
            {
                if (value < 10 || value > 12)
                    throw new ArgumentOutOfRangeException("Room height need to be between 10 and 12 feet");
                else    
                    _height = value; 

            }
        }

        private int _width;
        public int Width
        {
            get { return _width; }
            private set
            {

                if (value < 6 || value > 30)
                    throw new ArgumentOutOfRangeException("Room width needs to be between 6 and 30 feet");
                else
                    _width = value; 

            }
        }

        private int _length;
        public int Length
        {
            get { return _length; }
            private set
            {
                if (value < 6 || value > 30)
                    throw new ArgumentOutOfRangeException("Room Length needs to be between 6 and 30 feet");
                else
                    _length = value; 

            }
        }

        public Room(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public int CalculateSurfaceAreOfWall() => this.Length * this.Height;

    }
}
