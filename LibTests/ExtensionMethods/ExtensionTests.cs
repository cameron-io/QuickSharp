using System.Runtime.Intrinsics.X86;
using Lib.ExtensionMethods;

namespace LibTests.ExtensionMethods;

[TestClass]
public class ExtensionTests
{
    [TestMethod]
    public void StringExtensionsTest()
    {
        string s = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
        var newStr = s.Shorten(5);
        Assert.AreEqual("a b c d e", newStr);
    }
}
