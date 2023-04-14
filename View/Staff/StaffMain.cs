
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
    public partial class StaffMain : Form
    {
        //TBStaff staff=null;
        public StaffMain()
        {
            InitializeComponent();
            
        }
        public StaffMain(int Staff_Id)
        {
            InitializeComponent();
            //DoubleT db=new DoubleT();
            //staff=db.TBStaffs.Where(p=>p.staff_id==Staff_Id).FirstOrDefault();
            
        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
