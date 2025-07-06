namespace Shop;

class ShopManager
{
    public void SearchCheapestProduct(Shop shop1, Shop shop2, Shop shop3, List<(Product, int, int)> productSet1, string cheapestProduct, List<(Product, int, int)> productSet2, List<(Product, int, int)> productSet3)
    {
        int cheapProduct1 = 0;
        int cheapProduct2 = 0;
        int cheapProduct3 = 0;

        foreach (var product in productSet1)
        {
            if (cheapestProduct == product.Item1.Name)
            {
                cheapProduct1 = product.Item3;
                break;
            }
        }

        foreach (var product in productSet2)
        {
            if (cheapestProduct == product.Item1.Name)
            {
                cheapProduct2 = product.Item3;
                break;
            }
        }

        foreach (var product in productSet3)
        {
            if (cheapestProduct == product.Item1.Name)
            {
                cheapProduct3 = product.Item3;
                break;
            }
        }

        var cheapProductPrice = Math.Min(cheapProduct1, Math.Min(cheapProduct2, cheapProduct3));
        if (cheapProduct1 == 0 && cheapProduct2 == 0 && cheapProduct3 == 0)
        {
            Console.WriteLine("Такого товара в магазинах нет");
        }
        else if (cheapProductPrice == cheapProduct1 && cheapProductPrice == cheapProduct3 && cheapProductPrice == cheapProduct2)
        {
            Console.WriteLine($"Самый дешевый(ая) {cheapestProduct} в магазинах {shop1.Name}, {shop2.Name}, {shop3.Name} его стоимость {cheapProductPrice} рублей");
        }
        else if (cheapProductPrice == cheapProduct1 && cheapProductPrice == cheapProduct3)
        {
            Console.WriteLine($"Самый дешевый(ая) {cheapestProduct} в магазинах {shop1.Name}, {shop3.Name} его стоимость {cheapProductPrice} рублей");
        }
        else if (cheapProductPrice == cheapProduct2 && cheapProductPrice == cheapProduct3)
        {
            Console.WriteLine($"Самый дешевый(ая) {cheapestProduct} в магазинах {shop2.Name}, {shop3.Name} его стоимость {cheapProductPrice} рублей");
        }
        else if (cheapProductPrice == cheapProduct1)
        {
            Console.WriteLine($"Самый дешевый(ая) {cheapestProduct} в магазине {shop1.Name} его стоимость {cheapProductPrice} рублей");
        }
        else if (cheapProductPrice == cheapProduct2)
            Console.WriteLine($"Самый дешевый(ая) {cheapestProduct} в магазине {shop2.Name} его стоимость {cheapProductPrice} рублей");
        else
            Console.WriteLine($"Самый дешевый(ая) {cheapestProduct} в магазине {shop3.Name} его стоимость {cheapProductPrice} рублей");
    }

    public void GetProductsWithinBudget(List<(Product, int Quanity, int Price)> productSet, Shop shop, int budget)
    {
        bool isBudgetEnough = false;
        foreach (var product in productSet)
        {
            if (budget >= product.Price)
            {
                isBudgetEnough = true;
                Console.WriteLine($"\nНа {budget} рублей вы можете купить {product.Item1}-{budget / product.Price} шт. в магазине {shop.Name}");
            }
        }
        if (!isBudgetEnough)
        {
            Console.WriteLine("\nУ вас недостаточно денег");
        }
    }

