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
        public void AddToCart(Cart cartInfo)
        {
            _petroPrimeDbContext.carts.Add(cartInfo);
            _petroPrimeDbContext.SaveChanges();
        }

        //public int FetchCartAmount(int CartId)
        //{
        //    int amount = 0;
        //    var result = _petroPrimeDbContext.carts.Where(obj => obj.CartId == CartId).ToList();
        //    if (result.Count() > 0)
        //    {
        //        amount = result[0].TotalAmount;
        //    }
        //    return amount;
        //}

        //public int FetchCartId(int CustomerId)
        //{
        //    int cartId = 0;
        //    var result = _petroPrimeDbContext.carts.Where(obj => obj.CustomerId == CustomerId).ToList();
        //    if (result.Count() > 0)
        //    {
        //        cartId = result[0].CartId;
        //    }
        //    return cartId;
        //}
    }
}
