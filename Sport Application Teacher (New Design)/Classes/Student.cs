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
                connect($"SELECT [Дата], [Объект], [УСР] AS 'Учебная программа', [ОтрабЧасы] AS 'Отработано часов' FROM [ListJournal] WHERE [ФИО_Студ] = '{studName}'", "Student");
                studHours.ItemsSource = dst.Tables["Student"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectVolunteer(DataGrid studVol, string studName) 
        {
            try
            {
                connect($"SELECT [Название], [Дата], [Ответственный] FROM [Volunteer] WHERE [ФИО_Студ] = '{studName}'", "Volunteer");
                studVol.ItemsSource = dst.Tables["Volunteer"].DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public void insertVolunteer(DataGrid studVol, TextBox vol, DatePicker date, TextBox name) 
        //{
        //    try
        //    {
        //        connect($"INSERT INTO [Волонтерство] VALUES ({vol}, {date}, {name})", "Volunteer");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
