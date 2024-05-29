namespace TakingTurns.WPF.ViewModel.Commands;

public class ModifyUnitCommand(MainVM mainVM) : CommandBase
{
    public override void Execute(object? parameter) => mainVM.ModifyUnit();
}
