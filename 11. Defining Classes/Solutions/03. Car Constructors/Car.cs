﻿// ReSharper disable All
namespace CarManufacturer;

class Car
{
    private string make = null!;
    private string model = null!;
    private int year;
    private double fuelQuantity;
    private double fuelConsumption;

    public Car()
    {
        Make = "VW";
        Model = "Golf";
        Year = 2025;
        FuelQuantity = 200;
        FuelConsumption = 10;
    }

    public Car(string make, string model, int year) : this()
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public string Make
    {
        get => make;
        set => make = value;
    }

    public string Model
    {
        get => model;
        set => model = value;
    }
    public int Year
    {
        get => year;
        set => year = value;
    }
    public double FuelQuantity
    {
        get => fuelQuantity;
        set => fuelQuantity = value;
    }

    public double FuelConsumption
    {
        get => fuelConsumption;
        set => fuelConsumption = value;
    }

    public void Drive(double distance)
    {
        if (distance * fuelConsumption <= fuelQuantity) fuelQuantity -= distance * fuelConsumption;
        else Console.WriteLine("Not enough fuel to perform this trip!");
    }

    public string WhoAmI() => $"Make: {Make} \nModel: {Model} \nYear: {Year} \nFuel: {FuelQuantity:F2}";
}
