using DoubleTCinema.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleTCinema.View.Login
{
    public partial class ucResetPassword : UserControl
    {
        int Staff_Id;
        public ucResetPassword()
        {
            InitializeComponent();
        }
        public ucResetPassword(int temp)
        {
            InitializeComponent();
            Staff_Id = temp;
            lblResult.Text = "Vui lòng nhập mật khẩu";
            lblResult.Visible= false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtPass.Text!="" && txtUnPass.Text!= "")
            {
                if(txtPass.Text==txtUnPass.Text)
                {
                    DoubleT db= new DoubleT();
                    TBStaff staff = db.TBStaffs.Find(Staff_Id);
                    staff.pwd = BCrypt.Net.BCrypt.HashPassword(txtPass.Text);   
                    db.SaveChanges();
                    Panel panel = (Panel)this.Parent;
                    panel.Controls.Remove(this);
                    panel.Controls.Add(new ucFinishReset());
                    this.Dispose();
                }
                else
                {
                    lblResult.Text = "Mật khẩu không trùng khớp";
                    if (lblResult.Visible == false)
                    {
                        lblResult.Visible= true;
                    }
                }
            }
            else
            {
                lblResult.Text = "Vui lòng nhập mật khẩu";
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            panel.Controls.Remove(this);
            panel.Controls.Add(new ucLogin());
            this.Dispose();
        }
    }
}
