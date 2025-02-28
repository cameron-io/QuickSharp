using Lib.Delegates;

namespace LibTests.Delegates;

[TestClass]
public class IntProcessorTests
{
    [TestMethod]
    public void Test()
    {
        var proc = new IntProcessor();
        IntProcessor.Handler handler;
        handler = proc.ApplyOne;
        handler += proc.ApplyDouble;

        int start = 8;
        proc.Process(start, handler);

        Assert.AreEqual(2, proc.x);
    }
}
