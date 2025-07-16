namespace Shop;

class ShopManager
{
    public List<(Shop Shop, int TotalPriceBatch)> BuyBatchOfProducts(Shop shop, List<(int ProductCode, int Quanity)> batchOfProducts)
    {
        List<(Shop Shop, int TotalPriceBatch)> batchPrice = new();
        int totalPriceBatch=0;
        foreach(var product in shop.productSet)
        {
            foreach(var item in batchOfProducts)
            {
                if(product.Product.Code == item.ProductCode)
                {
                    if(item.Quanity<=product.Quanity)
                    {
                        totalPriceBatch += GetProductPriceByCode(shop, item.ProductCode) * item.Quanity;
                    }
                    else
                    {
                        Console.WriteLine("Покупка товаров невозможна из-за нехватки продуктов");
                        return batchPrice;
                    }
                }
            }
        }
        if(totalPriceBatch == 0)
        {
            Console.WriteLine("Покупка товаров невозможна из-за нехватки продуктов");
            return batchPrice;
        }
        batchPrice.Add((shop, totalPriceBatch));
        return batchPrice;
    }

    public int GetProductPriceByCode(Shop shop, int productCode)
    {
        foreach (var item in shop.productSet)
        {
            if (productCode == item.Product.Code)
            {
                return item.Price;
            }
        }
        return 0;
    }
}
