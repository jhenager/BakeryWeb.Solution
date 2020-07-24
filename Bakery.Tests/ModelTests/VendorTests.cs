using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ResturnsVendorName_String()
    {
      string vendorName = "Pierre";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.VendorName;
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void SetVendorName_SetVendorName_String()
    {
      string vendorname = "Pierre";
      Vendor newVendor = new Vendor(vendorname);
      string secondVendor = "Bill";
      newVendor.VendorName = secondVendor;
      string result = newVendor.VendorName;
      Assert.AreEqual(secondVendor, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newVendor = new List<Vendor> {};
      List<Vendor> result = Vendor.GetAll();

      foreach (Vendor thisVendor in result)
      {
        Console.WriteLine(thisVendor.VendorName);
      }

      CollectionAssert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendor_VendorList()
    {
      string vendor1 = "Joey";
      string vendor2 = "Don";
      Vendor newVendor1 = new Vendor(vendor1);
      Vendor newVendor2 = new Vendor(vendor2);
      List<Vendor> vendorList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      foreach (Vendor thisVendor in result)
      {
        Console.WriteLine(thisVendor.VendorName);
      }

      CollectionAssert.AreEqual(vendorList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}