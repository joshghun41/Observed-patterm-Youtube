using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            User user = new User();
            user.Name = "cosqun";
            user.Password = "cosqun123";

        }
        class User
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string SubName { get; set; }

           
        }
        List<User> users { get; set; }

        class Youtuber
        {
            public string Name { get; set; }
            List<User> users { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            youtubebutton.Visibility = Visibility.Hidden;
            subcriberbutton.Visibility = Visibility.Hidden; 
            showallbutton.Visibility = Visibility.Hidden;
            addpostbutton.Visibility = Visibility.Hidden;
        }

        private void subcriberbutton_Click(object sender, RoutedEventArgs e)
        {
            youtubebutton.Visibility = Visibility.Hidden;
            subcriberbutton.Visibility = Visibility.Hidden;
            showallbutton.Visibility = Visibility.Hidden;
            addpostbutton.Visibility = Visibility.Hidden;

        }

        private void showallbutton_Click(object sender, RoutedEventArgs e)
        {
            youtubebutton.Visibility = Visibility.Hidden;
            subcriberbutton.Visibility = Visibility.Hidden;
            showallbutton.Visibility = Visibility.Hidden;
            addpostbutton.Visibility = Visibility.Hidden;
        }

        private void addpostbutton_Click(object sender, RoutedEventArgs e)
        {
            youtubebutton.Visibility = Visibility.Hidden;
            subcriberbutton.Visibility = Visibility.Hidden;
            showallbutton.Visibility = Visibility.Hidden;
            addpostbutton.Visibility = Visibility.Hidden;


        }

        private void signbutton_Click(object sender, RoutedEventArgs e)
        {
            youtubebutton.Visibility = Visibility.Hidden;
            subcriberbutton.Visibility = Visibility.Hidden;
            showallbutton.Visibility = Visibility.Hidden;
            addpostbutton.Visibility = Visibility.Hidden;
            signbutton.Visibility = Visibility.Hidden;
            registerbutton.Visibility = Visibility.Hidden;


        }

        private void enterbutton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in users)
            {

            }
        }
    }
}
