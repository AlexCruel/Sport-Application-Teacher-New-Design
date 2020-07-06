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

namespace Sport_Application_Teacher__New_Design_.Pages
{
    /// <summary>
    /// Логика взаимодействия для AnalysisPage.xaml
    /// </summary>
    public partial class AnalysisPage : Page
    {
        Frame testFrame = new Frame();
        string nameText;

        public AnalysisPage(TextBlock text, Frame frame)
        {
            InitializeComponent();
            testFrame = frame;
            nameText = text.Text;
            Faculty faculty = new Faculty(facultyBox);
            faculty.connectFaculty();
            //MessageBox.Show(nameText);
        }

        public AnalysisPage(Frame frame)
        {
            InitializeComponent();
            testFrame = frame;
        }

        private void facultyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Specialty spec = new Specialty(specBox, facultyBox);
            spec.connectSpec();
        }

        private void specBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Group group = new Group(groupBox, specBox);
            group.connectGroup();
        }

        private void ButtonShowHours(object sender, RoutedEventArgs e)
        {
            testFrame.Content = new ReportSumHours(groupBox, testFrame);
        }
    }
}
