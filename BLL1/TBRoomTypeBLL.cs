using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBRoomTypeBLL
    {
        private DoubleT db;
        private static TBRoomTypeBLL _instance;
        public static TBRoomTypeBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBRoomTypeBLL();
                return _instance;
            }
            set { }
        }
        public int GetRoomTypePricePercent(int  roomType_id)
        {
            using(db=new DoubleT())
            {
                int result = db.TBRoomTypes.Where(p => p.room_type_id == roomType_id).Select(p => p.room_type_price_percent).FirstOrDefault();
                return result;
            }
        }
    }
}
