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
  }
}