using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AstroImage
{
    public partial class Form1 : Form
    {
        //BoundingRectList BoundingRects = new BoundingRectList();
        private StarFinder sf;
        int Threshold = 25;
       // int[,] ImageArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ResizeEnd += Form1_ResizeEnd;
            splitContainer2.Panel2.AutoScroll = true;
            this.Size = new Size(700, 500);
            Form1_ResizeEnd(null, null);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            splitContainer2.SplitterDistance = 500;
            splitContainer1.SplitterDistance = 300;
        }

        private void ActiveForm_ResizeEnd(object sender, EventArgs e)
        {

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


            Image grayScaled = (Image)MakeGrayscale3(new Bitmap(img));
            var imageArray = GetIntArrayFromImage(new Bitmap(grayScaled));
            sf = new StarFinder(imageArray);
            //pbImage.Image = img;
            pbImage.Image = grayScaled;

            lblHeight.Text = "Height: " + img.Height;
            lblWidth.Text = "Width: " + img.Width;
            double dMean = sf.ImageDataMean; ;
            double dStDev = sf.ImageDataStdDev;
            string mean = string.Format("Mean: {0:F2}", Convert.ToString(dMean));
            lblMean.Text = mean;
            string stdev = string.Format("Std Dev:{0:F2}", Convert.ToString(dStDev));
            lblStDev.Text = stdev;
            double doubleStDev = 2 * dStDev + dMean;
            string recommended = string.Format("2xStDev+M: {0:F2}", Convert.ToString(doubleStDev));
            lbl2StDev.Text = recommended;
        }

        private double GetMean(int[,] imageArray)
        {
            double result = 0;
            double sum = 0;
            int h = imageArray.GetUpperBound(0) - 1;
            int w = imageArray.GetUpperBound(1) - 1;
            for (int y = 0; y < w; y++)
            {
                for (int x = 0; x < h; x++)
                {
                    sum += imageArray[x, y];
                }
            }
            int pixels = h * w;
            result = sum / pixels;
            return result;
        }

        // Return the standard deviation of an array of Doubles.
        //
        // If the second argument is True, evaluate as a sample.
        // If the second argument is False, evaluate as a population.
        public double GetStdDev(int[,] arr, bool as_sample)
        {
            int h = arr.GetUpperBound(0) - 1;
            int w = arr.GetUpperBound(1) - 1;
            double[] values = new double[h * w];
            int count = 0;
            for (int y = 0; y < w; y++)
            {
                for (int x = 0; x < h; x++)
                {
                    values[count] += arr[x, y];
                    count++;
                }
            }
            // Get the mean.
            double mean = values.Sum() / values.Count();

            // Get the sum of the squares of the differences
            // between the values and the mean.
            var squares_query =
                from int value in values
                select (value - mean) * (value - mean);
            double sum_of_squares = squares_query.Sum();

            if (as_sample)
            {
                return Math.Sqrt(sum_of_squares / (values.Count() - 1));
            }
            else
            {
                return Math.Sqrt(sum_of_squares / values.Count());
            }
        }

        public double GetStdDev2(int[,] arr)
        {
            int h = arr.GetUpperBound(0) - 1;
            int w = arr.GetUpperBound(1) - 1;
            double[] values = new double[h * w];
            int count = 0;
            for (int y = 0; y < w; y++)
            {
                for (int x = 0; x < h; x++)
                {
                    values[count] += arr[x, y];
                    count++;
                }
            }
            double[] someDoubles = values;
            double average = someDoubles.Average();
            double sumOfSquaresOfDifferences = someDoubles.Select(val => (val - average) * (val - average)).Sum();
            double sd = Math.Sqrt(sumOfSquaresOfDifferences / someDoubles.Length);
            return sd;
        }
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
        private void cmdIterate_Click(object sender, EventArgs e)
        {
            int minSize = Convert.ToInt16(txtMinSize.Text);
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
            //ImageArray = arr;   //Used for writing out the subframes.
            sf.Threshold = Convert.ToInt16(txtEdgeThreshold.Text);
            sf.MinSize = Convert.ToInt16(txtMinSize.Text);

            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BoundingRectList result = sf.FindAllStars(arr);
            sw.Stop();
            if (rbAbsoluteBrightness.Checked)
            {
                sf.BoundingRects.SortOrder = BoundingRectList.SortOrderEnum.AbsoluteBrightness;
            }
            if (rbCentroid.Checked)
            {
                sf.BoundingRects.SortOrder = BoundingRectList.SortOrderEnum.CentroidLocation;
            }
            if (rbRelativeBrightness.Checked)
            {
                sf.BoundingRects.SortOrder = BoundingRectList.SortOrderEnum.RelativeBrightness;
            }
            if (rbSize.Checked)
            {
                sf.BoundingRects.SortOrder = BoundingRectList.SortOrderEnum.Volume;
            }
            if (rbUpperLefftCoord.Checked)
            {
                sf.BoundingRects.SortOrder = BoundingRectList.SortOrderEnum.UpperLeft;
            }
            sf.BoundingRects.SortList();
            lblElapsedTime.Text = "Elapsed Time: " + sw.ElapsedMilliseconds;
           
            DumpBoundingRectList(sf.BoundingRects);

        }

        //public BoundingRectList FindAllStars(int[,] arr, int threshold, int minSize)
        //{
        //    BoundingRectList result = new BoundingRectList();
        //    int xmax = arr.GetUpperBound(0) + 1;
        //    int ymax = arr.GetUpperBound(1) + 1;

        //    //Top-level loop
        //    for (int y = 0; y < ymax; y++)
        //    {
        //        for (int x = 0; x < xmax; x++)
        //        {
        //            Console.WriteLine("Evaluating " + x + ":" + y + "  Value: " + arr[x, y]);
        //            if (result.ContainsPoint(x, y)) //Is point already in a blob
        //            {
        //                Console.WriteLine("--Already in BR");
        //                continue;  //point is already in a bounding rect
        //            }
        //            if (arr[x, y] >= Threshold)  // Edge found
        //            {

        //                Console.WriteLine("--Edge found");
        //                Tuple<int, int, int> bar = GetBottomBoundingBar(arr, x, y, Threshold);
        //                int xMin = bar.Item1;
        //                int xMax = bar.Item2;
        //                int yMax = bar.Item3;
        //                int yMin = y; //TODO: *** IS THIS CORRECT ??

        //                int[,] subImage = GetSubImage(arr, xMin, yMin, xMax, yMax);
        //                BoundingRect rect = new BoundingRect(subImage, xMin, yMin, xMax, yMax);
        //                Console.WriteLine("--->BR found at [" + xMin + "," + yMin + "],[" + xmax + "," + ymax + "]");

        //                if (((xMax - xMin) >= minSize) && ((yMax - yMin) >= minSize))
        //                {

        //                    if (!result.BrIntersectsAnotherBr(rect))
        //                    {
        //                        result.BrList.Add(rect);
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("*** Rejected because it intersects another br");
        //                    }

        //                }
        //                else
        //                {
        //                    Console.WriteLine("*** Rejected due to small size");
        //                }
        //            }
        //            else  //Edge not detected
        //            {
        //                Console.WriteLine("--No Edge");
        //            }
        //        }

        //    }
        //    return result;
        //}

        //private int[,] GetSubImage(int[,] arr, int xMin, int yMin, int xMax, int yMax)
        //{
        //    int[,] result = new int[xMax - xMin, yMax - yMin];
        //    for (int x = 0; x < xMax - xMin - 1; x++)
        //    {
        //        for (int y = 0; y < yMax - yMin - 1; y++)
        //        {
        //            result[x, y] = arr[x + xMin, y + yMin];
        //        }
        //    }
        //    return result;
        //}

        //private Tuple<int, int, int> GetBottomBoundingBar(int[,] arr, int xStart, int yStart, int threshold)
        //{
        //    int yResult = yStart;
        //    int xMaxResult = xStart;
        //    int xMinResult = xStart;
        //    int maxXarr = arr.GetUpperBound(0) + 1;
        //    int maxYarr = arr.GetUpperBound(1) + 1;

        //    //Expand current row to the right.  No need to expand to left
        //    while (ValueToRightIsAboveThreshold(arr, xMaxResult, yResult, threshold))
        //    {
        //        xMaxResult++;
        //    }

        //    while (!EveryValueBelowIsBelowThreshold(arr, yResult, xMinResult, xMaxResult, threshold))
        //    {
        //        //Expand to the right
        //        while (ValueToRightIsAboveThreshold(arr, xMaxResult, yResult, threshold))
        //        {
        //            xMaxResult++;
        //        }

        //        //Expand to the left
        //        while (ValueToLeftIsAboveThreshold(arr, xMinResult, yResult, threshold))
        //        {
        //            xMinResult--;
        //        }

        //        //Move down a line
        //        if (yResult >= maxYarr)
        //        {
        //            return new Tuple<int, int, int>(xMinResult, xMaxResult, yResult);
        //        }
        //        yResult++;
        //    }
        //    return new Tuple<int, int, int>(xMinResult, xMaxResult, yResult);
        //}
        //private bool ValueToRightIsAboveThreshold(int[,] arr, int x, int y, int threshold)
        //{
        //    int maxXarr = arr.GetUpperBound(0) + 1;
        //    int maxYarr = arr.GetUpperBound(1) + 1;

        //    if (x == maxXarr - 1)     //at edge of image
        //    {
        //        return false;
        //    }
        //    if (y >= maxYarr)
        //    {
        //        return false;
        //    }
        //    Console.WriteLine("   VTR: " + (x + 1) + "," + y + "--" + arr[x + 1, y]);
        //    if (arr[x + 1, y] > threshold)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //private bool ValueToLeftIsAboveThreshold(int[,] arr, int x, int y, int threshold)
        //{
        //    int maxXarr = arr.GetUpperBound(0) + 1;
        //    int maxYarr = arr.GetUpperBound(1) + 1;
        //    if (x == 0)     //at edge of image
        //    {
        //        return false;
        //    }
        //    if (y >= maxYarr)
        //    {
        //        return false;
        //    }
        //    Console.WriteLine("   VTL: " + (x - 1) + "," + y + "--" + arr[x - 1, y]);
        //    if (arr[x - 1, y] > threshold)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //private bool EveryValueBelowIsBelowThreshold(int[,] arr, int y, int startX, int endX, int threshold)
        //{
        //    int maxXarr = arr.GetUpperBound(0) + 1;
        //    int maxYarr = arr.GetUpperBound(1) + 1;
        //    int minX = startX;
        //    int maxX = endX;

        //    //Check to make sure y+1 is in bounds
        //    if (y >= maxYarr - 1)
        //    {
        //        return false;
        //    }
        //    for (int i = startX; i < endX; i++)
        //    {
        //        Console.WriteLine("   EVB: " + i + "," + (y + 1) + "  -  " + arr[i, y + 1]);
        //        if (arr[i, y + 1] > threshold)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;      //All values below are above threshold
        //}
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
            txtOuputDir.Text += Environment.NewLine;
            for (int y = 0; y < ymax; y++)
            {
                for (int x = 0; x < xmax; x++)
                {
                    txtOuputDir.Text += (arr[x, y] + ",");
                }
                txtOuputDir.Text += Environment.NewLine;
            }
        }

        private void DumpBoundingRectList(BoundingRectList brList)
        {
            int count = 0;
            foreach (var item in brList.BrList)
            {
                string message = string.Format("{0}  BR at [({1},{2}),({3},{4})] Volume={5}", count, item.OriginalUpperLeftX, item.OriginalUpperLeftY, item.OriginalBottomRightX, item.OriginalBottomRightY, item.Volume);
                message += string.Format(" Centroid = ({0:G2},{1:G2})", item.CentroidX, item.CentroidY);
                message += string.Format("  Abs Brightness = {0:G5}  Rel Brightness = {1:G5}", item.AbsoluteBrightness, item.RelativeBrightness);
                message += Environment.NewLine;
                //string msg = count + "  ";
                //msg += "Found BR at [" + item.UpperLeftX + "," + item.UpperLeftY + "],[" + item.BottomRightX + "," + item.BottomRightY + "]";
                //txtOutput.Text += msg + " Volume:" + item.Volume + "  Centroid: [" + item.CentroidX + "," + item.CentroidY + "]";
                txtOutput.Text += message;
                count++;
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
        }

        private void cmdSaveData_Click(object sender, EventArgs e)
        {
            string path = txtOuputDir.Text;
            string fullPath = path + "\\BoundingRects.csv";
            sf.SaveAllBrsToCsvFiles(path);
            sf.SaveBrSummaryCsvFile(fullPath);

           
            txtOutput.Text += Environment.NewLine + "Done Saving Bounding Rectangle Files";
        }

        private void SaveSubFrame(string fileName, BoundingRect item)
        {
            item.SaveToCsv(fileName);
        }

        private void cmdHighlightBrs_Click(object sender, EventArgs e)
        {
            Rectangle rect1 = new Rectangle();
            Graphics gr = Graphics.FromImage(pbImage.Image);
            Pen pen = new Pen(Color.Red, 1);
            int x;
            int y;
            int h;
            int w;

            if (sf.BoundingRects.BrList.Count == 0)
            {
                txtOutput.Text += Environment.NewLine + "No bounding rects in list";
            }
            foreach (var item in sf.BoundingRects.BrList)
            {
                x = item.OriginalUpperLeftX;
                y = item.OriginalUpperLeftY;
                h = item.OriginalBottomRightY - item.OriginalUpperLeftY;
                w = item.OriginalBottomRightX - item.OriginalUpperLeftX;
                rect1 = new Rectangle(x, y, w, h);
                gr.DrawRectangle(pen, rect1);
            }
            pbImage.Invalidate();
        }

        private void cmdSourceFilePicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = txtOuputDir.Text;
            openFileDialog1.DefaultExt = "bmp";
            openFileDialog1.ShowDialog();
            txtSourceFile.Text = openFileDialog1.FileName;
        }

        private void cmdSaveCsv_Click(object sender, EventArgs e)
        {
            FileInfo iFileName = new FileInfo(txtSourceFile.Text);

            string prefix = iFileName.Name.Substring(0, iFileName.Name.Length - 4);
            string outputFile = "\\" + prefix + ".csv";
            outputFile = txtOuputDir.Text + outputFile;
            Console.WriteLine(outputFile);

            sf.SaveImageDataToCsv(outputFile);
            txtOutput.Text += Environment.NewLine + "Saved: " + outputFile + " (" + sf.ImageHeight + "x" + sf.ImageHeight + " array)" + Environment.NewLine;
        }

        private void cmdBackgroundSubtraction_Click(object sender, EventArgs e)
        {
            Bitmap bm = (Bitmap)pbImage.Image;
            Bitmap bmNew = new Bitmap(bm.Width, bm.Height, PixelFormat.Format8bppIndexed);
            bmNew = bm;
            int red, blue, green;
            Color pixelColor;
            double bg = sf.ImageDataMean;
            int sub = (int)Math.Round(bg / 3);
            Color greyColor;
            for (int h = 0; h < bm.Height; h++)
            {
                for (int w = 0; w <bm.Width; w++)
                {
                    red = 0;
                    blue = 0;
                    green = 0;
                    pixelColor = bm.GetPixel(w,h);
                    if (pixelColor.R-sub>0)
                    {
                        red = pixelColor.R - sub;
                    }
                    if (pixelColor.B - sub > 0)
                    {
                        blue = pixelColor.B - sub;
                    }
                    if (pixelColor.G - sub > 0)
                    {
                        green = pixelColor.G - sub;
                    }
                    greyColor = Color.FromArgb(red, green, blue);
                    bmNew.SetPixel(w, h, greyColor);
                }
            }
            pbImage.Image = bmNew;
        }
    }

}
