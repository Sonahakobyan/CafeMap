using System;
using System.Collections;
using System.Collections.Generic;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cafe> cafes = new List<Cafe>();
            cafes.Add(new Cafe("CINNABON", "http://www.cinnabon.com", "Baking cinnamon cookies. Cafe", "+374-93-545903", 40.181931, 44.514474));
            cafes.Add(new Cafe("JOSE", "http://www.facebook.com/josearmenia", "Restaurant, lounge cafe, show club, steak restaurant", "+374-91-540020", 40.175241, 44.521204));
            cafes.Add(new Cafe("MALOCCO", "http://www.facebook.com/maloccocafe", "kayfod cafe cascadeum", "+374-99-531327", 40.186641, 44.511876));
            cafes.Add(new Cafe("PAPARAZZI", "http://www.facebook.com/pages/Camino-muz-club/1430913243882164", "of t@ esim e ", "+374-55-444144", 40.181279, 44.515671));
            cafes.Add(new Cafe("TASHIR PIZZA", "http://www.tashirpizza.am", "Chain pizzeria. Pizza delivery service", "+374-11-251111", 40.180817, 44.514335));

            cafes[0].AddOrder();
            cafes[0].AddOrder(new DateTime(2017, 1, 18));
            cafes[0].AddOrder(new DateTime(2017, 1, 17));
            cafes[0].AddOrder(new DateTime(2017, 1, 18));
            cafes[0].AddOrder(new DateTime(2017, 1, 18));
            foreach (Building building in cafes[1].GetNearbies(new ArrayList(cafes)))
            {
                Console.WriteLine(building.Name);
                Console.WriteLine(building.Website);
                Console.WriteLine(building.Description);
                Console.WriteLine(building.Phone);
                Console.WriteLine(building.PopularDay());
                Console.WriteLine(building.OrderHistogram());
            }
        }
    }
}
