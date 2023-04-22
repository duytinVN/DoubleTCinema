using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Data.Entity.Migrations;

namespace BLL1
{
    
    public class TBStaffBLL
    {
        private DoubleT db;
        private static TBStaffBLL _instance;
        public static int id = -1;
        public static int pass=-1;
        public static TBStaffBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBStaffBLL();
                return _instance;
            }
            set { }
        }

        public void SetStaff_id(int staff_id)
        {
            id = staff_id;
        }
        public int GetId()
        {
            return id;
        }
        public bool CheckLogin(string username, string password)
        {
            using(db = new DoubleT())
            {
                string hass = BCrypt.Net.BCrypt.HashPassword(password, 10);
                TBStaff staff = db.TBStaffs.Where(p => p.username == username).FirstOrDefault();
                if (staff != null)
                {
                    bool ck = BCrypt.Net.BCrypt.Verify(password, staff.pwd);
                    if (ck == false)
                    {
                        return false;
                    }
                    else
                    {
                        SetStaff_id(staff.staff_id);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }            
        }
        public string ShowErrorLogin(string username, string password)
        {
            using(db = new DoubleT())
            {
                TBStaff staff = db.TBStaffs.Where(p => p.username == username).FirstOrDefault();
                if (staff != null)
                {
                    bool ck = BCrypt.Net.BCrypt.Verify(password, staff.pwd);
                    if (ck == false)
                    {
                        return "Sai mật khẩu";
                    }

                }
                else
                {
                    return "Không tìm thấy tài khoản cần tìm";
                }
                return null;
            }
        }
        public bool CheckEmail(string Email)
        {
            using(db=new DoubleT())
            {
                TBStaff staff = db.TBStaffs.Where(p => p.email == Email).FirstOrDefault();
                if (staff == null)
                {
                    
                    return false;
                }
                id = staff.staff_id;
                return true;
            }
            
        }
        public bool CheckPass(int check)
        {
            if (pass == check)
            {
                return true;
            }
            return false;
        }
        public void SetPass()
        {
            Random rand=new Random();
            pass = rand.Next(1000, 10000);
        }
        public void SendEmail(string Email)
        {
            var fromAddress = new MailAddress("hdtkcnp2412@gmail.com");
            var toAddress = new MailAddress(Email);
            const string fromPassword = "ucbtyuopeziedtgf";
            const string subject = "Gửi mã xác nhận đổi mật khẩu";
            string body = "Mã xác nhận cho bạn là: "+pass.ToString();

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        public void RePass(string txt)
        {
            string hass=BCrypt.Net.BCrypt.HashPassword(txt);
            using(db=new DoubleT())
            {
                TBStaff staff=db.TBStaffs.Where(p=>p.staff_id==id).FirstOrDefault();
                staff.pwd = hass;
                db.TBStaffs.AddOrUpdate(staff);
                db.SaveChanges();
            }
        }
        public string GetStaffName(int staff_id)
        {
            string result = "";
            using (db = new DoubleT())
            {
                result = db.TBStaffs.Where(p => p.staff_id == staff_id).Select(p => p.staff_name).FirstOrDefault();

            }
            return result;
        }
    }
}