    public void BuyBatchOfProducts((string Name, int Quanity)[] batchOfProducts, List<(Product, int Quanity, int Price)> productSet)
    {
        bool isAllProductsAvailable = true;
        int totalPurchasePrice = 0;

        foreach (var product in batchOfProducts)
        {
            bool isProductAvailable = false;
            foreach (var purchase in productSet)
            {
                if (product.Name == purchase.Item1.Name)
                {
                    isProductAvailable = true;
                    if (purchase.Quanity < product.Quanity)
                    {
                        isAllProductsAvailable = false;
                    }
                }
            }
            if (!isProductAvailable)
            {
                isAllProductsAvailable = false;
            }
        }
        if (!isAllProductsAvailable)
        {
            Console.WriteLine("\nПокупка невозможна из-за нехватки продуктов");
        }
        else
        {
            foreach (var purchase in productSet)
            {
                foreach (var product in batchOfProducts)
                {
                    if (product.Name == purchase.Item1.Name)
                    {
                        totalPurchasePrice += product.Quanity * purchase.Price;
                    }
                }
            }
            Console.WriteLine($"\nОбщая сумма покупки составила {totalPurchasePrice} рублей");
        }
    }

    public void SearchTheCheapestBatch(List<(Product, int Quanity, int Price)> productSet1, List<(Product, int Quanity, int Price)> productSet2, List<(Product, int Quanity, int Price)> productSet3, Shop shop1, Shop shop2, Shop shop3, (string Product, int Quanity)[] batchOfProducts)
    {
        int batch1 = CheapTotalBatchPrice(productSet1, batchOfProducts);
        int batch2 = CheapTotalBatchPrice(productSet2, batchOfProducts);
        int batch3 = CheapTotalBatchPrice(productSet3, batchOfProducts);

        int cheapBatchPrice = Math.Min(batch1, Math.Min(batch2, batch3));

        if (cheapBatchPrice == int.MaxValue)
        {
            Console.WriteLine("\nПокупка партии товаров невозможна из-за нехватки продуктов");
        }
        else if (cheapBatchPrice == batch1 && cheapBatchPrice == batch2 && cheapBatchPrice == batch3)
        {
            Console.WriteLine($"\nСамая дешевая партия товаров в магазинах {shop1.Name}, {shop2.Name} и {shop3.Name} их стоимость {cheapBatchPrice} рублей");
        }

        else if (cheapBatchPrice == batch1 && cheapBatchPrice == batch3)
        {
            Console.WriteLine($"\nСамая дешевая партия товаров в магазинах {shop1.Name} и {shop3.Name} их стоимость {cheapBatchPrice} рублей");
        }
        else if (cheapBatchPrice == batch2 && cheapBatchPrice == batch3)
        {
            Console.WriteLine($"\nСамая дешевая партия товаров в магазинах {shop2.Name} и {shop3.Name} его стоимость {cheapBatchPrice} рублей");
        }
        else if (cheapBatchPrice == batch1)
        {
            Console.WriteLine($"\nСамая дешевая партия товаров в магазине {shop1.Name} его стоимость {cheapBatchPrice} рублей");
        }
        else if (cheapBatchPrice == batch2)
            Console.WriteLine($"\nСамая дешевая партия товаров в магазине {shop2.Name} его стоимость {cheapBatchPrice} рублей");

        else
            Console.WriteLine($"\nСамая дешевая партия товаров в магазине {shop3.Name} его стоимость {cheapBatchPrice} рублей");

    }

    public int CheapTotalBatchPrice(List<(Product, int Quanity, int Price)> productSet, (string Name, int Quanity)[] batchOfProducts)
    {
        bool isAllProductsAvailable = true;
        int totalPurchasePrice=0;

        foreach (var product in batchOfProducts)
        {
            bool isProductAvailable = false;
            foreach (var purchase in productSet)
            {
                if (product.Name == purchase.Item1.Name)
                {
                    isProductAvailable = true;
                    if (purchase.Quanity < product.Quanity)
                    {
                        isAllProductsAvailable = false;
                    }
                }
            }
            if (!isProductAvailable)
            {
                isAllProductsAvailable = false;
            }
        }
        if (!isAllProductsAvailable)
        {
            return totalPurchasePrice = int.MaxValue;
        }
        else
        {
            foreach (var purchase in productSet)
            {
                foreach (var product in batchOfProducts)
                {
                    if (product.Name == purchase.Item1.Name)
                    {
                        totalPurchasePrice += product.Quanity * purchase.Price;
                    }
                }
            }
            return totalPurchasePrice;
        }
    }
}
