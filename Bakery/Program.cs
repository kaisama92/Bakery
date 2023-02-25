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
      Console.WriteLine($"The Price of Bread is ${newBread.Price}");
      Console.WriteLine($"The Price of Pastries is ${newPastry.Price}");
      Console.WriteLine("How many loaves of bread would you like?");
      // int loaves = Int32.Parse(Console.ReadLine());
      string loavesString = Console.ReadLine();
      string[] loavesArr = loavesString.Split(" ");
      Console.WriteLine("How many pastries would you like?");
      string pastriesString = Console.ReadLine();
      string[] pastriesArr = pastriesString.Split(" ");
      if (loavesArr.Length > 1)
      {
        throw new ArgumentException("Number of Loaves needs to have no spaces");
      }
      else if (pastriesArr.Length > 1)
      {
        throw new ArgumentException("Number of Pastries needs to have no spaces");
      }
      int loaves = Int32.Parse(loavesString);
      int pastries = Int32.Parse(pastriesString);
      int breadPrice = newBread.GetTotal(loaves);
      int pastryPrice = newPastry.GetTotal(pastries);
      Console.WriteLine($"{loaves} loaves and {pastries} pastries comes to a total of ${breadPrice + pastryPrice}");
    }
    catch (ArgumentException e)
    {
      Console.WriteLine(e);
      Program.Main();
    }
    catch (Exception ex)
    {
      if (ex.Message == "Input string was not in a correct format.")
      {
        Console.WriteLine("Both inputs need to be a number");
      }
      else
      {
      Console.WriteLine("Message = {0}", ex.Message);
      // Console.WriteLine("Source = {0}", ex.Source);
      Console.WriteLine("StackTrace = {0}", ex.StackTrace);
      // Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }
      Program.Main();
    }
  }
} 