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

        public void AddProduct(Product productInfo)
        {
            _petroPrimeDbContext.product.Add(productInfo);
            _petroPrimeDbContext.SaveChanges();
        }

        //public int ProductCategoryId(int ProductId)
        //{
        //    int categoryId = -1;
        //    var result = _petroPrimeDbContext.product.Where(obj => obj.ProductId == ProductId).ToList();
        //    if(result.Count() > 0)
        //    {
        //        categoryId = result[0].CategoryId;
        //    }
        //    return categoryId;
        //}

        //public string ProductDetails(int ProductId)
        //{
        //    string productDetails = "";
        //    var result = _petroPrimeDbContext.product.Where(obj => obj.ProductId == ProductId).ToList();
        //    if (result.Count() > 0)
        //    {
        //        productDetails = result[0].ProductDetails;
        //    }
        //    return productDetails;
        //}

        //public int ProductSupplierId(int ProductId)
        //{
        //    int supplierId = -1;
        //    var result = _petroPrimeDbContext.product.Where(obj => obj.ProductId == ProductId).ToList();
        //    if (result.Count() > 0)
        //    {
        //        supplierId = result[0].SupplierId;
        //    }
        //    return supplierId;
        //}
    }
}
