using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCModelBinding.Models
{
    public class Movie
    {
        public string Title { get; set; }

        public string ReleaseYear { get; set; }

        public string Genre { get; set; }

        public string Rating { get; set; }

        public int Length { get; set }

    }
}
