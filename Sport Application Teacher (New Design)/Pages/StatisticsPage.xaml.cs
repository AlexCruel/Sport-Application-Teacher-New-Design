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
        Frame frame = new Frame();
        TextBlock nameNumber = new TextBlock();
        Func<ChartPoint, string> label = chartpoint => string.Format("{0} ({1:P", chartpoint.Y, chartpoint.Participation);

        public StatisticsPage()
        {
            InitializeComponent();
            frame = (Frame)App.Current.Properties["frame"];
            nameNumber = (TextBlock)App.Current.Properties["nameNumber"];
            Group group = new Group(groupBox);
            group.connectGroupStat(nameNumber);
            pieChartGroup.LegendLocation = LegendLocation.Bottom;
        }

        private void groupBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.connectStudStat(groupBox, studBox);
        }

        private void ButtonShowStat(object sender, RoutedEventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            Group group = new Group(groupBox);

            Dictionary<string, int> dict = group.getStat(groupBox);
            ICollection<string> keys = dict.Keys;

            foreach (string item in keys)
                series.Add(new PieSeries() { Title = item, Values = new ChartValues<int> { dict[item] } });
            pieChartGroup.Series = series;
        }

        private void ButtonStudStat(object sender, RoutedEventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            Teacher teacher = new Teacher();

            Dictionary<string, int> dict = teacher.getStat(studBox);
            ICollection<string> keys = dict.Keys;

            foreach (string item in keys)
                series.Add(new PieSeries() { Title = item, Values = new ChartValues<int> { dict[item] } });
            pieChartStudent.Series = series;
        }
    }
}
