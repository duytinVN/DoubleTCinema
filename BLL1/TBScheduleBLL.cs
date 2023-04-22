using DAL1;
using DTO1;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBScheduleBLL
    {
        private DoubleT db;
        private static TBScheduleBLL _instance;
        public static TBScheduleBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBScheduleBLL();
                return _instance;
            }
            set { }
        }
        public string GetShowTimes(int schedule_id)
        {
            using(db=new DoubleT())
            {
                TBSchedule schedule=db.TBSchedules.Where(p=>p.schedule_id==schedule_id).FirstOrDefault();
                string temp= schedule.schedule_start.ToString("hh\\:mm") + " ~ " + schedule.schedule_end.ToString("hh\\:mm"); ;
                return temp;
            }
        }
        public int GetMovie_id(int schedule_id)
        {
            using(db=new DoubleT())
            {
                int movie_id = db.TBSchedules.Where(p => p.schedule_id == schedule_id).Select(p => p.movie_id).FirstOrDefault().Value;
                return movie_id;
            }
        }
        public DateTime GetScheduleDate(int schedule_id)
        {
            using(db=new DoubleT())
            {
                DateTime date = db.TBSchedules.Where(p => p.schedule_id == schedule_id).Select(p => p.schedule_date).FirstOrDefault();
                return date;
            }
        }
        public int GetRoomId(int schedule_id)
        {
            using(db=new DoubleT())
            {
                int room_id = db.TBSchedules.Where(p => p.schedule_id == schedule_id).Select(p => p.room_id).FirstOrDefault();
                return room_id;
            }
        }
        public List<TBScheduleDTO> GetListSchedule(DateTime date,int movie_id)
        {
            using(db=new DoubleT())
            {
                List<TBScheduleDTO> list = new List<TBScheduleDTO>();
                List<TBSchedule> result = db.TBSchedules.Where(p => (p.movie_id == movie_id)).ToList();
                foreach (TBSchedule i in result)
                {
                    if (i.schedule_date.ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"))
                    {
                        list.Add(new TBScheduleDTO
                        {
                            schedule_id = i.schedule_id,
                            schedule_date = i.schedule_date,
                            schedule_start = i.schedule_start,
                            schedule_end = i.schedule_end,
                            movie_id = i.TBMovie.movie_id,
                            room_id = i.TBRoom.room_id,
                            schedule_price_percent = i.schedule_price_percent,
                            room_type = i.TBRoom.TBRoomType.room_type_name == "2D" ? true : false
                        });
                    }
                }
                return list;
            }            
        }
        public TBScheduleDTO GetScheduleDTO(int schedule_id)
        {
            using(db=new DoubleT())
            {
                TBScheduleDTO result = new TBScheduleDTO();
                TBSchedule schedule = db.TBSchedules.Where(p => p.schedule_id == schedule_id).FirstOrDefault();
                if (schedule != null)
                {
                    result.schedule_id = schedule.schedule_id;
                    result.schedule_date = schedule.schedule_date;
                    result.schedule_start = schedule.schedule_start;
                    result.schedule_end = schedule.schedule_end;
                    result.schedule_price_percent = schedule.schedule_price_percent;
                    result.movie_id = schedule.TBMovie.movie_id;
                    result.room_id = schedule.TBRoom.room_id;
                }
                return result;
            }
        }
        public int GetSchedule_PricePercent(int schedule_id)
        {
            using(db= new DoubleT())
            {
                int result = db.TBSchedules.Where(p => p.schedule_id == schedule_id).Select(p => p.schedule_price_percent).FirstOrDefault();
                return result;
            }
        }
        public int GetPrice(int schedule_id)
        {
            using(db=new DoubleT())
            {
                int price = 0;
                int movie_price = 0;
                int room_price_percent = 0;
                int schedule_price_percent = 0;
                TBSchedule schedule = db.TBSchedules.Where(p => p.schedule_id == schedule_id).FirstOrDefault();
                if (schedule != null)
                {
                    movie_price = TBMovieBLL.Instance.GetPrice(schedule.TBMovie.movie_id);
                    room_price_percent = TBRoomBLL.Instance.GetRoomPricePercent(schedule.TBRoom.room_id);
                    schedule_price_percent = TBScheduleBLL.Instance.GetSchedule_PricePercent(schedule.schedule_id);
                    price = movie_price + movie_price * room_price_percent / 100 + movie_price * schedule_price_percent / 100;
                }
                return price;
            }
        }
    }
}
