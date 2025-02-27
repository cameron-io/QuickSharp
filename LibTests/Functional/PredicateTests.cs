namespace LibTests.Functional;

[TestClass]
public class Predicates
{
    [TestMethod]
    public void FilteringTest()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Assert.IsTrue(evenNumbers.SequenceEqual([2, 4, 6]));
    }

    [TestMethod]
    public void MapTest()
    {
        List<int> numbers = [1, 2, 3, 4];
        var squaredNumbers = numbers.Select(n => n * n);

        Assert.IsTrue(squaredNumbers.SequenceEqual([1, 4, 9, 16]));
    }

    [TestMethod]
    public void SortingTest()
    {
        List<string> names = ["Charlie", "Alice", "Bob"];
        var sortedNames = names.OrderBy(name => name);

        Assert.IsTrue(sortedNames.SequenceEqual(["Alice", "Bob", "Charlie"]));
    }
}
