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
   
    public partial class MainWindow : Window
    {
        public Repo repo { get; set; }

        public MainWindow()
        {
            InitializeComponent();
          
             repo = new Repo();
            repo.AddUser(new YoutubeSubscriber
            {
                Username ="cosqun",
                Password ="1"
            });
           
            
        }
        public interface ISubscriber
        {
          
        }

 public class Post
    {
        public string ImagePath { get; set; }
        public string TextInfo { get; set; }

    }

 public class Youtuber
    {
        
        public List<Post> Posts { get; set; }

        public List<ISubscriber> Subscribers { get; set; }

        public Youtuber()
        {
            Subscribers = new List<ISubscriber>();
        }

        public void NotifyAllUsers(Post post)
        {
            foreach (var subscriber in Subscribers)
            {
                if (subscriber is YoutubeSubscriber sB)
                {
                    sB.Posts.Add(post);
                }
            }
        }
    }

 public class YoutubeSubscriber : ISubscriber
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Post> Posts { get; set; }

        public YoutubeSubscriber()
        {
            Posts = new List<Post>();
        }
       
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
            var user=repo.GetUserByUsername(namebox.Text);
            if(user != null)
            {
                
            }

            
            
        }
    }
}
