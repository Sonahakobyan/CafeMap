using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    interface IHasPopularTime
    {
        List<DateTime> Orders { get; }
        void AddOrder(DateTime date);
        void AddOrder();
        string OrderHistogram();
        DayOfWeek PopularDay();
    }
}
