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
    class Teacher
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=(local)\SQLEXPRESS;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = Sport";

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
                teacherBox.SelectedValuePath = dst.Tables["Teacher"].Columns[0].ToString();
                teacherBox.DisplayMemberPath = dst.Tables["Teacher"].Columns[1].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //public void connectGroup(string value, ListBox groupBox)
        //{
        //    try
        //    {
        //        connect("SELECT * FROM [Группы] WHERE [КодПрепод] = " + value, "Group");
        //        groupBox.DataSource = dst.Tables["Group"];
        //        groupBox.ValueMember = dst.Tables["Group"].Columns[0].ColumnName;
        //        groupBox.DisplayMember = dst.Tables["Group"].Columns[2].ColumnName;
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        //public void connectStudHours(string value, DataGridView studHours)
        //{
        //    try
        //    {
        //        connect($"SELECT [ФИО_Студ], [ВсегоОтрабЧасов] FROM [Sum_HoursFull] WHERE [Группа] = '{value}'", "Hours");
        //        studHours.DataSource = dst.Tables["Hours"];
        //        studHours.Columns[0].HeaderText = "ФИО студента";
        //        studHours.Columns[1].HeaderText = "Всего отработано часов";
        //        studHours.Font = new Font("Microsoft Sans Serif", 16f, GraphicsUnit.Pixel);
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
