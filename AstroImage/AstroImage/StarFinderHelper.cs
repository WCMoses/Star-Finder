using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroImage
{
    public class StarFinderHelper
    {

        //IMAGE FUNCTIONS

        public double CalculateAbsoluteBrightness(int[,] arr)
        {
            int xmax = arr.GetUpperBound(0);
            int ymax = arr.GetUpperBound(1);
            double result = 0;
            for (int y = 0; y < ymax; y++)
            {
                for (int x = 0; x <xmax - 1; x++)
                {
                    result += arr[x, y];
                }
            }
            return result;
        }
        public double CalculateRelativeBrightness(int[,] arr)
        {
            int xmax = arr.GetUpperBound(0);
            int ymax = arr.GetUpperBound(1);
            int volume = xmax * ymax;
            double result = 0;
            result = CalculateAbsoluteBrightness(arr) / volume;
            return result;
        }


        //    MATH FUNCTIONS
        public double GetMean(int[,] arr)
        {
            double result = 0;
            double sum = 0;
            int h = arr.GetUpperBound(0);
            int w = arr.GetUpperBound(1);
            for (int y = 0; y < w; y++)
            {
                for (int x = 0; x < h; x++)
                {
                    sum += arr[x, y];
                }
            }
            int pixels = h * w;
            result = sum / pixels;
            return result;
        }

        public double GetStdDev(int[,] arr)
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

        // FILE FUNCTIONS

        public void SaveToCsv(int[,] imageArray, string fullPath)
        {

            int h = imageArray.GetUpperBound(0) ;
            int w = imageArray.GetUpperBound(1);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
            Console.Write("Saving h="+ (h+1) +"  w=" + (w+1) + " array" );
            int c = 0;
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                for (int y = 0; y < h+1; y++)
                {
                    for (int x = 0; x < w+1; x++)
                    {
                        writer.Write(imageArray[x, y] + ",");
                        c++;
                    }
                    writer.WriteLine();
                }
                writer.Flush();
                Console.WriteLine(" - " +c + "elements");
            }
        }

    }
}

