
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    interface IHasReview
    {
        List<int> Reviews { get; }
        int[] GetReviews();
        void AddReview(int score);      
    }
}
