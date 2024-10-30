using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhang
{
    internal class ShoppingCart
    {
        private List<ShoppingCartItem> items = new List<ShoppingCartItem>();

        public void AddToCart(Product product, int quantity)
        {
            var existingItem = items.FirstOrDefault(i => i.Product.Name == product.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new ShoppingCartItem(product, quantity));
            }
        }

        public void RemoveFromCart(Product product)
        {
            items.RemoveAll(i => i.Product.Name == product.Name);
        }

        public decimal TotalPrice => items.Sum(i => i.TotalPrice);
        public int TotalQuantity => items.Sum(i => i.Quantity);
        public List<ShoppingCartItem> GetItems() => new List<ShoppingCartItem>(items);
        public void ClearCart() => items.Clear();
    }
}
