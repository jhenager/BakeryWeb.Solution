using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrderName_ResturnsOrderName_String()
    {
      string orderName = "Bread";
      Order newOrder = new Order(orderName);
      string result = newOrder.OrderName;
      Assert.AreEqual("Croissant", result);
    }
  }
}