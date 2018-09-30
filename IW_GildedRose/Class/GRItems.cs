using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_GildedRose.Class
{
    public class GRItems
    {
        private string v1;
        private int v2;
        private int v3;

        public GRItems(string v1, int v2, int v3)
        {
            ItemName = v1;
            SellingValue = v2;
            QualityValue = v3;
        }

        public string ItemName { get; set; }
        public Int32 SellingValue { get; set; }
        public Int32 QualityValue { get; set; }
    }
}
