﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroImage
{
    public class BoundingRectList
    {
        private List<BoundingRect> _brList;
        public List<BoundingRect> BrList
        {
            get
            {
                return _brList;
            }
            set
            {
                _brList = value;
            }
        }
        public SortOrderEnum SortOrder { get; set; }

        public BoundingRectList()
        {
            BrList = new List<BoundingRect>();
            SortOrder = SortOrderEnum.UpperLeft;
        }

        public void SortList()
        {
            SortOrderEnum sortOrder = SortOrder;
            List<BoundingRect> result = new List<BoundingRect>();
            if (BrList == null)
            {
                return;
            }
            if (BrList.Count < 2)
            {
                return;
            }
            if (sortOrder == SortOrderEnum.UpperLeft)
            {
                var x = from b in BrList
                        orderby b.OriginalUpperLeftY, b.OriginalUpperLeftX
                        select b;
                result = x.ToList<BoundingRect>();
            }
            if (sortOrder == SortOrderEnum.CentroidLocation)
            {
                var x = from b in BrList
                        orderby b.CentroidX, b.CentroidY
                        select b;
                result = x.ToList<BoundingRect>();
            }
            if (sortOrder == SortOrderEnum.RelativeBrightness)
            {
                var x = from b in BrList
                        orderby b.RelativeBrightness descending
                        select b;
                result = x.ToList<BoundingRect>();
            }
            if (sortOrder == SortOrderEnum.AbsoluteBrightness)
            {
                var x = from b in BrList
                        orderby b.AbsoluteBrightness descending
                        select b;
                result = x.ToList<BoundingRect>();
            }
            if (sortOrder == SortOrderEnum.Volume)
            {
                var x = from b in BrList
                        orderby b.Volume descending
                        select b;
                result = x.ToList<BoundingRect>();
            }
            BrList = result;
        }
        public bool ContainsPoint(int x, int y)
        {
            foreach (var item in BrList)
            {
                if (item.ContainsPoint(x, y))
                {
                    Console.WriteLine("   ContainsPoint: " + x + "," + y + "--" + "true");
                    return true;
                }
            }
            Console.WriteLine("   ContainsPoint: " + x + "," + y + "--" + "false");
            return false;
        }

        public bool BrIntersectsAnotherBr(BoundingRect br)
        {

            foreach (var item in BrList)
            {
                //  Check to see if any part of rect is in another rect - Onlt need to check top row??
                // Hack - embed in algorith better.  Should not need??
                //

                for (int x = item.OriginalUpperLeftX; x < item.OriginalBottomRightX+1; x++)
                {
                    for (int y = 0; item.OriginalUpperLeftY < item.OriginalBottomRightY+1; y++)
                    {
                        if (ContainsPoint(x, y))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public enum SortOrderEnum
        {
            UpperLeft = 1,
            Volume = 2,
            AbsoluteBrightness = 3,
            RelativeBrightness = 4,
            CentroidLocation = 5
        }

    }
}
