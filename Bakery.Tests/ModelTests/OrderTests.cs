using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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
      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetOrderName_String()
    {
      string orderName = "Pastry";
      Order newOrder = new Order(orderName);
      string secondOrder = "Bread";
      newOrder.OrderName = secondOrder;
      string result = newOrder.OrderName;
      Assert.AreEqual(secondOrder, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> {};
      List<Order> result = Order.GetAll();

      foreach (Order thisOrder in result)
      {
        Console.WriteLine(thisOrder.OrderName);
      }

      CollectionAssert.AreEqual(newOrder, result);
    }
  }
}