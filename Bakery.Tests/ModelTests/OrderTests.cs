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
      Order newOrder = new Order("test", "d", 5, "a");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrderName_ResturnsOrderName_String()
    {
      string orderName = "Bread";
      Order newOrder = new Order(orderName, "d", 5, "a");
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetOrderName_String()
    {
      string orderName = "Pastry";
      Order newOrder = new Order(orderName, "d", 5, "a");
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

    [TestMethod]
    public void GetAll_ReturnsOrder_OrderList()
    {
      string order1 = "Joey";
      string order2 = "Don";
      Order newOrder1 = new Order(order1, "d", 5, "a");
      Order newOrder2 = new Order(order2, "d", 5, "a");
      List<Order> OrderList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      foreach (Order thisOrder in result)
      {
        Console.WriteLine(thisOrder.OrderName);
      }

      CollectionAssert.AreEqual(OrderList, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string name = "Test Order";
      Order newOrder = new Order(name, "d", 5, "a");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string name1 = "Bread";
      string name2 = "Dough";
      Order newOrder1 = new Order(name1, "d", 5, "a");
      Order newOrder2 = new Order(name2, "d", 5, "a");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}