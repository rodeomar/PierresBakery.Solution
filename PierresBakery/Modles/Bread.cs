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
  public decimal Price { get; set; } = 2.0m;

  public decimal GetOrderCost(int count)
  {
    decimal totalCost = 0.0m;
    int pastryCount = 0;

    for (int i = 1; i <= count; i++)
    {
      pastryCount++;
      totalCost += Price;

      if (pastryCount == 3)
      {
        totalCost -= Price;
        pastryCount = 0;
      }
    }

    return totalCost;
  }
}