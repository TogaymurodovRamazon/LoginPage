using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginPage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    # pragma warning disable
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveBorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            string email = tbEmail.Text;
            string password = pbPassword.Password.ToString();
            if (string.IsNullOrEmpty(email))
                MessageBox.Show("Email kiritilmadi!", "Warning",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (string.IsNullOrEmpty(password))
                MessageBox.Show("Password kiritilmadi!", "Warning",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                MessageBox.Show("Malumotlar saqlandi", "Succusfully");

                var gender = (rbIsMale.IsChecked.Value) ? "Erkak" : "Ayol";
                tbEmail.Text = "";
                pbPassword.Password = "";
                File.WriteAllText("D:\\Das\\2 C#\\@ Dot.Net misollari\\WPF\\Malumot.txt ", email + "\n" + password + "\n" + gender);

            }
        }
       
    }
}