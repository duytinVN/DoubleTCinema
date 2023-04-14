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
    public partial class MainLogin : Form
    {
       

        public MainLogin()
        {
            InitializeComponent();
            pnMain.Controls.Add(new ucLogin());
            
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
        public void CloseAndNewForm(int Id)
        {
            
            StaffMain frm= new StaffMain(Id);
            frm.Show();
            this.Visible = false;
            
        }
    }
}
