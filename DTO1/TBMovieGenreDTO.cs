using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO1
{
    public class TBMovieGenreDTO
    {
        public int movie_genres_id { get; set; }
        public string movie_genres { get; set; }
        public override string ToString()
        {
            return movie_genres;
        }
        
    }
}
