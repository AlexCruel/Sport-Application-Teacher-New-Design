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
    /// Логика взаимодействия для AdminFacultyWindow.xaml
    /// </summary>
    public partial class AdminFacultyWindow : Window
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=BITNB11;" +
                            "Integrated Security = SSPI;" +
                            "Initial Catalog = sportapp";

        public AdminFacultyWindow()
        {
            InitializeComponent();

            try
            {
                connect("SELECT * FROM [Факультеты]", "Faculty");
                dataFaculty.ItemsSource = dst.Tables["Faculty"].DefaultView;
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != "Наименование факультета") 
            {
                try
                {
                    connect("SELECT MAX(КодФакульт) FROM [Факультеты]", "max_id");
                    int max_id = Convert.ToInt32(dst.Tables["max_id"].Rows[0][0]); 

                    connect($"INSERT INTO [Факультеты] VALUES ({max_id + 1}, '{name.Text}')" +
                    "SELECT * FROM [Факультеты]", "Faculty");

                    dataFaculty.ItemsSource = dst.Tables["Faculty"].DefaultView;

                    MessageBox.Show($"Факультет '{name.Text}' добавлен", "Успех",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Введите наименование факультета!", 
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);

            
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "Наименование факультета")
                name.Text = "";
        }

        private void name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
                name.Text = "Наименование факультета";
        }
    }
}
