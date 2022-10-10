using ShoppingApi.Contracts;
using ShoppingApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTesting
{
    public class FakeShoppingCart : IShoppingCartService
    {
        readonly List<ShoppingItem> _shoppingItems;

        public FakeShoppingCart()
        {
            _shoppingItems = new List<ShoppingItem>()
            {
                new ShoppingItem(){ShoppingItemId = 1 , Manufacturer = "Apple", Name = "Iphone", Price = 50000},
                new ShoppingItem(){ShoppingItemId = 2 , Manufacturer = "Apple", Name = "Iphone", Price = 50000},
                new ShoppingItem(){ShoppingItemId = 3 , Manufacturer = "Apple", Name = "Iphone", Price = 50000},
            };
        }

        public List<ShoppingItem> GetAllItems()
        {
            return _shoppingItems;
        }
    }
}
