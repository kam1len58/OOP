namespace TestCheapestBatch;

using System.Text.Json;
using WorkShop;

[TestClass]
public sealed class TestCheapestBatch
{
    [TestMethod]
    public void TestMethodCheapestBatch()
    {
        //Arrange
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20",
            (new Product(1, "ХЛЕБ"), 80, 45),
            (new Product(2, "МОЛОКО"), 30, 85),
            (new Product(3, "РИС"), 40, 120),
            (new Product(4, "МАСЛО"), 25, 150),
            (new Product(5, "МЯСО"), 15, 400),
            (new Product(6, "РЫБА"), 20, 300),
            (new Product(7, "ЯЙЦА"), 100, 90),
            (new Product(8, "САХАР"), 60, 60),
            (new Product(9, "СОЛЬ"), 50, 30),
            (new Product(10, "КАРТОФЕЛЬ"), 200, 25)
        );

        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50",
            (new Product(1, "ХЛЕБ"), 80, 45),
            (new Product(2, "МОЛОКО"), 30, 85),
            (new Product(3, "РИС"), 40, 120),
            (new Product(4, "МАСЛО"), 25, 150),
            (new Product(5, "МЯСО"), 15, 400),
            (new Product(6, "РЫБА"), 20, 300),
            (new Product(7, "ЯЙЦА"), 100, 90),
            (new Product(8, "САХАР"), 60, 60),
            (new Product(9, "СОЛЬ"), 50, 30),
            (new Product(10, "КАРТОФЕЛЬ"), 200, 25)
        );

        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40",
           (new Product(1, "ХЛЕБ"), 60, 50),
           (new Product(2, "МОЛОКО"), 40, 95),
           (new Product(3, "РИС"), 50, 90),
           (new Product(4, "МАСЛО"), 60, 130),
           (new Product(5, "МЯСО"), 40, 550),
           (new Product(6, "РЫБА"), 60, 470),
           (new Product(7, "ЯЙЦА"), 40, 100),
           (new Product(8, "САХАР"), 100, 20),
           (new Product(9, "СОЛЬ"), 40, 35),
           (new Product(10, "КАРТОФЕЛЬ"), 240, 55)
        );
        ShopsManager shopsManager = new ShopsManager(new() { shop1, shop2, shop3 });

        Dictionary<int, int> batchOfProducts = new() { { 1, 10 }, { 2, 7 }, { 3, 3 }, { 4, 3 }, { 5, 9 }, { 6, 1 }, { 7, 2 }, { 8, 4 }, { 9, 6 }, { 10, 20 } };
        (List<Shop> Shops, int TotalPriceBatch)? cheapestBatch = (new() { shop1 }, 6855);

        //Act
        var result = shopsManager.SearchTheCheapestBatch(batchOfProducts);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string expected = JsonSerializer.Serialize(cheapestBatch, options);
        string actual = JsonSerializer.Serialize(result, options);

        //Assert
        Assert.AreEqual(expected, actual);
    }
}
