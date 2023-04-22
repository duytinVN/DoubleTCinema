using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using DoubleTCinema.View.Login;
using BLL1;

namespace DoubleTCinema
{

    public partial class ucVerification : UserControl
    {
        public ucVerification(string email)
        {
            InitializeComponent();
        }
        public ucVerification()
        {
            InitializeComponent();
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            int check = int.Parse(txtVerification.Text);
            if(TBStaffBLL.Instance.CheckPass(check))
            {
                Panel panel = (Panel)this.Parent;
                panel.Controls.Remove(this);
                panel.Controls.Add(new ucResetPassword());
            }
            else
            {
                if(lblResult.Visible==false)
                {
                    lblResult.Visible=true;
                }
            }
        }
        
    }
}
