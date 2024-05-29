namespace TakingTurns.WPF.ViewModel.Commands;

public class ModifyUnitCommand(MainVM mainVM) : CommandBase
{
    public override bool CanExecute(object? parameter) => mainVM.FieldsVarified && mainVM.SelectedUnit != null;
    public override void Execute(object? parameter) => mainVM.ModifyUnit();
}
