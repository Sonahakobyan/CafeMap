using System;
using System.Collections;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;

namespace Map
{
    abstract class Building : IHasLocation, IHasPopularTime, IHasReview
    {
        public GeoCoordinate Location { get; }
        public string Name { get; }     
        public List<DateTime> Orders { get; }
        public List<int> Reviews { get; }
        public string Website { get; }
        public string Description { get; }
        public string Phone { get; }
        //TODO: worktime

        public Building(string name, string website, string description, string phone, double latitude,double longtiude)
        {
            Name = name;
            Website = website;
            Description = description;
            Phone = phone;
            Location = new GeoCoordinate(latitude, longtiude);
            Orders = new List<DateTime>();
            Reviews = new List<int>();
        }

        

        public void AddOrder()
        {
            Orders.Add(DateTime.Now);
        }

        public void AddOrder(DateTime date)
        {
            Orders.Add(date);
        }

        public void AddReview(int score)
        {
            if (score >= 1 && score <= 5)
                Reviews.Add(score-1);
        }

        public abstract ArrayList GetNearbies(ArrayList list);
        

        public int[] GetReviews()
        {
            int[] reviews = new int[5];
            foreach(int review in Reviews)
            {
                reviews[review]++;
            }
            return reviews;
        }

        public string OrderHistogram()
        {
            if (Orders.Count == 0)
                return null;
            string histogram = "";
            int[] orders = new int[7];
            foreach (DateTime order in Orders)
            {
                orders[(int)order.DayOfWeek]++;
            }
            int max = orders.Max();
            int y = (max < 5) ? max : 5;
            bool[,] gram = new bool[max + 1, 7];
            for (int i = 0; i < orders.Length; i++)
            {
                double tmp = (double)orders[i] / max * y;
                orders[i] = (int)Math.Round(tmp);
            }

            for(int i = 0; i < 7; i++)
            {
                int count = orders[i];
                for(int j = 0; j <= count; j++)
                {
                    gram[j, i] = true;
                }
            }

            for(int i=y; i>= 0; i--)
            {
                for(int j=0;j<7;j++)
                {
                    histogram += (gram[i, j]) ? "*" : " "; 
                }
                histogram += "\r\n";
            }

            return histogram;
        }

        public DayOfWeek PopularDay()
        {
            if (Orders.Count == 0)
                return DayOfWeek.Monday;

            int[] orders = new int[7];
            foreach(DateTime order in Orders)
            {
                orders[(int)order.DayOfWeek]++;
            }
            int max = orders.Max();
            int maxIndex = Array.IndexOf(orders, max);
            return (DayOfWeek)maxIndex;
        }
    }
}
