using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests 
  {

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
      Assert.AreEqual("Pierre", result);
    }
  }
}