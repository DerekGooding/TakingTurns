using System.Globalization;
using System.Windows.Data;

namespace TakingTurns.WPF.View.Converters;

public class StringToIntConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => $"{value}";

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) 
        => int.TryParse(value as string, out int result) ? result : 0;
}
