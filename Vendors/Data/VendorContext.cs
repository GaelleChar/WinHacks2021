using Vendors.Models;
using Microsoft.EntityFrameworkCore;

namespace Vendors.Data
{
    public class VendorContext : DbContext{

      public VendorContext(DbContextOptions<VendorContext> opt) : base (opt){
          
      }

      public DbSet<Vendor> Vendors {get; set;} 
   }
}