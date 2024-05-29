
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

    private int _speedField;
    public int SpeedField
    {
        get => _speedField;
        set => SetProperty(ref _speedField, value);
    }

    private string? _selectedUnit;
    public string? SelectedUnit
    {
        get => _selectedUnit;
        set => SetProperty(ref _selectedUnit, value);
    }

    public bool FieldsVarified => SpeedField > 0 && !string.IsNullOrEmpty(NameField);

    public ObservableCollection<string> Units { get; set; } = [];
    public ObservableCollection<string> Simulation { get; set; } = [];

    private Engine _engine = new();

    private int _simulationLength = 10;

    #region Commands
    public AddUnitCommand AddUnitCommand { get; set; }
    public DestroyUnitCommand DestroyUnitCommand { get; set; }
    public ModifyUnitCommand ModifyUnitCommand { get; set; }
    public SetSimulationLengthCommand SetSimulationLengthCommand { get; set; }
    public StepCommand StepCommand { get; set; }
    public ResetCommand ResetCommand { get; set; }
    #endregion

    public MainVM()
    {
        AddUnitCommand = new(this);
        DestroyUnitCommand = new(this);
        ModifyUnitCommand = new(this);
        SetSimulationLengthCommand = new(this);
        StepCommand = new(this);
        ResetCommand = new(this);
    }

    private void RefreshCollections()
    {
        Units.Clear();
        _engine.Units.ForEach(x => Units.Add($"{x}"));
        Simulation.Clear();
        int count = 1;
        _engine.Simulate(_simulationLength).ForEach(x => Simulation.Add($"{count++:00}. {x.Name}"));
    }

    #region Command Methods
    internal void AddUnit()
    {
        _engine.Add(new(NameField, _speedField));
        RefreshCollections();
    }

    internal void DestroyUnit()
    {
        Unit? target = _engine.Units.Find(x => $"{x}" == SelectedUnit);
        if (target == null)
            return;
        _engine.Destroy(target);
        RefreshCollections();
    }

    internal void ModifyUnit()
    {
        Unit? target = _engine.Units.Find(x => $"{x}" == SelectedUnit);
        if (target == null)
            return;
        target.Speed = SpeedField;
        RefreshCollections();
    }

    internal void SetSimulationLength()
    {
        _simulationLength = _simulationLength == 10 ? 30 : 10;
        RefreshCollections();
    }

    internal void Step()
    {
        _engine.Step();
        RefreshCollections();
    }

    internal void Reset()
    {
        _engine = new();
        RefreshCollections();
    }
    #endregion
}
