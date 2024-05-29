namespace TakingTurns;

public static class Program
{
    private static bool _isExiting;
    private static Engine _engine = new();
    private static int _simulationRange = 20;

    private static void Main()
    {
        while (!_isExiting)
        {
            HandlePainting();
            HandleInput(Console.ReadLine() ?? string.Empty);
        }
    }

    private static void HandlePainting()
    {
        Console.Clear();
        PrintCommands();
        (int left, int top) = Console.GetCursorPosition();
        PrintTurnOrder(50, 0);
        PrintUnitList(100, 0);

        Console.SetCursorPosition(left, top);
    }

    private static void PrintCommands()
    {
        Console.WriteLine("X => Exit");
        Console.WriteLine("S => Step");
        Console.WriteLine("R => Reset");
        Console.WriteLine("{range} => set simulation");
        Console.WriteLine("{name} {speed} => create");
    }

    private static void PrintTurnOrder(int x, int y)
    {
        Console.SetCursorPosition(x, y++);
        Console.Write("**Turn Order**");
        List<Unit> orderedUnits = _engine.Simulate(_simulationRange);
        orderedUnits.ForEach(unit =>
        {
            if (y >= Console.BufferHeight)
                return;
            Console.SetCursorPosition(x, y++);
            Console.Write(unit.Name);
        });
    }

    private static void PrintUnitList(int x, int y)
    {
        Console.SetCursorPosition(x, y++);
        Console.Write("**Unit List**");
        _engine.Units.ForEach(unit =>
        {
            Console.SetCursorPosition(x, y++);
            Console.Write(unit);
        });
    }

    private static void HandleInput(string input)
    {
        string[] inputs = input.ToUpper().Split(' ');

        switch (inputs[0])
        {
            case "X":
                _isExiting = true;
                break;

            case "S":
                _engine.Step();
                break;

            case "R":
                _engine = new();
                break;

            default:
                HandleOther(inputs);
                break;
        }
    }

    private static void HandleOther(string[] inputs)
    {
        if (int.TryParse(inputs[0], out int range))
            ChangeSimulationRange(range);
        if (inputs.Length >= 2 && int.TryParse(inputs[^1], out int speed) && speed > 0)
            CreateUnit(string.Join(' ', inputs[0..^1]), speed);
    }

    private static void ChangeSimulationRange(int range) => _simulationRange = Math.Clamp(range, 1, 200);

    private static void CreateUnit(string name, int speed) => _engine.Add(new Unit(name, speed));
}