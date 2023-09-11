using PetroPrime.DAL.Data;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository.InterfaceDefination
{
    public class OrderRepository : IOrderRepository
    {
        private PetroPrimeDbContext _petroPrimeDbContext;

        public OrderRepository(PetroPrimeDbContext petroPrimeDbContext)
        {
            _petroPrimeDbContext = petroPrimeDbContext;
        }

        public void AddOrderDetails(Orders OrderInfo)
        {
            _petroPrimeDbContext.order.Add(OrderInfo);
            _petroPrimeDbContext.SaveChanges();
        }
    }
}
