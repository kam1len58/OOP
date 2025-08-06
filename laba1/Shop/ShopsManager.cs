namespace WorkShop;
using System.Linq;

public class ShopsManager
{
    private List<Shop> shops = new();

    public ShopsManager(List<Shop> shops)
    {
        this.shops = shops;
    }

    public (List<Shop> Shop, Product Product) SearchCheapestShops(int productCode)
    {
        (List<Shop> Shop, Product Product) cheapestShops = new();
        var productsByCode = SearchProductByCodeInShops(productCode, shops);
        if (productsByCode.Count > 0)
        {
            int minProductPrice = productsByCode[0].ProductPrice;
            List<Shop> shops = new();
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
        }
        return cheapestShops;
    }

    private List<(Shop Shop, Product Product, int ProductPrice)> SearchProductByCodeInShops(int productCode, List<Shop> shops)
    {
        List<(Shop Shop, Product Product, int ProductPrice)> products = new();
        foreach (var shop in shops)
        {
            if (shop.ProductSet.TryGetValue(productCode, out var product))
                products.Add((shop, product.Product, product.Price));
        }
        return products;
    }
}
