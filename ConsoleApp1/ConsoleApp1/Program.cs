namespace Task
{

    class car
    {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public bool IsElectric { get; set; }
    public int NumDoors { get; set; }
    public string Color { get; set; }
    public double FuelEfficiency { get; set; }

    public void Start()
    {
        Console.WriteLine("Starting the car...");
    }

    public void Accelerate()
    {
        Console.WriteLine("Accelerating the car...");
    }

    public void Brake()
    {
        Console.WriteLine("Braking the car...");
    }

    public double CalculateMpg(double milesDriven, double gallonsUsed)
    {
        return milesDriven / gallonsUsed;
    }

    public void Paint(string color)
    {
        Color = color;
        Console.WriteLine($"The car has been painted {color}.");
    }

    public bool IsAffordable(double budget)
    {
        return Price <= budget;
    }

    }
    internal class Program
    {
    public static void Main(string[] args)
    {
        car c = new car();
        c.Make = "";
        c.Model = "";
        c.Year = 2017;
        c.Price = 500000.0;
        c.IsElectric = false;
        c.NumDoors = 4;
        c.Color = "Black";
        c.FuelEfficiency = 0.0;
    }
    }
}