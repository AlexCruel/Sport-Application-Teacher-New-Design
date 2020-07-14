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

namespace Sport_Application_Teacher__New_Design_.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReportSumHours.xaml
    /// </summary>
    public partial class ReportSumHours : Page
    {
        Frame frame = new Frame();
        ComboBox groupBox = new ComboBox();
        Teacher teacher = new Teacher();

        public ReportSumHours(ComboBox group)
        {
            InitializeComponent();
            frame = (Frame)App.Current.Properties["frame"];
            groupBox = group;
            teacher.connectStudHours(groupBox, studHoursGrid);
        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            frame.Content = new HomePage();
        }

        private void ButtonNext(object sender, RoutedEventArgs e)
        {
            string studName = teacher.getStudName(studHoursGrid);

            if (studName == "nope")
                MessageBox.Show("Выберите студента!");
            else
                frame.Content = new ReportStudHours(studName, groupBox);
        }
    }
}
