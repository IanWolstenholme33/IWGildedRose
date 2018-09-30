using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IW_GildedRose.Class;

namespace IW_GildedRoseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncrease()
        {
            var newItem = new GRItems("Aged Brie", 1, 1);
            var IncreaseQuality = new IncreaseQuality();
            IncreaseQuality.Days = 1;
            IncreaseQuality.Factor = 1;
            Assert.AreNotEqual(IncreaseQuality.GetQuality(newItem.QualityValue), newItem.QualityValue);

        }

        [TestMethod]
        public void TestDecrease()
        {
            var newItem = new GRItems("Sulfuras", 2, 2);
            var ReduceQuality = new ReduceQuality();
            ReduceQuality.Days = 1;
            ReduceQuality.Factor = 1;
            Assert.AreNotEqual(ReduceQuality.GetQuality(newItem.QualityValue), newItem.QualityValue);

        }

        [TestMethod]
        public void TestSelling()
        {
            var newItem = new GRItems("Aged Brie", 1, 1);
            var DecreaseSelling = new DecreaseSelling();
            DecreaseSelling.Days = 1;
            DecreaseSelling.Factor = 1;
            Assert.IsTrue(DecreaseSelling.GetSellingValue(newItem.SellingValue) < newItem.QualityValue);
        }
    }
}
