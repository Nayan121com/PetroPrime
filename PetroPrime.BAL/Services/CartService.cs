using PetroPrime.DAL.Repository;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.BAL.Services
{
    public class CartService
    {
        private ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public int AddToCart(Cart cartInfo)
        {
            return _cartRepository.AddToCart(cartInfo);
        }

        public void clearCart(int cartId)
        {
            _cartRepository.ClearCart(cartId);
        }
    }
}
