namespace TakingTurns.WPF.ViewModel.Commands;

public class DestroyUnitCommand(MainVM mainVM) : CommandBase
{
    public override bool CanExecute(object? parameter) => mainVM.SelectedUnit != null;
    public override void Execute(object? parameter) => mainVM.DestroyUnit();
}
