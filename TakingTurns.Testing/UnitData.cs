namespace TakingTurns.Testing;

[TestClass]
public class UnitData
{
    [TestMethod]
    public void Should_ToString()
    {
        Unit testUnit = new("Example", 100);

        Assert.AreEqual($"{testUnit}", "Example | 100");
    }

    [TestMethod]
    public void ShouldNot_ToString()
    {
        Unit testUnit = new("Example", 100);

        Assert.AreNotEqual($"{testUnit}", "Example | 80");
    }
}