using DAL1;
using DTO1;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBMovieBLL
    {
        private DoubleT db;
        private static TBMovieBLL _instance;
        public static TBMovieBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBMovieBLL();
                return _instance;
            }
            set { }
        }
        public TBMovieDTO GetMovie(int id_movie)
        {
            using(db=new DoubleT())
            {
                TBMovie movie = db.TBMovies.Where(p => p.movie_id == id_movie).FirstOrDefault();
                TBMovieDTO movieDTO = new TBMovieDTO();
                if (movie != null)
                {
                    movieDTO.movie_id = movie.movie_id;
                    movieDTO.movie_name = movie.movie_name;
                    movieDTO.movie_description = movie.movie_description;
                    movieDTO.movie_director = movie.movie_director;
                    movieDTO.movie_nation = movie.movie_nation;
                    movieDTO.movie_length = movie.movie_length;
                    movieDTO.movie_release = movie.movie_release;
                    movieDTO.movie_price = movie.movie_price;
                    movieDTO.movie_genres = movie.TBMovieGenre.movie_genres;
                    movieDTO.movie_image = movie.movie_image;
                }

                return movieDTO;
            }
            
        }
        public List<string> GetListImgageMovie()
        {
            using(db=new DoubleT())
            {
                List<string> list = db.TBMovies.Select(p => p.movie_image).ToList();
                return list;
            }
            
        }
        public string GetNameMovie(int movie_id)
        {
            using(db=new DoubleT())
            {
                string result = db.TBMovies.Where(p => p.movie_id == movie_id).Select(p => p.movie_name).FirstOrDefault().ToString();
                if (result != null)
                {
                    return result;
                }
                return "";
            }
        }
        public int GetPrice(int movie_id)
        {
            using(db=new DoubleT())
            {
                int result = db.TBMovies.Where(p => p.movie_id == movie_id).Select(p => p.movie_price).FirstOrDefault();
                return result;
            }
        }
        public List<int> GetListMovie_id()
        {
            using(db=new DoubleT())
            {
                List<int> list = db.TBMovies.Where(p => p.is_deleted == false).Select(p => p.movie_id).ToList();

                return list;
            }
            
        }
        public string GetImageMovie(int movie_id)
        {
            using(db=new DoubleT())
            {
                string result = db.TBMovies.Where(p => p.movie_id == movie_id).Select(p => p.movie_image).FirstOrDefault();
                return result;
            }
        }
        public List<int> GetMovieByName(string name)
        {
            using(db=new DoubleT())
            {
                List<int> list = new List<int>();
                List<TBMovie> movies=db.TBMovies.ToList();
                foreach(TBMovie movie in movies)
                {
                    if (movie.movie_name.IndexOf(name,StringComparison.OrdinalIgnoreCase)>=0)
                    {
                        list.Add(movie.movie_id);
                    }
                }
                return list;
            }
           
        }
        public List<int> GetMovieByMovieGenres(TBMovieGenreDTO movie_genre)
        {
            using(db=new DoubleT())
            {
                List<int> list=new List<int>();
                List<TBMovie> movies=db.TBMovies.Where(p=>p.TBMovieGenre.movie_genres==movie_genre.movie_genres).ToList();
                foreach(TBMovie movie in movies)
                {
                    if (movie.is_deleted == false)
                    {
                        list.Add(movie.movie_id);
                    }
                }
                return list;
            }
        }
        public List<TBMovieStatiticsDTO> GetStatitics()
        {
            using (db=new DoubleT())
            {
               List<TBMovieStatiticsDTO> list=new List<TBMovieStatiticsDTO>();
                var query = from movie in db.TBMovies
                            join schedule in db.TBSchedules
                            on movie.movie_id equals schedule.movie_id
                            join receipt in db.TBReceipts on schedule.schedule_id equals receipt.schedule_id
                            group receipt by new
                            {
                                movie.movie_id,
                                movie.movie_name
                            } into g
                            select new TBMovieStatiticsDTO
                            {
                                movie_name=g.Key.movie_name,
                                number_of_ticket = g.Sum(x => x.number_of_tickets),
                                total_price = g.Sum(x => x.total_price)
                            };
                list=query.ToList();
                
                return list;
            }
        }
    }
}
