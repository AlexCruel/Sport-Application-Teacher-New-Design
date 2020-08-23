using MaterialDesignThemes.Wpf;
using Sport_Application_Teacher__New_Design_.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sport_Application_Teacher__New_Design_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            App.Current.Properties["frame"] = frame;
            App.Current.Properties["nameText"] = nameText;
            App.Current.Properties["nameNumber"] = nameNumber;
            frame.Content = new AuthPage(MenuBar);
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            namePanel.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            namePanel.Visibility = Visibility.Hidden;
        }

        private void Home_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            frame.Content = new HomePage();
        }

        private void Analysis_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            frame.Content = new AnalysisPage();
        }

        private void GitHub_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AlexCruel/Sport-Application-Teacher-New-Design");
        }

        private void Statistics_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            frame.Content = new StatisticsPage();
        }

        private void Shutdown_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
