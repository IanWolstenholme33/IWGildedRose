using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IW_GildedRose.Interface;

namespace IW_GildedRose.Class
{
    public class DecreaseSelling : ISelling, IFactor
    {
        public int Factor { set; get; }
        public int Days { set; get; }
        private Int32 NewSellingValue { get; set; }
        public int GetSellingValue(int SellingValue)
        {
            NewSellingValue = SellingValue - (Days * Factor);
            return NewSellingValue;
        }
    }
}
