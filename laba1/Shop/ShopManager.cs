namespace WorkShop;
using System.Linq;

public class ShopsManager
{
    public List<Shop> shops = new();

    public List<(List<Shop> Shop, Product Product)> SearchCheapestShops(int productCode)
    {
        List<(List<Shop> Shop, Product Product)> cheapestShops = new();
        var productsByCode = SearchProductByCodeInShops(productCode, shops);
        if (productsByCode.Count > 0)
        {
            int minProductPrice = productsByCode[0].ProductPrice;
            List<Shop> shops = new();
            foreach (var shop in productsByCode)
            {
                if (shop.ProductPrice < minProductPrice)
                {
                    minProductPrice = shop.ProductPrice;
                    shops.Clear();
                    shops.Add(shop.Shop);
                }
                else if (shop.ProductPrice == minProductPrice)
                {
                    shops.Add(shop.Shop);
                }
            }
            cheapestShops.Add((shops, productsByCode.First().Product));
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
