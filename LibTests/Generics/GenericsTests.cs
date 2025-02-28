using Lib.Generics;

namespace LibTests.Generics;

[TestClass]
public class GenericsTests
{
    [TestMethod]
    public void ListTest()
    {
        var strList = new GenericList<string>();
        var intList = new GenericList<int>();

        strList.Add("hello");
        strList.Add("world");

        Assert.IsTrue(strList[0] == "hello");
        Assert.IsTrue(strList[1] == "world");

        intList.Add(2);
        intList.Add(4);

        Assert.IsTrue(intList[0] == 2);
        Assert.IsTrue(intList[1] == 4);

        Assert.AreEqual(
            4,
            GenericComparables.Max<int>(intList[0], intList[1])
        );
    }
}
