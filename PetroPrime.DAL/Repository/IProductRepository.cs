using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product productInfo);
        string ProductDetails(int ProductId);
        int ProductCategoryId(int ProductId);
        //int ProductSupplierId(int ProductId);
    }
}
