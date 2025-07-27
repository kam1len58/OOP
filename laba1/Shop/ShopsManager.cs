namespace WorkShop;

public class ShopsManager
{
    Shop? shop1;
    Shop? shop2;
    Shop? shop3;
    public Shop[]? shops;

    public List<(Shop Shop, Product Product, int NumberOfProducts)> GetProductsWithInBudget(int budget, Shop[] shops)
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
        foreach (var item in shop.productSet)
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