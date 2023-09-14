using Microsoft.EntityFrameworkCore;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Data
{
    public class PetroPrimeDbContext:DbContext
    {
        public PetroPrimeDbContext(DbContextOptions<PetroPrimeDbContext> options) : base(options) { }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Supplier> supplier { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<ProductSupplier> productSupplier { get; set; }
        public DbSet<CartItem> cartItem { get; set; }
    }
}
