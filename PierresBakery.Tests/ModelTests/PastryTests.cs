using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;


namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
        [TestMethod]
    public void TestPastryCost_OnePastry()
    {
      Pastry pastry = new Pastry();
      decimal totalCost = pastry.GetOrderCost(1);
      Assert.AreEqual(2, totalCost);
    }
    [TestMethod]
    public void TestPastryCost_TwoPastry()
    {
      Pastry pastry = new Pastry();
      decimal totalCost = pastry.GetOrderCost(2);
      Assert.AreEqual(4, totalCost);
    }
    [TestMethod]
    public void TestPastryCost_ThreePastry()
    {
      Pastry pastry = new Pastry();
      decimal totalCost = pastry.GetOrderCost(3);
      Assert.AreEqual(6, totalCost);
    }
    public void TestPastryCost_FourPastry()
    {
      Pastry pastry = new Pastry();
      decimal totalCost = pastry.GetOrderCost(4);
      Assert.AreEqual(6, totalCost);
    }
    public void TestPastryCost_FivePastry()
    {
      Pastry pastry = new Pastry();
      decimal totalCost = pastry.GetOrderCost(5);
      Assert.AreEqual(8, totalCost);
    }
    public void TestPastryCost_SixPastry()
    {
      Pastry pastry = new Pastry();
      decimal totalCost = pastry.GetOrderCost(6);
      Assert.AreEqual(10, totalCost);
    }
    public void TestPastryCost_SevenPastry()
    {
      Pastry pastry = new Pastry();
      decimal totalCost = pastry.GetOrderCost(7);
      Assert.AreEqual(12, totalCost);
    }
    public void TestPastryCost_EightPastry()
    {
      Pastry pastry = new Pastry();
      decimal totalCost = pastry.GetOrderCost(8);
      Assert.AreEqual(12, totalCost);
    }
  }
}