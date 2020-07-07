﻿using Sport_Application_Teacher__New_Design_.Classes;
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
        TextBlock nameNumber = new TextBlock();

        public AnalysisPage(Frame frame, TextBlock name)
        {
            InitializeComponent();
            testFrame = frame;
            nameNumber = name;
            Faculty faculty = new Faculty(facultyBox);
            faculty.connectFaculty();
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
            groupBox.DisplayMemberPath = "nope";
        }

        private void ButtonShowHours(object sender, RoutedEventArgs e)
        {
            if (groupBox.Text != "")
                testFrame.Content = new ReportSumHours(groupBox, testFrame);
            else
                MessageBox.Show("Укажите группу!");
        }

        private void groupBox_GotMouseCapture(object sender, MouseEventArgs e)
        {
            if (specBox.Text != "")
            {
                Group group = new Group(groupBox, specBox);
                group.connectGroup(nameNumber);
            }
        }

        private void buttonShow_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            buttonShow.IsEnabled = true;
        }
    }
}
