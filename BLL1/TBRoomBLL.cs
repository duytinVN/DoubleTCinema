using DAL1;
using DTO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBRoomBLL
    {
        private DoubleT db;
        private static TBRoomBLL _instance;
        public static TBRoomBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBRoomBLL();
                return _instance;
            }
            set { }
        }
        public TBRoomDTO GetRoom(int room_id)
        {
            using(db=new DoubleT())
            {
                TBRoomDTO result = new TBRoomDTO();
                TBRoom room = db.TBRooms.Where(p => p.room_id == room_id).FirstOrDefault();
                if (room != null)
                {
                    result.room_id = room.room_id;
                    result.room_number_of_row = room.room_number_of_row;
                    result.room_name = room.room_name;
                    result.room_number_of_seat = room.room_number_of_seat;
                    result.room_type_name = room.TBRoomType.room_type_name;
                    result.room_type_price_percent = room.TBRoomType.room_type_price_percent;
                }
                return result;
            }
        }
        public string GetNameRoom(int room_id)
        {
            using(db=new DoubleT())
            {
                string result = db.TBRooms.Where(p => p.room_id == room_id).Select(p => p.room_name).FirstOrDefault();
                return result;
            }
        }
        public int GetRoomPricePercent(int room_id)
        {
            using (db = new DoubleT())
            {
                int roomtype = db.TBRooms.Where(p => p.room_id == room_id).Select(p => p.TBRoomType.room_type_id).FirstOrDefault();
                int price_percent = TBRoomTypeBLL.Instance.GetRoomTypePricePercent(roomtype);
                return price_percent;
            }
        }
    }
}
