using WorkShop;
using System.Text.Json;

namespace TestWorkShopSearchCheapestShops;

[TestClass]
public class TestShopSearchCheapestShops
{
    [TestMethod]
    public void SearchCheapestShopsTestOne()
    {
        //Arrange
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20",
            (new Product(1, "ХЛЕБ"), 80, 45),
            (new Product(2, "МОЛОКО"), 30, 85),
            (new Product(3, "РИС"), 40, 120),
            (new Product(4, "МАСЛО"), 25, 150),
            (new Product(5, "МЯСО"), 15, 550),
            (new Product(6, "РЫБА"), 20, 390),
            (new Product(7, "ЯЙЦА"), 100, 90),
            (new Product(8, "САХАР"), 60, 60),
            (new Product(9, "СОЛЬ"), 50, 30),
            (new Product(10, "КАРТОФЕЛЬ"), 200, 25)
        );
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50",
            (new Product(1, "ХЛЕБ"), 35, 45),
            (new Product(2, "МОЛОКО"), 25, 95),
            (new Product(3, "РИС"), 30, 100),
            (new Product(4, "МАСЛО"), 35, 120),
            (new Product(5, "МЯСО"), 25, 555),
            (new Product(6, "РЫБА"), 40, 400),
            (new Product(7, "ЯЙЦА"), 50, 140),
            (new Product(8, "САХАР"), 80, 90),
            (new Product(9, "СОЛЬ"), 30, 20),
            (new Product(10, "КАРТОФЕЛЬ"), 170, 45)
        );
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40",
            (new Product(1, "ХЛЕБ"), 60, 45),
            (new Product(2, "МОЛОКО"), 40, 95),
            (new Product(3, "РИС"), 50, 90),
            (new Product(4, "МАСЛО"), 60, 130),
            (new Product(5, "МЯСО"), 40, 550),
            (new Product(6, "РЫБА"), 60, 470),
            (new Product(7, "ЯЙЦА"), 40, 100),
            (new Product(8, "САХАР"), 100, 20),
            (new Product(9, "СОЛЬ"), 40, 35),
            (new Product(10, "КАРТОФЕЛЬ"), 240, 15)
        );
        ShopsManager shopsManager = new ShopsManager(new() { shop1, shop2, shop3 });
        (HashSet<Shop> Shop, Product Product)? cheapestProduct = (new() { shop1, shop3 }, new Product(5, "МЯСО"));

        //Act
        var result = shopsManager.SearchCheapestShops(5);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string expected = JsonSerializer.Serialize(cheapestProduct, options);
        string actual = JsonSerializer.Serialize(result, options);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SearchCheapestShopsTestTwo()
    {
        //Arrange
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20",
            (new Product(1, "ХЛЕБ"), 0, 45),
            (new Product(2, "МОЛОКО"), 0, 85),
            (new Product(3, "РИС"), 0, 120),
            (new Product(4, "МАСЛО"), 0, 150),
            (new Product(5, "МЯСО"), 0, 550),
            (new Product(6, "РЫБА"), 0, 390),
            (new Product(7, "ЯЙЦА"), 0, 90),
            (new Product(8, "САХАР"), 0, 60),
            (new Product(9, "СОЛЬ"), 0, 30),
            (new Product(10, "КАРТОФЕЛЬ"), 0, 25)
        );
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50",
            (new Product(1, "ХЛЕБ"), 0, 45),
            (new Product(2, "МОЛОКО"), 0, 95),
            (new Product(3, "РИС"), 0, 100),
            (new Product(4, "МАСЛО"), 0, 120),
            (new Product(5, "МЯСО"), 0, 555),
            (new Product(6, "РЫБА"), 0, 400),
            (new Product(7, "ЯЙЦА"), 0, 140),
            (new Product(8, "САХАР"), 0, 90),
            (new Product(9, "СОЛЬ"), 0, 20),
            (new Product(10, "КАРТОФЕЛЬ"), 0, 45)
        );
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40",
            (new Product(1, "ХЛЕБ"), 0, 45),
            (new Product(2, "МОЛОКО"), 0, 95),
            (new Product(3, "РИС"), 0, 90),
            (new Product(4, "МАСЛО"), 0, 130),
            (new Product(5, "МЯСО"), 0, 550),
            (new Product(6, "РЫБА"), 0, 470),
            (new Product(7, "ЯЙЦА"), 0, 100),
            (new Product(8, "САХАР"), 0, 20),
            (new Product(9, "СОЛЬ"), 0, 35),
            (new Product(10, "КАРТОФЕЛЬ"), 0, 15)
        );
        ShopsManager shopsManager = new ShopsManager(new() { shop1, shop2, shop3 });
        (HashSet<Shop> Shop, Product Product)? cheapestProduct = (new() { shop3 }, new Product(10, "КАРТОФЕЛЬ"));

        //Act
        var result = shopsManager.SearchCheapestShops(10);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string expected = JsonSerializer.Serialize(cheapestProduct, options);
        string actual = JsonSerializer.Serialize(result, options);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SearchCheapestShopsTestThree()
    {
        //Arrange
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20",
            (new Product(1, "ХЛЕБ"), 80, 45),
            (new Product(2, "МОЛОКО"), 30, 85),
            (new Product(3, "РИС"), 40, 120),
            (new Product(4, "МАСЛО"), 25, 150),
            (new Product(5, "МЯСО"), 15, 550),
            (new Product(6, "РЫБА"), 20, 390),
            (new Product(7, "ЯЙЦА"), 100, 90),
            (new Product(8, "САХАР"), 60, 60),
            (new Product(9, "СОЛЬ"), 50, 30),
            (new Product(10, "КАРТОФЕЛЬ"), 200, 25)
        );
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");
        ShopsManager shopsManager = new ShopsManager(new() { shop1, shop2, shop3 });
        (HashSet<Shop> Shop, Product Product)? cheapestProduct = (new() { shop1 }, new Product(4, "МАСЛО"));

        //Act
        var result = shopsManager.SearchCheapestShops(4);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string expected = JsonSerializer.Serialize(cheapestProduct, options);
        string actual = JsonSerializer.Serialize(result, options);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SearchCheapestShopsTestFour()
    {
        //Arrange
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20");
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");
        ShopsManager shopsManager = new ShopsManager(new() { shop1, shop2, shop3 });
        (HashSet<Shop> Shop, Product Product)? cheapestProduct = null;

        //Act
        var result = shopsManager.SearchCheapestShops(5);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string expected = JsonSerializer.Serialize(cheapestProduct, options);
        string actual = JsonSerializer.Serialize(result, options);

        //Assert
        Assert.AreEqual(expected, actual);
    }
}

