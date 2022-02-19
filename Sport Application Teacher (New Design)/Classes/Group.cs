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
    class Group
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=BITNB117\SQLEXPRESSE;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";
        ComboBox groupBox, specBox;

        public Group(ComboBox group, ComboBox spec)
        {
            groupBox = group;
            specBox = spec;
        }

        public Group(ComboBox group) 
        {
            groupBox = group;
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

        public void connectGroup(TextBlock nameNumber)
        {
            try
            {
                // connect($"SELECT * FROM [Группы] WHERE [КодСпец] = {specBox.SelectedValue} AND [НомерПрепод] = '{nameNumber.Text}'", "Group");
                connect($"SELECT * FROM [Группы] WHERE [КодСпец] = {specBox.SelectedValue}", "Group");
                groupBox.ItemsSource = dst.Tables["Group"].DefaultView;
                groupBox.SelectedValuePath = dst.Tables["Group"].Columns[0].ToString();
                groupBox.DisplayMemberPath = dst.Tables["Group"].Columns[2].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectGroupAll() 
        {
            try
            {
                connect($"SELECT * FROM [Группы]", "Group");
                groupBox.ItemsSource = dst.Tables["Group"].DefaultView;
                groupBox.SelectedValuePath = dst.Tables["Group"].Columns[0].ToString();
                groupBox.DisplayMemberPath = dst.Tables["Group"].Columns[2].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connectGroupStat(TextBlock nameNumber)
        {
            try
            {
                connect($"SELECT * FROM [Группы] WHERE [НомерПрепод] = '{nameNumber.Text}'", "groupStat");
                groupBox.ItemsSource = dst.Tables["groupStat"].DefaultView;
                groupBox.SelectedValuePath = dst.Tables["groupStat"].Columns[0].ToString();
                groupBox.DisplayMemberPath = dst.Tables["groupStat"].Columns[2].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Dictionary<string, int> getStat(ComboBox groupBox, DatePicker dateFrom, DatePicker dateTo) 
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            try
            {
                // connect($"SELECT [Объект], [Группа], SUM([ОтрабЧасы]) FROM [ListJournal] WHERE [Группа] = '{groupBox.Text}' GROUP BY [Объект], [Группа]", "Statistics");
                connect($"SELECT [Объект], [Группа], SUM([ОтрабЧасы]) FROM [ListJournal] " +
                    $"WHERE [Группа] = '{groupBox.Text}' " +
                    $"AND [Дата] >= convert(DATETIME, '{dateFrom.SelectedDate.Value.ToString("yyyy-MM-dd 00:00:00")}', 102) " +
                    $"AND [Дата] <= convert(DATETIME, '{dateTo.SelectedDate.Value.ToString("yyyy-MM-dd 00:00:00")}', 102)" +
                    $"GROUP BY [Объект], [Группа]", "Statistics");

                for (int i = 0; i < dst.Tables["statistics"].Rows.Count; i++) 
                    dict.Add((string)dst.Tables["statistics"].Rows[i][0], (int)dst.Tables["Statistics"].Rows[i][2]);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dict;
        }
    }
}
