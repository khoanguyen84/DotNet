using ShopingCart.DAL.Interface;
using ShopingCart.Domain;

namespace ShopingCart.DAL.Implement
{
    public class CartService : ICartService
    {
        public List<CartDetail> Cart = new List<CartDetail>();
        public bool AddToCart(CartDetail cartDetail)
        {
            try
            {
                CartDetail cartItem = GetCartItem(cartDetail.ProductName);
                if (string.IsNullOrEmpty(cartItem.ProductName))
                {
                    Cart.Add(cartDetail);
                }
                else
                {
                    cartItem.Quantity += cartDetail.Quantity;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<CartDetail> GetCart()
        {
            return Cart;
        }

        public CartDetail GetCartItem(string productName)
        {
            foreach (CartDetail item in Cart)
            {
                if (item.ProductName.ToLower().Equals(productName.ToLower()))
                {
                    return item;
                }
            }
            return new CartDetail();
        }

        public bool RemoveCartItem(string productName)
        {
            try
            {
                CartDetail cartItem = GetCartItem(productName);
                if (!string.IsNullOrEmpty(cartItem.ProductName))
                {
                    return Cart.Remove(cartItem);
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateCartItem(string productName, int newQuantity)
        {
            try
            {
                CartDetail cartItem = GetCartItem(productName);
                if (!string.IsNullOrEmpty(cartItem.ProductName))
                {
                    cartItem.Quantity += newQuantity;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
