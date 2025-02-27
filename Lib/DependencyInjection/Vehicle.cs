using System;

namespace Lib.DependencyInjection;

public class Vehicle
{
    private readonly IService _service;

    /*
     * Vehicle does not initialize the injected class.
     * This leads to better separation of concerns.
     */
    public Vehicle(IService service)
    {
        service.RegisterCustomer();
        _service = service;
    }

    public IService GetIService()
    {
        return _service;
    }
}
