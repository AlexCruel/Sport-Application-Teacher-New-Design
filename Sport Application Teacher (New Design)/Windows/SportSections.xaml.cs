using Sport_Application_Teacher__New_Design_.Classes;
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
    /// Логика взаимодействия для SportSections.xaml
    /// </summary>
    public partial class SportSections : Window
    {
        Student student = new Student();
        ComboBox groupBox = new ComboBox();

        public SportSections(string number, string name, ComboBox group)
        {
            InitializeComponent();
            studBlock.Text = name;
            groupBox = group;
            student.connectSections(studHoursGrid, number);
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "Спортивная секция")
                name.Text = "";
        }

        private void name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
                name.Text = "Спортивная секция";
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

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            ReportSumHoursWindow reportSumHours = new ReportSumHoursWindow(groupBox);
            reportSumHours.Show();
            Close();
        }
    }
}
