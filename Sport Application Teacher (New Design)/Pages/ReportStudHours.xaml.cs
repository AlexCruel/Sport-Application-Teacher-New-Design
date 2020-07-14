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
    /// Логика взаимодействия для ReportStudHours.xaml
    /// </summary>
    public partial class ReportStudHours : Page
    {
        Frame frame = new Frame();
        Teacher teacher = new Teacher();
        ComboBox groupBox = new ComboBox();

        public ReportStudHours(string name, ComboBox group)
        {
            InitializeComponent();
            frame = (Frame)App.Current.Properties["frame"];
            groupBox = group;
            nameStudBlock.Content = name;
            teacher.connectStud(studHoursGrid, name);
        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            frame.Content = new ReportSumHours(groupBox);
        }
    }
}
