namespace WorkShop;

public class ShopsManager
{
    private List<Shop> _shops = new();

    public ShopsManager(List<Shop> shops)
    {
        _shops = shops;
    }
    public (Shop Shop, int TotalPriceBatch)? BuyBatchOfProducts(int shopCode, Dictionary<int, int> batchOfProducts)
    {
        (Shop Shop, int TotalPriceBatch)? batch = null;
        int totalPriceBatch = 0;
        foreach (var shop in _shops)
        {
            if (shop.Code == shopCode)
            {
                foreach (var product in shop.Products)
                {
                    if (batchOfProducts.TryGetValue(product.Key, out var Quantity))
                    {
                        if (product.Value.Quanity >= Quantity)
                        {
                            totalPriceBatch += GetProductPriceByCode(shop, product.Key) * Quantity;
                            batch = (shop, totalPriceBatch);
                        }
                        else
                        {
                            return batch;
                        }
                    }
                }
            }
        }
        return batch;
    }

    public int GetProductPriceByCode(Shop shop, int productCode)
    {
        foreach (var item in shop.Products)
        {
            if (productCode == item.Key)
            {
                return item.Value.Price;
            }
        }
        return 0;
    }
}
