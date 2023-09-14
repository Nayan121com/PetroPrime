using PetroPrime.DAL.Data;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository.InterfaceDefination
{
    public class ProductSupplierRepository : IProductSupplierRepository
    {
        private PetroPrimeDbContext _petroPrimeDbContext;
        public ProductSupplierRepository(PetroPrimeDbContext petroPrimeDbContext)
        {
            _petroPrimeDbContext = petroPrimeDbContext;
        }

        public void AddProductSupplier(int supplierId, int productId)
        {
            ProductSupplier prodSupplierDetails = new ProductSupplier();
            prodSupplierDetails.ProductId = productId;
            prodSupplierDetails.SupplierId = supplierId;
            _petroPrimeDbContext.productSupplier.Add(prodSupplierDetails);    
        }

        public List<int> FetchProductSupplier(int productId)
        {
            var result = _petroPrimeDbContext.productSupplier.Where(obj => obj.ProductId == productId);
            List<int> supplierIds = new List<int>();
            foreach(var i in result)
            {
                supplierIds.Add(i.ProductId);
            }

            return supplierIds;
        }
    }
}
