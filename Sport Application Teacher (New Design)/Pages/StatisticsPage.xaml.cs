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
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace Sport_Application_Teacher__New_Design_.Pages
{
    /// <summary>
    /// Логика взаимодействия для StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        Frame frame = new Frame();
        TextBlock nameNumber = new TextBlock();
        DatePicker dateFrom = new DatePicker();
        DatePicker dateTo = new DatePicker();
        Func<ChartPoint, string> label = chartpoint => string.Format("{0} ({1:P", chartpoint.Y, chartpoint.Participation);

        Notifier notifier = new Notifier(cfg =>
        {
            cfg.PositionProvider = new WindowPositionProvider(
                parentWindow: Application.Current.MainWindow,
                corner: Corner.TopRight,
                offsetX: 10,
                offsetY: 10);

            cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                notificationLifetime: TimeSpan.FromSeconds(3),
                maximumNotificationCount: MaximumNotificationCount.FromCount(5));

            cfg.Dispatcher = Application.Current.Dispatcher;
        });

        public StatisticsPage(DatePicker dateFrom, DatePicker dateTo)
        {
            InitializeComponent();
            frame = (Frame)App.Current.Properties["frame"];
            nameNumber = (TextBlock)App.Current.Properties["nameNumber"];

            this.dateFrom = dateFrom;
            this.dateTo = dateTo;

            Group group = new Group(groupBox);
            group.connectGroupStat(nameNumber);

            pieChartGroup.LegendLocation = LegendLocation.Bottom;
            pieChartStudent.LegendLocation = LegendLocation.Bottom;
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

            if (dateFrom.Text != "" && dateTo.Text != "")
            {
                Dictionary<string, int> dict = group.getStat(groupBox, dateFrom, dateTo);
                ICollection<string> keys = dict.Keys;

                foreach (string item in keys)
                    series.Add(new PieSeries() { Title = item, Values = new ChartValues<int> { dict[item] } });
                pieChartGroup.Series = series;
            }
            else
                notifier.ShowWarning("Укажите диапазон дат");
        }

        private void ButtonStudStat(object sender, RoutedEventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            Teacher teacher = new Teacher();

            if (dateFrom.Text != "" && dateTo.Text != "")
            {
                Dictionary<string, int> dict = teacher.getStat(studBox, dateFrom, dateTo);
                ICollection<string> keys = dict.Keys;

                foreach (string item in keys)
                    series.Add(new PieSeries() { Title = item, Values = new ChartValues<int> { dict[item] } });
                pieChartStudent.Series = series;
            }
            else
                notifier.ShowWarning("Укажите диапазон дат");
        }
    }
}
