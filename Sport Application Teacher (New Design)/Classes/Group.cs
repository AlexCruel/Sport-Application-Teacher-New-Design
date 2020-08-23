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
        string connectionString = @"Data Source=(local)\SQLEXPRESS;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = Sport1";
        ComboBox groupBox, specBox;

        public Group(ComboBox group, ComboBox spec)
        {
            groupBox = group;
            specBox = spec;
        }

        public Group() 
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

        public void connectGroup(TextBlock nameNumber)
        {
            try
            {
                connect($"SELECT * FROM [Группы] WHERE [КодСпец] = {specBox.SelectedValue} AND [НомерПрепод] = '{nameNumber.Text}'", "Group");
                groupBox.ItemsSource = dst.Tables["Group"].DefaultView;
                groupBox.SelectedValuePath = dst.Tables["Group"].Columns[0].ToString();
                groupBox.DisplayMemberPath = dst.Tables["Group"].Columns[2].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Dictionary<string, int> getStat() 
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            try
            {
                connect("SELECT [Объект], [Группа], SUM([ОтрабЧасы]) FROM [ListJournal] GROUP BY [Объект], [Группа]", "statistics");

                for (int i = 0; i < dst.Tables["statistics"].Rows.Count; i++) 
                    dict.Add((string)dst.Tables["statistics"].Rows[i][0], (int)dst.Tables["statistics"].Rows[i][2]);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dict;
        }
    }
}
