using PetroPrime.DAL.Repository;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.BAL.Services
{
    public class ProductService 
    {
        private IProductRepository _productRepository;

        public void AddProduct(Product ProductInfo, int catId, )
        {
            ProductInfo.CategoryId = catId;
            _productRepository.AddProduct(ProductInfo);
        }

        public string ProductDetails(int ProductId)
        {
            return _productRepository.ProductDetails(ProductId);
        }

    }
}