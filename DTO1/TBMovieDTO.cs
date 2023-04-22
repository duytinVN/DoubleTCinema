using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO1
{
    public class TBMovieDTO
    {
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public string movie_director { get; set; }
        public string movie_genres { get; set; }
        public int movie_length { get; set; }
        public DateTime movie_release { get; set; }
        public string movie_nation { get; set; }
        public string movie_description { get; set; }
        public string movie_image { get; set; }
        public int movie_price { get; set; }
    }
}
