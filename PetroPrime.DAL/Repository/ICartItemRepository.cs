using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository
{
    public interface ICartItemRepository
    {
        public void AddCartItem(CartItem cartItem);
        public void UpdateCartItem(CartItemInfo cartInfo);
        public void DeleteCartItem(int CartItemId);
    }
}
