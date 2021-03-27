using System.Collections.Generic;
using Vendors.Models;

namespace Vendors.Data
{
    public interface IVendorRepo
    {
        bool SaveChanges();
       IEnumerable<Vendor> GetAllVendors();
       Vendor GetVendorById(int id);
       void CreateVendor(Vendor vendor);
       void UpdateVendor(Vendor vendor);
    }

}