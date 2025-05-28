namespace laba7;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(0);
        int fuelLevel;
        do
        {
            Console.WriteLine("Введите кол-во бензина: ");
            fuelLevel = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
        while (fuelLevel == 0);

        bool fuelAmount = car.Refuel(fuelLevel);

        car.Drive();
    }
}