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
        string connectionString = @"Data Source=BITNB117\SQLEXPRESSE;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";

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

        public void connectStudList(DataGrid studHours, string studNumber, DatePicker dateFrom, DatePicker dateTo)
        {
            try
            {
                // connect($"SELECT [Дата], [Объект], [УСР] AS 'Учебная программа', [ОтрабЧасы] AS 'Отработано часов' FROM [ListJournal] WHERE [СтудНомер] = '{studNumber}'", "Student");
                connect($"SELECT [Дата], [Объект], [УСР] AS 'Учебная программа', [ОтрабЧасы] AS 'Отработано часов' FROM [ListJournal] " +
                    $"WHERE [СтудНомер] = '{studNumber}' " +
                    $"AND [Дата] >= convert(DATETIME, {dateFrom.SelectedDate.Value.ToString("yyyy-MM-dd")}, 102) " +
                    $"AND [Дата] <= convert(DATETIME, {dateTo.SelectedDate.Value.ToString("yyyy-MM-dd")}, 102)", "Student");
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
                connect($"SELECT [Название], [Дата], [Ответственный], [Часы] FROM [Volunteer] WHERE [СтудНомер] = '{studNumber}'", "Volunteer");
                studHoursGrid.ItemsSource = dst.Tables["Volunteer"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertVolunteer(string number, TextBox name, DatePicker date, TextBox person, ComboBox hours)
        {
            try
            {
                connect($"INSERT INTO [Волонтерство] VALUES ('{number}', '{name.Text}', '{date}', '{person.Text}', '{hours.Text}')", "Volunteer");
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
                connect($"SELECT [Название], [Дата], [Ответственный], [Часы] FROM [SportSections] WHERE [СтудНомер] = '{studNumber}'", "SportSections");
                studHoursGrid.ItemsSource = dst.Tables["SportSections"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertSections(string number, TextBox name, DatePicker date, TextBox person, ComboBox hours)
        {
            try
            {
                connect($"INSERT INTO [Секции] VALUES ('{number}', '{name.Text}', '{date}', '{person.Text}', '{hours.Text}')", "SportSections");
                name.Text = "Спортивная секция";
                date.SelectedDate = DateTime.Now;
                person.Text = "Ответственный";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectEvents(DataGrid studHoursGrid, string studNumber)
        {
            try
            {
                connect($"SELECT [Название], [Дата], [Ответственный], [Часы] FROM [Events] WHERE [СтудНомер] = '{studNumber}'", "Events");
                studHoursGrid.ItemsSource = dst.Tables["Events"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertEvents(string number, TextBox name, DatePicker date, TextBox person, ComboBox hours)
        {
            try
            {
                connect($"INSERT INTO [Мероприятия] VALUES ('{number}', '{name.Text}', '{date}', '{person.Text}', '{hours.Text}')", "Events");
                name.Text = "Спортивная секция";
                date.SelectedDate = DateTime.Now;
                person.Text = "Ответственный";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectFitness(DataGrid studHoursGrid, string studNumber)
        {
            try
            {
                connect($"SELECT [Семестр], [Дисциплина], [Результат], [Отметка] FROM [Fitness] WHERE [СтудНомер] = '{studNumber}'", "Fitness");
                studHoursGrid.ItemsSource = dst.Tables["Fitness"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertFitness(string number, ComboBox semester, ComboBox discipline, TextBox result, TextBox mark)
        {
            try
            {
                connect($"INSERT INTO [Физическая подготовка] VALUES ('{number}', '{semester.Text}', '{discipline.Text}', '{result.Text}', '{mark.Text}')", "Fitness");
                result.Text = "Результат";
                mark.Text = "Отметка";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
