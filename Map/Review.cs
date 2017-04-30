using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{

    class Review
    {
        public Cafe Cafe { get; set; }
        public byte Score { get; set; }
        public string Description { get; set; }


        public Review(Cafe cafe, byte score,string description = null)
        {
            Cafe = cafe;
            Score = score;
            Description = description;
        }
    }
}
