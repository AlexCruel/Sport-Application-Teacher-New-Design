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
    /// Логика взаимодействия для PhysicalFitness.xaml
    /// </summary>
    public partial class PhysicalFitness : Window
    {
        Student student = new Student();
        ComboBox groupBox = new ComboBox();
        string number;

        public PhysicalFitness(string number, string name, ComboBox group)
        {
            InitializeComponent();
            studBlock.Text = name;
            groupBox = group;
            this.number = number;
            student.connectFitness(studHoursGrid, number);
        }

        private void result_GotFocus(object sender, RoutedEventArgs e)
        {
            if (result.Text == "Результат")
                result.Text = "";
        }

        private void result_LostFocus(object sender, RoutedEventArgs e)
        {
            if (result.Text == "")
                result.Text = "Результат";
        }

        private void mark_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mark.Text == "Отметка")
                mark.Text = "";
        }

        private void mark_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mark.Text == "")
                mark.Text = "Отметка";
        }

        private void Button_Record(object sender, RoutedEventArgs e)
        {
            if (semester.Text != "" && discipline.Text != "" && result.Text != "Результат" && mark.Text != "Отметка")
            {
                student.insertFitness(number, semester, discipline, result, mark);
                student.connectFitness(studHoursGrid, number);
            }
            else
                MessageBox.Show("Введите данные корректно!");
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            ReportSumHoursWindow reportSumHours = new ReportSumHoursWindow(groupBox);
            reportSumHours.Show();
            Close();
        }
    }
}
