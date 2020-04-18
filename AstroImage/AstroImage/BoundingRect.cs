using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroImage
{
    public class BoundingRect
    {
        private StarFinderHelper helper = new StarFinderHelper();
        public int[,] ImageData { get; private set; }
        public int OriginalUpperLeftX { get; set; }
        public int OriginalUpperLeftY { get; set; }
        public int OriginalBottomRightX { get; set; }
        public int OriginalBottomRightY { get; set; }

        private double _absBrightness;
        public double AbsoluteBrightness
        {
            get
            {
                if (_absBrightness == 0)
                {
                    _absBrightness = helper.CalculateAbsoluteBrightness(ImageData);
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
                    _relBrightness = helper.CalculateRelativeBrightness(ImageData);
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
                return (OriginalBottomRightX - OriginalUpperLeftX) * (OriginalBottomRightY - OriginalUpperLeftY);
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

        public double Mean
        {
            get
            { return helper.GetMean(ImageData); }
        }

        public double StdDeviation
        {
            get
            { return helper.GetStdDev(ImageData); }
        }


        public BoundingRect(int[,] imageData, int upperLeftX, int upperLeftY, int bottomRightX, int bottomRightY)
        {
            int xmax = imageData.GetUpperBound(0);
             
            if ((bottomRightX-upperLeftX) != imageData.GetUpperBound(0)+1)
            {
                throw new Exception("Bounding rects coordinates are incorrect size in x.");
            }
            if ((bottomRightY - upperLeftY) != imageData.GetUpperBound(1) + 1)
            {
                throw new Exception("Bounding rects coordinates are incorrect size in y.");
            }
            ImageData = imageData;
            OriginalUpperLeftX = upperLeftX;
            OriginalUpperLeftY = upperLeftY;
            OriginalBottomRightX = bottomRightX;
            OriginalBottomRightY = bottomRightY;
        }

        public bool ContainsPoint(int x, int y)
        {
            bool result = false;
            if ((x >= OriginalUpperLeftX) && (x <= OriginalBottomRightX))
            {
                if ((y >= OriginalUpperLeftY) && (y <= OriginalBottomRightY))
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
            double[] xLine = new double[OriginalBottomRightX - OriginalUpperLeftX];
            double[] yLine = new double[OriginalBottomRightY - OriginalUpperLeftY];
            double xLineSum = 0;
            double yLineSum = 0;

            //Calculate x value
            for (int y = 0; y < OriginalBottomRightY - OriginalUpperLeftY - 1; y++)
            {
                for (int x = 0; x < OriginalBottomRightX - OriginalUpperLeftX - 1; x++)
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
            for (int x = 0; x < OriginalBottomRightX - OriginalUpperLeftX - 1; x++)
            {
                for (int y = 0; y < OriginalBottomRightY - OriginalUpperLeftY - 1; y++)
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




      

        //File Functions
        public void SaveToCsv(string fullPath)
        {
            helper.SaveToCsv(ImageData, fullPath);
        }
    }
}
