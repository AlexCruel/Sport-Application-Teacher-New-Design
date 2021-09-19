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
    /// Логика взаимодействия для AdminTeacherWindow.xaml
    /// </summary>
    public partial class AdminTeacherWindow : Window
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=BITNB11;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";

        public AdminTeacherWindow()
        {
            InitializeComponent();

            Teacher teacher = new Teacher();

            try
            {
                connect("SELECT [Группа], [ФИО_Препод], [КодГруппы] FROM [Groups]", "Group");
                dataGroup.ItemsSource = dst.Tables["Group"].DefaultView;

                teacher.connectTeacherID(teacherBox);
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

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (teacherBox.Text != "" && dataGroup.SelectedItem != null)
            {
                try
                {
                    var idGroup = (TextBlock)dataGroup.Columns[2].GetCellContent(dataGroup.SelectedItem);
                    var nameGroup = (TextBlock)dataGroup.Columns[0].GetCellContent(dataGroup.SelectedItem);
                    var nameTeacher = (TextBlock)dataGroup.Columns[1].GetCellContent(dataGroup.SelectedItem);
                    // var idTeacher = (TextBlock)dataGroup.Columns[2].GetCellContent(dataGroup.SelectedItem);

                    connect($"UPDATE [Группы] SET [НомерПрепод] = '{teacherBox.SelectedValue}'" +
                        $"WHERE [КодГруппы] = '{idGroup.Text}'" +
                        $"SELECT [Группа], [ФИО_Препод], [КодГруппы] FROM [Groups]", "Group");

                    MessageBox.Show($"Преподаватель для группы {nameGroup.Text}: " +
                        $"'{nameTeacher.Text}' => '{teacherBox.Text}'", "Успех",
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
