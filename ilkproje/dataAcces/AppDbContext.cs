using System;
using System.Data.Entity;
using System.Linq;
using ilkproje.Models;

namespace ilkproje.dataAcces
{
    public class AppDbContext : DbContext
    {
      
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }
        public virtual DbSet<yazar> Blogs { get; set; }
    }
}