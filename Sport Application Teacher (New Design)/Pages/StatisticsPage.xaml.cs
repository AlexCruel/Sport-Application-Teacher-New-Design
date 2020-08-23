using System;
using System.Collections.Generic;
using System.Data;
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
using LiveCharts;
using LiveCharts.Wpf;
using Sport_Application_Teacher__New_Design_.Classes;

namespace Sport_Application_Teacher__New_Design_.Pages
{
    /// <summary>
    /// Логика взаимодействия для StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        Func<ChartPoint, string> label = chartpoint => string.Format("{0} ({1:P", chartpoint.Y, chartpoint.Participation);

        public StatisticsPage()
        {
            InitializeComponent();
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SeriesCollection series = new SeriesCollection();

            int[] mass = new int[5] { 25, 25, 25, 25, 25 };

            foreach (var obj in mass)
                series.Add(new PieSeries() { Title = "Btn1", Values = new ChartValues<int> { obj } });

            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SeriesCollection series = new SeriesCollection();

            int[] mass = new int[5] { 21, 22, 23, 10, 3 };

            foreach (var obj in mass)
                series.Add(new PieSeries() { Title = "Btn2", Values = new ChartValues<int> { obj } });

            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            Group group = new Group();

            Dictionary<string, int> dict = group.getStat();
            ICollection<string> keys = dict.Keys;

            foreach (string item in keys)
                series.Add(new PieSeries() { Title = item, Values = new ChartValues<int> { dict[item] } });
            pieChart1.Series = series;
        }
    }
}
