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

            try
            {
                connect("SELECT * FROM [Специальности]", "Specialty");
                dataSpecialty.ItemsSource = dst.Tables["Specialty"].DefaultView;
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
            if (codeSpec.Text != "Код специальности" && codeFac.Text != "Код факультета" &&
                name.Text != "Название специальности") 
            {
                try
                {
                    connect($"INSERT INTO [Специальности] VALUES ({codeSpec.Text}, " +
                        $"{codeFac.Text}, '{name.Text}')" +
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

        private void codeSpec_GotFocus(object sender, RoutedEventArgs e)
        {
            if (codeSpec.Text == "Код специальности")
                codeSpec.Text = "";
        }

        private void codeSpec_LostFocus(object sender, RoutedEventArgs e)
        {
            if (codeSpec.Text == "")
                codeSpec.Text = "Код специальности";
        }

        private void codeFac_GotFocus(object sender, RoutedEventArgs e)
        {
            if (codeFac.Text == "Код факультета")
                codeFac.Text = "";
        }

        private void codeFac_LostFocus(object sender, RoutedEventArgs e)
        {
            if (codeFac.Text == "")
                codeFac.Text = "Код факультета";
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
