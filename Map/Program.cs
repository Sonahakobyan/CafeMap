using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            bool FirstMenu = true;
            while(FirstMenu)
            {
                Console.WriteLine("### Log In ###");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                if(User:check(username, password)) // TODO: Implement User::Check method
                {
                    FirstMenu = false;
                }
            }
        }
    }
}
