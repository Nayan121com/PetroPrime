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
    public class CartRepository : ICartRepository
    {
        private PetroPrimeDbContext _petroPrimeDbContext;

        public CartRepository(PetroPrimeDbContext petroPrimeDbContext)
        {
            _petroPrimeDbContext = petroPrimeDbContext;
        }
        public int AddToCart(Cart cartInfo)
        {
            _petroPrimeDbContext.carts.Add(cartInfo);
            _petroPrimeDbContext.SaveChanges();
            return cartInfo.CartId;
        }

        public void ClearCart(int cartId)
        {
            // Performing the modify opertion, making entries 0.
            var cart = _petroPrimeDbContext.carts.Find(cartId);
            cart.NumberOfItem = 0;
            cart.TotalAmount = 0;
            _petroPrimeDbContext.Entry(cart).State = EntityState.Modified;
            _petroPrimeDbContext.SaveChanges();
        }
    }
}
