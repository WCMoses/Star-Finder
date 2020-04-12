using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroImage
{
    public class BoundingRect
    {
        public int UpperLeftX { get; set; }
        public int UpperLeftY { get; internal set; }
        public int BottomRightX { get; internal set; }
        public int BottomRightY { get; set; }
        public int[,] ImageData { get; set; }

        public BoundingRect(int upperLeftX, int upperLeftY, int bottomRightX, int bottomRightY)
        {
            UpperLeftX = upperLeftX;
            UpperLeftY = upperLeftY;
            BottomRightX = bottomRightX;
            BottomRightY = bottomRightY;
        }


    }
}
