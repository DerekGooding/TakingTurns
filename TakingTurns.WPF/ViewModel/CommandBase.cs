﻿using System.Windows.Input;

namespace TakingTurns.WPF.ViewModel;

public class CommandBase : ICommand
{
    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public virtual bool CanExecute(object? parameter) => true;

    public virtual void Execute(object? parameter) => throw new NotImplementedException();
}