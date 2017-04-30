using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        private List<Cafe> favCafes;
        private static List<User> users = new List<User>();

        public User (string username,string password)
        {
            Username = username;
            Password = password;
            users.Add(this);
        }

        //functions

        public static bool Check(string username,string password)
        {
            foreach(User user in users)
            {
                if (user.Username == username && user.Password == password)
                    return true;
            }
            return false; 
        }

        public void AddCafe(Cafe cafe)
        {
            favCafes.Add(cafe);
        }

        public List<Cafe> GetSavedCafes()
        {
            return favCafes;
        }
        
    }
}
