
using BLL1;
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
    public partial class ucFogottPassword : UserControl
    {
        
        public ucFogottPassword()
        {
            InitializeComponent();
            lblResult.Visible = false;
            lblResult.Text = "Không tìm thấy tài khoản liên kết với email trên";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            panel.Controls.Remove(this);
            panel.Controls.Add(new ucLogin());
            this.Dispose();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                lblResult.Text = "Vui lòng nhập email";
                if (lblResult.Visible == false)
                {
                    lblResult.Visible = true;
                }
            }
            else
            {
                string text=TBStaffBLL.Instance.CheckEmail(txtEmail.Text);
                if(text==null)
                {
                    MessageBox.Show("Đã tìm thấy email");
                }
                else
                {
                    lblResult.Text = text;
                    if (lblResult.Visible == false)
                    {
                        lblResult.Visible = true;
                    }
                }
            }
            //else
            //{
            //    DoubleT db = new DoubleT();
            //    TBStaff staff=new TBStaff();
            //    staff=db.TBStaffs.Where(p=>p.email.ToString().Trim()==txtEmail.Text).FirstOrDefault();
            //    if (staff != null)
            //    {
            //        Panel panel=(Panel)this.Parent;
            //        panel.Controls.Remove(this);
            //        panel.Controls.Add(new ucVerification(txtEmail.Text));
            //        this.Dispose();
            //    }
            //    else
            //    {
            //        lblResult.Text = "Không tìm thấy tài khoản tương ứng với email trên";
            //        if(lblResult.Visible == false)
            //        {
            //            lblResult.Visible = true;
            //        }    
            //    }
            //}
        }
    }
}
