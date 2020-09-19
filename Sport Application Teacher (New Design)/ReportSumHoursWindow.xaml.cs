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
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace Sport_Application_Teacher__New_Design_.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReportSumHoursWindow.xaml
    /// </summary>
    public partial class ReportSumHoursWindow : Window
    {
        Teacher teacher = new Teacher();
        ComboBox groupBox = new ComboBox();

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

        public ReportSumHoursWindow(ComboBox group)
        {
            InitializeComponent();
            groupBox = group;
            teacher.connectStudHours(group, studHoursGrid);
        }

        private void ButtonSheet(object sender, RoutedEventArgs e)
        {
            string studName = teacher.getStudName(studHoursGrid);

            if (studName == "nope")
                notifier.ShowWarning("Выберите студента!");
            else 
            {
                ReportStudHoursWindow reportStudHours = new ReportStudHoursWindow(studName, groupBox);
                reportStudHours.Show();
                Close();
            }
        }

        private void ButtonExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
