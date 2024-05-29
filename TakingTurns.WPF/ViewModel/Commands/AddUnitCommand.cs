namespace TakingTurns.WPF.ViewModel.Commands;

public class AddUnitCommand(MainVM mainVM) : CommandBase
{
    public override bool CanExecute(object? parameter) => mainVM.FieldsVarified;
    public override void Execute(object? parameter) => mainVM.AddUnit();
}
