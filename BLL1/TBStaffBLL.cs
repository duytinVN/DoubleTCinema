using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    
    public class TBStaffBLL
    {
        private DoubleT db=new DoubleT();
        private static TBStaffBLL _instance;
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
        public bool CheckLogin(string username, string password)
        {
            string hass = BCrypt.Net.BCrypt.HashPassword(password,10);
            TBStaff staff= db.TBStaffs.Where(p=>p.username == username).FirstOrDefault();
            if (staff != null)
            {
                bool ck = BCrypt.Net.BCrypt.Verify(password, staff.pwd);
                if(ck==false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            
        }
        public string ShowErrorLogin(string username, string password)
        {
            TBStaff staff = db.TBStaffs.Where(p => p.username == username).FirstOrDefault();
            if(staff != null)
            {
                bool ck = BCrypt.Net.BCrypt.Verify(password, staff.pwd);
                if (ck==false)
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
        public string CheckEmail(string Email)
        {
            TBStaff staff=db.TBStaffs.Where(p=>p.email==Email).FirstOrDefault();
            if(staff == null)
            {
                return "Không tìm thấy tài khoản tương ứng với email trên";
            }
            return null;
        }
    }
}
