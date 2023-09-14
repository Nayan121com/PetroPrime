using PetroPrime.DAL.Repository;
using PetroPrime.DAL.Repository.InterfaceDefination;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.BAL.Services
{
    public class CartItemService
    {
        private ICartItemRepository _cartItemRepository;

        public CartItemService(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }
        public void AddCartItem(CartItem cartItem)
        {
            _cartItemRepository.AddCartItem(cartItem);
        }

        public void DeleteCartItem(int cartItemId)
        {
            _cartItemRepository.DeleteCartItem(cartItemId);
        }

        public void UpdateCartItem(int cartItemId, int quantity)
        {
            _cartItemRepository.UpdateCartItem(cartItemId, quantity);
        }
    }
}
