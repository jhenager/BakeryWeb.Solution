using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorItems = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorItems);
      return View(model);
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newvendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

  
    
    [HttpPost("/vendors/{vendorsId}/orders")]
    public ActionResult Create(int vendorId, string orderName, string description, int price, string date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderName, description, price, date);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}