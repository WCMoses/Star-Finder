using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroImage
{
    public partial class Form1 : Form
    {
        BoundingRectList BoundingRects = new BoundingRectList();
        int Threshold = 25;
        int[,] ImageArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdShowImage_Click(object sender, EventArgs e)
        {
            string fname = txtSourceFile.Text;
            //pbImage.Load(fname);
            if (!File.Exists(fname))
            {
                MessageBox.Show("File does not exist", "File does not exist");
                return;
            }
            Image imag = Image.FromFile(fname);
            Bitmap img = new Bitmap(new Bitmap(imag));
            pbImage.Image = img;
            int h = img.Height;
            int w = img.Width;
            lblHeight.Text = "Height: " + h.ToString();
            lblWidth.Text = "Width: " + w.ToString();
        }

        private void cmdIterate_Click(object sender, EventArgs e)
        {
            Threshold = Convert.ToInt16(txtEdgeThreshold.Text);
            Bitmap img = new Bitmap(txtSourceFile.Text);
            int upperXBound = -1;
            int lowerXBound = -1;
            int upperYBound = -1;
            int lowerYBound = -1;
            int xImage = img.Height;
            int yImage = img.Width;
            int[,] arr = new int[xImage, yImage];
            arr = GetIntArrayFromImage(img);
            ImageArray = arr;   //Used for writing out the subframes.

            Stopwatch sw = new Stopwatch();
            sw.Start();
            BoundingRectList result = FindAllStars(arr, Threshold);
            sw.Stop();
            lblElapsedTime.Text = "Elapsed Time: " + sw.ElapsedMilliseconds;
            BoundingRects = result;  //Used for writing out BR file
            DumpBoundingRectList(result);

        }

        public BoundingRectList FindAllStars(int[,] arr, int threshold)
        {
            BoundingRectList result = new BoundingRectList();
            int xmax = arr.GetUpperBound(0) + 1;
            int ymax = arr.GetUpperBound(1) + 1;

            //Top-level loop
            for (int y = 0; y < ymax; y++)
            {
                for (int x = 0; x < xmax; x++)
                {
                    //Console.WriteLine("Evaluating " + x + ":" + y + "  Value: " + arr[x, y]);
                    if (result.ContainsPoint(x, y)) //Is point already in a blob
                    {
                        //Console.WriteLine("Already in BR");
                        continue;  //point is already in a bounding rect
                    }
                    if (arr[x, y] >= Threshold)  // Edge found
                    {
                        //Console.WriteLine("Edge found");
                        Tuple<int, int, int> bar = GetBottomBoundingBar(arr, x, y, Threshold);
                        int xMin = bar.Item1;
                        int xMax = bar.Item2;
                        int yMax = bar.Item3;
                        int yMin = y;
                        BoundingRect rect = new BoundingRect(xMin, yMin, xMax, yMax);
                        result.BrList.Add(rect);

                    }
                    else  //Edge not detected
                    {
                        //Console.WriteLine("No Edge");
                    }
                }

            }
            return result;
        }
        private Tuple<int, int, int> GetBottomBoundingBar(int[,] arr, int xStart, int yStart, int threshold)
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
                yResult++;
            }
            return new Tuple<int, int, int>(xMinResult, xMaxResult, yResult);
        }
        private bool ValueToRightIsAboveThreshold(int[,] arr, int x, int y, int threshold)
        {
            int maxXarr = arr.GetUpperBound(0) + 1;
            int maxYarr = arr.GetUpperBound(1) + 1;

            if (x == maxXarr)     //at edge of image
            {
                return false;
            }
            //Console.WriteLine("   VTR: " + (x + 1) + "," + y + "--" + arr[x + 1, y]);
            if (arr[x + 1, y] > threshold)
            {
                return true;
            }
            return false;
        }

        private bool ValueToLeftIsAboveThreshold(int[,] arr, int x, int y, int threshold)
        {
            if (x == 0)     //at edge of image
            {
                return false;
            }
            //Console.WriteLine("   VTL: " + (x - 1) + "," + y + "--" + arr[x - 1, y]);
            if (arr[x - 1, y] > threshold)
            {
                return true;
            }
            return false;
        }

        private bool EveryValueBelowIsBelowThreshold(int[,] arr, int y, int startX, int endX, int threshold)
        {
            int maxXarr = arr.GetUpperBound(0) + 1;
            int maxYarr = arr.GetUpperBound(1) + 1;
            int minX = startX;
            int maxX = endX;

            //TODO: Check to make sure y+1 is in bounds

            for (int i = startX; i < endX; i++)
            {
                //Console.WriteLine("   EVB: " + i + "," + (y + 1) + "  -  " + arr[i, y + 1]);
                if (arr[i, y + 1] > threshold)
                {
                    return false;
                }
            }
            return true;      //All values below are above threshold
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
                    result[x, y] = GetPixelValue(pixel);
                }
            }
            //DumpArray(result);
            return result;
        }
        private int GetPixelValue(Color pixel)
        {
            int result = 0;
            int red = pixel.R;
            int green = pixel.G;
            int blue = pixel.B;
            if (red == 0 && green == 0 && blue == 0)
            {
                result = 0;
            }
            else
            {
                result = (red + blue + green) / 3;
            }
            // Console.WriteLine("    Pixel Value: " + result);
            return result;
        }
        private void DumpArray(int[,] arr)
        {
            int xmax = arr.GetUpperBound(0) + 1;
            int ymax = arr.GetUpperBound(1) + 1;
            for (int y = 0; y < ymax; y++)
            {
                for (int x = 0; x < xmax; x++)
                {
                    Console.Write(arr[x, y] + ",");
                }
                Console.WriteLine();
            }
        }

        private void DumpBoundingRectList(BoundingRectList brList)
        {
            int count = 0;
            foreach (var item in brList.BrList)
            {
                string msg = count + "  ";
                 msg += "Found BR at [" + item.UpperLeftX + "," + item.UpperLeftY + "],[" + item.BottomRightX + "," + item.BottomRightY + "]";
                txtOutput.Text += msg + Environment.NewLine;
                count++;
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        private void cmdSaveData_Click(object sender, EventArgs e)
        {
            string path = txtOuputDir.Text;
            string fullPath = path + "\\BoundingRects.txt";
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            string msg = "";
            int count = 0;
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (var item in BoundingRects.BrList)
                {
                    msg = count + ":  " + "[" + item.UpperLeftX + "," + item.UpperLeftY + "]";
                    msg += "," + "[" + item.BottomRightX + "," + item.BottomRightY + "]";
                    writer.WriteLine(msg);
                    count++;
                }
            }
            count = 0;
            foreach (var item in BoundingRects.BrList)
            {
                string fileName = fullPath + "BR-" + count + ".csv";
                SaveSubFrame(fileName, item);
                count++;
            }
            txtOutput.Text += Environment.NewLine + "Done Saving Bounding Rectangle Files";
        }

        private void SaveSubFrame(string fileName, BoundingRect item)
        {
            int upperLeftX = item.UpperLeftX;
            int upperLeftY = item.UpperLeftY;
            int bottomRightX = item.BottomRightX;
            int bottomRightY = item.BottomRightY;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int y = upperLeftY; y < bottomRightY; y++)
                {
                    for (int x = upperLeftX; x < bottomRightX; x++)
                    {
                        writer.Write(ImageArray[x, y] + ",");
                    }
                    writer.WriteLine();
                }
                writer.Flush();
            }
        }
    }

}
