using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We have two items: Bread and Pastry");
      Console.WriteLine("Here are the deals we offer:");
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("Pastry: Buy 3, get 1 free. A single pastry costs $2.");

      Console.WriteLine("How many loaves of bread would you like?");
      int breadCount = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("How many pastries would you like?");
      int pastryCount = Convert.ToInt32(Console.ReadLine());


      Bread bread = new Bread();
      Pastry pastry = new Pastry();

      int freeBreadCount = breadCount / 3;
      decimal breadCost = (breadCount - freeBreadCount) * 5m;

      int freePastryCount = pastryCount / 4;
      decimal pastryCost = (pastryCount - freePastryCount) * 2m;

      Console.WriteLine("Your order total is $" + (breadCost + pastryCost));
    }
  }
}
