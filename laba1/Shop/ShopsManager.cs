namespace WorkShop;

public class ShopsManager
{
    private List<Shop> shops;

    public ShopsManager(List<Shop> shops)
    {
        this.shops = shops;
    }

    public List<(Shop Shop, Product Product, int NumberOfProducts)> GetProductsWithInBudget(int budget)
    {
        List<(Shop Shop, Product Product, int NumberOfProducts)> productsWithInBudget = new();
        foreach (var shop in shops)
        {
            var products = SearchProductByBudget(shop, budget);
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

    private List<(Product Product, int NumberOfProducts)> SearchProductByBudget(Shop shop, int budget)
    {
        List<(Product Product, int NumberOfProducts)>? products = new();
        foreach (var item in shop.ProductSet)
        {
            if (budget >= item.Value.Price)
            {
                int numberOfProducts = budget / item.Value.Price;
                products.Add((item.Value.Product, numberOfProducts));
            }
        }
        return products;
    }
}