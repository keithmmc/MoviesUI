using MoviesUI.Data;
using System.Collections.Generic;

namespace MoviesUI.Models
{
    public class MovieActors
    {
        public Movie Movie { get; set; }

        public List<Actor> Actors { get; set; }
    }
}
