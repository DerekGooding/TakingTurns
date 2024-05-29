namespace TakingTurns.WPF.ViewModel.Commands;

public class AddUnitCommand(MainVM mainVM) : CommandBase
{
    public override void Execute(object? parameter) => mainVM.AddUnit();
}
