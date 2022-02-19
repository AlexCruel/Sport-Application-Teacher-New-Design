using Sport_Application_Teacher__New_Design_.Classes;
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
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace Sport_Application_Teacher__New_Design_.Pages
{
    /// <summary>
    /// Логика взаимодействия для AnalysisPage.xaml
    /// </summary>
    public partial class AnalysisPage : Page
    {
        Frame frame = new Frame();
        TextBlock nameNumber = new TextBlock();
        DatePicker dateFrom = new DatePicker();
        DatePicker dateTo = new DatePicker();

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

        public AnalysisPage()
        {
            InitializeComponent();
            frame = (Frame)App.Current.Properties["frame"];
            nameNumber = (TextBlock)App.Current.Properties["nameNumber"];
            Faculty faculty = new Faculty(facultyBox);
            faculty.connectFaculty();
        }

        public AnalysisPage(DatePicker dateFrom, DatePicker dateTo)
        {
            InitializeComponent();
            frame = (Frame)App.Current.Properties["frame"];
            nameNumber = (TextBlock)App.Current.Properties["nameNumber"];
            Faculty faculty = new Faculty(facultyBox);
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;

            faculty.connectFaculty();
        }

        public AnalysisPage(Frame frame)
        {
            InitializeComponent();
            frame = (Frame)App.Current.Properties["frame"];
        }

        private void facultyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Specialty spec = new Specialty(specBox, facultyBox);
            spec.connectSpec();
            groupBox.DisplayMemberPath = "nope";
        }

        private void groupBox_GotMouseCapture(object sender, MouseEventArgs e)
        {
            if (specBox.Text != "")
            {
                Group group = new Group(groupBox, specBox);
                group.connectGroup(nameNumber);
            }
        }

        private void ButtonShowHours(object sender, RoutedEventArgs e)
        {
            if (groupBox.Text != "" && dateFrom.Text != "" && dateTo.Text != "")
            {
                ReportSumHoursWindow reportSumHours = new ReportSumHoursWindow(groupBox, dateFrom, dateTo);
                reportSumHours.Show();
            }
            else
                notifier.ShowWarning("Укажите группу и диапазон дат");
        }
    }
}
