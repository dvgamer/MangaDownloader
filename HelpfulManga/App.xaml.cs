using System;
using System.IO;
using System.Windows;

namespace HelpfulManga
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private String ApplicationPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\";

        private void App_Startup(object sender, StartupEventArgs e)
        {
            MainWindow AppMain = new MainWindow();
            AppMain.Show();
        }
    }
}
