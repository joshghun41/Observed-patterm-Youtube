using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfApp2.MainWindow;

namespace WpfApp2
{
    public class Repo
    {
        public List<YoutubeSubscriber> Users { get; set; }
        public List<Youtuber> Youtubers { get; set; }
        public Repo()
        {
            Users = new List<YoutubeSubscriber>();
            if (File.Exists("Users.json"))
            {
                Users = JsonConvert.DeserializeObject< List<YoutubeSubscriber >> (File.ReadAllText("Users.json"));
            }
          
        }
        public void SetUsersFromFile()
        {
            Users = JsonConvert.DeserializeObject<List<YoutubeSubscriber>>(File.ReadAllText("Users.json"));
        }

       

        public YoutubeSubscriber GetUserByUsername(string Username)
        {
            return Users.SingleOrDefault(x => x.Username == Username);
        }

      
        public void AddUser(YoutubeSubscriber u)
        {
            Users.Add(u);
            string fileName = "Users.json";
            string jsonString = JsonConvert.SerializeObject(Users);
            File.WriteAllText(fileName, jsonString);
        }
        public void Update()
        {
            string fileName = "Users.json";
            string jsonString = JsonConvert.SerializeObject(Users);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
