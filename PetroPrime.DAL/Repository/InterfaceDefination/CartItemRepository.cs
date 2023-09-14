using Microsoft.EntityFrameworkCore;
using PetroPrime.DAL.Data;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository.InterfaceDefination
{
    public class CartItemRepository : ICartItemRepository
    {
        private PetroPrimeDbContext _petroPrimeDbContext;
        
        public CartItemRepository(PetroPrimeDbContext petroPrimeDbContext) { 
            _petroPrimeDbContext = petroPrimeDbContext;
        }
        public void AddCartItem(CartItem cartItem)
        {
            _petroPrimeDbContext.cartItem.Add(cartItem);
            _petroPrimeDbContext.SaveChanges();
        }

        public void DeleteCartItem(int cartItemId)
        {
            var ctItem = _petroPrimeDbContext.cartItem.Find(cartItemId);
            _petroPrimeDbContext.cartItem.Remove(ctItem);
            _petroPrimeDbContext.SaveChanges();
        }

        public void UpdateCartItem(int cartItemId, int quantity)
        {
            var ctItem = _petroPrimeDbContext.cartItem.Find(cartItemId);
            ctItem.Quantity = quantity;
            _petroPrimeDbContext.Entry(ctItem).State = EntityState.Modified;
            _petroPrimeDbContext.SaveChanges();
        }
    }
}
