using Lib.Builder;

namespace LibTests.Builder;

[TestClass]
public class AircraftBuilderTests
{
    [TestMethod]
    public void BuildTest()
    {
        var aircraftBuilder = new AircraftBuilder();
        var aircraft = aircraftBuilder
            .SetModelName("Piper Cub L-4H Grasshopper")
            .SetEngine("65-hp Continental horizontally-opposed flat four engine")
            .SetFuselage("Welded steel frame")
            .SetLandingGear("Fixed, tailwheel")
            .Build();

        Assert.AreEqual("Welded steel frame", aircraft.Fuselage);
    }
}
