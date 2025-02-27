using Lib.Singletons;

namespace LibTests.Singletons;

[TestClass]
public class ThreadSafeSingletonTests
{
    [TestMethod]
    public void TestMethod1()
    {
        ThreadSafeSingleton singleton1 = ThreadSafeSingleton.Instance;
        ThreadSafeSingleton singleton2 = ThreadSafeSingleton.Instance;

        // Verify that both variables reference the same instance.
        if (singleton1 == singleton2)
        {
            Console.WriteLine("Both instances are the same.");
        }

        singleton1.IncrementCount();
        singleton1.IncrementCount();
        singleton1.IncrementCount();

        Assert.AreEqual(3, singleton1.Count);
        Assert.AreEqual(3, singleton2.Count);
    }
}
