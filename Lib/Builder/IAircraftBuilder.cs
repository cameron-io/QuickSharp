namespace Lib.Builder;

public interface IAircraftBuilder
{
    IAircraftBuilder SetModelName(string modelName);
    IAircraftBuilder SetEngine(string engine);
    IAircraftBuilder SetWings(string wings);
    IAircraftBuilder SetFuselage(string fuselage);
    IAircraftBuilder SetLandingGear(string langingGear);
    Aircraft Build();
}