using System.Collections.Generic;
using System;


namespace PierresBakery.Models
{
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

        if (pastryCount == 4)
        {
          totalCost -= Price;
          pastryCount = 0;
        }
      }
      return totalCost;
    }
  }
}