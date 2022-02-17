using Sport_Application_Teacher__New_Design_.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sport_Application_Teacher__New_Design_.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminStudentWindow.xaml
    /// </summary>
    public partial class AdminStudentWindow : Window
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=BITNB117\SQLEXPRESSE;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";

        public AdminStudentWindow()
        {
            InitializeComponent();

            Group group = new Group(groupBox);

            try
            {
                connect("SELECT * FROM [Студенты]", "Students");
                dataStudent.ItemsSource = dst.Tables["Students"].DefaultView;
               
                group.connectGroupAll();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnChangeGroup_Click(object sender, RoutedEventArgs e)
        {
            if (groupBox.Text != "" && dataStudent.SelectedItem != null)
            {
                try
                {
                    var idStud = (TextBlock)dataStudent.Columns[0].GetCellContent(dataStudent.SelectedItem);
                    var nameStud = (TextBlock)dataStudent.Columns[2].GetCellContent(dataStudent.SelectedItem);
                    var groupStud = (TextBlock)dataStudent.Columns[3].GetCellContent(dataStudent.SelectedItem);

                    connect($"UPDATE [Студенты] SET [КодГруппы] = '{groupBox.SelectedValue}'" +
                        $"WHERE [СтудНомер] = '{idStud.Text}'" +
                        $"SELECT * FROM [Students]", "Students");

                    MessageBox.Show($"Группа для студента {nameStud.Text} сменена: '{groupStud.Text}' на '{groupBox.Text}'", "Успех",
                       MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (SqlException ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Введите данные корректно!",
                   "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
