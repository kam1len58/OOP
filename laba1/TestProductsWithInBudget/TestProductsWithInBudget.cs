using System.Text.Json;
using WorkShop;

namespace TestProductsWithInBudget;


[TestClass]
public class TestProductsWithInBudget
{
    [TestMethod]
    public void GetProductsWithInBudgetTestOne()
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
        ShopsManager shopManager = new ShopsManager(new() { { 1, shop1 }, { 2, shop2 }, { 3, shop3 } });
        int budget = 1000;
        List<(Shop Shop, Product Product, int NumberOfProducts)> productsWithInBudget = new()
        {
            (shop1,new Product(1, "ХЛЕБ"),22),
            (shop1,new Product(2, "МОЛОКО"),11),
            (shop1,new Product(3, "РИС"), 8),
            (shop1,new Product(4, "МАСЛО"),6),
            (shop1,new Product(5, "МЯСО"),2),
            (shop1,new Product(6, "РЫБА"),3),
            (shop1,new Product(7, "ЯЙЦА"),11),
            (shop1,new Product(8, "САХАР"),16),
            (shop1,new Product(9, "СОЛЬ"),33),
            (shop1,new Product(10, "КАРТОФЕЛЬ"),40)
        };

        //Act
        var result = shopManager.GetProductsWithInBudget(budget, 1);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string expected = JsonSerializer.Serialize(result, options);
        string actual = JsonSerializer.Serialize(productsWithInBudget, options);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetProductsWithInBudgetTestTwo()
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
        ShopsManager shopManager = new ShopsManager(new() { { 1, shop1 }, { 2, shop2 }, { 3, shop3 } });
        int budget = 1000;
        List<(Shop Shop, Product Product, int NumberOfProducts)> productsWithInBudget = new()
        {
            (shop2,new Product(1, "ХЛЕБ"),25),
            (shop2,new Product(2, "МОЛОКО"),10),
            (shop2,new Product(3, "РИС"), 10),
            (shop2,new Product(4, "МАСЛО"),8),
            (shop2,new Product(5, "МЯСО"),1),
            (shop2,new Product(6, "РЫБА"),2),
            (shop2,new Product(7, "ЯЙЦА"),7),
            (shop2,new Product(8, "САХАР"),11),
            (shop2,new Product(9, "СОЛЬ"),50),
            (shop2,new Product(10, "КАРТОФЕЛЬ"),22)
        };

        //Act
        var result = shopManager.GetProductsWithInBudget(budget, 2);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string expected = JsonSerializer.Serialize(result, options);
        string actual = JsonSerializer.Serialize(productsWithInBudget, options);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetProductsWithInBudgetTestThree()
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
        ShopsManager shopManager = new ShopsManager(new() { { 1, shop1 }, { 2, shop2 }, { 3, shop3 } });
        int budget = 1000;
        List<(Shop Shop, Product Product, int NumberOfProducts)>? productsWithInBudget = null;

        //Act
        var result = shopManager.GetProductsWithInBudget(budget, 2);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string expected = JsonSerializer.Serialize(result, options);
        string actual = JsonSerializer.Serialize(productsWithInBudget, options);

        //Assert
        Assert.AreEqual(expected, actual);
    }
}
