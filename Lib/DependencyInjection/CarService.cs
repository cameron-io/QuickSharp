using System;

namespace Lib.DependencyInjection;

public class CarService
{
    private static CarService? _instance = null;
    public string Name { get; set; }
    public int Count { get; set; }

    private CarService()
    {
        Name = "Car Service";
        Count = 0;
    }

    public static CarService GetInstance()
    {
        _instance ??= new CarService();
        return _instance;
    }

    public void RegisterCustomer()
    {
        Count += 1;
    }
}