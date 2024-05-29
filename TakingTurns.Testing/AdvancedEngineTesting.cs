namespace TakingTurns.Testing;

[TestClass]
public class AdvancedEngineTesting
{
    [TestMethod]
    public void Should_Step()
    {
        Engine testEngine = new();
        Unit normal = new("Normal", 100);
        Unit fast = new("Fast", 120);

        testEngine.Add(normal);
        testEngine.Add(fast);

        Unit first = testEngine.Step();
        Unit second = testEngine.Step();


        Assert.AreEqual(first.Name, fast.Name);
        Assert.AreEqual(second.Name, normal.Name);
    }

    [TestMethod]
    public void Should_MatchSimulation_2Units()
    {
        const int simulationLength = 10;
        Engine testEngine = new();
        Unit normal = new("Normal", 100);
        Unit fast = new("Fast", 120);

        testEngine.Add(normal);
        testEngine.Add(fast);

        List<Unit> simulationResults = testEngine.Simulate(simulationLength);

        List<Unit> actualResults = [];
        for (int i = 0; i < simulationLength; i++)
            actualResults.Add(testEngine.Step());

        for (int i = 0; i < simulationLength; i++)
            Assert.AreEqual(simulationResults[i].Name, actualResults[i].Name);
    }

    [TestMethod]
    public void Should_MatchSimulation_5Units()
    {
        const int simulationLength = 10;
        Engine testEngine = new();
        Unit normal = new("Normal", 100);
        Unit fast = new("Fast", 120);
        Unit slow = new("Slow", 50);
        Unit normal_2 = new("Normal_2", 100);
        Unit slow_2 = new("Slow_2", 75);

        testEngine.Add(normal);
        testEngine.Add(fast);
        testEngine.Add(slow);
        testEngine.Add(normal_2);
        testEngine.Add(slow_2);

        List<Unit> simulationResults = testEngine.Simulate(simulationLength);

        List<Unit> actualResults = [];
        for (int i = 0; i < simulationLength; i++)
            actualResults.Add(testEngine.Step());

        for (int i = 0; i < simulationLength; i++)
            Assert.AreEqual(simulationResults[i].Name, actualResults[i].Name);
    }

    [TestMethod]
    public void Should_MatchSimulation_10Units_Randomized()
    {
        const int simulationLength = 20;
        Engine testEngine = new();
        for (int i = 0;i < 10; i++)
        {
            Unit testUnit = new($"Name_{i}", i * Random.Shared.Next(70, 200));
            testEngine.Add(testUnit);
        }

        List<Unit> simulationResults = testEngine.Simulate(simulationLength);

        List<Unit> actualResults = [];
        for (int i = 0; i < simulationLength; i++)
            actualResults.Add(testEngine.Step());

        for (int i = 0; i < simulationLength; i++)
            Assert.AreEqual(simulationResults[i].Name, actualResults[i].Name);
    }
}