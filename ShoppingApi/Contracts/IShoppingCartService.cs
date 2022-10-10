using ShoppingApi.Model;

namespace ShoppingApi.Contracts
{
    public interface IShoppingCartService
    {
        List<ShoppingItem> GetAllItems();
    }
}
