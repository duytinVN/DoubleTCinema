using DAL1;
using DTO1;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL1
{
    public class TBCustomerBLL
    {
        
        private static TBCustomerBLL _instance;
        public static TBCustomerBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TBCustomerBLL();
                return _instance;
            }
            set { }
        }
        public bool CheckPhone(string phone)
        {
            using(var db=new DoubleT())
            {
                TBCustomer customer = db.TBCustomers.Where(p => p.customer_phone == phone).FirstOrDefault();
                if (customer == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public TBCustomerDTO GetTBCustomerDTO(string phone)
        {
            using(var db=new DoubleT())
            {
                TBCustomerDTO result = new TBCustomerDTO();
                TBCustomer customer = db.TBCustomers.Where(p => p.customer_phone == phone).FirstOrDefault();
                if (customer != null)
                {
                    if (customer.is_deleted != true)
                    {
                        result.customer_id = customer.customer_id;
                        result.customer_name = customer.customer_name;
                        result.customer_phone = customer.customer_phone;
                        result.customer_birthday = customer.customer_birthday;
                        result.customer_address = customer.customer_address;
                    }
                }
                return result;
            }
            
        }
        public int GetID(string phone)
        {
            using(var db = new DoubleT())
            {
                int id = db.TBCustomers.Where(p => p.customer_phone == phone).Select(p => p.customer_id).FirstOrDefault();
                return id;
            }
        }
        public int SetCustomer(TBCustomerDTO customerDTO)
        {
            using(var db = new DoubleT())
            {
                int id = -1;
                TBCustomer cus=new TBCustomer();
                cus.customer_points = 0;
                cus.customer_phone=customerDTO.customer_phone;
                cus.customer_name=customerDTO.customer_name;
                cus.customer_address=customerDTO.customer_address;
                cus.customer_birthday=customerDTO.customer_birthday;
                db.TBCustomers.Add(cus);
                db.SaveChanges();
                id = GetID(customerDTO.customer_phone);
                return id;
            }
        }
        public List<TBCustomerDTO> GetListCustomers()
        {
            
            using(var db = new DoubleT())
            {
                List<TBCustomerDTO> result = new List<TBCustomerDTO>();
                List<TBCustomer> list=db.TBCustomers.ToList();
                foreach (TBCustomer c in list)
                {
                    result.Add(new TBCustomerDTO
                    {
                        customer_id=c.customer_id,
                        customer_name=c.customer_name,
                        customer_address=c.customer_address,
                        customer_birthday=c.customer_birthday,
                        customer_phone=c.customer_phone,
                    });
                }
                return result;
            }
        }
        public bool CheckFormatIsPhone(string i)
        {
            return Regex.IsMatch(i, @"^[0-9]{10}$");
        }
        public bool CheckFormatAddress(string i)
        {
            return Regex.IsMatch(i, @"^[a-zA-Z0-9 ]*$");
        }
        public bool CheckFormatName(string i)
        {
            return Regex.IsMatch(i, @"^[a-zA-Z ]*$");
        }
        public bool CheckFormatBirday(DateTime dt)
        {
            if(dt>=DateTime.Now) return false;
            return true;
        }
        public List<TBCustomerDTO> GetListCustomers(string name)
        {
            using(var db = new DoubleT())
            {
                List<TBCustomerDTO> customer=new List<TBCustomerDTO> ();
                List<TBCustomer> list= db.TBCustomers.ToList();
                foreach (TBCustomer c in list)
                {
                    if (c.is_deleted == false && (c.customer_name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        customer.Add(new TBCustomerDTO
                        {
                            customer_id = c.customer_id,
                            customer_name = c.customer_name,
                            customer_address = c.customer_address,
                            customer_phone = c.customer_phone,
                            customer_birthday = c.customer_birthday
                        });
                    }
                }
                return customer;
            }
        }
        public TBCustomerDTO GetCustomer(int id)
        {
            using (var db = new DoubleT())
            {
                TBCustomer customer=db.TBCustomers.Where(p=>p.customer_id == id).FirstOrDefault();
                TBCustomerDTO result=new TBCustomerDTO();
                if(customer != null)
                {
                    result.customer_id= customer.customer_id;
                    result.customer_name= customer.customer_name;
                    result.customer_address= customer.customer_address;
                    result.customer_birthday= customer.customer_birthday;
                    result.customer_phone= customer.customer_phone;
                }
                return result;
            }
        }
        public void SaveOrUpdate(TBCustomerDTO customer)
        {
            using(var db = new DoubleT())
            {
                if (customer.customer_id == -1)
                {
                    TBCustomer result = new TBCustomer();
                    result.customer_name = customer.customer_name;
                    result.customer_address = customer.customer_address;
                    result.customer_points = 0;
                    result.customer_birthday = customer.customer_birthday;
                    result.customer_phone = customer.customer_phone;
                    db.TBCustomers.Add(result);
                    db.SaveChanges();
                }
                else
                {
                    TBCustomer result = db.TBCustomers.Where(p=>p.customer_id==customer.customer_id).FirstOrDefault();
                    if (result != null)
                    {
                        result.customer_name = customer.customer_name;
                        result.customer_phone=customer.customer_phone;
                        result.customer_address=customer.customer_address;
                        result.customer_points=customer.customer_points;
                        result.customer_birthday=customer.customer_birthday;
                        db.TBCustomers.AddOrUpdate(result);
                        db.SaveChanges();
                    }
                    
                }
            }
            
        }
    }
}
