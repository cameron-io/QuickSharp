namespace LibTests.Threading;

using Lib.Threading;

[TestClass]
public sealed class ProcThreadContainerTests
{
    [TestMethod]
    public void ThreadQueueTest()
    {
        // Queue the task.
        ThreadPool.QueueUserWorkItem(ProcThreadContainer.ThreadProc);
        Console.WriteLine("Main thread does some work, then sleeps.");
        Thread.Sleep(1000);

        Console.WriteLine("Main thread exits.");
    }
}
