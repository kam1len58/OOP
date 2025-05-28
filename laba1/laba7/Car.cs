namespace laba7;

class Car : IVehiculo
{
    public int FuelLevel { get; set; }

    public Car(int fuelLevel)
    {
        FuelLevel = fuelLevel;
    }

    public void Drive()
    {
        if (FuelLevel > 0)
        {
            Console.WriteLine("Driving");
        }
    }

    public bool Refuel(int fuelLevel)
    {
        FuelLevel++;
        return true;
    }
}
