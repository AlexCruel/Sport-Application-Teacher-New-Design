using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sport_Application_Teacher__New_Design_.Classes
{
    class Student
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=(local)\SQLEXPRESS;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = Sport1";

        public Student() 
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

        public void connectStudList(DataGrid studHours, string studName)
        {
            try
            {
                connect($"SELECT [Дата], [Объект], [УСР] AS 'Учебная программа', [ОтрабЧасы] AS 'Отработано часов' FROM [ListJournal] WHERE [СтудНомер] = '{studName}'", "Student");
                studHours.ItemsSource = dst.Tables["Student"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectVolunteer(DataGrid studHoursGrid, string studNumber) 
        {
            try
            {
                connect($"SELECT [Название], [Дата], [Ответственный] FROM [Volunteer] WHERE [СтудНомер] = '{studNumber}'", "Volunteer");
                studHoursGrid.ItemsSource = dst.Tables["Volunteer"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertVolunteer(TextBox name, DatePicker date, TextBox person)
        {
            try
            {
                connect($"INSERT INTO [Волонтерство] VALUES ('17Д28-157', '{name.Text}', '{date}', '{person.Text}')", "Volunteer");
                name.Text = "Волонтёрская работа";
                date.SelectedDate = DateTime.Now;
                person.Text = "Ответственный";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectSections(DataGrid studHoursGrid, string studNumber)
        {
            try
            {
                connect($"SELECT [Название], [Дата], [Ответственный] FROM [SportSections] WHERE [СтудНомер] = '{studNumber}'", "SportSections");
                studHoursGrid.ItemsSource = dst.Tables["SportSections"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertSections(TextBox name, DatePicker date, TextBox person)
        {
            try
            {
                connect($"INSERT INTO [Секции] VALUES ('17Д28-157', '{name.Text}', '{date}', '{person.Text}')", "SportSections");
                name.Text = "Спортивная секция";
                date.SelectedDate = DateTime.Now;
                person.Text = "Ответственный";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
