using Sport_Application_Teacher__New_Design_.Classes;
using Sport_Application_Teacher__New_Design_.Pages;
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

        public Dictionary<string, int> getStat(ComboBox studBox)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            try
            {
                connect($"EXEC [SumHoursFull] '{studBox.SelectedValue}'", "studStat");

                for (int i = 0; i < dst.Tables["studStat"].Rows.Count; i++)
                    dict.Add((string)dst.Tables["studStat"].Rows[i][0], (int)dst.Tables["studStat"].Rows[i][1]);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dict;
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

        public void connectStudStat(ComboBox groupBox, ComboBox studBox)
        {
            try
            {
                connect($"SELECT * FROM [Студенты] WHERE [КодГруппы] = '{groupBox.SelectedValue}'", "studStat");
                studBox.ItemsSource = dst.Tables["studStat"].DefaultView;
                studBox.SelectedValuePath = dst.Tables["studStat"].Columns[0].ToString();
                studBox.DisplayMemberPath = dst.Tables["studStat"].Columns[2].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
