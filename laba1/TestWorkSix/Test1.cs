namespace TestWorkSix;
using WorkSix;

[TestClass]
public class TestWorkSix
{
    [TestMethod]
    public void TestWorkSixMethod()
    {
        //Arrange
        Location location1 = new Location(5.5, 9.1);
        RectangleShape rectangleShape = new RectangleShape(location1);
       

        //Act
        Location location2 = new Location(6, 10);
        rectangleShape.location=location2;


        //Assert
        Assert.AreEqual(6,rectangleShape.location.X);
        Assert.AreEqual(10,rectangleShape.location.Y);
        Assert.AreEqual(32, rectangleShape.Perimeter());
        Assert.AreEqual(60, rectangleShape.Area());
    }
}
