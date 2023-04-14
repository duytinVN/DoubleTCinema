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
using DoubleTCinema.DAL;

namespace DoubleTCinema
{

    public partial class ucVerification : UserControl
    {
        TBStaff staff;
        int Rand;
        public ucVerification(string email)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            lblResult.Visible = false;
           
            //txtVerification.Text = email;
            Random ran= new Random();
            Rand=ran.Next(1000,9999);
            txtVerification.Text = Rand.ToString();
            
            DoubleT db=new DoubleT();
            staff=db.TBStaffs.Where(p=>p.email==email).FirstOrDefault();
            GuiMaXacNhan(email);
        }
        public ucVerification()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            lblResult.Visible = false;
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtVerification.Text!=Rand.ToString())
            {
                lblResult.Visible = true;
            }
            else
            {
                Panel panel=(Panel)this.Parent;
                panel.Controls.Remove(this);
                panel.Controls.Add(new ucResetPassword(staff.staff_id));
                this.Dispose();
            }
        }
        public void GuiMaXacNhan(string email)
        {
            //MailMessage mail=new MailMessage();
            //SmtpClient server = new SmtpClient("smtp.gmail.com");
            //mail.From = new MailAddress("caotuankhai1902@gmail.com");
            //mail.To.Add(email);
            //mail.Subject = "Gửi mã xác nhận";
            //mail.Body = "Mã xác nhận của bạn là:"+Rand.ToString();
            //server.Port = 587;
            //server.DeliveryMethod= SmtpDeliveryMethod.Network;
            //server.EnableSsl = true;
            //server.Credentials = new NetworkCredential("caotuankhai1902@gmail.com", "khai12345678");



            //server.Send(mail);
            try
            {
                var fromAddress = new MailAddress("caotuankhai1902@gmail.com");
                var toAddress = new MailAddress(email);
                const string pass = "khai12345678";
                const string subject = "Gửi mã xác nhận";
                string body = Rand.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, pass),
                    Timeout = 2000000

                };
                using (var Message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(Message);
                }
                MessageBox.Show("OTP đã được gửi qua mail ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
