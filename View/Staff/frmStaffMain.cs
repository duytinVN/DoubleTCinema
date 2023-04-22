
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

namespace DoubleTCinema.View.Staff
{
    public delegate void myDel(UserControl x, UserControl y);
    
    public partial class frmStaffMain : Form
    {
        //TBStaff staff=null;
        public event myDel ChangedUC;
        public void LoadForm()
        {
            pnView.Controls.Clear();
            ucMovieBooking uc = new ucMovieBooking();
            uc.ChangedUC += ReloadUC;
            pnView.Controls.Add(uc);
            btnMovie.Checked = true;
            
        }

        public frmStaffMain()
        {
            InitializeComponent();
            LoadForm();
            //ucStatistical uc=new ucStatistical();
            //pnView.Controls.Add(uc);
            

        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {          
            this.Close();
            
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void ReloadUC(UserControl Load,UserControl Remove)
        {
            if (pnView.Controls.Contains(Remove))
            {
                pnView.Controls.Remove(Remove);
                Remove.Dispose();
            }
            
            Load.Dock= DockStyle.Fill;
            
            pnView.Controls.Add(Load);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnView.Controls.Clear();
            pnView.Controls.Add(new ucStaffUser());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnView.Controls.Clear();
            pnView.Controls.Add(new ucMovieBooking());
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            pnView.Controls.Clear();
            pnView.Controls.Add(new ucShift());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pnView.Controls.Clear();
            pnView.Controls.Add(new ucStatistical());
        }
    }
}
