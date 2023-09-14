using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PetroPrime.DAL.Data;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository.InterfaceDefination
{
    public class ProductRepository : IProductRepository
    {
        private PetroPrimeDbContext _petroPrimeDbContext; 
        public ProductRepository(PetroPrimeDbContext petroPrimeDbContext) 
        {
            _petroPrimeDbContext = petroPrimeDbContext;
        }

        public int AddProduct(Product productInfo)
        {
            _petroPrimeDbContext.product.Add(productInfo);
            _petroPrimeDbContext.SaveChanges();
            return productInfo.ProductId;
        }
    }
}
