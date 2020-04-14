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
        public int UpperLeftY { get; set; }
        public int BottomRightX { get; set; }
        public int BottomRightY { get; set; }

        private double _absBrightness;
        public double AbsoluteBrightness
        {
            get
            {
                if (_absBrightness == 0)
                {
                    _absBrightness = CalculateAbsoluteBrightness();
                }
                return _absBrightness;
            }
            private set
            {
                _absBrightness = value;
            }
        }
        private double _relBrightness =0;
        public double RelativeBrightness
        {
            get
            {
                if (_relBrightness == 0)
                {
                    _relBrightness = CalculateRelativeBrightness();
                }
                return _relBrightness;
            }
            private set
            { _relBrightness = value; }
        }
        public int Volume
        {
            get
            {
                return (BottomRightX - UpperLeftX) * (BottomRightY - UpperLeftY);
            }
        }

        private double _centroidX;
        public double CentroidX
        {
            get
            {
                if (_centroidX == 0)
                {
                    CalculateCentroid();
                }
                return _centroidX;
            }
            private set { _centroidX = value; }
        }

        private double _centroidY;
        public double CentroidY
        {
            get
            {
                if (_centroidY == 0)
                {
                    CalculateCentroid();
                }
                return _centroidY;
            }
            private set { _centroidY = value; }
        }


        public int[,] ImageData { get; private set; }

        public BoundingRect(int[,] imageData, int upperLeftX, int upperLeftY, int bottomRightX, int bottomRightY)
        {
            ImageData = imageData;
            UpperLeftX = upperLeftX;
            UpperLeftY = upperLeftY;
            BottomRightX = bottomRightX;
            BottomRightY = bottomRightY;
        }

        public bool ContainsPoint(int x, int y)
        {
            bool result = false;
            if ((x >= UpperLeftX) && (x <= BottomRightX))
            {
                if ((y >= UpperLeftY) && (y <= BottomRightY))
                {
                    result = true;
                }
            }
            return result;
        }
        private void CalculateCentroid()
        {
            double xSum = 0;
            double ySum = 0;

            double resultX = 0;
            double resultY = 0;
            double[] xLine = new double[BottomRightX - UpperLeftX];
            double[] yLine = new double[BottomRightY - UpperLeftY];
            double xLineSum = 0;
            double yLineSum = 0;

            //Calculate x value
            for (int y = 0; y < BottomRightY - UpperLeftY - 1; y++)
            {
                for (int x = 0; x < BottomRightX - UpperLeftX - 1; x++)
                {
                    xLine[x] = ImageData[x, y];
                }
            }
            xLineSum = xLine.Sum();
            for (int i = 1; i < xLine.Length; i++)
            {
                xSum += i * xLine[i - 1];
            }
            resultX = xSum / xLineSum;  //<--x RESULT

            //Get y Values
            for (int x = 0; x < BottomRightX - UpperLeftX - 1; x++)
            {
                for (int y = 0; y < BottomRightY - UpperLeftY - 1; y++)
                {
                    yLine[y] = ImageData[x, y];
                }
            }
            yLineSum = yLine.Sum();
            for (int i = 1; i < yLine.Length; i++)
            {
                ySum += i * yLine[i - 1];
            }
            resultY = ySum / yLineSum;  //<--y RESULT

            CentroidX = resultX;
            CentroidY = resultY;
        }

        private double CalculateAbsoluteBrightness()
        {
            double result = 0;
            for (int y = 0; y < BottomRightY - UpperLeftY - 1; y++)
            {
                for (int x = 0; x < BottomRightX - UpperLeftX - 1; x++)
                {
                    result += ImageData[x, y];
                }
            }
            return result;
        }
        private double CalculateRelativeBrightness()
        {
            double result = 0;
            int h = BottomRightX - UpperLeftX;
            int w = BottomRightY - UpperLeftY;
            result = AbsoluteBrightness / h * w;
            return result;
        }
    }
}
