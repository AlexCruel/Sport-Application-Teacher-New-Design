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
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnFaculty_Click(object sender, RoutedEventArgs e)
        {
            new AdminFacultyWindow().Show();
        }

        private void btnSpecialty_Click(object sender, RoutedEventArgs e)
        {
            new AdminSpecialtyWindow().Show();
        }

        private void btnGroup_Click(object sender, RoutedEventArgs e)
        {
            new AdminGroupWindow().Show();
        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            new AdminStudentWindow().Show();
        }

        private void btnTeacher_Click(object sender, RoutedEventArgs e)
        {
            new AdminTeacherWindow().Show();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            new AdminAddStudentWindow().Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
