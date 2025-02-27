namespace Lib.Threading;

using System;

public class ProcThreadContainer
{
    // This thread procedure performs the task.
    public static void ThreadProc(Object? stateInfo)
    {
        // No state object was passed to QueueUserWorkItem, so stateInfo is null.
        Console.WriteLine("Hello from the thread pool.");
    }
}
