﻿using Sport_Application_Teacher__New_Design_.Pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sport_Application_Teacher__New_Design_
{
    public class Teacher
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=(local)\SQLEXPRESS;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = Sport1";

        public DataSet Dst
        {
            get { return dst; }
        }

        public Teacher()
        {

        }

        private void connect(string c, string a)
        {
            try
            {
                dst.Clear();
                adapter = new SqlDataAdapter(c, connectionString);
                adapter.Fill(dst, a);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectTeacher(ComboBox teacherBox)
        {
            try
            {
                connect("SELECT * FROM [Преподаватели]", "Teacher");
                teacherBox.ItemsSource = dst.Tables["Teacher"].DefaultView;
                teacherBox.SelectedValuePath = dst.Tables["Teacher"].Columns[2].ToString();
                teacherBox.DisplayMemberPath = dst.Tables["Teacher"].Columns[1].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void connectStudHours(ComboBox value, DataGrid studHours)
        {
            try
            {
                connect($"SELECT [ФИО Студента], [Всего отработано часов] FROM [Sum_HoursFull] WHERE [Группа] = '{value.Text}'", "Hours");
                studHours.ItemsSource = dst.Tables["Hours"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string getStudName(DataGrid studHours)
        {   
            if (studHours.SelectedItem != null)
            {
                TextBlock value = (TextBlock)studHours.Columns[0].GetCellContent(studHours.SelectedItem);
                return value.Text;
            }

            return "nope";

        }

        public void connectStud(DataGrid studHours, string studName)
        {
            try
            {
                connect($"SELECT [Дата], [УСР] AS 'Учебная программа', [ОтрабЧасы] AS 'Отработано часов' FROM [ListJournal] WHERE [ФИО_Студ] = '{studName}'", "Student");
                studHours.ItemsSource = dst.Tables["Student"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
