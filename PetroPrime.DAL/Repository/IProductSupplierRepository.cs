using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository
{
    public interface IProductSupplierRepository
    {
        void AddProductSupplier(int supplierId, int productId);

        List<int> FetchProductSupplier(int productId);
    }
}
