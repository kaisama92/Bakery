using System;

namespace Bakery.Models
{
  public class Register
  {
    public int Price { get; }
    public int Discount { get; }

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

// namespace Bakery.Models
// {
//   public class Register
//   {
//     public int Price { get; set; }
//     public int Discount { get; set; }
//     public int GetPrice(int input)
//     {
//       int remainder = input/this.Discount;
//       int price = this.Price;
//       int total = price * (input-remainder); 
//       return total;
//     }
//   }
//   public class Bread : Register
//   {
//     public Bread()
//     {
//       Discount = 3;
//       Price = 5;
//     }
//   }
//   public class Pastry : Register
//   {
//     public Pastry()
//     {
//       Discount = 4;
//       Price = 2;
//     }
//   }
  
// }
