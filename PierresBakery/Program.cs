using System;

namespace PierresBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Bread: $5 each, Buy 2, get 1 free");
            Console.WriteLine("Pastry: $2 each, 3 for $5");

            Console.WriteLine("How many loaves of bread would you like? ");
            int pastryCount = int.Parse(Console.ReadLine());
            
           Bread bread = new Bread();
            Pastry pastry = new Pastry(); 
            // Console.ReadLine();
        }
    }
}
