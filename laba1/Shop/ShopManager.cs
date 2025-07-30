namespace WorkShop;
using System.Linq;

public class ShopsManager
{
    public List<Shop> shops = new();

    public List<(Shop Shop, Product Product)> SearchCheapestShops(int productCode)
    {
        List<(Shop Shop, Product Product)> cheapestShops = new();
        var productsByCode = SearchProductByCodeInShops(productCode, shops);
        if (productsByCode.Count > 0)
        {
            int minProductPrice = productsByCode.Min(price => price.ProductPrice);
            foreach (var shop in productsByCode)
            {
                if (shop.ProductPrice == minProductPrice)
                    cheapestShops.Add((shop.Shop, shop.Product));
            }
            return cheapestShops;
        }
        return cheapestShops;
    }

    private List<(Shop Shop, Product Product, int ProductPrice)> SearchProductByCodeInShops(int productCode, List<Shop> shops)
    {
        List<(Shop Shop, Product Product, int ProductPrice)> products = new();
        foreach (var shop in shops)
        {
            if (shop.productSet.TryGetValue(productCode, out var product))
                products.Add((shop, product.Product, product.Price));
        }
        return products;
    }
}
