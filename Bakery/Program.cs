using System;
using Bakery.Models;

class Program
{
  static void Main()
  {
    try
    {
      Console.WriteLine("Hello");
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();
      Console.WriteLine($"The Price of Bread is {newBread.Price}");
      Console.WriteLine($"The Price of Pastries is {newPastry.Price}");
      Console.WriteLine("How many loaves of bread would you like?");
      int loaves = Int32.Parse(Console.ReadLine());
      if (typeof(Int32) != loaves.GetType())
      Console.WriteLine("How many pastries would you like?");
      int pastries = Int32.Parse(Console.ReadLine());
      int breadPrice = newBread.GetTotal(loaves);
      int pastryPrice = newPastry.GetTotal(pastries);
      Console.WriteLine($"{loaves} loaves and {pastries} pastries comes to a total of ${breadPrice + pastryPrice}");
    }
    catch
    {

    }
  }
} 