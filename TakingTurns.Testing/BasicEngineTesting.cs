namespace TakingTurns.Testing;

[TestClass]
public class BasicEngineTesting
{
    [TestMethod]
    public void Should_Initialize()
    {
        Engine testEngine = new();

        Assert.IsNotNull(testEngine);
        Assert.IsTrue(testEngine.Units.Count == 0);
    }

    [TestMethod]
    public void Should_Add()
    {
        Engine testEngine = new();
        Unit testUnit = new("Example", 100);

        testEngine.Add(testUnit);

        Assert.IsNotNull(testEngine);
        Assert.IsTrue(testEngine.Units.Count == 1);
    }

    [TestMethod]
    public void Should_Destroy()
    {
        Engine testEngine = new();
        Unit testUnit = new("Example", 100);

        testEngine.Add(testUnit);
        testEngine.Destroy(testUnit);

        Assert.IsNotNull(testEngine);
        Assert.IsTrue(testEngine.Units.Count == 0);
    }

    [TestMethod]
    public void Should_Modify_ByName()
    {
        Engine testEngine = new();
        Unit testUnit = new("Example", 100);
        Unit testUnitSimilar = new("Example", 80);

        testEngine.Add(testUnit);
        testEngine.Modify(testUnitSimilar);

        Assert.IsNotNull(testEngine);
        Assert.IsTrue(testEngine.Units[0].Speed == 80);
    }

    [TestMethod]
    public void Should_Modify_ByDirectEdit()
    {
        Engine testEngine = new();
        Unit testUnit = new("Example", 100);

        testEngine.Add(testUnit);
        testUnit.Speed = 80;

        Assert.IsNotNull(testEngine);
        Assert.IsTrue(testEngine.Units[0].Speed == 80);
    }
}