using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class BigViewModel
    {
        public Movie Movie { get; set; }
        public List<Review> Review { get; set; }

        public string Name;
        public string ReviewText;

    }
}
