
using BLL1;
using DoubleTCinema.View.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleTCinema
{
    public partial class ucLogin : UserControl
    {
        
        public ucLogin()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            lblResult.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            lblResult.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //DoubleT db=new DoubleT();
            //if(txtUser.Text=="" || txtPassWord.Text=="")
            //{
            //    lblResult.Text = "Vui lòng nhập tên đăng nhập hoặc mật khẩu";
            //    if(lblResult.Visible==false )
            //    {
            //        lblResult.Visible=true;
            //    }
            //}
            //else
            //{
            //    TBStaff staff= new TBStaff();
            //    staff=db.TBStaffs.Where(p=>p.username.ToString().Trim()==txtUser.Text.Trim()).FirstOrDefault();
            //    if (staff != null)
            //    {
                    
            //        bool check=BCrypt.Net.BCrypt.Verify(txtPassWord.Text,staff.pwd);
            //        if (check==true)
            //        {

            //            MainLogin form = (MainLogin)this.ParentForm;
            //            form.CloseAndNewForm(staff.staff_id);

            //        }
            //        else
            //        {
            //            lblResult.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            //            if (lblResult.Visible == false)
            //            {
            //                lblResult.Visible = true;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        lblResult.Text = "Không tìm thấy tài khoản người dùng";
            //        if (lblResult.Visible == false)
            //        {
            //            lblResult.Visible = true;
            //        }
            //    }

            //}
            if(txtUser.Text=="" || txtPassWord.Text=="")
            {
                lblResult.Text = "Vui lòng nhập tên đăng nhập và mật khẩu đầy đủ";
                if(lblResult.Visible == false )
                {
                    lblResult.Visible = true;
                }
            }
            else
            {
                bool login=TBStaffBLL.Instance.CheckLogin(txtUser.Text, txtPassWord.Text);
                if(login==true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    string text=TBStaffBLL.Instance.ShowErrorLogin(txtUser.Text,txtPassWord.Text);
                    lblResult.Text = text;
                    if (lblResult.Visible == false)
                    {
                        lblResult.Visible = true;
                    }
                }
            }    
        }

        private void lblFogotPassword_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            panel.Controls.Remove(this);
            panel.Controls.Add(new ucFogottPassword());
            this.Dispose();
        }
    }
}
