﻿using Sport_Application_Teacher__New_Design_.Admin;
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
        DatePicker dateFrom, dateTo;

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

        public ReportSumHoursWindow(ComboBox group, DatePicker dateFrom, DatePicker dateTo)
        {
            InitializeComponent();
            groupBox = group;
            groupBlock.Text = group.Text;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            teacher.connectGroupHours(group, studHoursGrid, dateFrom, dateTo);
        }

        public ReportSumHoursWindow(ComboBox group)
        {
            InitializeComponent();
            
        }

        private void Button_Sheet(object sender, RoutedEventArgs e)
        {
            string studName = teacher.getStudName(studHoursGrid);
            string studNumber = teacher.getStudNumber(studHoursGrid);

            if (studNumber == "nope")
                notifier.ShowWarning("Выберите студента!");
            else
            {
                ReportStudHoursWindow reportStudHours = new 
                    ReportStudHoursWindow(studNumber, studName, groupBox, dateFrom, dateTo);
                reportStudHours.Show();
                Close();
            }
        }

        private void Button_Volunteer(object sender, RoutedEventArgs e)
        {
            string studName = teacher.getStudName(studHoursGrid);
            string studNumber = teacher.getStudNumber(studHoursGrid);

            if (studNumber == "nope")
                notifier.ShowWarning("Выберите студента!");
            else
            {
                Volunteer volunteer = new Volunteer(studNumber, studName, groupBox, dateFrom, dateTo);
                volunteer.Show();
                Close();
            }
        }

        private void Button_Sections(object sender, RoutedEventArgs e)
        {
            string studName = teacher.getStudName(studHoursGrid);
            string studNumber = teacher.getStudNumber(studHoursGrid);

            if (studNumber == "nope")
                notifier.ShowWarning("Выберите студента!");
            else
            {
                SportSections sections = new SportSections(studNumber, studName, groupBox, dateFrom, dateTo);
                sections.Show();
                Close();
            }
        }

        private void Button_Events(object sender, RoutedEventArgs e)
        {
            string studName = teacher.getStudName(studHoursGrid);
            string studNumber = teacher.getStudNumber(studHoursGrid);

            if (studNumber == "nope")
                notifier.ShowWarning("Выберите студента!");
            else
            {
                SportEvents events = new SportEvents(studNumber, studName, groupBox, dateFrom, dateTo);
                events.Show();
                Close();
            }
        }

        private void Button_Fitness(object sender, RoutedEventArgs e)
        {
            string studName = teacher.getStudName(studHoursGrid);
            string studNumber = teacher.getStudNumber(studHoursGrid);

            if (studNumber == "nope")
                notifier.ShowWarning("Выберите студента!");
            else
            {
                PhysicalFitness fitness = new PhysicalFitness(studNumber, studName, groupBox, dateFrom, dateTo);
                fitness.Show();
                Close();
            }
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
