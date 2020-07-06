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
                            "Initial Catalog = Sport";
        ComboBox groupBox, specBox;

        public Group(ComboBox group, ComboBox spec)
        {
            groupBox = group;
            specBox = spec;
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

        public void connectGroup()
        {
            try
            {
                connect("SELECT * FROM [Группы] WHERE [КодСпец] = " + specBox.SelectedValue, "Group");
                groupBox.ItemsSource = dst.Tables["Group"].DefaultView;
                groupBox.SelectedValuePath = dst.Tables["Group"].Columns[0].ToString();
                groupBox.DisplayMemberPath = dst.Tables["Group"].Columns[2].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
