namespace Lib.Generics;

public class GenericComparables
{
    // Can use Generic Method inside non-generic class, otherwise:
    // - class GenericComparables<T> where T : IComparable
    public static T Max<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    // Generic constraints may be of types: struct, class, new()
    // - new() is required to provide a default constructor
    //   for scenarios where T must be constructed.
    //   > var obj = new T();
}
