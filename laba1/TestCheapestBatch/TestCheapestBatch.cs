using System.Text.Json;
using WorkShop;

namespace TestCheapestBatch;

[TestClass]
public sealed class TestCheapestBatch
{
    [TestMethod]
    public void MethodCheapestBatchTestOne()
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
        (List<Shop> Shops, int TotalPriceBatch)? cheapestBatch = (new() { shop1, shop2 }, 6855);

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

    [TestMethod]
    public void MethodCheapestBatchTestTwo()
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

        Dictionary<int, int> batchOfProducts = new() { { 1, 100 }, { 2, 700 }, { 3, 300 } };
        (HashSet<Shop> Shops, int TotalPriceBatch)? cheapestBatch = null;

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

    [TestMethod]
    public void MethodCheapestBatchTestThree()
    {
        //Arrange
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20");
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");
        ShopsManager shopsManager = new ShopsManager(new() { shop1, shop2, shop3 });

        Dictionary<int, int> batchOfProducts = new() { { 5, 100 }, { 2, 700 }, { 1, 300 } };
        (HashSet<Shop> Shops, int TotalPriceBatch)? cheapestBatch = null;

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

    [TestMethod]
    public void MethodCheapestBatchTestFour()
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
           (new Product(1, "ХЛЕБ"), 35, 40),
           (new Product(2, "МОЛОКО"), 25, 95),
           (new Product(3, "РИС"), 30, 100),
           (new Product(4, "МАСЛО"), 35, 120),
           (new Product(5, "МЯСО"), 25, 550),
           (new Product(6, "РЫБА"), 40, 400),
           (new Product(7, "ЯЙЦА"), 50, 140),
           (new Product(8, "САХАР"), 80, 90),
           (new Product(9, "СОЛЬ"), 30, 20),
           (new Product(10, "КАРТОФЕЛЬ"), 170, 45)
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

        Dictionary<int, int> batchOfProducts = new() { { 1, 10 }, { 2, 7 }, { 3, 3 } };
        (HashSet<Shop> Shops, int TotalPriceBatch)? cheapestBatch = (new() { shop2 }, 1365);

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

    [TestMethod]
    public void MethodCheapestBatchTestFive()
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

        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");
        ShopsManager shopsManager = new ShopsManager(new() { shop1, shop2, shop3 });

        Dictionary<int, int> batchOfProducts = new() { { 1, 10 }, { 2, 7 }, { 3, 3 }, { 4, 3 }, { 5, 9 }, { 6, 1 }, { 7, 2 }, { 8, 4 }, { 9, 6 }, { 10, 20 } };
        (HashSet<Shop> Shops, int TotalPriceBatch)? cheapestBatch = (new() { shop1 }, 6855);

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

    [TestMethod]
    public void MethodCheapestBatchTestSix()
    {
        //Arrange
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20",
            (new Product(1, "ХЛЕБ"), 0, 45),
            (new Product(2, "МОЛОКО"), 0, 85),
            (new Product(3, "РИС"), 0, 120),
            (new Product(4, "МАСЛО"), 0, 150),
            (new Product(5, "МЯСО"), 0, 400),
            (new Product(6, "РЫБА"), 0, 300),
            (new Product(7, "ЯЙЦА"), 0, 90),
            (new Product(8, "САХАР"), 0, 60),
            (new Product(9, "СОЛЬ"), 0, 30),
            (new Product(10, "КАРТОФЕЛЬ"), 0, 25)
        );

        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50",
           (new Product(1, "ХЛЕБ"), 0, 40),
           (new Product(2, "МОЛОКО"), 0, 95),
           (new Product(3, "РИС"), 0, 100),
           (new Product(4, "МАСЛО"), 0, 120),
           (new Product(5, "МЯСО"), 0, 550),
           (new Product(6, "РЫБА"), 0, 400),
           (new Product(7, "ЯЙЦА"), 0, 140),
           (new Product(8, "САХАР"), 0, 90),
           (new Product(9, "СОЛЬ"), 0, 20),
           (new Product(10, "КАРТОФЕЛЬ"), 0, 45)
        );

        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40",
           (new Product(1, "ХЛЕБ"), 0, 50),
           (new Product(2, "МОЛОКО"), 0, 95),
           (new Product(3, "РИС"), 0, 90),
           (new Product(4, "МАСЛО"), 0, 130),
           (new Product(5, "МЯСО"), 0, 550),
           (new Product(6, "РЫБА"), 0, 470),
           (new Product(7, "ЯЙЦА"), 0, 100),
           (new Product(8, "САХАР"), 0, 20),
           (new Product(9, "СОЛЬ"), 0, 35),
           (new Product(10, "КАРТОФЕЛЬ"), 0, 55)
        );
        ShopsManager shopsManager = new ShopsManager(new() { shop1, shop2, shop3 });

        Dictionary<int, int> batchOfProducts = new() { { 1, 10 }, { 2, 7 }, { 3, 3 } };
        (HashSet<Shop> Shops, int TotalPriceBatch)? cheapestBatch = null;

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
