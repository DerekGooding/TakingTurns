using TakingTurns.WPF.ViewModel;

namespace TakingTurns.WPF.View;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainVM();
    }

    private void About_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show($"{Application.Current.MainWindow.Title}\n" +
                            "Created by: Derek Gooding\n" +
                            "©2024\n" +
                            "Libertas Infinitum");

    private void Exit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
}