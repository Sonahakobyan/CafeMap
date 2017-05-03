using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    class User
    {
        public string FirstName { get; }
        public string LastName { get; }
        public List<Cafe> Buildings;

        public User()
        {
            
        }


        public User (string firstname,string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Buildings = new List<Cafe>();
        }

        //functions

        public static User Check(List<User> users, string firstname,string lastname)
        {
            foreach(User user in users)
            {
                if (user.FirstName == firstname && user.LastName == lastname)
                    return user;
            }
            return null; 
        }

        public void AddBuilding(Cafe building)
        {
            Buildings.Add(building);
        }

        public List<Cafe> GetSavedCafes()
        {
            return Buildings;
        }
        
    }
}
