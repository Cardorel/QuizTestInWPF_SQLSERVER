using ProjectKoursova.ViewModels;
using ProjectKoursova.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectKoursova
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = new MainView() { DataContext = new MainViewModel(new RegistrationViewModel() ) };
            MainWindow.Show();
        }
    }
}
