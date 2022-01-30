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
        string connectionString = @"Data Source=BITNB117\SQLEXPRESSE;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";

        public AdminTeacherWindow()
        {
            InitializeComponent();

            Teacher teacher = new Teacher();

            try
            {
                connect("SELECT [НомерПрепод], [ФИО_Препод] FROM [Преподаватели]", "Teacher");
                dataTeacher.ItemsSource = dst.Tables["Teacher"].DefaultView;
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (numberTeacher.Text != "" && name.Text != "" && password.Text != "Пароль")
            {
                if (password.Text.Length >= 5)
                {
                    try
                    {
                        connect($"INSERT INTO [Преподаватели] VALUES ('{numberTeacher.Text}', '{name.Text}', {password.Text})" +
                            "SELECT * FROM [Преподаватели]", "Teacher");

                        dataTeacher.ItemsSource = dst.Tables["Teacher"].DefaultView;

                        MessageBox.Show($"Преподаватель '{name.Text}' добавлен", "Успех",
                                    MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Пароль должен содержать минимум 5 символов!",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                MessageBox.Show("Не заполнены поля!",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "ФИО")
                name.Text = "";
        }

        private void name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
                name.Text = "ФИО";
        }

        private void numberTeacher_GotFocus(object sender, RoutedEventArgs e)
        {
            if (numberTeacher.Text == "Номер")
                numberTeacher.Text = "";
        }

        private void numberTeacher_LostFocus(object sender, RoutedEventArgs e)
        {
            if (numberTeacher.Text == "")
                numberTeacher.Text = "Номер";
        }

        private void password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (password.Text == "Пароль")
                password.Text = "";
        }

        private void password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (password.Text == "")
                password.Text = "Пароль";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
