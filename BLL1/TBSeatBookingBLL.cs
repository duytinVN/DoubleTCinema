using DAL1;
using DTO1;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBSeatBookingBLL
    {
        private DoubleT db;
        private static TBSeatBookingBLL _instance;
        public static TBSeatBookingBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBSeatBookingBLL();
                    
                return _instance;
            }
            set { }
        }
        public List<string> GetSeatBooking(int schedule_id)
        {
            using(db=new DoubleT())
            {
                List<string> list = new List<string>();
                List<TBSeatBooking> temp = db.TBSeatBookings.Where(p => p.schedule_id == schedule_id).ToList();
                foreach (TBSeatBooking b in temp)
                {
                    string result = b.TBSeat.seat_name;
                    list.Add(result);
                }
                return list;
            }
            
        }
        public string GetSeat(List<TBSeatBookingDTO> list)
        {
            using(db=new DoubleT())
            {
                string result = "";
                foreach (TBSeatBookingDTO b in list)
                {
                    result += TBSeatBLL.Instance.GetSeatName(b.seat_id) + " ";
                }
                return result;
            }
            
        }
        public int GetPrice(int seat_booking_id)
        {
            using(db=new DoubleT())
            {
                int result = 0;
                TBSeatBooking seat = db.TBSeatBookings.Where(p => p.seat_booking_id == seat_booking_id).FirstOrDefault();
                if (seat != null)
                {
                    int schedule_price = TBScheduleBLL.Instance.GetPrice(seat.TBSchedule.schedule_id);
                    int movie_price = TBMovieBLL.Instance.GetPrice(TBScheduleBLL.Instance.GetMovie_id(seat.schedule_id.GetValueOrDefault()));
                    int seat_per = TBSeatBLL.Instance.GetPricePersent(seat.seat_id);
                    result = schedule_price+movie_price*seat_per/100;
                }
                return result;
            }
        }
        public List<TBSeatBookingDTO> SetSeatBooking(string seat, int schedule)
        {
            using(db=new DoubleT())
            {
                int room_id = TBScheduleBLL.Instance.GetRoomId(schedule);
                List<TBSeatBookingDTO> list = new List<TBSeatBookingDTO>();
                List<string> temp = seat.Split(' ').ToList();
                foreach (string i in temp)
                {
                    list.Add(new TBSeatBookingDTO
                    {
                        seat_id = TBSeatBLL.Instance.GetSeat_id(i,room_id),
                        schedule_id = schedule,
                        
                    });
                }
                return list;
            }
            
        }
        public void SaveBooking(List<TBSeatBookingDTO> list)
        {
            using(db=new DoubleT())
            {
                foreach (TBSeatBookingDTO b in list)
                {
                    TBSeatBooking result = new TBSeatBooking
                    {
                        seat_id = b.seat_id,
                        receipt_id = b.receipt_id,
                        schedule_id = b.schedule_id,
                        is_deleted = false,

                    };
                    db.TBSeatBookings.Add(result);
                    db.SaveChanges();
                }
            }
        }
        public List<TBSeatBookingDTO> GetListSeatBooking(int receipt_id)
        {
            using(db=new DoubleT())
            {
                List<TBSeatBookingDTO> list = new List<TBSeatBookingDTO>();
                List<TBSeatBooking> result=db.TBSeatBookings.Where(p=>p.receipt_id==receipt_id && p.is_deleted==false).ToList();
                foreach(TBSeatBooking i in result)
                {
                    list.Add(new TBSeatBookingDTO
                    {
                        seat_booking_id = i.seat_booking_id,
                        receipt_id = i.receipt_id,
                        seat_id=i.seat_id,
                        schedule_id=i.TBSchedule.schedule_id,
                    });
                }
                return list;
            }
        }
    }
}
