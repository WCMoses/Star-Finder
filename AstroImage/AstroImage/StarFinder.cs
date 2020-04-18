using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroImage
{
    public class StarFinder
    {
        private StarFinderHelper helper = new StarFinderHelper();
        public int[,] ImageData { get; private set; }
        public int ImageWidth
        {
            get
            { return ImageData.GetUpperBound(1) + 1; }
        }
        public int ImageHeight
        {
            get
            { return ImageData.GetUpperBound(0) + 1; }
        }
        public BoundingRectList BoundingRects { get; private set; }
        public int Threshold { get; set; }
        public int MinSize { get; set; }
        public double ImageDataMean
        {
            get
            { return helper.GetMean(ImageData); }
        }

        public double ImageDataStdDev
        {
            get
            { return helper.GetStdDev(ImageData); }
        }


        //  ctors
        public StarFinder(int[,] imageData)
        {
            BoundingRects = new BoundingRectList();
            ImageData = imageData;
            
        }

        public StarFinder(Image image)
        {
            BoundingRects = new BoundingRectList();
            var id = MakeGrayscale3(new Bitmap(image));
            var arr = GetIntArrayFromImage(id);
            ImageData = arr;
        }

        public StarFinder(Bitmap image)
        {
            BoundingRects = new BoundingRectList();
            var id = MakeGrayscale3(image);
            var arr = GetIntArrayFromImage(id);
            ImageData = arr;
        }




        //  STAR FINDER ALGORITHM FUNCTIONS
        public BoundingRectList FindAllStars(int[,] arr)
        {
            int threshold = Threshold;
            int minSize = MinSize;
            BoundingRectList result = new BoundingRectList();
            int xmax = arr.GetUpperBound(0) ;
            int ymax = arr.GetUpperBound(1) ;

            //Top-level loop
            for (int y = 0; y < ymax+1; y++)
            {
                for (int x = 0; x < xmax+1; x++)
                {
                    Console.WriteLine("Evaluating " + x + ":" + y + "  Value: " + arr[x, y]);
                    if (result.ContainsPoint(x, y)) //Is point already in a blob
                    {
                        Console.WriteLine("--Already in BR");
                        continue;  //point is already in a bounding rect
                    }
                    if (arr[x, y] >= Threshold)  // Edge found
                    {

                        Console.WriteLine("--Edge found");
                        Tuple<int, int, int> bar = GetBottomBoundingBar(arr, x, y, Threshold);
                        int xMin = bar.Item1;
                        int xMax = bar.Item2;
                        int yMax = bar.Item3;
                        int yMin = y; //TODO: *** IS THIS CORRECT ??

                        int[,] subImage = GetSubArray(arr, xMin, yMin, xMax, yMax);
                        BoundingRect rect = new BoundingRect(subImage, xMin, yMin, xMax, yMax);
                        Console.WriteLine("--->BR found at [" + xMin + "," + yMin + "],[" + xmax + "," + ymax + "]");

                        if (((xMax - xMin) >= minSize) && ((yMax - yMin) >= minSize))
                        {

                            //if (!result.BrIntersectsAnotherBr(rect))
                            //{
                                result.BrList.Add(rect);
                            Console.WriteLine(" ---->  BR added");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("*** Rejected because it intersects another br");
                            //}

                        }
                        else
                        {
                            Console.WriteLine("*** Rejected due to small size");
                        }
                    }
                    else  //Edge not detected
                    {
                        Console.WriteLine("--No Edge");
                    }
                }

            }
            BoundingRects = result;
            return result;
        }

        public Tuple<int, int, int> GetBottomBoundingBar(int[,] arr, int xStart, int yStart, int threshold)
        {
            int yResult = yStart;
            int xMaxResult = xStart;
            int xMinResult = xStart;
            int maxXarr = arr.GetUpperBound(0) + 1;
            int maxYarr = arr.GetUpperBound(1) + 1;

            //Expand current row to the right.  No need to expand to left
            while (ValueToRightIsAboveThreshold(arr, xMaxResult, yResult, threshold))
            {
                xMaxResult++;
            }

            while (!EveryValueBelowIsBelowThreshold(arr, yResult, xMinResult, xMaxResult, threshold))
            {
                //Expand to the right
                while (ValueToRightIsAboveThreshold(arr, xMaxResult, yResult, threshold))
                {
                    xMaxResult++;
                }

                //Expand to the left
                while (ValueToLeftIsAboveThreshold(arr, xMinResult, yResult, threshold))
                {
                    xMinResult--;
                }

                //Move down a line
                if (yResult >= maxYarr)
                {
                    return new Tuple<int, int, int>(xMinResult, xMaxResult, yResult);
                }
                yResult++;
            }
            return new Tuple<int, int, int>(xMinResult, xMaxResult, yResult);
        }

        public bool ValueToRightIsAboveThreshold(int[,] arr, int x, int y, int threshold)
        {
            int maxXarr = arr.GetUpperBound(0) + 1;
            int maxYarr = arr.GetUpperBound(1) + 1;

            if (x == maxXarr - 1)     //at edge of image
            {
                return false;
            }
            if (y >= maxYarr)
            {
                return false;
            }
            Console.WriteLine("   VTR: " + (x + 1) + "," + y + "--" + arr[x + 1, y]);
            if (arr[x + 1, y] > threshold)
            {
                return true;
            }
            return false;
        }

        public bool ValueToLeftIsAboveThreshold(int[,] arr, int x, int y, int threshold)
        {
            int maxXarr = arr.GetUpperBound(0) + 1;
            int maxYarr = arr.GetUpperBound(1) + 1;
            if (x == 0)     //at edge of image
            {
                return false;
            }
            if (y >= maxYarr)
            {
                return false;
            }
            Console.WriteLine("   VTL: " + (x - 1) + "," + y + "--" + arr[x - 1, y]);
            if (arr[x - 1, y] > threshold)
            {
                return true;
            }
            return false;
        }

        public bool EveryValueBelowIsBelowThreshold(int[,] arr, int y, int startX, int endX, int threshold)
        {
            int maxXarr = arr.GetUpperBound(0) + 1;
            int maxYarr = arr.GetUpperBound(1) + 1;
            int minX = startX;
            int maxX = endX;

            //Check to make sure y+1 is in bounds
            if (y >= maxYarr - 1)
            {
                return false;
            }
            for (int i = startX; i < endX; i++)
            {
                Console.WriteLine("   EVB: " + i + "," + (y + 1) + "  -  " + arr[i, y + 1]);
                if (arr[i, y + 1] > threshold)
                {
                    return false;
                }
            }
            return true;      //All values below are above threshold
        }


        // IMAGE FUNCTIONS
        public static Bitmap MakeGrayscale3(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);
            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
              {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
              });
            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();
            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);
            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        private int[,] GetIntArrayFromImage(Bitmap img)
        {
            int h = img.Height;
            int w = img.Width;

            int[,] result = new int[w, h];
            for (int y = 0; y < h; y++)  //(int x = 0; x < w; x++)
            {
                for (int x = 0; x < w; x++)  // (int y = 0; y < h; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    // Console.WriteLine("R:" + pixel.R + " G:" + pixel.G + " B:" + pixel.B);
                    result[x, y] = (int)pixel.GetBrightness();  //TODO: round.  don't cast
                }
            }
            //DumpArray(result);
            return result;
        }



        //      MISC FUNCTIONS
        private int[,] GetSubArray(int[,] arr, int xMin, int yMin, int xMax, int yMax)
        {
            int[,] result = new int[xMax - xMin, yMax - yMin];
            for (int x = 0; x < xMax - xMin - 1; x++)
            {
                for (int y = 0; y < yMax - yMin - 1; y++)
                {
                    result[x, y] = arr[x + xMin, y + yMin];
                }
            }
            return result;
        }

        public void SaveBrSummaryCsvFile(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            string msg = "";
            int count = 0;
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                //  Insert mean, threshold, min size for image, st dev
                msg = "Count,X1,Y1,X2,Y2,Cent X Offset,Cent Y Offset,Cent X,Cent Y,Volume,Mean,Std Dev,Rel Brightness, Abs Brightness";
                writer.WriteLine(msg);
                foreach (var item in BoundingRects.BrList)
                {
                    msg = count.ToString();
                    msg += string.Format(",{0},{1},{2},{3}", item.OriginalUpperLeftX, item.OriginalBottomRightY, item.OriginalBottomRightX, item.OriginalBottomRightY);  //bounding rect coords
                    msg += string.Format(",{0:F2},{1:F2}", item.CentroidX, item.CentroidY);  //centroid offset
                    msg += string.Format(",{0:F2},{1:F2}", item.OriginalUpperLeftX + item.CentroidX, item.OriginalUpperLeftY + item.CentroidY);  //Absolute centroid locations
                    msg += string.Format(",{0},{1:F2},{2:F2}", item.Volume, item.Mean, item.StdDeviation);
                    msg += string.Format(",{0:F2},{1:F2}", item.RelativeBrightness, item.AbsoluteBrightness);
                    writer.WriteLine(msg);
                    count++;
                }
            }
        }

        public void SaveAllBrsToCsvFiles(string directory)
        {
            int count = 0;
            foreach (var item in BoundingRects.BrList)
            {
                string fn = directory + "\\BR-" + count + ".csv";
                item.SaveToCsv(fn);
                count++;
            }
        }

        public void SaveImageDataToCsv(string fullPath)
        {
            helper.SaveToCsv(ImageData, fullPath);
        }
        
    }
}
