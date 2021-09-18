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
    class Faculty
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=BITNB11;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";
        ComboBox facultyBox;

        public Faculty(ComboBox faculty)
        {
            facultyBox = faculty;
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

        public void connectFaculty()
        {
            try
            {
                connect("SELECT * FROM [Факультеты]", "Faculty");
                facultyBox.ItemsSource = dst.Tables["Faculty"].DefaultView;
                facultyBox.SelectedValuePath = dst.Tables["Faculty"].Columns[0].ToString();
                facultyBox.DisplayMemberPath = dst.Tables["Faculty"].Columns[1].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
