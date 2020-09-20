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
using System.Windows.Shapes;

namespace Sport_Application_Teacher__New_Design_.Windows
{
    /// <summary>
    /// Логика взаимодействия для SportEvents.xaml
    /// </summary>
    public partial class SportEvents : Window
    {
        ComboBox groupBox = new ComboBox();

        public SportEvents(string name, ComboBox group)
        {
            InitializeComponent();
            studBlock.Text = name;
            groupBox = group;
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "Мероприятие")
                name.Text = "";
        }

        private void name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
                name.Text = "Мероприятие";
        }

        private void person_GotFocus(object sender, RoutedEventArgs e)
        {
            if (person.Text == "Ответственный")
                person.Text = "";
        }

        private void person_LostFocus(object sender, RoutedEventArgs e)
        {
            if (person.Text == "")
                person.Text = "Ответственный";
        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            ReportSumHoursWindow reportSumHours = new ReportSumHoursWindow(groupBox);
            reportSumHours.Show();
            Close();
        }
    }
}
