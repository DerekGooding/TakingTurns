namespace TakingTurns.WPF.ViewModel.Commands;

public class StepCommand(MainVM mainVM) : CommandBase
{
    public override bool CanExecute(object? parameter) => mainVM.Units.Any();
    public override void Execute(object? parameter) => mainVM.Step();
}
