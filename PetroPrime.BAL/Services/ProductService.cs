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

        public int AddProduct(Product ProductInfo)
        {
            return _productRepository.AddProduct(ProductInfo);
        }

        public Product FetchProduct(int ProductId)
        {
            return _productRepository.FetchProduct(ProductId);
        }

        public void DeleteProduct(int ProductId)
        {
            _productRepository.DeleteProduct(ProductId);
        }
    }
}