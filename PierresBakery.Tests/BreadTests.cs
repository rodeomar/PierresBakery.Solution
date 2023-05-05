using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;


namespace PierresBakery.Tests
{
    [TestClass]
    public class BakeryTests
    {
        [TestMethod]
        public void TestBreadCost_TwoLoaves()
        {
            Bread bread = new Bread();
            decimal totalCost = bread.GetOrderCost(2);
            Assert.AreEqual(10m, totalCost);
        }
        [TestMethod]
        public void TestBreadCost_ThreeLoaves()
        {
          Bread bread = new Bread();
          decimal totalCost = bread.GetOrderCost(3);
          Assert.AreEqual(10m, totalCost);
        }
    }
}