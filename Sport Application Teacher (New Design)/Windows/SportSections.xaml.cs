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

namespace Sport_Application_Teacher__New_Design_.Admin
{
    /// <summary>
    /// Логика взаимодействия для SportSections.xaml
    /// </summary>
    public partial class SportSections : Window
    {
        Student student = new Student();
        ComboBox groupBox = new ComboBox();
        DatePicker dateFrom = new DatePicker();
        DatePicker dateTo = new DatePicker();
        string number;

        public SportSections(string number, string name, ComboBox group, DatePicker dateFrom, DatePicker dateTo)
        {
            InitializeComponent();
            studBlock.Text = name;
            groupBox = group;
            this.number = number;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;

            student.connectSections(studHoursGrid, number, dateFrom, dateTo);
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

        private void Button_Record(object sender, RoutedEventArgs e)
        {
            if (name.Text != "Спортивная секция" && person.Text != "Ответственный" && hours.Text != "")
            {
                student.insertSections(number, name, date, person, hours);
                student.connectSections(studHoursGrid, number, dateFrom, dateTo);
            }
            else
                MessageBox.Show("Введите данные корректно!");
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            ReportSumHoursWindow reportSumHours = new ReportSumHoursWindow(groupBox, dateFrom, dateTo);
            reportSumHours.Show();
            Close();
        }
    }
}
