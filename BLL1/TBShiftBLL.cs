using DAL1;
using DTO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBShiftBLL
    {
        private DoubleT db;
        private static TBShiftBLL _instance;
        public static TBShiftBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBShiftBLL();
                return _instance;
            }
            set { }
        }
        public string GetTimes(int id_shifttime)
        {
            using(db=new DoubleT())
            {
                TBShifttime time=db.TBShifttimes.Where(p=>p.shifttime_id==id_shifttime).FirstOrDefault();
                string temp= time.shift_start.ToString("hh\\:mm") + " ~ " + time.shift_end.ToString("hh\\:mm");
                return temp;
            }
        }
        
        public List<TBShiftDTO> GetListShift(DateTime date)
        {
            using(db=new DoubleT())
            {
                List<TBShiftDTO> list = new List<TBShiftDTO>();
                int id = TBStaffBLL.Instance.GetId();
                List<TBShift> shift=db.TBShifts.Where(p=>( p.staff_id==id)).ToList();
                foreach(TBShift i in shift)
                {
                    string temp = i.shift_date.ToString("dd/MM/yyyy");
                    string temp2 = date.ToString("dd/MM/yyyy");
                    if (temp==temp2)
                    {
                        string text = GetTimes(i.TBShifttime.shifttime_id);
                        list.Add(new TBShiftDTO
                        {
                            shift_id = i.shift_id,
                            shift_time = text,
                            staff_name = TBStaffBLL.Instance.GetStaffName(i.staff_id),
                            shift_date = date.ToString("dd/MM/yyyy")
                        });
                    }
                }
                return list;
            }
        }
        
    }
}
