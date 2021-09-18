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
    class Specialty
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=BITNB11;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";
        ComboBox specBox, facultyBox;

        public Specialty(ComboBox spec, ComboBox faculty)
        {
            specBox = spec;
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

        public void connectSpec()
        {
            try
            {
                connect("SELECT * FROM [Специальности] WHERE [КодФакульт] = " + facultyBox.SelectedValue, "Spec");
                specBox.ItemsSource = dst.Tables["Spec"].DefaultView;
                specBox.SelectedValuePath = dst.Tables["Spec"].Columns[0].ToString();
                specBox.DisplayMemberPath = dst.Tables["Spec"].Columns[2].ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
