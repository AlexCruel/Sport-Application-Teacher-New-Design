﻿using System;
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

namespace Sport_Application_Teacher__New_Design_.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReportStudHoursWindow.xaml
    /// </summary>
    public partial class ReportStudHoursWindow : Window
    {
        Teacher teacher = new Teacher();
        ComboBox groupBox = new ComboBox();

        public ReportStudHoursWindow(string name, ComboBox group)
        {
            InitializeComponent();
            groupBox = group;
            nameStudBlock.Content = name;
            teacher.connectStud(studHoursGrid, name);
        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            ReportSumHoursWindow reportSumHours = new ReportSumHoursWindow(groupBox);
            reportSumHours.Show();
            Close();
        }

        private void studHoursGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "Дата")
            {
                (e.Column as DataGridTextColumn).Binding.StringFormat = "dd/MM/yyyy H:mm:ss";
            }
        }
    }
}