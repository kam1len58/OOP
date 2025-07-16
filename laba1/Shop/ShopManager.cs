namespace Shop;

class ShopManager
{
    public List<(Shop Shop, Product Product, int NumberOfProducts)> GetProductsWithinBudget(Shop shop, int budget)
    {
        List<(Shop Shop, Product Product, int NumberOfProducts)> shops = new();
        var products = SearchProductByBudget(shop, budget);
        foreach (var product in products)
        {
            if (product.NumberOfProducts > 0)
            {
                shops.Add((shop, product.Product, product.NumberOfProducts));
            }
        }
        if (products.Count == 0)
        {
            Console.WriteLine("У вас недостаточно денег");
            return shops;
        }
        return shops;
    }

    public List<(Product Product, int NumberOfProducts)> SearchProductByBudget(Shop shop, int budget)
    {
        List<(Product Product, int NumberOfProducts)>? products = new();
        Product product;
        int numberOfProducts;
        foreach (var item in shop.productSet)
        {
            if (budget >= item.Price)
            {
                product = item.Product;
                numberOfProducts = budget / item.Price;
                products.Add((product, numberOfProducts));
            }
        }
        if (products.Count > 0)
        {
            return products;
        }
        return products;
    }
}
