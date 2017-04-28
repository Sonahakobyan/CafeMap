using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{

    class Review
    {
        public Cafe Cafe { get; set; }
        public Int16 Score { get; set; }


        public Review(Cafe cafe ,Int16 score)
        {
            Cafe = cafe;
            Score = score;
        }
    }
}
