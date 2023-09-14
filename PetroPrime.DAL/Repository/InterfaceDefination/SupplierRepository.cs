using PetroPrime.DAL.Data;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository.InterfaceDefination
{
    public class SupplierRepository : ISupplierRepository
    {
        private PetroPrimeDbContext _petroPrimeDbContext;
        public SupplierRepository(PetroPrimeDbContext petroPrimeDbContext)
        {
            _petroPrimeDbContext = petroPrimeDbContext;
        }
        public Supplier Login(Login supplierDetails)
        {
            Supplier supplierInfo = null;
            var result = _petroPrimeDbContext.supplier.Where(supplierObj => supplierObj.SupplierEmail == supplierDetails.Email &&
                                                        supplierObj.SupplierPassword == supplierDetails.Password).ToList();
            if (result.Count() > 0)
            {
                supplierInfo = result[0];
            }
            return supplierInfo;
        }

        public void Register(Supplier supplierInfo)
        {
            _petroPrimeDbContext.supplier.Add(supplierInfo);
            _petroPrimeDbContext.SaveChanges();
        }
    }
}
