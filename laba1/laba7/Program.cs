namespace laba7;

class Program
{
    static void Main(string[] args)
    {
        int fuelLevel;
        do
        {
            Console.WriteLine("Введите кол-во бензина: ");
            fuelLevel = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
        while (fuelLevel <= 0);
        Car car = new Car(fuelLevel);
        bool fuelAmount = car.Refuel(fuelLevel);

        car.Drive();
    }
}