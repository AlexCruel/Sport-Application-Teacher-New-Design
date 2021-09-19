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
    /// Логика взаимодействия для AdminGroupWindow.xaml
    /// </summary>
    public partial class AdminGroupWindow : Window
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=BITNB11;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";

        public AdminGroupWindow()
        {
            InitializeComponent();

            Specialty spec = new Specialty(groupBox);
            Teacher teacher = new Teacher();

            try
            {
                connect("SELECT * FROM [Группы]", "Group");
                dataGroup.ItemsSource = dst.Tables["Group"].DefaultView;

                spec.connectSpecAll();
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

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "Наименование группы")
                name.Text = "";
        }

        private void name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
                name.Text = "Наименование группы";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (groupBox.Text != "" && name.Text != "Наименование группы" && teacherBox.Text != "")
            {
                try
                {
                    connect("SELECT MAX(КодГруппы) FROM [Группы]", "max_id");
                    int max_id = Convert.ToInt32(dst.Tables["max_id"].Rows[0][0]);

                    connect($"INSERT INTO [Группы] VALUES ({max_id + 1}, " +
                        $"{groupBox.SelectedValue}, '{name.Text}', '{teacherBox.SelectedValue}')" +
                        $"SELECT * FROM [Группы]", "Group");

                    dataGroup.ItemsSource = dst.Tables["Group"].DefaultView;

                    MessageBox.Show($"Группа '{name.Text}' добавлена", "Успех",
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
