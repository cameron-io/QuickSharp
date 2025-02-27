namespace Lib.Builder;

public class AircraftBuilder : IAircraftBuilder
{
    private readonly Aircraft _aircraft = new();

    public AircraftBuilder()
    {
    }

    public Aircraft Build()
    {
        return _aircraft;
    }

    public IAircraftBuilder SetEngine(string engine)
    {
        _aircraft.Engine = engine;
        return this;
    }

    public IAircraftBuilder SetFuselage(string fuselage)
    {
        _aircraft.Fuselage = fuselage;
        return this;
    }

    public IAircraftBuilder SetLandingGear(string langingGear)
    {
        _aircraft.LandingGear = langingGear;
        return this;
    }

    public IAircraftBuilder SetModelName(string modelName)
    {
        _aircraft.ModelName = modelName;
        return this;
    }

    public IAircraftBuilder SetWings(string wings)
    {
        _aircraft.Wings = wings;
        return this;
    }
}