﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO1
{
    public class TBSeatBookingDTO
    {
        public Nullable<int> seat_booking_id { get; set; }
        public int schedule_id { get; set; }
        public int seat_id { get; set; }
        public int receipt_id { get; set; }
    }
}
