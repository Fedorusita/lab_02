using System;

class Vehicle
{
    private double[] coordinates = new double[2];
    private int price, speed, year;

    public Vehicle(double[] coordinates, int price, int speed, int year)
    {
        this.coordinates = coordinates;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void Info()
    {
        Console.WriteLine($"Coordinates: ({coordinates[0]}, {coordinates[1]})");
        Console.WriteLine($"Price: {price}$");
        Console.WriteLine($"Speed: {speed} km/h");
        Console.WriteLine($"Year of manufacture: {year}");
    }
}

class Plane : Vehicle
{
    private double altitude;
    private int passengers;

    public Plane(double[] coordinates, int price, int speed, int year, double altitude, int passengers)
        : base(coordinates, price, speed, year)
    {
        this.altitude = altitude;
        this.passengers = passengers;
    }

    public new void Info()
    {
        base.Info();
        Console.WriteLine($"Altitude: {altitude} m");
        Console.WriteLine($"Number of passengers: {passengers}");
    }
}

class Car : Vehicle
{
    public Car(double[] coordinates, int price, int speed, int year)
        : base(coordinates, price, speed, year)
    {
    }
}

class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(double[] coordinates, int price, int speed, int year, int passengers, string port)
        : base(coordinates, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public new void Info()
    {
        base.Info();
        Console.WriteLine($"Number of passengers: {passengers}");
        Console.WriteLine($"Port pripiski: {port}");
    }
}

class lab_02_2
{
    static void Main(string[] args)
    {
        Plane plane = new Plane(new double[] { 1, 2 }, 1000000, 900, 2004, 10000, 200);
        Car car = new Car(new double[] { 5, 10 }, 30000, 180, 2022);
        Ship ship = new Ship(new double[] { 30, 40 }, 2000000, 50, 2018, 1500, "Port");

        Console.WriteLine("Информация о самолете:");
        plane.Info();

        Console.WriteLine("\nИнформация о машине:");
        car.Info();

        Console.WriteLine("\nИнформация о судне:");
        ship.Info();
    }
}
