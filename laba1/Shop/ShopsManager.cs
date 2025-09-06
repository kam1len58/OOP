namespace WorkShop;

public class ShopsManager
{
    private Dictionary<int, Shop> _shops;

    public ShopsManager(Dictionary<int, Shop> shops)
    {
        _shops = shops;
    }

    public List<(Shop Shop, Product Product, int NumberOfProducts)>? GetProductsWithInBudget(int budget, int shopCode)
    {
        List<(Shop Shop, Product Product, int NumberOfProducts)>? productsWithInBudget = null;
        bool isProductInStock = true;
        if (_shops.TryGetValue(shopCode, out var shop))
        {
            var productsInBudget = shop.SearchProductByBudget(shop, budget);
            if (productsInBudget.Count == 0)
            {
                isProductInStock = false;
                return productsWithInBudget;
            }
            if (isProductInStock)
            {
                productsWithInBudget = shop.SearchProductByBudget(shop, budget).
                Where(products => products.NumberOfProducts > 0).
                Select(products => (shop, products.Product, products.NumberOfProducts)).
                ToList();
            }
        }
        return productsWithInBudget;
    }
}
