namespace Lib.Generics;

// The following list is restricted by int type as its store

class IntList
{
    public void Add(int number)
    {
        throw new NotImplementedException();
    }
    public int this[int index]
    {
        get { throw new NotImplementedException(); }
    }
}

// We may upcast this to object

class ObjectList
{
    public void Add(object word)
    {
        throw new NotImplementedException();
    }
    public int this[int index]
    {
        get { throw new NotImplementedException(); }
    }
}

// However, this will encur a performance penalty
// Unboxing is required each time the actual values are accessed.

// This is solved by a generic class
public class GenericList<T>
{
    public List<T> store = [];
    public void Add(T value)
    {
        store.Add(value);
    }

    public T this[int index]
    {
        get { return store[index]; }
    }
}
