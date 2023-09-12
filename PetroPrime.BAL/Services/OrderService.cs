using PetroPrime.DAL.Repository;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.BAL.Services
{
    public class OrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddOrderDetails(Orders OrderInfo, int paymentId)
        {
            OrderInfo.PaymentId = paymentId;
            _orderRepository.AddOrderDetails(OrderInfo);
        }
    }
}
