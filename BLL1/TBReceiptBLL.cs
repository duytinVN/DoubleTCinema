using DAL1;
using DTO1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBReceiptBLL
    {
        private DoubleT db;
        private static TBReceiptBLL _instance;
        public static TBReceiptBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBReceiptBLL();
                return _instance;
            }
            set { }
        }
        public TBReceiptDTO GetReceiptDTO(int receipt_id)
        {
            using(db=new DoubleT())
            {
                TBReceiptDTO ret = new TBReceiptDTO();
                TBReceipt get=db.TBReceipts.Where(p=>p.receipt_id==receipt_id).FirstOrDefault();
                if (get != null)
                {
                    ret.receipt_id = get.receipt_id;
                    ret.total_price = get.total_price;
                    ret.staff_id = get.staff_id;
                    ret.customer_id= get.customer_id;
                    ret.datetime_booking= get.datetime_booking;
                    ret.number_of_tickets= get.number_of_tickets;
                    ret.schedule_id= get.schedule_id;
                }
                return ret;
            }
        }
        
        public int SaveReceipt(TBReceiptDTO tBReceiptDTO)
        {
            using(db=new DoubleT())
            {
                TBReceipt receipt = new TBReceipt();
                receipt.total_price = tBReceiptDTO.total_price;
                receipt.datetime_booking = tBReceiptDTO.datetime_booking;
                if (tBReceiptDTO.customer_id != null)
                {
                    receipt.customer_id = tBReceiptDTO.customer_id;
                }
                receipt.number_of_tickets = tBReceiptDTO.number_of_tickets;
                receipt.schedule_id = tBReceiptDTO.schedule_id;
                receipt.staff_id = tBReceiptDTO.staff_id;
                db.TBReceipts.Add(receipt);
                db.SaveChanges();
                int id_receip = GetId();
                return id_receip;
            }
        }
        public int GetId()
        {
            using(db=new DoubleT())
            {
                int id = db.TBReceipts.OrderByDescending(p => p.receipt_id).Select(p => p.receipt_id).FirstOrDefault();
                return id;
            }
        }
    }
}
