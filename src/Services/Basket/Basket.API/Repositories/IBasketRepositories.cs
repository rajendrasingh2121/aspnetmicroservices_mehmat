using Basket.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public interface IBasketRepositories
    {
        Task<ShoppingCart> GetBasket(string username);
        Task<ShoppingCart> UpdatBasket(ShoppingCart cart);
        Task DeleteBasket(string username);
    }
}
