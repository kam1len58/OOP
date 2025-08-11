namespace WorkShop;

public class ShopsManager
{
    private List<Shop> shops;

    public ShopsManager(List<Shop> shops)
    {
        this.shops = shops;
    }

    public List<(Shop Shop, Product Product, int NumberOfProducts)> GetProductsWithInBudget(int budget, int shopCode)
    {
        List<(Shop Shop, Product Product, int NumberOfProducts)> productsWithInBudget = new();
        foreach (var shop in shops)
        {
            if (shop.Code == shopCode)
            {
                var products = Shop.SearchProductByBudget(shop, budget);
                foreach (var product in products)
                {
                    if (product.NumberOfProducts > 0)
                    {
                        productsWithInBudget.Add((shop, product.Product, product.NumberOfProducts));
                    }
                }
            }
        }
        return productsWithInBudget;
    }
}