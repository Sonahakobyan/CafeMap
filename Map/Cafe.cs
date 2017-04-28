using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;

namespace Map
{
    class Cafe
    {
        static List<Cafe> Cafes = new List<Cafe>();
        public string Name { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public WorkTime Work { get; set; }
        public Address Location { get; set; }
        public string PopularTime { get; set; }
        public Cafe (string name)
        {
            Name = name;
        }
        public List<Cafe> Nearby()
        {

        }
        public struct WorkTime
        {
            DateTime Open;
            DateTime Close;
        }
        public struct Address
        {
            string City;
            string Street;
            string Building;
            GeoCoordinate Coords;// = new GeoCoordinate(sLatitude, sLongitude);
        }
        
    }
}
