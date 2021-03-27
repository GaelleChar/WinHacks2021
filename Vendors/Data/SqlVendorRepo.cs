using System;
using System.Collections.Generic;
using System.Linq;
using Vendors.Models;

namespace Vendors.Data
{
    public class SqlVendorRepo : IVendorRepo
    {
        private readonly VendorContext _context;

        public SqlVendorRepo(VendorContext context)
        {
            _context = context;
        }

        public void CreateVendor(Vendor vendor)
        {
            if (vendor == null)
            {
                throw new ArgumentNullException(nameof(vendor));
            }

            _context.Vendors.Add(vendor);
        }

        public IEnumerable<Vendor> GetAllVendors()
        {
            return _context.Vendors.ToList();
        }

        public Vendor GetVendorById(int id)
        {
            return _context.Vendors.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateVendor(Vendor vendor)
        {
            //Nothing
        }
    }


}