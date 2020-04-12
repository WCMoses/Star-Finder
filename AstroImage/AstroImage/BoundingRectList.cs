using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroImage
{
    public class BoundingRectList
    {
        public List<BoundingRect> BrList { get; set; }

        public BoundingRectList()
        {
            BrList = new List<BoundingRect>();
        }
        public bool ContainsPoint(int x, int y)
        {

            foreach (var item in BrList)
            {
                if (BrContainsPoint(item, x, y))
                {
                   // Console.Write("   ContainsPointt: " + x + "," + y + "--" + "true");
                    return true;
                }
            }
            //Console.Write("   ContainsPointt: " + x + "," + y + "--" + "false");
            return false;
        }
        private bool BrContainsPoint(BoundingRect br, int x, int y)
        {
           // Console.Write("    BrContainsPoint:" + x + "," + y);
           // Console.Write(" in: [" + br.UpperLeftX + "," + br.UpperLeftY + "], [" + br.BottomRightX + "," + br.BottomRightY + "] = ");

            if (x >= br.UpperLeftX && x <= br.BottomRightX)
            {
                if (y >= br.UpperLeftY && y <= br.BottomRightY)
                {
                   // Console.WriteLine("true");
                    return true;
                }
            }
           // Console.WriteLine("false");
            return false;
        }
    }
}
