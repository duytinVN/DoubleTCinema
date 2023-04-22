using BLL1;
using DTO1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleTCinema.View.Staff
{
    public partial class frmEditCustomers : Form
    {
        int Id=-1;
        
        public frmEditCustomers(int id_customer=-1)
        {
            InitializeComponent();
            if(id_customer != -1)
            {
                this.Id= id_customer;
                LoadCustomer(id_customer);
            }
            else
            {
                lblIdCustomer.Visible = false;
                txtIdCustomer.Visible = false;
            }
        }
        public void LoadCustomer(int id)
        {
            TBCustomerDTO cus=TBCustomerBLL.Instance.GetCustomer(id);
            if(cus != null)
            {
                txtIdCustomer.Text=cus.customer_id.ToString();
                txtNameCustomer.Text = cus.customer_name;
                txtAddress.Text = cus.customer_address.ToString();
                dtpBirthday.Value = cus.customer_birthday;
                txtPhone.Text = cus.customer_phone;
            }
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBCustomerDTO cus=new TBCustomerDTO();
            cus.customer_id = Id;
            cus.customer_phone = txtPhone.Text;
            cus.customer_address = txtAddress.Text;
            cus.customer_birthday = dtpBirthday.Value;
            cus.customer_name = txtNameCustomer.Text;
            TBCustomerBLL.Instance.SaveOrUpdate(cus);
            
            
            this.Close();
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if(txtPhone.Text == "Nhập số điện thoại")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if(txtPhone.Text == "")
            {
                txtPhone.Text = "Nhập số điện thoại";
                txtPhone.ForeColor = Color.Silver;
            }
            else
            {
                if (TBCustomerBLL.Instance.CheckFormatIsPhone(txtPhone.Text)==false)
                {
                    lblResultPhone.Visible = true;
                }
                else
                {
                    lblResultPhone.Visible = false;
                }
            }
        }

        private void txtNameCustomer_Enter(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "Nhập họ và tên")
            {
                txtNameCustomer.Text = "";
                txtNameCustomer.ForeColor = Color.Black;
            }
        }

        private void txtNameCustomer_Leave(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "")
            {
                txtNameCustomer.Text = "Nhập họ và tên";
                txtNameCustomer.ForeColor = Color.Silver;
            }
            else
            {
                if (TBCustomerBLL.Instance.CheckFormatName(txtNameCustomer.Text) != false)
                {
                    lblResultName.Visible = true;
                }
                else
                {
                    lblResultName.Visible = false;
                }
            }
        }

        private void dtpBirthday_Leave(object sender, EventArgs e)
        {
            if(TBCustomerBLL.Instance.CheckFormatBirday(dtpBirthday.Value) != false)
            {
                lblResultBirthday.Visible = true;
            }
            else
            {
                lblResultBirthday.Visible=false;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Nhập địa chỉ")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.Black;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Nhập địa chỉ";
                txtAddress.ForeColor = Color.Silver;
            }
            else
            {
                if (TBCustomerBLL.Instance.CheckFormatAddress(txtAddress.Text) != false)
                {
                    lblResultAddress.Visible = true;
                }
                else
                {
                    lblResultAddress.Visible = false;
                }
            }
        }
    }
}
