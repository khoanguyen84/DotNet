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
                CartDetail cartItem = GetCartItem(cartDetail.ProductId);
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

        public void ClearCart()
        {
            Cart = new List<CartDetail>();
        }

        public List<CartDetail> GetCart()
        {
            return Cart;
        }

        public CartDetail GetCartItem(int productId)
        {
            foreach (CartDetail item in Cart)
            {
                if (item.ProductId == productId)
                {
                    return item;
                }
            }
            return new CartDetail();
        }

        public bool RemoveCartItem(int productId)
        {
            try
            {
                CartDetail cartItem = GetCartItem(productId);
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

        public bool UpdateCartItem(int productId, int newQuantity)
        {
            try
            {
                CartDetail cartItem = GetCartItem(productId);
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
