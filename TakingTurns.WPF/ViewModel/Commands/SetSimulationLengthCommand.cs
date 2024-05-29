namespace TakingTurns.WPF.ViewModel.Commands;

public class SetSimulationLengthCommand(MainVM mainVM) : CommandBase
{
    public override void Execute(object? parameter) => mainVM.SetSimulationLength();
}
