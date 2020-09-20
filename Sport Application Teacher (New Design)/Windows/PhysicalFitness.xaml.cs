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
        ComboBox groupBox = new ComboBox();

        public PhysicalFitness(string name, ComboBox group)
        {
            InitializeComponent();
            studBlock.Text = name;
            groupBox = group;
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
            if (mark.Text == "Оценка")
                mark.Text = "";
        }

        private void mark_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mark.Text == "")
                mark.Text = "Оценка";
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            ReportSumHoursWindow reportSumHours = new ReportSumHoursWindow(groupBox);
            reportSumHours.Show();
            Close();
        }
    }
}
