using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;

namespace Map
{
    class Cafe
    {
        public string Name { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        static List<Cafe> Cafes = new List<Cafe>();
        public WorkTime Work;
        public Address Location;
        // public string PopularTime { get; set; }
        public List<Review> Reviews;

        public Cafe (string name, double latitude, double longtiude)
        {
            Name = name;
            Location.Coords = new GeoCoordinate(latitude, longtiude);

        }
        public List<Cafe> Nearby()
        {
            List<Cafe> nearbies = new List<Cafe>();
            foreach(Cafe cafe in Cafes)
            {
                if (this.Location.Coords.GetDistanceTo(cafe.Location.Coords) <= 1000 &&
                    this.Name != cafe.Name)
                    nearbies.Add(cafe);
            }
            return nearbies;
        }
        public struct WorkTime
        {
            DateTime Open;
            DateTime Close;
        }
        public struct Address
        {
            public string City;
            public string Street;
            public string Building;
            public GeoCoordinate Coords;
        }
        
    }
}
