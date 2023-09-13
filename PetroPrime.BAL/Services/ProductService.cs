using PetroPrime.DAL.Repository;
using PetroPrime.Entity.Model;

namespace PetroPrime.BAL.Services
{
    public class ProductService 
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
                _productRepository = productRepository;
        }

        public void AddProduct(Product ProductInfo)
        {
            _productRepository.AddProduct(ProductInfo);
        }

        //public string ProductDetails(int ProductId)
        //{
        //    return _productRepository.ProductDetails(ProductId);
        //}

    }
}