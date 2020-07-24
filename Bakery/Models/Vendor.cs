using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public int Id { get; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      Id = instances.Count;
    }
  }
}