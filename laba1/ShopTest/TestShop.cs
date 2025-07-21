namespace ShopTest;
using WorkShop;
using System.Text.Json;

[TestClass]
public class DeliveryBatchProductsTests
{
    [TestMethod]
    public void ComparisonActualAndExpectedBatches()
    {
        //Arrange
        Shop shop = new Shop(1, "Магнит", "пр. Мира, 20");
        (Product Product, int Quanity, int Price)[] batchProducts1 =
        [
            (new Product(1, "ХЛЕБ"), 80, 45),
            (new Product(2, "МОЛОКО"), 30, 85),
            (new Product(3, "РИС"), 40, 120),
            (new Product(4, "МАСЛО"), 25, 150),
            (new Product(5, "МЯСО"), 15, 400),
            (new Product(6, "РЫБА"), 20, 300),
            (new Product(7, "ЯЙЦА"), 100, 90),
            (new Product(8, "САХАР"), 60, 60),
            (new Product(9, "СОЛЬ"), 50, 30),
            (new Product(10, "КАРТОФЕЛЬ"), 200, 25),
            (new Product(1, "ХЛЕБ"), 80, 45),
            (new Product(2, "МОЛОКО"), 30, 85),
            (new Product(3, "РИС"), 40, 120),
            (new Product(4, "МАСЛО"), 25, 150),
            (new Product(5, "МЯСО"), 15, 400),
            (new Product(10, "КАРТОФЕЛЬ"), 200, 250)
        ];
        (Product Product, int Quanity, int Price)[] batchProducts2 =
        [
            (new Product(1, "ХЛЕБ"), 80, 45),
            (new Product(2, "МОЛОКО"), 30, 85),
            (new Product(3, "РИС"), 40, 1200),
            (new Product(4, "МАСЛО"), 25, 150),
            (new Product(5, "МЯСО"), 15, 400),
            (new Product(6, "РЫБА"), 20, 300),
            (new Product(7, "ЯЙЦА"), 100, 90),
            (new Product(8, "САХАР"), 60, 60),
            (new Product(9, "СОЛЬ"), 50, 30),
            (new Product(10, "КАРТОФЕЛЬ"), 200, 25),
            (new Product(6, "РЫБА"), 20, 30),
            (new Product(7, "ЯЙЦА"), 100, 900),
            (new Product(8, "САХАР"), 60, 760),
            (new Product(9, "СОЛЬ"), 50, 300),
            (new Product(10, "КАРТОФЕЛЬ"), 200, 225),
            (new Product(1, "ХЛЕБ"), 80, 75),
            (new Product(2, "МОЛОКО"), 30, 90),
            (new Product(1, "ХЛЕБ"), 80, 750),
            (new Product(2, "МОЛОКО"), 30, 980)
        ];
        List<(Product Product, int Quanity, int Price)> batchAfterDelivery =new()
        {
            (new Product(1, "ХЛЕБ"), 400, 750),
            (new Product(2, "МОЛОКО"), 150, 980),
            (new Product(3, "РИС"), 120, 1200),
            (new Product(4, "МАСЛО"), 75, 150),
            (new Product(5, "МЯСО"), 45, 400),
            (new Product(6, "РЫБА"), 60, 30),
            (new Product(7, "ЯЙЦА"), 300, 900),
            (new Product(8, "САХАР"), 180, 760),
            (new Product(9, "СОЛЬ"), 150, 300),
            (new Product(10, "КАРТОФЕЛЬ"), 800, 225)
        };

        //Act
        shop.DeliveryBatchProducts(batchProducts1);
        shop.DeliveryBatchProducts(batchProducts2);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string actualJson = JsonSerializer.Serialize(shop.productSet,options);
        string expectedJson = JsonSerializer.Serialize(batchAfterDelivery,options);

        //Assert
        Assert.AreEqual(expectedJson,actualJson);
    }
}

