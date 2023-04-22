using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using Guna.UI2;
using System.Drawing;
using DTO1;
using DoubleTCinema.View.Staff;

namespace DoubleTCinema.View.Control
{
    class ShowtimeButton : Guna2Button
    {
        //TBScheduleDTO schedule;
        public int shedule_id;
        public ShowtimeButton(TBScheduleDTO st)
        {
            //schedule = new TBScheduleDTO();
            //schedule=st;
            shedule_id = st.schedule_id;
            this.Size = new Size(170, 50);
            this.FillColor = Color.White;
            this.ForeColor = Color.FromArgb(0, 88, 220);
            this.Font = new Font("Arial", 14, FontStyle.Regular);
            this.BorderRadius = 8;
            this.BorderColor = Color.FromArgb(82, 222, 253);
            this.BorderThickness = 1;

            this.HoverState.Font = new Font("Arial", 14, FontStyle.Bold);
            this.HoverState.BorderColor = Color.Blue;
            this.HoverState.FillColor = Color.DeepSkyBlue;
            this.HoverState.ForeColor = Color.White;

            //this.Text= st;
            this.Text = st.schedule_start.ToString("hh\\:mm") + " ~ " + st.schedule_end.ToString("hh\\:mm");
        }
        protected override void OnClick(EventArgs e)
        {
            //int schedule_id=schedule.schedule_id;
            
            //frmBookChair frm=new frmBookChair(schedule_id);
            
            //frm.ShowDialog();
            base.OnClick(e);
            
        }
    }
}
