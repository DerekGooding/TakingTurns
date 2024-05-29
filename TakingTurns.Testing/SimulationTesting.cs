namespace TakingTurns.Testing;

[TestClass]
public class SimulationTesting
{
    [TestMethod]
    public void Should_Simulate()
    {
        Engine testEngine = new();
        Unit normal = new("Normal", 100);
        Unit fast = new("Fast", 120);
        const int simulationLength = 10;

        testEngine.Add(normal);
        testEngine.Add(fast);

        List<Unit> simulatedResults = testEngine.Simulate(simulationLength);

        Assert.IsNotNull(simulatedResults);
        Assert.IsTrue(simulatedResults.Count > 0);
    }

    [TestMethod]
    public void Should_SimulateToLength()
    {
        Engine testEngine = new();
        Unit normal = new("Normal", 100);
        Unit fast = new("Fast", 120);
        const int simulationLength = 10;

        testEngine.Add(normal);
        testEngine.Add(fast);

        List<Unit> simulatedResults = testEngine.Simulate(simulationLength);

        Assert.IsNotNull(simulatedResults);
        Assert.IsTrue(simulatedResults.Count == simulationLength);
    }

    [TestMethod]
    public void ShouldNot_RepeatOnStart()
    {
        Engine testEngine = new();
        Unit normal = new("Normal", 100);
        Unit fast = new("Fast", 120);

        testEngine.Add(normal);
        testEngine.Add(fast);

        List<Unit> simulatedResults = testEngine.Simulate(10);

        Assert.AreEqual(simulatedResults[0].Name, fast.Name);
        Assert.AreEqual(simulatedResults[1].Name, normal.Name);
    }

    [TestMethod]
    public void Should_Lap_2digit()
    {
        Engine testEngine = new();
        Unit normal = new("Normal", 10);
        Unit fast = new("Fast", 15);

        testEngine.Add(normal);
        testEngine.Add(fast);

        List<Unit> simulatedResults = testEngine.Simulate(10);

        Assert.AreEqual(simulatedResults[0].Name, fast.Name);
        Assert.AreEqual(simulatedResults[1].Name, normal.Name);
        Assert.AreEqual(simulatedResults[2].Name, fast.Name);
        Assert.AreEqual(simulatedResults[3].Name, normal.Name);
        Assert.AreEqual(simulatedResults[4].Name, fast.Name);
        Assert.AreEqual(simulatedResults[5].Name, fast.Name);
        Assert.AreEqual(simulatedResults[6].Name, normal.Name);
        Assert.AreEqual(simulatedResults[7].Name, fast.Name);
        Assert.AreEqual(simulatedResults[8].Name, normal.Name);
        Assert.AreEqual(simulatedResults[9].Name, fast.Name);
    }

    [TestMethod]
    public void Should_Lap_3digit()
    {
        Engine testEngine = new();
        Unit normal = new("Normal", 10 * 10);
        Unit fast = new("Fast", 15 * 10);

        testEngine.Add(normal);
        testEngine.Add(fast);

        List<Unit> simulatedResults = testEngine.Simulate(10);

        Assert.AreEqual(simulatedResults[0].Name, fast.Name);
        Assert.AreEqual(simulatedResults[1].Name, normal.Name);
        Assert.AreEqual(simulatedResults[2].Name, fast.Name);
        Assert.AreEqual(simulatedResults[3].Name, normal.Name);
        Assert.AreEqual(simulatedResults[4].Name, fast.Name);
        Assert.AreEqual(simulatedResults[5].Name, fast.Name);
        Assert.AreEqual(simulatedResults[6].Name, normal.Name);
        Assert.AreEqual(simulatedResults[7].Name, fast.Name);
        Assert.AreEqual(simulatedResults[8].Name, normal.Name);
        Assert.AreEqual(simulatedResults[9].Name, fast.Name);
    }

    [TestMethod]
    public void Should_Lap_5digit()
    {
        Engine testEngine = new();
        Unit normal = new("Normal", 10 * 10 * 100);
        Unit fast = new("Fast", 15 * 10 * 100);

        testEngine.Add(normal);
        testEngine.Add(fast);

        List<Unit> simulatedResults = testEngine.Simulate(10);

        Assert.AreEqual(simulatedResults[0].Name, fast.Name);
        Assert.AreEqual(simulatedResults[1].Name, normal.Name);
        Assert.AreEqual(simulatedResults[2].Name, fast.Name);
        Assert.AreEqual(simulatedResults[3].Name, normal.Name);
        Assert.AreEqual(simulatedResults[4].Name, fast.Name);
        Assert.AreEqual(simulatedResults[5].Name, fast.Name);
        Assert.AreEqual(simulatedResults[6].Name, normal.Name);
        Assert.AreEqual(simulatedResults[7].Name, fast.Name);
        Assert.AreEqual(simulatedResults[8].Name, normal.Name);
        Assert.AreEqual(simulatedResults[9].Name, fast.Name);
    }

    [TestMethod]
    public void Should_Lap_8digit()
    {
        Engine testEngine = new();
        Unit normal = new("Normal", 10 * 100 * 100 * 100);
        Unit fast = new("Fast", 15 * 100 * 100 * 100);

        testEngine.Add(normal);
        testEngine.Add(fast);

        List<Unit> simulatedResults = testEngine.Simulate(10);

        Assert.AreEqual(simulatedResults[0].Name, fast.Name);
        Assert.AreEqual(simulatedResults[1].Name, normal.Name);
        Assert.AreEqual(simulatedResults[2].Name, fast.Name);
        Assert.AreEqual(simulatedResults[3].Name, normal.Name);
        Assert.AreEqual(simulatedResults[4].Name, fast.Name);
        Assert.AreEqual(simulatedResults[5].Name, fast.Name);
        Assert.AreEqual(simulatedResults[6].Name, normal.Name);
        Assert.AreEqual(simulatedResults[7].Name, fast.Name);
        Assert.AreEqual(simulatedResults[8].Name, normal.Name);
        Assert.AreEqual(simulatedResults[9].Name, fast.Name);
    }
}