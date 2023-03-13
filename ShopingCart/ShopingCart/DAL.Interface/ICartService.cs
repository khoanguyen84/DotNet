using ShopingCart.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.DAL.Interface
{
    public interface ICartService
    {
        List<CartDetail> GetCart();
        bool RemoveCartItem(int productId);
        bool AddToCart(CartDetail cartDetail);
        bool UpdateCartItem(int productId, int newQuantity);
        CartDetail GetCartItem(int productId);
        void ClearCart();
    }
}
