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

                    frmMainLogin form =(frmMainLogin) this.ParentForm;
                    frmStaffMain staff = new frmStaffMain();
                    staff.FormClosed += frmStaff_Closed;
                    staff.Show();
                    form.Hide();

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
        private void frmStaff_Closed(object sender, EventArgs e)
        {
            frmMainLogin frm= (frmMainLogin) this.ParentForm;
            frm.Close();
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
