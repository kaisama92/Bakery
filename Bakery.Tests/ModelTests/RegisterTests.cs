using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetObjectPrice_ReturnsPrice_Int()
    {
      Bread newBread = new Bread();
      int price = 5;
      int result = newBread.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetObjectDiscount_ReturnsDiscount_Int()
    {
      Bread newBread = new Bread();
      int discount = 3;
      int result = newBread.Discount;
      Assert.AreEqual(discount, result);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetObjectPrice_ReturnsPrice_Int()
    {
      Pastry newPastry = new Pastry();
      int price = 2;
      int result = newPastry.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetObjectDiscount_ReturnsPrice_Int()
    {
      Pastry newPastry = new Pastry();
      int discount = 4;
      int result = newPastry.Discount;
      Assert.AreEqual(discount, result);
    }
  }
  [TestClass]
  public class RegisterTests
  {
    [TestMethod]
    public void RegisterConstructor_CreatesInstanceOfRegister_Register()
    {
      Register newRegister = new Register();
      Assert.AreEqual(typeof(Register), newRegister.GetType());
    }
    [TestMethod]
    public void GetObjectPrice_ReturnsPriceOfRegister_Int()
    {
      Register newRegister = new Register();
      int result = newRegister.Price;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetObjectDiscount_ReturnsDiscountOfRegister_Int()
    {
      Register newRegister = new Register();
      int result = newRegister.Discount;
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void GetTotal_ReturnsTheTotalPriceOfANumberOfObjects_Int()
    {
      Register newRegister = new Register();
      int input = 5;
      Assert.AreEqual(3, newRegister.GetTotal(input));
    }
  }
}