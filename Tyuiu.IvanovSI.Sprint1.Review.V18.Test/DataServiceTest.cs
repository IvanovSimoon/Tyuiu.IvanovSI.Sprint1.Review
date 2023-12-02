using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint1.Review.V18.Lib;
namespace Tyuiu.IvanovSI.Sprint1.Review.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double z = ds.Calculate(x, y);
            Assert.AreEqual(1.913, z);
        }
    }
}
