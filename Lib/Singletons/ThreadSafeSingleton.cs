namespace Lib.Singletons;

public class ThreadSafeSingleton
{
    // Private static instance variable to hold the singleton instance.
    private static ThreadSafeSingleton? instance = null;

    // Private static readonly object for thread safety.
    private static readonly Lock lockObject = new();

    public int Count { get; set; } = 0;

    // Private constructor to prevent external instantiation.
    private ThreadSafeSingleton()
    {
        // Initialization code here (if needed).
    }

    // Public static method to access the singleton instance.
    public static ThreadSafeSingleton Instance
    {
        get
        {
            // Double-checked locking for thread safety.
            if (instance == null)
            {
                lock (lockObject)
                {
                    instance ??= new ThreadSafeSingleton();
                }
            }
            return instance;
        }
    }

    // Example method of the singleton class.
    public void IncrementCount()
    {
        Count++;
    }
}
