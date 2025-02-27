using System;

namespace Lib.DependencyInjection;

public class AircraftService
{
    private static AircraftService? _instance = null;
    public string Name { get; set; }
    public int Count { get; set; }

    private AircraftService()
    {
        this.Name = "Aircraft Service";
        this.Count = 0;
    }

    public static AircraftService GetInstance()
    {
        _instance ??= new AircraftService();
        return _instance;
    }

    public void RegisterCustomer()
    {
        this.Count += 1;
    }
}