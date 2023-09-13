using PetroPrime.DAL.Repository;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.BAL.Services
{
    public class CustomerService
    {
        private ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Register(Customer customerInfo)
        {
            _customerRepository.Register(customerInfo);
        }

        public Customer Login(Customer customer)
        {
            return _customerRepository.Login(customer);
        }
           
    }
}
