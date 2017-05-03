using System;
using System.Collections;
using System.Collections.Generic;

namespace Map
{
    class Program
    {
        static List<Cafe> cafes;
        static List<User> users;
        static User loggedIn;
        static void Main(string[] args)
        {

            cafes = new List<Cafe>();
            cafes.Add(new Cafe("CINNABON", "http://www.cinnabon.com", "Baking cinnamon cookies. Cafe", "+374-93-545903", 40.181931, 44.514474));
            cafes.Add(new Cafe("JOSE", "http://www.facebook.com/josearmenia", "Restaurant, lounge cafe, show club, steak restaurant", "+374-91-540020", 40.175241, 44.521204));
            cafes.Add(new Cafe("MALOCCO", "http://www.facebook.com/maloccocafe", "kayfod cafe cascadeum", "+374-99-531327", 40.186641, 44.511876));
            cafes.Add(new Cafe("PAPARAZZI", "http://www.facebook.com/pages/Camino-muz-club/1430913243882164", "of t@ esim e ", "+374-55-444144", 40.181279, 44.515671));
            cafes.Add(new Cafe("TASHIR PIZZA", "http://www.tashirpizza.am", "Chain pizzeria. Pizza delivery service", "+374-11-251111", 40.180817, 44.514335));

            users = new List<User>();
            users.Add(new User("Sona", "Hakobyan"));
            users.Add(new User("Anna", "Simonyan"));
            users.Add(new User("Meruzhan", "Hovhannisyan"));

            cafes[0].AddOrder();
            cafes[0].AddOrder(new DateTime(2017, 1, 18));
            cafes[0].AddOrder(new DateTime(2017, 1, 17));
            cafes[0].AddOrder(new DateTime(2017, 1, 18));
            cafes[0].AddOrder(new DateTime(2017, 1, 18));

            loggedIn = new User();
            bool login = false;
            while (!login)
            {
                Console.WriteLine("#### Please Login #####");
                Console.Write("FirstName: ");
                string firstname = Console.ReadLine();
                Console.Write("LastName: ");
                string lastname = Console.ReadLine();
                loggedIn = User.Check(users, firstname, lastname);
                if (loggedIn != null)
                {
                    login = true;
                }
            }
            ShowMenu();
            
        }

        static void ShowMenu()
        {
            
            bool menu = true;
            bool cafeList = false;
            while (menu)
            {
                Console.WriteLine("Hello {0} {1}", loggedIn.FirstName, loggedIn.LastName);
                Console.WriteLine("1. See Saved Cafes");
                Console.WriteLine("2. See All Cafes");
                Console.WriteLine("3. Find Cafe By Name");
                Console.WriteLine("4. Find Cafe By Address");
                Console.WriteLine("5. Exit");
                Console.Write("Select Number: ");
                int choosen = Convert.ToInt32(Console.ReadLine());
                switch (choosen)
                {
                    case 1:
                        for (int i = 1; i <= loggedIn.Buildings.Count; i++)
                        {
                            Console.WriteLine("{0}. {1}", i, loggedIn.Buildings[i - 1]);
                        }
                        menu = false;
                        break;
                    case 2:
                        for (int i = 1; i <= cafes.Count; i++)
                        {
                            Console.WriteLine("{0}. {1}", i, cafes[i - 1]);
                        }
                        cafeList = true;
                        menu = false;
                        break;
                    case 3:
                        Console.WriteLine("In Development");
                        break;
                    case 4:
                        Console.WriteLine("In Development");
                        break;
                    case 5:
                        return;
                    default:
                        break;
                }

            }

            while (cafeList)
            {
                Console.Write("Select Number of Cafe(0 to exit): ");
                int choosen = Convert.ToInt32(Console.ReadLine());
                if (choosen == 0) return;
                if (choosen >= 1 && choosen <= cafes.Count)
                {
                    Console.WriteLine(cafes[choosen - 1].Name);
                    Console.WriteLine(cafes[choosen - 1].Website);
                    Console.WriteLine(cafes[choosen - 1].Description);
                    Console.WriteLine(cafes[choosen - 1].Phone);
                    Console.WriteLine(cafes[choosen - 1].PopularDay());
                    Console.WriteLine(cafes[choosen - 1].OrderHistogram());
                    Console.Write("If you want to Add Cafe to Your Saved List: write yes or no: ");
                    string choose = Console.ReadLine();
                    if (choose == "yes") loggedIn.AddBuilding(cafes[choosen - 1]);
                    Console.Write("If you want to see nearbies: write yes or no: ");
                    choose = Console.ReadLine();
                    if (choose == "yes")
                    {
                        foreach (Cafe cafe in cafes[choosen - 1].GetNearbies(cafes))

                            Console.WriteLine(cafe);
                    }
                    ShowMenu();
                }
            }
        }
    }
}
