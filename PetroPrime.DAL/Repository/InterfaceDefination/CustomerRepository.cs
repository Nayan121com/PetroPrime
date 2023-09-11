using PetroPrime.DAL.Data;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository.InterfaceDefination
{
    public class CustomerRepository : ICustomerRepository
    {
        private PetroPrimeDbContext _petroPrimeDbContext;
        public CustomerRepository(PetroPrimeDbContext petroPrimeDbContext)
        {
            _petroPrimeDbContext = petroPrimeDbContext;
        }

        public Customer Login(Customer customerDetails)
        {
            Customer customerInfo = null;
            var result = _petroPrimeDbContext.customer.Where(customerObj => customerObj.CustomerEmail == customerDetails.CustomerEmail && 
                                                        customerObj.CustomerPassword == customerDetails.CustomerPassword).ToList();
            if(result.Count() > 0)
            {
                customerInfo = result[0];
            }
            return customerInfo;
        }

        public void Register(Customer customerInfo)
        {
            _petroPrimeDbContext.customer.Add(customerInfo);
            _petroPrimeDbContext.SaveChanges();
        }
    }
}
