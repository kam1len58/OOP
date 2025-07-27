namespace WorkShop;

public class ShopManager
{
    Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20");
    Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
    Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");

    public List<(Shop Shop, Product Product, int NumberOfProducts)> GetProductsWithInBudget(int budget, params Shop[] shops)
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

    public static List<(Product Product, int NumberOfProducts)> SearchProductByBudget(Shop shop, int budget)
    {
        List<(Product Product, int NumberOfProducts)>? products = new();
        Product product;
        int numberOfProducts;
        foreach (var item in shop.productSet)
        {
            if (budget >= item.Value.Price)
            {
                product = item.Value.Product;
                numberOfProducts = budget / item.Value.Price;
                products.Add((product, numberOfProducts));
            }
        }
        if (products.Count > 0)
        {
            return products;
        }
        else
        {
            Console.WriteLine("Покупка невозможна из-за нехватки продуктов или денег");
        }
        return products;
    }
}
