using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string orderName)
    {
      OrderName = orderName;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}