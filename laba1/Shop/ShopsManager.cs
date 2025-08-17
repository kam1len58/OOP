namespace WorkShop;

public class ShopsManager
{
    private Dictionary<int,Shop> shops;

    public ShopsManager(Dictionary<int, Shop> shops)
    {
        this.shops = shops;
    }

    public List<(Shop Shop, Product Product, int NumberOfProducts)> GetProductsWithInBudget(int budget, int shopCode)
    {
        List<(Shop Shop, Product Product, int NumberOfProducts)> productsWithInBudget = new();
        if(shops.TryGetValue(shopCode,out var shop)) {
                var products = Shop.SearchProductByBudget(shop, budget);
                foreach (var product in products)
                {
                    if (product.NumberOfProducts > 0)
                    {
                        productsWithInBudget.Add((shop, product.Product, product.NumberOfProducts));
                    }
                }
            }

        return productsWithInBudget;
    }
}