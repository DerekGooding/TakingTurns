namespace TakingTurns.WPF.ViewModel.Commands;

public class DestroyUnitCommand(MainVM mainVM) : CommandBase
{
    public override void Execute(object? parameter) => mainVM.DestroyUnit();
}
