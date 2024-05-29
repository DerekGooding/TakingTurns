namespace TakingTurns.WPF.ViewModel.Commands;

public class StepCommand(MainVM mainVM) : CommandBase
{
    public override void Execute(object? parameter) => mainVM.Step();
}
