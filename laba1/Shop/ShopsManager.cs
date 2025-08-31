namespace WorkShop;
using System.Linq;

public class ShopsManager
{
    private List<Shop> _shops = new();

    public ShopsManager(List<Shop> shops)
    {
        _shops = shops;
    }

    public (List<Shop> Shop, Product Product)? SearchCheapestShops(int productCode)
    {
        (List<Shop> Shop, Product Product)? cheapestShops = null;
        var productsByCode = SearchProductByCodeInShops(productCode);
        if (productsByCode.Count == 0)
            return cheapestShops;

        int minProductPrice = productsByCode.First().ProductPrice;
        List<Shop> shops = [];
        foreach (var product in productsByCode)
        {
            if (product.ProductPrice < minProductPrice)
            {
                minProductPrice = product.ProductPrice;
                shops.Clear();
                shops.Add(product.Shop);
            }
            else if (product.ProductPrice == minProductPrice)
            {
                shops.Add(product.Shop);
            }
        }
        cheapestShops = (shops, productsByCode.First().Product);

        return cheapestShops;
    }

    private List<(Shop Shop, Product Product, int ProductPrice)> SearchProductByCodeInShops(int productCode)
    {
        List<(Shop Shop, Product Product, int ProductPrice)> products = [];
        foreach (var shop in _shops)
        {
            if (shop.Products.TryGetValue(productCode, out var product))
            {
                if (product.Quanity > 0)
                    products.Add((shop, product.Product, product.Price));
            }
        }
        return products;
    }
}
