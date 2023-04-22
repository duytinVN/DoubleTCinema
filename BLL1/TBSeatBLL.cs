using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBSeatBLL
    {
        private DoubleT db;
        private static TBSeatBLL _instance;
        public static TBSeatBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBSeatBLL();
                return _instance;
            }
            set { }
        }
        public string GetSeatType(string seat_name,int room_id)
        {
            using(db=new DoubleT())
            {
                TBSeat seat=db.TBSeats.Where(p=>(p.seat_name==seat_name && p.room_id==room_id)).FirstOrDefault();
                if (seat != null)
                {
                    if (seat.TBSeatType.seat_type_id == 1000)
                    {
                        return "VIP";
                    }
                    else
                    {
                        return "Regular";
                    }
                }
                else
                {
                    return "";
                }
            }
        }
        public string GetSeatName(int seat_id)
        {
            using(db=new DoubleT())
            {
                string result = db.TBSeats.Where(p => p.seat_id == seat_id).Select(p => p.seat_name).FirstOrDefault();
                return result;
                
            }
        }
        public string GetRoomName(int seat_id)
        {
            using(db=new DoubleT())
            {
                string result=db.TBSeats.Where(p=>p.seat_id==seat_id).Select(p=>p.TBRoom.room_name).FirstOrDefault().ToString();
                return result;
            }
        }
        public int GetSeat_id(string seat_name,int room_id)
        {
            using(db=new DoubleT())
            {
                int id = db.TBSeats.Where(p => p.seat_name == seat_name && p.room_id==room_id).Select(p => p.seat_id).FirstOrDefault();
                return id;
            }  
        }
        public int GetPricePersent(int seat_id)
        {
            using(db=new DoubleT())
            {
                int result=db.TBSeats.Where(p=>p.seat_id==seat_id).Select(p=>p.TBSeatType.seat_type_price_percent).FirstOrDefault();
                return result;
            }
        }
        public int GetPricePersent(bool isVip)
        {
            using(db=new DoubleT())
            {
                if (isVip)
                {
                    TBSeatType seatType = db.TBSeatTypes.Where(p => p.seat_type_name.ToString() == "VIP").FirstOrDefault();
                    if (seatType != null)
                    {
                        return seatType.seat_type_price_percent;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    TBSeatType seatType = db.TBSeatTypes.Where(p => p.seat_type_name.ToString() == "Regular").FirstOrDefault();
                    if (seatType != null)
                    {
                        return seatType.seat_type_price_percent;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }
}
