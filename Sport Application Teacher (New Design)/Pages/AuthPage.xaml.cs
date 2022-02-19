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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace Sport_Application_Teacher__New_Design_
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        Frame frame = new Frame();
        Teacher teacher = new Teacher();
        TextBlock nameText = new TextBlock();
        TextBlock nameNumber = new TextBlock();
        Grid MenuBar = new Grid();
        Button btnAccount = new Button();
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

        public AuthPage(Grid menu, Button btnAccount, DatePicker dateFrom, DatePicker dateTo)
        {
            InitializeComponent();
            frame = (Frame)App.Current.Properties["frame"];
            nameText = (TextBlock)App.Current.Properties["nameText"];
            nameNumber = (TextBlock)App.Current.Properties["nameNumber"];
            MenuBar = menu;
            this.btnAccount = btnAccount;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;

            teacher.connectTeacher(loginBox);
        }

        private void ButtonEnter(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text != "")
            {
                int index = loginBox.SelectedIndex;
                string value = teacher.Dst.Tables["Teacher"].Rows[index][2].ToString();

                if (passwordBox.Password == value && loginBox.Text != null)
                {
                    GridLogin.Visibility = Visibility.Hidden;
                    nameText.Text = loginBox.Text;
                    nameNumber.Text = teacher.Dst.Tables["Teacher"].Rows[index][0].ToString();
                    frame.Content = new HomePage();
                    MenuBar.IsEnabled = true;
                    dateFrom.IsEnabled = true;
                    dateTo.IsEnabled = true;

                    if (loginBox.Text == "Админ1")
                        btnAccount.IsEnabled = true;

                    teacher.Dst.Clear();
                    notifier.ShowSuccess("Доступ разрешен");
                }
                else
                    notifier.ShowError("Неверный пароль для данного пользователя!");
            }
            else
                notifier.ShowWarning("Введите логин!");
        }
    }
}
