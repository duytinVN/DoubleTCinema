using BLL1;
using DoubleTCinema.View.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleTCinema
{
    public partial class frmMainLogin : Form
    {
        private static int ck = 0;
        //List<string> list;

        public frmMainLogin()
        {
            InitializeComponent();
            pnMain.Controls.Add(new ucLogin());
            //list=TBMovieBLL.Instance.GetListImgageMovie();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void RemoveUserControl(UserControl uc)
        {
            pnMain.Controls.Remove(uc);
        }

        public void LoadUsercontrol(UserControl uc)
        {
            pnMain.Controls.Add(uc);
            uc.Dock= DockStyle.Fill;
            
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> list=TBMovieBLL.Instance.GetListImgageMovie();
            string temp = list[ck];
            if(temp != null)
            {
                pbMovie.Image=Image.FromFile(temp);
            }
            if (ck ==list.Count-1)
            {
                ck = 0;
            }
            else
                ck++;
        }
        public void ClosedForm(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
