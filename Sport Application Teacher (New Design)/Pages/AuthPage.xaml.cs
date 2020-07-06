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

namespace Sport_Application_Teacher__New_Design_
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        Teacher teacher = new Teacher();
        TextBlock nameText = new TextBlock();
        TextBlock nameNumber = new TextBlock();
        Frame frame = new Frame();

        public AuthPage(TextBlock text, Frame testFrame, TextBlock number)
        {
            InitializeComponent();
            nameText = text;
            frame = testFrame;
            nameNumber = number;
            teacher.connectTeacher(loginBox);
        }

        private void ButtonEnter(object sender, RoutedEventArgs e)
        {
            int index = loginBox.SelectedIndex;
            string value = teacher.Dst.Tables["Teacher"].Rows[index][2].ToString();

            if (passwordBox.Text == value)
            {
                GridLogin.Visibility = Visibility.Hidden;
                nameText.Text = loginBox.Text;
                nameNumber.Text = teacher.Dst.Tables["Teacher"].Rows[index][0].ToString();
                frame.Content = new HomePage();
                teacher.Dst.Clear();
            }
            else
                MessageBox.Show("Неверный пароль для данного пользователя!", "Внимание", MessageBoxButton.OK);
        }
    }
}
