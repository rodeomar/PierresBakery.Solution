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

public class Pastry
{
  int PastryCount { get; set; } = 0;
  decimal PastryPrice { get; set; } = 2.0m;
  decimal GetOrderCost(int pastryCount)
  {
    PastryCount = pastryCount;
    decimal totalCost = 0m;
    if (pastryCount >= 3)
    {
      totalCost = (pastryCount / 3) * 5m + (pastryCount %3) * PastryPrice;
    }
    else
    {
      totalCost = pastryCount * pastryCount * PastryPrice;
    }
    return totalCost;
  }
}