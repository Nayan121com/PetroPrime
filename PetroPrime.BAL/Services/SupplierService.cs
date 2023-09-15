using PetroPrime.DAL.Repository;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.BAL.Services
{
    public class SupplierService
    {
        private ISupplierRepository _supplierRepository;
        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public void Register(Supplier supplierInfo)
        {
            _supplierRepository.Register(supplierInfo);
        }

        public Supplier Login(Login supplierDetails)
        {
             var result = _supplierRepository.Login(supplierDetails);
            return result;
        }
    }
}
