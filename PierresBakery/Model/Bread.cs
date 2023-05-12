using System.Collections.Generic;
using System;


namespace PierresBakery.Models
{
  public class Bread
  {
    public int LoafCount { get; set; } = 0;
    public decimal LoafPrice { get; set; } = 5.0m;

    public decimal GetOrderCost(int loafCount)
    {
      LoafCount = loafCount;
      decimal totalCost = 0m;
      int freeLoaves = loafCount / 3;
      totalCost = (loafCount - freeLoaves) * LoafPrice;
      return totalCost;
    }
  }
}