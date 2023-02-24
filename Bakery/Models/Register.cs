using System;

namespace Bakery.Models
{
  public class Register
  {
    public int Price { get; } = 1;
    public int Discount { get; } =  2;
    public Register()
    {
      
    }
  }
  public class Bread
  {
    public int Price { get; }
    public int Discount { get; }
    public Bread()
    {
      Price = 5;
      Discount = 3;
    }
  }
  
  public class Pastry
  {
    public int Price { get; }
    public int Discount { get; }
    public Pastry()
    {
      Price = 2;
      Discount = 4;
    }
  }
}