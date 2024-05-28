namespace TakingTurns;

public class Unit(string name, int speed)
{
    public string Name { get; set; } = name;
    public int Speed { get; set; } = speed;

    public override string ToString() => $"{Name} | {Speed}";
}