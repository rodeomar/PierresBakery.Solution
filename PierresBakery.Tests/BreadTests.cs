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
        [TestMethod]
           public void TestBreadCost_FourLoaves()
        {
          Bread bread = new Bread();
          decimal totalCost = bread.GetOrderCost(4);
          Assert.AreEqual(15m, totalCost);
        }
           [TestMethod]
        public void TestBreadCost_FiveLoaves()
        {
            Bread bread = new Bread();
            decimal totalCost = bread.GetOrderCost(5);
            Assert.AreEqual(20m, totalCost);
        }
        [TestMethod]
        public void TestBreadCost_SixLoaves()
        {
            Bread bread = new Bread();
            decimal totalCost = bread.GetOrderCost(6);
            Assert.AreEqual(20m, totalCost);
        }
        [TestMethod]
        public void TestBreadCost_SevenLoaves()
        {
            Bread bread = new Bread();
            decimal totalCost = bread.GetOrderCost(7);
            Assert.AreEqual(25m, totalCost);
        }
    }
}