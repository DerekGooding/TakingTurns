
using System.Collections.ObjectModel;
using TakingTurns.WPF.ViewModel.Commands;

namespace TakingTurns.WPF.ViewModel;

public class MainVM : ViewModelBase
{

    private string _nameField = string.Empty;
    public string NameField
    {
        get => _nameField;
        set => SetProperty(ref _nameField, value);
    }

    private int _speedField = 0;
    public int SpeedField
    {
        get => _speedField;
        set => SetProperty(ref _speedField, value);
    }

    public ObservableCollection<string> Units = [];
    public ObservableCollection<string> Simulation = [];

    private readonly Engine _engine = new();

    #region Commands
    public AddUnitCommand AddUnitCommand { get; set; }
    public DestroyUnitCommand DestroyUnitCommand { get; set; }
    public ModifyUnitCommand ModifyUnitCommand { get; set; }
    public SetSimulationLengthCommand SetSimulationLengthCommand { get; set; }
    public StepCommand StepCommand { get; set; }
    #endregion

    public MainVM()
    {
        AddUnitCommand = new(this);
        DestroyUnitCommand = new(this);
        ModifyUnitCommand = new(this);
        SetSimulationLengthCommand = new(this);
        StepCommand = new(this);
    }

    #region Command Methods
    internal void AddUnit()
    {
        throw new NotImplementedException();
    }

    internal void DestroyUnit()
    {
        throw new NotImplementedException();
    }

    internal void ModifyUnit()
    {
        throw new NotImplementedException();
    }

    internal void SetSimulationLength()
    {
        throw new NotImplementedException();
    }

    internal void Step()
    {
        throw new NotImplementedException();
    }
    #endregion
}
