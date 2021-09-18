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
    /// Логика взаимодействия для AdminSpecialtyWindow.xaml
    /// </summary>
    public partial class AdminSpecialtyWindow : Window
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=BITNB11;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";

        public AdminSpecialtyWindow()
        {
            InitializeComponent();

            Faculty fac = new Faculty(facBox);

            try
            {
                connect("SELECT * FROM [Специальности]", "Specialty");
                dataSpecialty.ItemsSource = dst.Tables["Specialty"].DefaultView;

                fac.connectFaculty();
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
            if (facBox.Text != "" && name.Text != "Название специальности")
            {
                try
                {
                    connect("SELECT MAX(КодСпец) FROM [Специальности]", "max_id");
                    int max_id = Convert.ToInt32(dst.Tables["max_id"].Rows[0][0]);

                    connect($"INSERT INTO [Специальности] VALUES ({max_id + 1}, " +
                        $"{facBox.SelectedValue}, '{name.Text}')" +
                        $"SELECT * FROM [Специальности]", "Specialty");

                    dataSpecialty.ItemsSource = dst.Tables["Specialty"].DefaultView;

                    MessageBox.Show($"Специальность '{name.Text}' добавлена", "Успех",
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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "Название специальности")
                name.Text = "";
        }

        private void name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
                name.Text = "Название специальности";
        }
    }
}
