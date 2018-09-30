using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IW_GildedRose.Interface;

namespace IW_GildedRose.Class
{
    public class ReduceQuality : IQuality,IFactor
    {
        public int Factor { get; set; }
        public int Days { get; set; }
        private int newQuality { get; set; }
        public int GetQuality(int QualityValue)
        {
            newQuality = QualityValue - (Days * Factor);
            return newQuality;
        }
    }
}
