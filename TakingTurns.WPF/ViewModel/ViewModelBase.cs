﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TakingTurns.WPF.ViewModel;

public class ViewModelBase : INotifyPropertyChanged
{
    protected readonly bool _isLive = !DesignerProperties.GetIsInDesignMode(new DependencyObject());

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void SetProperty<T>(ref T reference, T value, [CallerMemberName] string propertyName = "")
    {
        if (Equals(reference, value)) return;
        reference = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}