using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;
using System.Collections;

namespace Map
{
    class Cafe : Building
    {
        public Cafe(string name, string website, string description, string phone, double latitude, double longtiude) : base(name, website, description, phone, latitude, longtiude)
        {
        }
        /*
        public List<Cafe> FindCafesByName(string name)
        {
            List<Cafe> foundCafes = new List<Cafe>();
            foreach (Cafe cafe in Cafes)
            {
                if (cafe.Name == name)
                    foundCafes.Add(cafe);
            }
            return foundCafes;
        }


        public List<Cafe> FindCafesByAddress(Address address)
        {
            List<Cafe> foundCafes = new List<Cafe>();
            foreach (Cafe cafe in Cafes)
            {
                if (cafe.Location.City == address.City || cafe.Location.Street == address.Street
                    || cafe.Location.Building == address.Building)
                    foundCafes.Add(cafe);
            }
            return foundCafes;
        }


        public Cafe FindCafeByCoords(GeoCoordinate coords)
        {
            Cafe foundCafe = null;
            foreach (Cafe cafe in Cafes)
            {
                if (cafe.Location.Coords == coords)
                    foundCafe = cafe;
            }
            return foundCafe;
        }
        */
        public override ArrayList GetNearbies(ArrayList list)
        {
            ArrayList nearbies =  new ArrayList();
            foreach(Building obj in list)
            {
                if (Location.GetDistanceTo(obj.Location) <= 1000 &&
                    Name != obj.Name)
                    nearbies.Add(obj);
            }
            return nearbies;
        }
    }
}
