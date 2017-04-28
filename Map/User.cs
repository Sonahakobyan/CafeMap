using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    class User
    {
        public string Name { get; set; }
        private List<Cafe> cafes;

        public void WriteReview(Review review)
        {
            review.Cafe.Reviews.Add(review);
        }
    }
}
