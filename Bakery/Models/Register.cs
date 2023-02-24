using System;

namespace Bakery.Models
{
  public class Register
  {
    public int Price { get; }
    public Register(int amount)
    {
      Price = amount;
    }
  }
  public class Bread
  {
    public int Price { get; set; }
    public int Discount { get; set; }
    public Bread()
    {
      Price = 5;
      Discount = 3;
    }
  }
  
  public class Pastry
  {
    public int Price { get; set; }
    public int Discount { get; set; }
    public Pastry()
    {
      Price = 2;
      Discount = 4;
    }
  }
}