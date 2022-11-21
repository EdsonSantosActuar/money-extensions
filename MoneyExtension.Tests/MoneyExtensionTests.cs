using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConverDecimalToInt()
    {
        decimal valor = 279.91M;

        var cents = valor.ToCents();

        Assert.AreEqual(27991, cents); 
    }
}