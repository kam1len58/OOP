namespace WorkShop;

public class ShopsManager
{
    private Dictionary<int, Shop> _shops;

    public ShopsManager(Dictionary<int, Shop> shops)
    {
        _shops = shops;
    }

    public List<(Shop Shop, Product Product, int NumberOfProducts)> GetProductsWithInBudget(int budget, int shopCode)
    {
        List<(Shop Shop, Product Product, int NumberOfProducts)> productsWithInBudget = new();
        if (_shops.TryGetValue(shopCode, out var shop))
        {
            Shop store = shop;
            var products = store.SearchProductByBudget(shop, budget);
            productsWithInBudget = products.Where(products => products.NumberOfProducts > 0).Select(products => (shop, products.Product, products.NumberOfProducts)).ToList();
        }

        return productsWithInBudget;
    }
}
