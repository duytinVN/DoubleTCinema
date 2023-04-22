using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO1
{
    public class TBSeatDTO
    {
        public int seat_id { get; set; }
        public string seat_name { get; set; }
        public int room_id { get; set; }
        public string seat_type_name { get; set; }
        public int seat_type_price_percent { get; set; }
        
    }
}
