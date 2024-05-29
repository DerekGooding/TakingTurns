namespace TakingTurns.WPF.ViewModel.Commands;

public class ResetCommand(MainVM mainVM) : CommandBase
{
    public override void Execute(object? parameter) => mainVM.Reset();
}
