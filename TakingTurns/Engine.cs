namespace TakingTurns;

public class Engine()
{
    private readonly List<(Unit unit, int time)> _tracker = [];
    private int Tick => _tracker.Max(x => x.unit.Speed);
    public List<Unit> Units => _tracker.ConvertAll(x => x.unit);

    public List<Unit> Simulate(int length)
    {
        if (_tracker.Count == 0)
            return [];
        List<Unit> result = [];

        List<(Unit unit, int time)> simulation = [.. _tracker];
        int tick = Tick;
        for (int i = 0; i < length; i++)
        {
            result.Add(Step(simulation, tick));
        }

        return result;
    }

    public Unit Step() => Step(_tracker);

    public void Add(Unit unit) => _tracker.Add(new(unit, 0));

    public void Destroy(Unit unit) => _tracker.Remove(_tracker.Find(x => x.unit.Name == unit.Name));

    public void Modify(Unit unit) => _tracker.Find(x => x.unit.Name == unit.Name).unit.Speed = unit.Speed;

    private Unit Step(List<(Unit unit, int time)> simulation) => Step(simulation, Tick);

    private static Unit Step(List<(Unit unit, int time)> simulation, int tick)
    {
        if (simulation.All(x => x.time < tick))
        {
            for (int i = 0; i < simulation.Count; i++)
            {
                (Unit unit, int time) = simulation[i];
                simulation[i] = (unit, time + unit.Speed);
            }
        }

        (Unit unit, int time) maxTimeUnit = simulation.OrderByDescending(x => x.time).First();
        simulation[simulation.IndexOf(maxTimeUnit)] = (maxTimeUnit.unit, maxTimeUnit.time - tick);
        return maxTimeUnit.unit;
    }
}