using System;
using Bakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Hello");
    Bread newBread = new Bread();
    Pastry newPastry = new Pastry();
    Console.WriteLine($"The Price of Bread is {newBread.Price}");
    Console.WriteLine($"The Price of Pastries is {newPastry.Price}");
    Console.WriteLine("How many loafs of bread would you like?");
    int bread = Int32.Parse(Console.ReadLine());
    Console.WriteLine("How many pastries would you like?");
    int pastry = Int32.Parse(Console.ReadLine());
    
  }
}