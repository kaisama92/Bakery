using System;

namespace Bakery.Models
{
  public class Register
  {
    public int Price { get; set; }
    public int Discount { get; set; }

    public Register()
    {
      Price = 1;
      Discount = 2;
    }
    
    public int GetTotal(int input)
    {
      int remainder = input/this.Discount;
      int total = this.Price * (input-remainder);
      return total;
    }
  }
  
  public class Bread : Register
  {
    public Bread()
    {
      Price = 5;
      Discount = 3;
    }
  }
  
  public class Pastry : Register
  {
    public Pastry()
    {
      Price = 2;
      Discount = 4;
    }
  } 
}
