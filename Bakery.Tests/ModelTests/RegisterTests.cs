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
    public void GetPrice_ReturnsPrice_Int()
    {
      Bread newBread = new Bread();
      int price = 5;
      int result = newBread.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDiscount_ReturnsDiscount_Int()
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
    public void GetPrice_ReturnsPrice_Int()
    {
      Pastry newPastry = new Pastry();
      int price = 2;
      int result = newPastry.Price;
      Assert.AreEqual(price, result);
    }
  }
}