using DAL1;
using DTO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBMovieGenreBLL
    {
        private DoubleT db;
        private static TBMovieGenreBLL _instance;
        public static TBMovieGenreBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBMovieGenreBLL();
                return _instance;
            }
            set { }
        }
        public List<TBMovieGenreDTO> GetListMovieGenre()
        {
            using(db=new DoubleT())
            {
                List<TBMovieGenreDTO> result = new List<TBMovieGenreDTO>();
                List<TBMovieGenre> list= db.TBMovieGenres.ToList();
                foreach(TBMovieGenre item in list)
                {
                    if(item.is_deleted==false)
                    {
                        result.Add(new TBMovieGenreDTO
                        {
                            movie_genres_id = item.movie_genres_id,
                            movie_genres = item.movie_genres
                        });
                    }
                }
                return result;
            }
            
        }
    }
}
