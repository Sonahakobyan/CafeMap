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
        private List<Cafe> cafes;
        private static List<User> users = new List<User>();

        public User (string username,string password)
        {
            Username = username;
            Password = password;
            users.Add(this);
        }

        public void WriteReview(Review review)
        {
            review.Cafe.Reviews.Add(review);
        }

        public static bool Check(string username,string password)
        {
            foreach(User user in users)
            {
                if (user.Username == username && user.Password == password)
                    return true;
            }
            return false; 
        }
    }
}
