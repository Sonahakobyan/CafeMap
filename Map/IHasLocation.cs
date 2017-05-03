using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;
using System.Collections;
namespace Map
{
    interface IHasLocation
    {
        string Name { get; } 
        GeoCoordinate Location { get; }
        List<Cafe> GetNearbies(List<Cafe> list);
           
    }
}
