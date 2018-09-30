using IW_GildedRose.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IW_GildedRose.Class;

namespace IW_GildedRose
{
    class Program
    {
        static void Main(string[] args)
        {
            var Items = new List<GRItems>
                { new GRItems("Aged Brie" , 1 ,1),
                  new GRItems("Backstage passes" , -1 ,2),
                  new GRItems("Backstage passes" , 9 ,2),
                  new GRItems("Sulfuras" , 2 ,2),
                  new GRItems("Normal item" , -1 ,55),
                  new GRItems("Normal item" , 2 ,2),
                  new GRItems("INVALID ITEM" , 2 ,2),
                  new GRItems("Conjured" , 2 ,2),
                  new GRItems("Conjured" , -1 ,5),
                 };

            
            var SellingValue = new DecreaseSelling();
            SellingValue.Days = 1;
            SellingValue.Factor = 1;
            foreach (var item in Items)
            {
                var SValue = SellingValue.GetSellingValue(item.SellingValue);
                var Qvalue = GetQuality(item.ItemName,item.QualityValue,item.SellingValue);
                if (Qvalue == -99)
                {
                    Console.WriteLine("NO SUCH ITEM");
                }
                else
                {
                    Console.WriteLine(item.ItemName + ' ' + (item.ItemName == "Sulfuras" ? item.SellingValue : SValue) + ' ' + Qvalue);
                }
            }
        }

        public static Int32 GetQuality(string ItemName , Int32 Quality , Int32 Days)
        {
            var IncQuality = new IncreaseQuality();
            var DecQualtity = new ReduceQuality();
            switch (ItemName)
            {
                case "Aged Brie":
                    IncQuality.Days = 1;
                    IncQuality.Factor = 1;
                    return IncQuality.GetQuality(Quality);
                case "Backstage passes":
                    IncQuality.Days = 1;
                    IncQuality.Factor = (Days < 10 && Days > 5 ? 2 : Days <= 5 ? 3 : 1 );
                    return IncQuality.GetQuality(Quality);
                case "Sulfuras":
                    return Quality;
                case "Normal item":
                    DecQualtity.Days = 1;
                    DecQualtity.Factor = 1;
                    return DecQualtity.GetQuality(Quality);
                case "Conjured":
                    DecQualtity.Days = 1;
                    DecQualtity.Factor = 2;
                    return DecQualtity.GetQuality(Quality);
                default:
                    return -99;
            }
        }
    }
}
