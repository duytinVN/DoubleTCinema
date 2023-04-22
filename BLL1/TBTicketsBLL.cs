using DAL1;
using DTO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBTicketsBLL
    {
        private static TBTicketsBLL _instance;
        public static TBTicketsBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBTicketsBLL();
                return _instance;
            }
            set { }
        }

        public List<TBTicketsDTO> GetListTickets(int receipt_id)
        {
            using(var db=new DoubleT())
            {
                List<TBTicketsDTO> result=new List<TBTicketsDTO>();
                List<TBSeatBookingDTO> Seats=TBSeatBookingBLL.Instance.GetListSeatBooking(receipt_id);
                foreach(TBSeatBookingDTO s in Seats)
                {
                    int temp=s.seat_booking_id.GetValueOrDefault();
                    
                    result.Add(new TBTicketsDTO
                    {
                        seat_name=TBSeatBLL.Instance.GetSeatName(s.seat_id),
                        room_name=TBSeatBLL.Instance.GetRoomName(s.seat_id),
                        schedule_date=TBScheduleBLL.Instance.GetScheduleDate(s.schedule_id),
                        movie_name=TBMovieBLL.Instance.GetNameMovie(TBScheduleBLL.Instance.GetMovie_id(s.schedule_id)),
                        ticket_id=s.seat_booking_id.GetValueOrDefault(),
                        schedule_time=TBScheduleBLL.Instance.GetShowTimes(s.schedule_id),
                        price=TBSeatBookingBLL.Instance.GetPrice(temp),
                        receipt_id=s.receipt_id
                    });
                }
                return result;
            }
        }
    }
}
